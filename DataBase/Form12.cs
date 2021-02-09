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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 main = this.Owner as Form7;
            if (main != null)
            {
                DataRow nRow = main._1DatabaseDataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                // nRow[0] = rc;
                //nRow[0] = textBox1.Text;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox6.Text;
                nRow[7] = textBox7.Text;
                // nRow[4] = tbPhoto.Text;
                main._1DatabaseDataSet.Tables[4].Rows.Add(nRow);
                main.студентыTableAdapter.Update(main._1DatabaseDataSet.Студенты);
                main._1DatabaseDataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                //tbMail.Text = "";
                //tbPhoto.Text = "";
            }
        }
    }
}
