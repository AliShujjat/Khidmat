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
    public partial class AddProcedure : Form
    {
        DbConnection db = new DbConnection();
        DataTable dt = new DataTable();
        private MainScreen mainscreenRef;
        public AddProcedure(MainScreen main)
        {
            InitializeComponent();
            //ListBoxSubProcedures.Text = "";
            mainscreenRef = main;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string q = "INSERT INTO operativeProcedure (operationName, parentProcedure, description) VALUES ('" + NameTextBox.Text.ToString() + "', NULL, '" + TextBoxDescription.Text.ToString() + "');";
            db.Inserts(q);

            dt = db.Select("Select distinct procedureID from operativeProcedure where operationName = '" + NameTextBox.Text.ToString() + "';");
            int parentProcedure = Convert.ToInt32(dt.Rows[0][0].ToString());
            
            for (int ix = 0; ix < ListBoxSubProcedures.Items.Count; ++ix)
            {
                string text = ListBoxSubProcedures.Items[ix].Text.ToString();
                MessageBox.Show(text);
                q = "INSERT INTO operativeProcedure (operationName, parentProcedure, description) VALUES ('" + text.ToString() + "'," + parentProcedure.ToString() + ", NULL);";
                db.Inserts(q);
            }

            MessageBox.Show("Procedure Added Successfully");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }

        private void ListBoxSubProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TextboxAddSubProcedure.Text.ToString() != "")
            {
                ListBoxSubProcedures.Items.Add(TextboxAddSubProcedure.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please Add a Subprocedure to be shown below");
            }
        }
    }
}
