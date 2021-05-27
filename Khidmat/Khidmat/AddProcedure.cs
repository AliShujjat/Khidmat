using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class AddProcedure : Form
    {
        private MainScreen mainscreenRef;
        public AddProcedure(MainScreen main)
        {
            InitializeComponent();
            mainscreenRef = main;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }
    }
}
