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
    public partial class SearchUsers : Form
    {
        DbConnection db = new DbConnection();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public static int doctorID;

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

        }

        private void SearchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchUsers_Load(object sender, EventArgs e)
        {
            dt = db.Select("select doctorName AS Doctor, Sex, Specialization, Contact, dateofbirth AS DOB from doctor");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string qd = "delete from doctor where doctorName = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and contact = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' and specialization = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "';";
            MessageBox.Show("Are you sure you want to delete?");
            MessageBox.Show(qd);
            db.Deletes(qd);
            MessageBox.Show("Record Deleted Successfully!");
            this.Refresh();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            dt = db.Select("Select doctorID from doctor where doctorName = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and contact = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' and specialization = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "';");
            MessageBox.Show(dt.Rows[0][0].ToString());
            doctorID = Convert.ToInt32(dt.Rows[0][0].ToString());
            
            AddNewUser userform = new AddNewUser(true, dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
            userform.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            AddNewUser userform = new AddNewUser(false, dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
            userform.Show();

        }
    }
}
