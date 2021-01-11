using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_automation
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = user_name.Text;
            string password = pass_word.Text;
            if (username == "worker" && password == "123456")
            {
                Order_Page app = new Order_Page();
                app.Show();
                this.Hide();
            }
           else if(username == "admin" && password == "123456")
            {
                Setting_Page app = new Setting_Page();
                app.Show();
                this.Hide();
            }
            else if(username=="sudedalyan" && password=="123456")
            {
                Order_Page app = new Order_Page();
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Information Incorrect !");
                user_name_Text = " ";
                pass_word.Text = " ";
            }
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
