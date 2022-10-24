using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    public partial class LoginCGS : Form
    {
        public LoginCGS()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Login(txtbUserName.Text, txtbPass.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login(string txtbUserName, string txtbPass)
        {
            using (StreamReader sr = new StreamReader(@"../../files/login.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();
                    strArray = str.Split(',');
                    if (strArray[0] != txtbUserName)
                        continue;
                    if (strArray[0] == txtbUserName && strArray[1] == txtbPass)
                    {
                        MainCGS main = new MainCGS();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Error");
                    }
                }
            }

        }
    }
}
