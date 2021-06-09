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
        bool check = false;

        public AddNewUser()//AdminPanel panel)
        {
            InitializeComponent();
            //adminPanelRef = panel;
        }

        public AddNewUser (bool editable, string Name, string specialization, string Contact, string DOB, string sex)
        {
            InitializeComponent();
            //adminPanelRef = panel;
            MessageBox.Show(Name);
            NameTextBox.Text = Name;
            SpecializationTextBox.Text = specialization;
            ContactTextBox.Text = Contact;
            gendervariable = sex;
            DOBPicker.Value = Convert.ToDateTime(DOB);

            if (editable == false)
            {
                NameTextBox.Enabled = false;
                SpecializationTextBox.Enabled = false;
                ContactTextBox.Enabled = false;
                DOBPicker.Enabled = false;
                SubmitButton.Enabled = false;
            }

            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
            {
                if (sex == GenderListBox.Items[ix].ToString())
                {
                    GenderListBox.SetItemChecked(ix, true);

                }
            }

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
            if (this.check == false)
            {
                string q = "INSERT INTO doctor (doctorName, sex, specialization, contact, dateofbirth) VALUES ('" + NameTextBox.Text.ToString() + "','" + gendervariable.ToString() + "','" + SpecializationTextBox.Text.ToString() + "','" + ContactTextBox.Text.ToString() + "', CONVERT(date, '" + DOBPicker.Value.Date + "', 105));";
                MessageBox.Show(q);
                db.Inserts(q);
                MessageBox.Show("User Added Successfully!");
                //adminPanelRef.Show();
            }
            else
            {
                string qu = "UPDATE doctor " +
                    "SET doctorName = '" + NameTextBox.Text.ToString() + "', specialization = '" + SpecializationTextBox.Text.ToString() + "', contact = '" + ContactTextBox.Text.ToString() + "', dateofbirth = CONVERT(date, '" + DOBPicker.Value.Date + "', 105) , sex = '" + gendervariable + "';" +
                    "WHERE doctorID = " + SearchUsers.doctorID.ToString();
                MessageBox.Show(qu);
                db.Update(qu);
                MessageBox.Show("Update Successful");
            }

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
