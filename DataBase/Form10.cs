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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main._1DatabaseDataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                // nRow[0] = rc;
                //nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox1.Text;
                // nRow[4] = tbPhoto.Text;
                main._1DatabaseDataSet.Tables[2].Rows.Add(nRow);
                main.отделения_железных_дорогTableAdapter.Update(main._1DatabaseDataSet.Отделения_железных_дорог);
                main._1DatabaseDataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox2.Text = "";
                textBox1.Text = "";
                //tbMail.Text = "";
                //tbPhoto.Text = "";
            }
        }
    }
}
