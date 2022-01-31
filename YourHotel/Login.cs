using System;
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
                config.getconfig.loggedin = true;
                this.Close();
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
