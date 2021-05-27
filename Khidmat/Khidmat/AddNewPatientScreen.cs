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

        private AddNewRecord recordscreenref;
        public AddNewPatientScreen( AddNewRecord main)
        {
            InitializeComponent();
            recordscreenref = main;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
                if (ix != e.Index) GenderListBox.SetItemChecked(ix, false);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddNewPatientScreen_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            recordscreenref.Show();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            recordscreenref.Show();
        }
    }
}
