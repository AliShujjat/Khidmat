using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class AddNewRecord : Form
    {
 
        private MainScreen mainscreenRef;
        public AddNewRecord(MainScreen main)
        {
            InitializeComponent();
            mainscreenRef = main;
        }

        private void AddNewRecord_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }

        private void OutcomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
