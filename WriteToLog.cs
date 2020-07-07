using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PatientCasesBrowser
{
    public class WriteToLog
    {
        /// <summary>
        /// 写入到文件，文件名file_name，内容log_txt
        /// </summary>
        /// <returns></returns>
        public bool writetofile(string txt, string file_name)
        {
            FileInfo fi = new FileInfo(file_name);
            if (!Directory.Exists(fi.DirectoryName))
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }
            txt = DateTime.Now.ToString("HH:mm:ss") + txt;
            try
            {
                using (FileStream sw = new FileStream(file_name, FileMode.Append, FileAccess.Write))
                    if (File.Exists(file_name))
                    {
                        StreamWriter fs = new StreamWriter(sw);
                        // 为文件添加一些文本内容
                        fs.WriteLine(txt);
                        fs.Close();
                        return true;
                    }
                    else
                    {
                        using (StreamWriter fs = new StreamWriter(sw))
                        {
                            fs.WriteLine(txt);
                            fs.Close();
                            return true;
                        }
                    }
            }
            catch
            {
                return false;
            }
        }
    }
    /// <summary>
    /// 记录错误日志
    /// </summary>
    public class _ErrorLog
    {
        public static void Insert(string x)
        {
            string err_name = "Syslog\\Err_log" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt";
            WriteToLog flog = new WriteToLog();
            flog.writetofile(x, err_name);
        }
    }
    /// <summary>
    /// 记录操作日志
    /// </summary>
    public class _ActionLog
    {
        public static void Insert(string x)
        {
            string act_name = "Syslog\\Act_log" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt";
            WriteToLog flog = new WriteToLog();
            flog.writetofile(x, act_name);
        }
    }
}
