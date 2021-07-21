using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projektmunka_gui
{
    class GlobalVar
    {
        private static int whereiam;
        private static int action;
        private static int actionid;
        public static int Whereiam { get => whereiam; set => whereiam = value; }
        public static int Action { get => action; set => action = value; }
        public static int Actionid { get => actionid; set => actionid = value; }

        public static String LoginData =
           "Server=localhost;" +
           "Database=projekt2020_fa;" +
           "UserID=projekt2020_fa;" +
           "Password=12345678;";
        public static MySqlConnection MyDB = new MySqlConnection(LoginData);
        public static int DBExecute(string sql)
        {
            try
            {
                MyDB.Close();
                MyDB.Open();
                MySqlCommand Cmd = new MySqlCommand(sql, MyDB);
                Cmd.ExecuteNonQuery();
                MyDB.Close();
                return 1;
            }
            catch (Exception Fail)
            {
                MessageBox.Show($"{Fail}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public static MySqlDataReader DBQuery(string sql)
        {
            MySqlDataReader Results = null;
            try
            {
                MyDB.Close();
                MyDB.Open();
                MySqlCommand Cmd = new MySqlCommand(sql, MyDB);
                Results = Cmd.ExecuteReader();
            }
            catch (Exception Fail)
            {
                Results = null;
                MessageBox.Show($"{Fail}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Results;
        }
    }
}
