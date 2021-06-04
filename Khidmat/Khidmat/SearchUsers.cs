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
    }
}
