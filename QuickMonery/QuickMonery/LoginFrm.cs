using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

       


        private void PanlLogin_Click(object sender, EventArgs e)
        {
            Login();
        }


        public void Login()
        {
            string userName = txtUserName.Text.Trim();

            string password = txtPassword.Text.Trim();

            if (userName == "zhangsan" && password == "zhangsan")
            {
                MainFrm main = new MainFrm();

                main.Show();

                this.Hide();
            }
        }

       
    }
}
