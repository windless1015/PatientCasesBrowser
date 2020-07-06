using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
            JudgeDBIsExist();
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////d
        private bool JudgeDBIsExist()
        {
            //string dbPath = System.Environment.CurrentDirectory ;
            string dbPath = System.IO.Directory.GetCurrentDirectory() + @"surgery_db.sql";
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("程序目录下缺少手术列表数据库文件(surgery_db.sql)!","错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        //////////////////数据库操作/////////
    }
}
