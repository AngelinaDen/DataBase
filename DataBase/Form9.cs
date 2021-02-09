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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main._1DatabaseDataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                // nRow[0] = rc;
                //nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                // nRow[3] = tbMail.Text;
                // nRow[4] = tbPhoto.Text;
                main._1DatabaseDataSet.Tables[1].Rows.Add(nRow);
                main.железные_дорогиTableAdapter.Update(main._1DatabaseDataSet.Железные_дороги);
                main._1DatabaseDataSet.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox2.Text = "";
                //tbMail.Text = "";
                //tbPhoto.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); this.Close();
        }
    }
}
