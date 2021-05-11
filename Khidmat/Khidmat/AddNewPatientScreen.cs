using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Khidmat
{
    public partial class AddNewPatientScreen : Form
    {

        private MainScreen mainscreenRef;
        public AddNewPatientScreen( MainScreen main)
        {
            InitializeComponent();
            mainscreenRef = main;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
                if (ix != e.Index) GenderListBox.SetItemChecked(ix, false);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
