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
            if (Program.userType == false)
            {
                AdminPanelButton.Enabled = false;
                AdminPanelButton.Visible = false;
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            loginReference.Show();

            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen();// this);
            searchScreen.Show();
            this.Hide();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            AddNewRecord addNewRecordScreen = new AddNewRecord();//this);
            addNewRecordScreen.Show();
            this.Hide();
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(loginReference);
            adminPanel.Show();
            this.Close();
        }

        private void AddNewProcedureButton_Click(object sender, EventArgs e)
        {
            AddProcedure addProcedureScreen = new AddProcedure(this);
            addProcedureScreen.Show();
            this.Hide();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
