using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace projektmunka_gui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            switch (GlobalVar.Whereiam)
            {
                case 2: Form_Munkavallalok(); break;
                case 3: Form_Munkaadok(); break;
                case 4: Form_Tanulmanyok(); break;
                case 5: Form_Munkahelyek(); break;
                case 6: Form_Hirdetesek(); break;
                case 7: Form_Jelentkezesek(); break;
            }
        }
        private void Form_Jelentkezesek()
        {
            label1.Text = "Jelentkezések tábla";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM jelentkezesek WHERE ID={GlobalVar.Actionid}");
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "hirdetesID";
            label3.Text = "jelentkezoID";
            label4.Text = "statusz";
            if (GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("hirdetesID");
                textBox2.Text = Result.GetString("jelentkezoID");
                textBox3.Text = Result.GetString("statusz");
            }
        }
        private void Check_Jelentkezesek()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM jelentkezesek WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                sql = $"UPDATE jelentkezesek SET " +
                      $"hirdetesID='{textBox1.Text}'," +
                      $"jelentkezoID='{textBox2.Text}'," +
                      $"statusz='{textBox3.Text}'" +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                sql = $"INSERT INTO jelentkezesek VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{textBox3.Text}'" +
                      $")";
            }
            if (GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void Form_Hirdetesek()
        {
            label1.Text = "Hirdetések tábla";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM hirdetesek WHERE ID={GlobalVar.Actionid}");
            label9.Hide();
            label10.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "feladoID";
            label3.Text = "statusz";
            label4.Text = "munkakor";
            label5.Text = "kategoria";
            label6.Text = "hirdetes_szoveg";
            label7.Text = "hatarido";
            label8.Text = "hely";
            if (GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("feladoID");
                textBox2.Text = Result.GetString("statusz");
                textBox3.Text = Result.GetString("munkakor");
                textBox4.Text = Result.GetString("kategoria");
                textBox5.Text = Result.GetString("hirdetes_szoveg");
                textBox6.Text = Result.GetDateTime("hatarido").ToString("yyyy-MM-dd");
                textBox7.Text = Result.GetString("hely");
            }
        }
        private void Check_Hirdetesek()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM hirdetesek WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                sql = $"UPDATE hirdetesek SET " +
                      $"feladoID='{textBox1.Text}'," +
                      $"statusz='{textBox2.Text}'," +
                      $"munkakor='{textBox3.Text}'," +
                      $"kategoria='{textBox4.Text}'," +
                      $"hirdetes_szoveg='{textBox5.Text}'," +
                      $"hatarido=CAST('{textBox6.Text}' AS DATETIME)," +
                      $"hely='{textBox7.Text}' " +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                DateTime today = DateTime.Today;
                sql = $"INSERT INTO hirdetesek VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{textBox3.Text}'," +
                      $"'{textBox4.Text}'," +
                      $"'{textBox5.Text}'," +
                      $"'{today.ToString("yyyy-MM-dd")}'," +
                      $"'{textBox6.Text}'," +
                      $"'{textBox7.Text}'" +
                      $")";
            }
            if (GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void Form_Munkahelyek()
        {
            label1.Text = "Munkahelyek tábla";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkahelyek WHERE ID={GlobalVar.Actionid}");
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "mvID";
            label3.Text = "munkahely";
            label4.Text = "datum";
            label5.Text = "munkakor";
            if (GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("mvID");
                textBox2.Text = Result.GetString("munkahely");
                textBox3.Text = Result.GetString("datum");
                textBox4.Text = Result.GetString("munkakor");
            }
        }
        private void Check_Munkahelyek()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkahelyek WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                sql = $"UPDATE munkahelyek SET " +
                      $"mvID='{textBox1.Text}'," +
                      $"munkahely='{textBox2.Text}'," +
                      $"datum='{textBox3.Text}'," +
                      $"munkakor='{textBox4.Text}'" +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                sql = $"INSERT INTO munkahelyek VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{textBox3.Text}'," +
                      $"'{textBox4.Text}'" +
                      $")";
            }
            if (GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void Form_Tanulmanyok()
        {
            label1.Text = "Tanulmányok tábla";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM tanulmanyok WHERE ID={GlobalVar.Actionid}");
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "mvID";
            label3.Text = "iskola";
            label4.Text = "datum";
            label5.Text = "vegzettseg";
            if (GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("mvID");
                textBox2.Text = Result.GetString("iskola");
                textBox3.Text = Result.GetString("datum");
                textBox4.Text = Result.GetString("vegzettseg");
            }
        }
        private void Check_Tanulmanyok()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM tanulmanyok WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                sql = $"UPDATE tanulmanyok SET " +
                      $"mvID='{textBox1.Text}'," +
                      $"iskola='{textBox2.Text}'," +
                      $"datum='{textBox3.Text}'," +
                      $"vegzettseg='{textBox4.Text}'" +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                sql = $"INSERT INTO tanulmanyok VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{textBox3.Text}'," +
                      $"'{textBox4.Text}'" +
                      $")";
            }
            if (GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void Form_Munkaadok()
        {
            label1.Text = "Munkaadók tábla";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkaadok WHERE ID={GlobalVar.Actionid}");
            label9.Hide();
            label10.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "nev";
            label3.Text = "email";
            label4.Text = "jelszo";
            label5.Text = "cegnev";
            label6.Text = "telephely";
            label7.Text = "leiras";
            label8.Text = "telefonszam";
            if (GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("nev");
                textBox2.Text = Result.GetString("email");
                textBox3.Text = Result.GetString("jelszo");
                textBox4.Text = Result.GetString("cegnev");
                textBox5.Text = Result.GetString("telephely");
                textBox6.Text = Result.GetString("leiras");
                textBox7.Text = Result.GetString("telefonszam");
            }
        }
        private void Check_Munkaadok()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                string pass;
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkaadok WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                if (textBox3.Text == Result.GetString("jelszo")) pass = Result.GetString("jelszo");
                else pass = CreateMD5(textBox3.Text).ToLower();
                sql = $"UPDATE munkaadok SET " +
                      $"nev='{textBox1.Text}'," +
                      $"email='{textBox2.Text}'," +
                      $"jelszo='{pass}'," +
                      $"cegnev='{textBox4.Text}'," +
                      $"telephely='{textBox5.Text}'," +
                      $"leiras='{textBox6.Text}'," +
                      $"telefonszam='{textBox7.Text}' " +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                DateTime today = DateTime.Today;
                sql = $"INSERT INTO munkaadok VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{CreateMD5(textBox3.Text).ToLower()}'," +
                      $"'{textBox4.Text}'," +
                      $"'{textBox5.Text}'," +
                      $"'{textBox7.Text}'," +
                      $"'{textBox6.Text}'," +
                      $"'{today.ToString("yyyy-MM-dd")}'," +
                      $"'{today.ToString("yyyy-MM-dd")}'" +
                      $")";
            }
            if (GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void Form_Munkavallalok()
        {
            label1.Text = "Munkavállalók";
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkavallalok WHERE ID={GlobalVar.Actionid}");
            label9.Hide();
            label10.Hide();
            textBox8.Hide();
            textBox9.Hide();
            label2.Text = "statusz";
            label3.Text = "nev";
            label4.Text = "email";
            label5.Text = "jelszo";
            label6.Text = "szul_datum";
            label7.Text = "telefonszam";
            label8.Text = "lakhely";
            if(GlobalVar.Action == 4)
            {
                Result.Read();
                textBox1.Text = Result.GetString("statusz");
                textBox2.Text = Result.GetString("nev");
                textBox3.Text = Result.GetString("email");
                textBox4.Text = Result.GetString("jelszo");
                textBox5.Text = Result.GetDateTime("szul_datum").ToString("yyyy-MM-dd");
                textBox6.Text = Result.GetString("telefonszam");
                textBox7.Text = Result.GetString("lakhely");
            }
        }
        private void Check_Munkavallalok()
        {
            string sql;
            if (GlobalVar.Action == 4)
            {
                DateTime parsedDate = DateTime.ParseExact(textBox5.Text, "yyyy-MM-dd", null);
                string pass;
                MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM munkavallalok WHERE ID='{GlobalVar.Actionid}'");
                Result.Read();
                MessageBox.Show($"{textBox4.Text}\n{Result.GetString("jelszo")}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox4.Text == Result.GetString("jelszo")) pass = Result.GetString("jelszo");
                else pass = CreateMD5(textBox4.Text).ToLower();
                sql = $"UPDATE munkavallalok SET " +
                      $"statusz='{textBox1.Text}'," +
                      $"nev='{textBox2.Text}'," +
                      $"email='{textBox3.Text}'," +
                      $"jelszo='{pass}'," +
                      $"szul_datum=CAST('{textBox5.Text}' AS DATETIME)," +
                      $"telefonszam='{textBox6.Text}'," +
                      $"lakhely='{textBox7.Text}' " +
                      $"WHERE ID='{GlobalVar.Actionid}'";
            }
            else
            {
                DateTime today = DateTime.Today;
                sql = $"INSERT INTO munkavallalok VALUES(null," +
                      $"'{textBox1.Text}'," +
                      $"'{textBox2.Text}'," +
                      $"'{textBox3.Text}'," +
                      $"'{CreateMD5(textBox4.Text).ToLower()}'," +
                      $"'{textBox5.Text}'," +
                      $"'{textBox6.Text}'," +
                      $"'{textBox7.Text}'," +
                      $"'{today.ToString("yyyy-MM-dd")}'," +
                      $"'{today.ToString("yyyy-MM-dd")}'" +
                      $")";
            }
            if(GlobalVar.DBExecute(sql) == 1)
            {
                Form2 nextsite = new Form2();
                nextsite.Show();
                this.Close();
            }
        }
        private void vissza_btn_Click(object sender, EventArgs e)
        {
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            switch (GlobalVar.Whereiam)
            {
                case 2: Check_Munkavallalok(); break;
                case 3: Check_Munkaadok(); break;
                case 4: Check_Tanulmanyok(); break;
                case 5: Check_Munkahelyek(); break;
                case 6: Check_Hirdetesek(); break;
                case 7: Check_Jelentkezesek(); break;
            }
        }
    }
}
