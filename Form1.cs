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
                MessageBox.Show("程序目录下缺少手术列表数据库文件(surgery_db.sql)!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buildSQL_Click(object sender, EventArgs e)
        {
            SqliteHelper.dbConnection();
            //从excel表格里面读取数据然后插入到sql表里面
            string FILE = System.IO.Directory.GetCurrentDirectory() + @"\Input\手术操作分类代码国家临床版1.xlsx";
            Workbook workbook = new Workbook();
            workbook.Open(FILE);
            //获取第一个表单
            Sheet sheet = workbook.Sheet("所有条目");
            string type = "";
            string entry = "";
            //获取这个表单的所有行
            var rows = sheet.Rows;
            int count = 0;
            foreach (Row row in rows)
            {
                if (count > 0)
                {
                    object main = row.Cell(1);
                    object addi = row.Cell(2);
                    string name = row.Cell(3).ToString();
                    InsertOneItem(ref count, ref main, ref addi, ref name, ref type, ref entry);
                }
                count++;
            }
            int a = 1;
        }

        ////////////////////////////////////////d



        //////////////////数据库操作/////////
        private void InsertOneItem(ref int id, ref object mainCode, ref object additionalCode, ref string surgeryName,
            ref string type, ref string optionEntry)
        {
            string main_code = "";
            string addi_code = "";
            if (mainCode != null)
                main_code = mainCode.ToString();
            if (additionalCode != null)
                addi_code = additionalCode.ToString();
            string insertSQL = "insert into surgery_db(id, main_code, additional_code, surgery_name) " +
                "values(" + id.ToString() + ", '" + main_code  +"','" + addi_code +"','" + surgeryName +"')";

            SqliteHelper.ExecuteNonQuery(insertSQL);
        }
    }
}
