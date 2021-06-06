using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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


        private void ClearButton_Click_1(object sender, EventArgs e)
        {


        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainscreenReference.Show();
        }

        private void SearchScreen_Load(object sender, EventArgs e)
        {

        }
    }

}
