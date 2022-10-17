using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wildem
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "adatok";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "SELECT * FROM bejelentkezes";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string usernametext = usernamebe.Text;
            string passwordtext = passwordbe.Text;

            if (usernametext == Convert.ToString(reader["nev"]) && passwordtext == Convert.ToString(reader["jelszo"]))
            {
                Console.WriteLine("Sikeres bejelentkezes.");
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

