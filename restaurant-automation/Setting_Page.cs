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

namespace restaurant_automation
{
    public partial class Setting_Page : Form
    {
        int sellect = -1;
       
        public Setting_Page()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Setting_Page_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Name", typeof(string));
            tablo.Columns.Add("Surname", typeof(string));
            tablo.Columns.Add("Username", typeof(string));
            tablo.Columns.Add("Password", typeof(string));
            tablo.Rows.Add("Ayşe", "Yılmaz", "ayseyılmaz", "1234");
            tablo.Rows.Add("Mehmet", "Yıldız", "worker", "123456");
            dataGridView1.DataSource = tablo;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView1.DataSource = tablo;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order_Page app = new Order_Page();
            app.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            else
                MessageBox.Show("Please select a regist");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sellect != -1)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
                {
                    dataGridView1.Rows[sellect].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[sellect].Cells[1].Value = textBox2.Text;
                    dataGridView1.Rows[sellect].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[sellect].Cells[3].Value = textBox4.Text;

                }
                else MessageBox.Show("Please complete all rows.");
            }
            else MessageBox.Show("Please select regist!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                sellect = dataGridView1.CurrentRow.Index;
            }
            else MessageBox.Show("Please select a regist");
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
