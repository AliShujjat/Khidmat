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
    public partial class AddNewRecord : Form
    {
        DbConnection db = new DbConnection();
        DataTable dt = new DataTable();

        private MainScreen mainscreenRef;
        public AddNewRecord()//MainScreen main)
        {
            InitializeComponent();
            //mainscreenRef = main;
            db.FillComboBox(ProcedureComboBox, "select operationName from operativeProcedure where parentProcedure is NULL;");
            db.FillComboBox(DoctorComboBox, "select doctorName from doctor;");
        }

        private void AddNewRecord_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainscreenRef.Show();
        }

        private void OutcomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //string q = "INSERT INTO operativeProcedurePatient (patientMR, procedureID, diagnosisID, doctorID ,doctorComments, assistant, anaesthetist, anesthesiaType, dateOfAdmission, dateOfDischarge, wardNumber, roomNumber, bedNumber, outcome, formtype, subprocedure) VALUES ('" + HospitalRegTextbox.Text.ToString() + "','" + gendervariable.ToString() + "','" + SpecializationTextBox.Text.ToString() + "','" + ContactTextBox.Text.ToString() + "','" + DOBPicker.Text.ToString() + "');";
            //MessageBox.Show(q);
            //db.Inserts(q);

        }

        private void ProcedureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubProcedureCheckBox.Items.Clear();
            //dt = db.Select();
            string q = "Select distinct operationName from operativeProcedure where parentProcedure in (select distinct procedureID from operativeProcedure where operationName = '" + ProcedureComboBox.SelectedItem.ToString() + "');";
            db.cmd = new SqlCommand(q,db.conn);
            db.cmd.CommandText = q;
            db.conn.Open();
            SqlDataReader drd = db.cmd.ExecuteReader();
            while (drd.Read())
            {
                ((ListBox)SubProcedureCheckBox).Items.Add(drd["operationName"].ToString());
                ((ListBox)SubProcedureCheckBox).DisplayMember = drd["operationName"].ToString();
                ((ListBox)SubProcedureCheckBox).ValueMember = drd["operationName"].ToString();
            }
            db.conn.Close();
        }
    }
}
