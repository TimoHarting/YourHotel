using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logon_Click(object sender, EventArgs e)
        {
            string uname = username.Text;
            string pw = password.Text;

            if(controller.logon.login(uname, pw) == true)
            {
                Main m = new Main();
                m.Show();
            }
            else
            {
                username.Clear();
                password.Clear();

                MessageBox.Show("Bitte überprüfe deine Eingaben");
            }
        }
    }
}
