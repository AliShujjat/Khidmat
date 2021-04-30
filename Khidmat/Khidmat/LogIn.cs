using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            MainScreen mainscreen = new MainScreen(this);
            mainscreen.Show();
            this.Hide();
        }
    }
}
