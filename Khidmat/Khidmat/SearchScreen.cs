using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class SearchScreen : Form
    {
        public MainScreen mainscreenReference;
        public SearchScreen(MainScreen mainScreen)
        {
            InitializeComponent();
            mainscreenReference = mainScreen;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenReference.Show();
        }
    }
}
