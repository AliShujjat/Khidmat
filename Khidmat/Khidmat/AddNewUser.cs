using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class AddNewUser : Form
    {
        AdminPanel adminPanelRef;
        public AddNewUser(AdminPanel panel)
        {
            InitializeComponent();
            adminPanelRef = panel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPanelRef.Show();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            adminPanelRef.Show();
        }
    }
}
