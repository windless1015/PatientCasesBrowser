﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcelLibrary
{
    public class Workbook
    {
        private const string NS_MAIN = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        private const string NS_PR = "http://schemas.openxmlformats.org/package/2006/relationships";
        private const string NS_OR = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
        private const string NS_ORW = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet";

        private string file;
        private List<Sheet> sheets = new List<Sheet>();
        private Dictionary<int, string> sharedStrings = new Dictionary<int, string>();
        private Dictionary<int, NumberFormat> numberFormats = new Dictionary<int, NumberFormat>();
        private WorkbookOptions options = new WorkbookOptions();
        private int baseYear = 1900;

        public void Open(string file)
        {
            this.file = file;
            Open();
        }

        public void Open(string file, WorkbookOptions options)
        {
            this.file = file;
            this.options = options;
            Open();
        }

        private void Open()
        {
            using (ZipArchive archive = ZipFile.OpenRead(file))
            {
                // Read "xl/workbook.xml" to get sheet names and ids
                ZipArchiveEntry sheetsEntry = archive.Entries.FirstOrDefault(e => e.FullName == "xl/workbook.xml");
                LoadWorkbookXml(sheetsEntry);

                // Read "xl/_rels/workbook.xml.rels" to get sheet paths
                ZipArchiveEntry sheetPathsEntry = archive.Entries.FirstOrDefault(e => e.FullName == "xl/_rels/workbook.xml.rels");
                LoadWorkbookXmlRels(sheetPathsEntry);

                // Read "xl/sharedStrings.xml" to get shared strings
                ZipArchiveEntry sharedStringsEntry = archive.Entries.FirstOrDefault(e => e.FullName == "xl/sharedStrings.xml");
                LoadSharedStrings(sharedStringsEntry);

                // Read "xl/styles.xml" to get number formats
                ZipArchiveEntry stylesEntry = archive.Entries.FirstOrDefault(e => e.FullName == "xl/styles.xml");
                LoadStyles(stylesEntry);

                // Optionally load all sheets
                if (options.LoadSheets)
                {
                    foreach (Sheet sheet in this.sheets)
                    {
                        sheet.Open();
                    }
                }
            }
        }

        private void LoadWorkbookXml(ZipArchiveEntry entry)
        {
            XDocument document = XDocument.Load(entry.Open());
            XElement root = document.Root;
            XNamespace ns = NS_MAIN;
            XNamespace r = NS_OR;

            XElement workbookPr = root.Element(ns + "workbookPr");
            XAttribute date1904 = workbookPr.Attribute("date1904");
            if (date1904 != null && date1904.Value == "1")
            {
                this.baseYear = 1904;
            }

            foreach (XElement element in root.Element(ns + "sheets").Elements())
            {
                XAttribute id = element.Attribute(r + "id");
                XAttribute name = element.Attribute("name");
                XAttribute state = element.Attribute("state");

                bool hidden = false;
                if (state != null && state.Value == "hidden")
                {
                    hidden = true;
                }

                Sheet sheet = new Sheet(name.Value, id.Value, hidden);
                sheet.Workbook = this;
                this.sheets.Add(sheet);
            }
        }

        private void LoadWorkbookXmlRels(ZipArchiveEntry entry)
        {
            XDocument document = XDocument.Load(entry.Open());
            XElement root = document.Root;
            XNamespace ns = NS_PR;

            foreach (XElement element in root.Elements(ns + "Relationship"))
            {
                XAttribute id = element.Attribute("Id");
                XAttribute type = element.Attribute("Type");
                XAttribute target = element.Attribute("Target");

                if (type.Value != NS_ORW)
                {
                    continue;
                }

                Sheet sheet = (from s in this.sheets
                               where s.Id == id.Value
                               select s).FirstOrDefault();

                // Get sheet file path
                Match match = Regex.Match(target.Value, @"worksheets/(.+)");
                string path = @"xl/worksheets/" + match.Groups[1].Value;
                sheet.Path = path.ToLower();
            }
        }

        private void LoadSharedStrings(ZipArchiveEntry entry)
        {
            // The xl/sharedStrings.xml file will be missing if there are no strings
            if (entry == null)
            {
                return;
            }

            XDocument document = XDocument.Load(entry.Open());
            XElement root = document.Root;
            XNamespace ns = NS_MAIN;
            int count = 0;

            foreach (XElement si in root.Elements(ns + "si"))
            {
                IEnumerable<XElement> ts = si.Descendants(ns + "t");
                string sum = string.Empty;
                foreach (XElement t in ts)
                {
                    sum += t.Value;
                }

                this.sharedStrings.Add(count, sum);
                count++;
            }
        }

        private void LoadStyles(ZipArchiveEntry entry)
        {
            XDocument document = XDocument.Load(entry.Open());
            XNamespace ns = NS_MAIN;
            XElement cellXfs = document.Root.Element(ns + "cellXfs");
            int index = 0;

            foreach (XElement element in cellXfs.Elements())
            {
                XAttribute numFmtId = element.Attribute("numFmtId");
                if (numFmtId != null)
                {
                    int numberFormatId = int.Parse(numFmtId.Value);
                    switch (numberFormatId)
                    {
                        case 0:
                            this.numberFormats.Add(index, NumberFormat.General);
                            break;
                        case 2:
                            this.numberFormats.Add(index, NumberFormat.Number);
                            break;
                        case 164:
                            this.numberFormats.Add(index, NumberFormat.Currency);
                            break;
                        case 44:
                            this.numberFormats.Add(index, NumberFormat.Accounting);
                            break;
                        case 14:
                            this.numberFormats.Add(index, NumberFormat.Date);
                            break;
                        case 165:
                            this.numberFormats.Add(index, NumberFormat.Time);
                            break;
                        case 49:
                            this.numberFormats.Add(index, NumberFormat.Text);
                            break;
                        case 10:
                            this.numberFormats.Add(index, NumberFormat.Percentage);
                            break;
                        case 13:
                            this.numberFormats.Add(index, NumberFormat.Fraction);
                            break;
                        case 166:
                            this.numberFormats.Add(index, NumberFormat.Custom);
                            break;
                        case 11:
                            this.numberFormats.Add(index, NumberFormat.Scientific);
                            break;
                        default:
                            this.numberFormats.Add(index, NumberFormat.Unsupported);
                            break;
                    }
                    index++;
                }
            }
        }

        public IEnumerable<Sheet> Sheets
        {
            get
            {
                if (this.Options.IncludeHidden)
                {
                    return this.sheets.OrderBy(s => s.Id);
                }
                else
                {
                    return this.sheets.Where(s => s.Hidden == false).OrderBy(s => s.Id);
                }
            }
        }

        public Sheet Sheet(string name)
        {
            return this.sheets.SingleOrDefault(s => s.Name == name);
        }

        public WorkbookOptions Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        public string File
        {
            get { return this.file; }
        }

        public Dictionary<int, string> SharedStrings
        {
            get { return this.sharedStrings; }
        }

        public Dictionary<int, NumberFormat> NumberFormats
        {
            get { return this.numberFormats; }
        }

        public int BaseYear
        {
            get { return this.baseYear; }
        }
    }
}
