using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wildem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            librarypanel.Visible = true;
            storepanel.Visible = false;
            accountpanel.Visible = false;
            settingspanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            storepanel.Visible = true;
            librarypanel.Visible = false;
            accountpanel.Visible = false;
            settingspanel.Visible = false;

        }

        private void librarypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            accountpanel.Visible = true;
            storepanel.Visible = false;
            librarypanel.Visible = false;
            settingspanel.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            accountpanel.Visible = false;
            storepanel.Visible = false;
            librarypanel.Visible = false;
            settingspanel.Visible = true;
        }
    }
}
