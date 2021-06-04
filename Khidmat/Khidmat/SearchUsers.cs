using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class SearchUsers : Form
    {
        AdminPanel adminPanelRef;
        public SearchUsers(AdminPanel panel)
        {
            InitializeComponent();
            adminPanelRef = panel;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPanelRef.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchByTextbox.Text = "";
        }
    }
}
