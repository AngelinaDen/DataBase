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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main._1DatabaseDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
               // nRow[0] = rc;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                // nRow[3] = tbMail.Text;
                // nRow[4] = tbPhoto.Text;
                main._1DatabaseDataSet.Tables[0].Rows.Add(nRow);
                main.группыTableAdapter.Update(main._1DatabaseDataSet.Группы);
                main._1DatabaseDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                //tbMail.Text = "";
                //tbPhoto.Text = "";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Close(); this.Close();
        }
    }
}
