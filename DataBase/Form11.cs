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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main._1DatabaseDataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                // nRow[0] = rc;
                //nRow[0] = textBox1.Text;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                // nRow[4] = tbPhoto.Text;
                main._1DatabaseDataSet.Tables[3].Rows.Add(nRow);
                main.руководителиTableAdapter.Update(main._1DatabaseDataSet.Руководители);
                main._1DatabaseDataSet.Tables[3].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                //tbMail.Text = "";
                //tbPhoto.Text = "";
            }
        }
    }
}
