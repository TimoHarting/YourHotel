using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YourHotel.forms;

namespace YourHotel
{
    public partial class Main : Form
    {
        public Main()
        {
            Login l = new Login();
            l.ShowDialog();

            if (config.getconfig.loggedin)
            {
                InitializeComponent();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void restaurant_Click(object sender, EventArgs e)
        {
            restaurantForm rf = new restaurantForm();
            rf.Show();
        }
    }
}
