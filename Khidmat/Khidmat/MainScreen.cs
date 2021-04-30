using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class MainScreen : Form
    {
        public LogIn loginReference;
        public MainScreen(LogIn login)
        {
            InitializeComponent();
            loginReference = login;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNewPatientScreen addNewPatientScreen = new AddNewPatientScreen(this);
            addNewPatientScreen.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginReference.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen(this);
            searchScreen.Show();
            this.Hide();
        }
    }
}
