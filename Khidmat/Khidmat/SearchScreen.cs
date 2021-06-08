using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Khidmat
{
    public partial class SearchScreen : Form
    {
        public static int oppID;
        DbConnection db = new DbConnection();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();


        public MainScreen mainscreenReference;

        public SearchScreen()// MainScreen mainScreen)
        {
            InitializeComponent();
            //mainscreenReference = mainScreen;
            db.FillComboBox(procedureTextBox, "select operationName from operativeProcedure where parentProcedure is NULL;");
            db.FillComboBox(doctorComboBox, "select doctorName from doctor;");
            db.FillComboBox(diagnosisComboBox, "select distinct diagnosisName from diagnosis;");
        }


        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            procedureTextBox.SelectedIndex = -1;
            doctorComboBox.SelectedIndex = -1;
            diagnosisComboBox.SelectedIndex = -1;
            HosptRegTextbox.Clear();
            HosptRegTextbox.Focus();

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainscreenReference.Show();
        }

        private void SearchScreen_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string q = "select patientName AS [Patient Name], diagnosisName AS [Diagnosis], operationName AS [Procedure], subprocedure AS [SubProcedures], doctorName AS [Doctor] from patientInfo, operativeProcedure, diagnosis, doctor, operativeProcedurePatient where operativeProcedurePatient.patientMR = patientInfo.patientMR and operativeProcedurePatient.diagnosisID = diagnosis.diagnosisID and operativeProcedurePatient.doctorID = doctor.doctorID and operativeProcedurePatient.procedureID = operativeProcedure.procedureID";
            if (procedureTextBox.SelectedItem != null)
            {
                q += " and operativeProcedurePatient.procedureID in (select procedureID from operativeProcedure where operationName = '" + procedureTextBox.SelectedItem.ToString() + "')"; 
            }
            if (diagnosisComboBox.SelectedItem != null)
            {
                q += " and operativeProcedurePatient.diagnosisID in (select diagnosisID from diagnosis where diagnosisName = '" + diagnosisComboBox.SelectedItem.ToString() + "')";
            }
            if (doctorComboBox.SelectedItem != null)
            {
                q += " and operativeProcedurePatient.doctorID in (select doctorID from doctor where doctorName = '" + doctorComboBox.SelectedItem.ToString() + "')";
            }
            if (HosptRegTextbox.Text != "")
            {
                q += " and operativeProcedurePatient.patientMR = '" + HosptRegTextbox.Text.ToString() + "'";
            }
            MessageBox.Show(q);
            
            dt = db.Select(q);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string qd = "delete from operativeProcedurePatient where operativeProcedurePatient.procedureID in (select procedureID from operativeProcedure where operationName = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "') and operativeProcedurePatient.diagnosisID in (select diagnosisID from diagnosis where diagnosisName = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "') and operativeProcedurePatient.doctorID in (select doctorID from doctor where doctorName = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "') and operativeProcedurePatient.patientMR in (select patientMR from patientInfo where patientName = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') and operativeProcedurePatient.subprocedure = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
            MessageBox.Show("Are you sure you want to delete?");
            db.Deletes(qd);
            MessageBox.Show("Record Deleted Successfully!");

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            string qv = "select top 1 * from operativeProcedurePatient where operativeProcedurePatient.procedureID in (select procedureID from operativeProcedure where operationName = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "') and operativeProcedurePatient.diagnosisID in (select diagnosisID from diagnosis where diagnosisName = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "') and operativeProcedurePatient.doctorID in (select doctorID from doctor where doctorName = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "') and operativeProcedurePatient.patientMR in (select patientMR from patientInfo where patientName = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') and operativeProcedurePatient.subprocedure = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
            dt = db.Select(qv);
            oppID = Convert.ToInt32(dt.Rows[0][0].ToString());

            dt2 = db.Select("Select description from diagnosis where diagnosisID =" + dt.Rows[0][3].ToString() + ";");
            string description = dt2.Rows[0][0].ToString();

            AddNewRecord recordform = new AddNewRecord(false, dt.Rows[0][15].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dt.Rows[0][16].ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), description, dt.Rows[0][14].ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][6].ToString());
            recordform.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string qv = "select top 1 * from operativeProcedurePatient where operativeProcedurePatient.procedureID in (select procedureID from operativeProcedure where operationName = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "') and operativeProcedurePatient.diagnosisID in (select diagnosisID from diagnosis where diagnosisName = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "') and operativeProcedurePatient.doctorID in (select doctorID from doctor where doctorName = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "') and operativeProcedurePatient.patientMR in (select patientMR from patientInfo where patientName = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "') and operativeProcedurePatient.subprocedure = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
            dt = db.Select(qv);
            oppID = Convert.ToInt32(dt.Rows[0][0].ToString());

            dt2 = db.Select("Select description from diagnosis where diagnosisID =" + dt.Rows[0][3].ToString() + ";");
            string description = dt2.Rows[0][0].ToString();

            AddNewRecord recordform = new AddNewRecord(true, dt.Rows[0][15].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dt.Rows[0][16].ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), description, dt.Rows[0][14].ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][6].ToString());
            recordform.Show();

        }
    }

}
