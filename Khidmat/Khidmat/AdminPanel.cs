using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class AdminPanel : Form
    {
        public LogIn loginReference;
        public AdminPanel(LogIn login)
        {
            InitializeComponent();
            loginReference = login;
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            loginReference.Show();
            this.Close();

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUserScreen = new AddNewUser(this);
            addNewUserScreen.Show();
            this.Hide();
        }
    }
}
