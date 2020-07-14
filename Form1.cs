using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary;

namespace PatientCasesBrowser
{
    public partial class Form1 : Form
    {
        DataTable datatable = null;
        public Form1()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            bool isDbFileExist = SqliteHelper.JudgeDBIsExist();
            if (!isDbFileExist)
            {
                SqliteHelper.CreateDBFile();
                //MessageBox.Show("程序目录下缺少手术列表数据库文件(surgery_db.db)!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            datatable = SqliteHelper.SqlTable("SELECT * from surgery_db");
            dataGridView.DataSource = datatable;

        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (textBox_number.Text == "")
                sql = "SELECT * from surgery_db";
            else
                sql = "SELECT * from surgery_db where main_code like '%" + textBox_number.Text + "%'";
            //判断
            datatable = SqliteHelper.SqlTable(sql);
            dataGridView.DataSource = datatable;
        }

        private void btn_buildSQL_Click(object sender, EventArgs e)
        {
            //从excel表格里面读取数据然后插入到sql表里面
            string FILE = System.IO.Directory.GetCurrentDirectory() + @"\Input\手术操作分类代码国家临床版1.xlsx";
            Workbook workbook = new Workbook();
            workbook.Open(FILE);
            //获取第一个表单
            Sheet sheet = workbook.Sheet("所有条目");
            //获取这个表单的所有行
            var rows = sheet.Rows;
            int count = 0;

            object main_code;
            object addi_code;
            string surgery_name;
            string surg_type;
            string entry_option;
            foreach (Row row in rows)
            {
                if (count > 0)
                {
                    main_code = row.Cell(1);
                    addi_code = row.Cell(2);
                    surgery_name = row.Cell(3).Value;
                    surg_type = row.Cell(4).Value;
                    entry_option = row.Cell(5).Value;
                    InsertOneItem(ref count, ref main_code, ref addi_code, ref surgery_name, ref surg_type, ref entry_option);
                }
                count++;
            }

        }

        ////////////////////////////////////////d



        //////////////////数据库操作/////////
        private void InsertOneItem(ref int id, ref object mainCode, ref object additionalCode, ref string surgeryName,
            ref string type, ref string optionEntry)
        {
            string main_code = "";
            string addi_code = "";
            if (mainCode != null)
                main_code = ((Cell)mainCode).Value;
            if (additionalCode != null)
                addi_code = ((Cell)additionalCode).Value;
            string insertSQL = "INSERT INTO surgery_db (id, main_code, additional_code, surgery_name, surgical_type, entry_option) " +
                "VALUES (" + id.ToString() + ", '" + main_code  +"','" + addi_code +"','" + surgeryName + "','" + type + "','"+ optionEntry + "')";

            SqliteHelper.ExecuteNonQuery(insertSQL);
        }

        private void SelectionQuery(string querySql) //显式所有的记录
        {
            //SQLiteCommandBuilder builder = new SQLiteCommandBuilder(dataAdapter);
            //dataAdapter.SelectCommand.CommandText = querySql;
            //dataAdapter.Update(datatable);
            //datatable.Clear();
            //dataAdapter.Fill(datatable);
            //builder.Dispose();
            //dataGridView.ClearSelection();
        }

    }
}
