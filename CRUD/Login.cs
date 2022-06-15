using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Login : Form
    {
        private SmartText passwordST;
        private SmartText usernameST;        

        public Login()
        {
            InitializeComponent();
            passwordST = new SmartText("password", passwordText);
            usernameST = new SmartText("username", usernameText);
        }

        private void usernameText_Enter(object sender, EventArgs e)
        {          
            usernameST.WritingState();
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {            
            usernameST.InicialState();
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            passwordST.WritingState();
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            passwordST.InicialState();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameText.ForeColor == Color.Gray) Db.username = ""; 
            else Db.username = usernameText.Text;

            if (passwordText.ForeColor == Color.Gray) Db.password = "";
            else Db.password = passwordText.Text;

            if (Db.Connect() == true)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }            
        }
    }
}
