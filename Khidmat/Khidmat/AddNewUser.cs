using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Khidmat
{
    public partial class AddNewUser : Form
    {
        //AdminPanel adminPanelRef;
        public string gendervariable;
        DbConnection db = new DbConnection();
        private int index;
        public AddNewUser()//AdminPanel panel)
        {
            InitializeComponent();
            //adminPanelRef = panel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //adminPanelRef.Show();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            string q = "INSERT INTO doctor (doctorName, sex, specialization, contact, dateofbirth) VALUES ('" + NameTextBox.Text.ToString() + "','" + gendervariable.ToString() + "','" + SpecializationTextBox.Text.ToString() + "','"  + ContactTextBox.Text.ToString() + "','" + DOBPicker.Text.ToString() + "');";
            MessageBox.Show(q);
            db.Inserts(q);
            this.Close();
            //adminPanelRef.Show();
        }

        private void GenderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
            {
                if (GenderListBox.GetItemChecked(ix))
                {
                    gendervariable = GenderListBox.Items[ix].ToString();
                    index = ix;

                }
            }
        }
    }
}
