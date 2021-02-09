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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 nazad = new Form2(); nazad.Show(); this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DatabaseDataSet.Отделения_железных_дорог". При необходимости она может быть перемещена или удалена.
            this.отделения_железных_дорогTableAdapter.Fill(this._1DatabaseDataSet.Отделения_железных_дорог);

        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            if (Form1.usr == "user")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
            }
            else
                if (Form1.usr == "moderator")
            {
                button2.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            отделения_железных_дорогTableAdapter.Update(_1DatabaseDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 af = new Form10();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 sf = new Form15();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Доступно редактирование");
            dataGridView1.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы уверены что хотите удалить данную строку?",
            "Внимание",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                int delet = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.Rows.RemoveAt(delet);
                dataGridView1.AllowUserToDeleteRows = false;
            }
        }
    }
}
