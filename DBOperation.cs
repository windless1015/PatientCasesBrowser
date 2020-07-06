using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace PatientCasesBrowser
{
    class DBOperation
    {

        private SQLiteConnection db_conn = null;
        private SQLiteConnectionStringBuilder sql_builder = null;
        public void Open(string database_file_name)
        {
            db_conn = new SQLiteConnection(database_file_name);
            sql_builder = new SQLiteConnectionStringBuilder();

            sql_builder.DataSource = database_file_name;
            db_conn.ConnectionString = sql_builder.ToString();
            db_conn.Open();
        }

        public void DbExecuteSqlCommand(string sql)
        {
            SQLiteCommand sql_cmd = new SQLiteCommand();
            sql_cmd.CommandText = sql;
            sql_cmd.Connection = db_conn;
            sql_cmd.ExecuteNonQuery(); 　　//更新数据
        }


    }
}
