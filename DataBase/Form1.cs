using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DataBase
{
    
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public static String usr;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        Form2 form2;
       
        private void button1_Click (object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "12345")
            {
                usr = txtUser.Text;
                Form1 f1 = new Form1();
                form2.Show();
                this.Hide();
                // f1.ShowDialog();
            }
            else
            if (txtUser.Text == "moderator" && txtPass.Text == "1234")
            {
                usr = txtUser.Text;
                Form1 f1 = new Form1();
                form2.Show();
                this.Hide();

                // f1.ShowDialog();

            }
            else
            if (txtUser.Text == "user" && txtPass.Text == "123")
            {
                usr = txtUser.Text;
                Form1 f1 = new Form1();
                form2.Show();
                this.Hide();
                // f1.ShowDialog();

            }
            else
                MessageBox.Show("Неправильный логин или пароль");
            
        }
    }
}