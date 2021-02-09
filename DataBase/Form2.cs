using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 gruppa = new Form3(); gruppa.Show(); this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 otdel = new Form5(); otdel.Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 RJD = new Form4(); RJD.Show(); this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 rukovod = new Form6(); rukovod.Show(); this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 student = new Form7(); student.Show(); this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            if (Form1.usr == "user")
            {
                button2.Visible = false;
                button3.Visible = false;
            }
            
        }
    }
}
