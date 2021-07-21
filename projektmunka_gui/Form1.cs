using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektmunka_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GlobalVar.Whereiam = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 2;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 3;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 4;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 5;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 6;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            GlobalVar.Whereiam = 7;
            Form2 nextsite = new Form2();
            nextsite.Show();
            this.Hide();
        }
        /* =========================================================================================================================================================== */
        
    }
}
