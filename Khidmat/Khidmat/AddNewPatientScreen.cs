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
    public partial class AddNewPatientScreen : Form
    {
        DbConnection db = new DbConnection();
        public string gendervariable;

        private AddNewRecord recordscreenref;
        public AddNewPatientScreen() //AddNewRecord main)
        {
            InitializeComponent();
            //recordscreenref = main;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
                if (ix != e.Index) 
                { 
                    GenderListBox.SetItemChecked(ix, false);
                }
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
            //recordscreenref.Show();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show(gendervariable);
            //string q = "INSERT INTO patientInfo (patientMR, patientName, sex, age, history, contact, occupation, address) VALUES ('" + HospitalRegTextbox.Text.ToString() + "','" + NameTextBox.Text.ToString() + "','" + gendervariable.ToString() + "'," + Convert.ToInt32(AgeTextBox.Text.ToString()) + ",'" + "history" + "','" + ContactTextBox.Text.ToString() + "','" + OccupationTextbox.Text.ToString() + "','" + richTextBox1.Text.ToString() + "');";
            //MessageBox.Show(q);
            //db.Inserts(q);
            

            //db.InsertQuery("Insert into UsersLogs (LOG_ID, USER_ID, LOGIN_DATE, LOGIN_TIME, MODULE_TYPE) values (" + Program.thislogin_logid + "," + Program.userid + ",CAST( GETDATE() AS Date ), CAST( GETDATE() AS Time ), 'S')");


        }

        private void GenderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int ix = 0; ix < GenderListBox.Items.Count; ++ix)
            {
                if (GenderListBox.GetItemChecked(ix))
                {
                    gendervariable = GenderListBox.Items[ix].ToString();
                }
            }

        }
    }
}
