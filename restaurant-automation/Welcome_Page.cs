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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            Setting_Page app = new Setting_Page();
            app.Show();
            this.Hide();
        }

        private void worker_login_Click(object sender, EventArgs e)
        {
            Login_Page app = new Login_Page();
            app.Show();
            this.Hide();
        }
    }
}
