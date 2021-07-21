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

namespace projektmunka_gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HideEdit();
            GlobalVar.Actionid = 0;
            switch (GlobalVar.Whereiam)
            {
                case 2: Munkavallalok(); break;
                case 3: Munkaadok(); break;
                case 4: Tanulmanyok(); break;
                case 5: Munkahelyek(); break;
                case 6: Hirdetesek(); break;
                case 7: Jelentkezesek(); break;
            }
        }

        private void Jelentkezesek()
        {
            label1.Text = "Jelentkezések tábla";
            UpdateList();
        }
        private void Hirdetesek()
        {
            label1.Text = "Hirdetésések tábla";
            UpdateList();
        }
        private void Munkahelyek()
        {
            label1.Text = "Munkahelyek tábla";
            UpdateList();
        }
        private void Tanulmanyok()
        {
            label1.Text = "Tanulmányok tábla";
            UpdateList();
        }
        private void Munkaadok()
        {
            label1.Text = "Munkaadók tábla";
            UpdateList();
        }
        private void Munkavallalok()
        {
            label1.Text = "Munkavállalók tábla";
            UpdateList();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowEdit(int type)
        {
            GlobalVar.Action = type;
            what_lbl.Show();
            what_tbx.Show();
            what_btn.Show();
        }
        private void HideEdit()
        {
            GlobalVar.Action = 0;
            what_lbl.Hide();
            what_tbx.Hide();
            what_btn.Hide();
        }
        private void lista_btn_Click(object sender, EventArgs e)
        {
            HideEdit();
            UpdateList();
        }
        private void UpdateList()
        {
            switch (GlobalVar.Whereiam)
            {
                case 2: List_Munkavallalok(); break;
                case 3: List_Munkaadok(); break;
                case 4: List_Tanulmanyok(); break;
                case 5: List_Munkahelyek(); break;
                case 6: List_Hirdetesek(); break;
                case 7: List_Jelentkezesek(); break;
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void List_Jelentkezesek()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("hirdetesID");
            listView1.Columns.Add("jelentkezoID");
            listView1.Columns.Add("statusz");
            listView1.Items.Clear();
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM jelentkezesek");
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetInt32("hirdetesID").ToString());
                    item.SubItems.Add(Result.GetInt32("jelentkezoID").ToString());
                    item.SubItems.Add(Result.GetString("statusz"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void List_Hirdetesek()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("feladoID");
            listView1.Columns.Add("statusz");
            listView1.Columns.Add("munkakor");
            listView1.Columns.Add("kategoria");
            listView1.Columns.Add("hirdetes_szoveg");
            listView1.Columns.Add("fel_datum");
            listView1.Columns.Add("hatarido");
            listView1.Columns.Add("hely");
            listView1.Items.Clear();
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM hirdetesek");
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetInt32("feladoID").ToString());
                    item.SubItems.Add(Result.GetInt32("statusz").ToString());
                    item.SubItems.Add(Result.GetString("munkakor"));
                    item.SubItems.Add(Result.GetString("kategoria"));
                    item.SubItems.Add(Result.GetString("hirdetes_szoveg"));
                    item.SubItems.Add(Result.GetDateTime("fel_datum").ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Result.GetDateTime("hatarido").ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Result.GetString("hely"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void List_Munkahelyek()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("mvID");
            listView1.Columns.Add("munkahely");
            listView1.Columns.Add("datum");
            listView1.Columns.Add("munkakor");
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM munkahelyek");
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetInt32("mvID").ToString());
                    item.SubItems.Add(Result.GetString("munkahely"));
                    item.SubItems.Add(Result.GetString("datum"));
                    item.SubItems.Add(Result.GetString("munkakor"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void List_Tanulmanyok()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("mvID");
            listView1.Columns.Add("iskola");
            listView1.Columns.Add("datum");
            listView1.Columns.Add("vegzettseg");
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM tanulmanyok");
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetInt32("mvID").ToString());
                    item.SubItems.Add(Result.GetString("iskola"));
                    item.SubItems.Add(Result.GetString("datum"));
                    item.SubItems.Add(Result.GetString("vegzettseg"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void List_Munkaadok()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("nev");
            listView1.Columns.Add("cegnev");
            listView1.Columns.Add("email");
            listView1.Columns.Add("telephely");
            listView1.Columns.Add("telefonszam");
            listView1.Items.Clear();
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM munkaadok");
            if (Result.HasRows)
            {
                while (Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetString("nev"));
                    item.SubItems.Add(Result.GetString("cegnev"));
                    item.SubItems.Add(Result.GetString("email"));
                    item.SubItems.Add(Result.GetString("telephely"));
                    item.SubItems.Add(Result.GetString("telefonszam"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void List_Munkavallalok()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("statusz");
            listView1.Columns.Add("nev");
            listView1.Columns.Add("email");
            listView1.Columns.Add("szul_datum");
            listView1.Columns.Add("telefonszam");
            listView1.Columns.Add("lakhely");
            listView1.Columns.Add("reg_datum");
            listView1.Columns.Add("log_datum");
            listView1.Items.Clear();
            listView1.Show();
            MySqlDataReader Result = GlobalVar.DBQuery("SELECT * FROM munkavallalok");
            if(Result.HasRows)
            {
                while(Result.Read())
                {
                    ListViewItem item = new ListViewItem(Result.GetInt32("ID").ToString());
                    item.SubItems.Add(Result.GetInt32("statusz").ToString());
                    item.SubItems.Add(Result.GetString("nev"));
                    item.SubItems.Add(Result.GetString("email"));
                    item.SubItems.Add(Result.GetDateTime("szul_datum").ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Result.GetString("telefonszam"));
                    item.SubItems.Add(Result.GetString("lakhely"));
                    item.SubItems.Add(Result.GetDateTime("reg_datum").ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Result.GetDateTime("log_datum").ToString("yyyy-MM-dd"));
                    listView1.Items.Add(item);
                }
            }
        }
        private void vissza_btn_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 1;
            Form1 nextsite = new Form1();
            nextsite.Show();
            listView1.Columns.Clear();
            listView1.Hide();
            this.Hide();
        }
        private void torles_btn_Click(object sender, EventArgs e)
        {
            what_lbl.Text = "Add meg a törölni kívánt elem ID-jét!";
            ShowEdit(3);
        }
        private void modositas_btn_Click(object sender, EventArgs e)
        {
            what_lbl.Text = "Add meg a módosítani kívánt elem ID-jét!";
            ShowEdit(4);
        }
        private void what_btn_Click(object sender, EventArgs e)
        {
            string tablename = "";
            switch (GlobalVar.Whereiam)
            {
                case 2: tablename = "munkavallalok"; break;
                case 3: tablename = "munkaadok"; break;
                case 4: tablename = "tanulmanyok"; break;
                case 5: tablename = "munkahelyek"; break;
                case 6: tablename = "hirdetesek"; break;
                case 7: tablename = "jelentkezesek"; break;
            }
            int id = int.Parse(what_tbx.Text);
            MySqlDataReader Result = GlobalVar.DBQuery($"SELECT * FROM {tablename} WHERE ID={id}");
            if (Result.HasRows)
            {
                if (GlobalVar.Action == 3)
                {
                    GlobalVar.DBExecute($"DELETE FROM {tablename} WHERE ID={id}");
                    UpdateList();
                }
                else if (GlobalVar.Action == 4)
                {
                    GlobalVar.Actionid = id;
                    Form3 nextsite = new Form3();
                    nextsite.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show($"A(z) ({id}) azonosítójú sor nem szerepel a(z) {tablename} táblában.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void hozzaadas_btn_Click(object sender, EventArgs e)
        {
            GlobalVar.Action = 2;
            Form3 nextsite = new Form3();
            nextsite.Show();
            this.Hide();
        }
    }
}
