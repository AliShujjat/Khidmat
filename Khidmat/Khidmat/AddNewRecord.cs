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
        bool check = false;

        private MainScreen mainscreenRef;
        public AddNewRecord()//MainScreen main)
        {
            InitializeComponent();
            //mainscreenRef = main;
            db.FillComboBox(ProcedureComboBox, "select operationName from operativeProcedure where parentProcedure is NULL;");
            db.FillComboBox(DoctorComboBox, "select doctorName from doctor;");
        }

        public AddNewRecord(bool editable, string formtype, string MR, string DOA, string DOD, string comments, string ward, string room, string bed, string procedure, string subprocesdure, string diagnosis, string diagnosisdiscription, string outcome, string doctor, string anesthetist, string atype, string assistant)//MainScreen main)
        {
            InitializeComponent();
            //mainscreenRef = main;
            db.FillComboBox(ProcedureComboBox, "select operationName from operativeProcedure where parentProcedure is NULL;");
            db.FillComboBox(DoctorComboBox, "select doctorName from doctor;");

            FormTypeComboBox.Text = formtype;
            HospitalRegTextbox.Text = MR;
            DOAPicker.Text = DOA;
            DODPicker.Text = DOD;
            DoctorCommentsTextBox.Text = comments;
            WardTextbox.Text = ward;
            RoomNumberTextbox.Text = room;
            BedNumberTextbox.Text = bed;
            ProcedureComboBox.Text = procedure;
            DiagnosisTextBox.Text = diagnosis;
            DiagnosisDescriptionTextBox.Text = diagnosisdiscription;
            DoctorComboBox.Text = doctor;
            OutcomeComboBox.Text = outcome;
            AnaesthetistTextBox.Text = anesthetist;
            AnaesthesiaTypeTextBox.Text = atype;
            AssistantTextBox.Text = assistant;
            
            this.check = editable;

            if (editable == false)
            {
                FormTypeComboBox.Enabled = false;
                HospitalRegTextbox.Enabled = false;
                DOAPicker.Enabled = false;
                DODPicker.Enabled = false;
                DoctorCommentsTextBox.Enabled = false;
                WardTextbox.Enabled = false;
                RoomNumberTextbox.Enabled = false;
                BedNumberTextbox.Enabled = false;
                ProcedureComboBox.Enabled = false;
                DiagnosisTextBox.Enabled = false;
                DiagnosisDescriptionTextBox.Enabled = false;
                DoctorComboBox.Enabled = false;
                OutcomeComboBox.Enabled = false;
                AnaesthetistTextBox.Enabled = false;
                AnaesthesiaTypeTextBox.Enabled = false;
                AssistantTextBox.Enabled = false;
                SubmitButton.Enabled = false;
            }
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
            string dq = "INSERT INTO diagnosis (diagnosisName, description) VALUES ('" + DiagnosisTextBox.Text.ToString() + "','" + DiagnosisDescriptionTextBox.Text.ToString() + "');";
            db.Inserts(dq);

            dt = db.Select("select procedureID from operativeProcedure where operationName = '" + ProcedureComboBox.SelectedItem.ToString() + "';");
            int procedureIDint = Convert.ToInt32(dt.Rows[0][0].ToString());

            dt = db.Select("select MAX(diagnosisID) from diagnosis where diagnosisName = '" + DiagnosisTextBox.Text.ToString() + "';");
            int diagnosisIDint = Convert.ToInt32(dt.Rows[0][0].ToString());

            dt = db.Select("select doctorID from doctor where doctorName = '" + DoctorComboBox.SelectedItem.ToString() + "';");
            int doctorIDint = Convert.ToInt32(dt.Rows[0][0].ToString());

            string subprocedurelist = "";
            for (int i = 0; i < SubProcedureCheckBox.Items.Count; i++)
            {
                if (SubProcedureCheckBox.GetItemChecked(i))
                {
                    subprocedurelist += (string)SubProcedureCheckBox.Items[i];
                    subprocedurelist += ", ";
                }
            }

            if (this.check == false)
            {
                string q = "INSERT INTO operativeProcedurePatient (patientMR, procedureID, diagnosisID, doctorID ,doctorComments, assistant, anaesthetist, anesthesiaType, dateOfAdmission, dateOfDischarge, wardNumber, roomNumber, bedNumber, outcome, formtype, subprocedure) VALUES ('" + HospitalRegTextbox.Text.ToString() + "'," + procedureIDint.ToString() + "," + diagnosisIDint.ToString() + "," + doctorIDint.ToString() + ",'" + DoctorCommentsTextBox.Text.ToString() + "','" + AssistantTextBox.Text.ToString() + "','" + AnaesthetistTextBox.Text.ToString() + "','" + AnaesthesiaTypeTextBox.Text.ToString() + "','" + DOAPicker.Value.Date + "','" + DODPicker.Value.Date + "','" + WardTextbox.Text.ToString() + "','" + RoomNumberTextbox.Text.ToString() + "','" + BedNumberTextbox.Text.ToString() + "','" + OutcomeComboBox.SelectedItem.ToString() + "','" + FormTypeComboBox.SelectedItem.ToString() + "','" + subprocedurelist.ToString() + "');";
                MessageBox.Show(q);
                db.Inserts(q);
            }
            else
            {
                MessageBox.Show(SearchScreen.oppID.ToString());
                string qu = "UPDATE operativeProcedurePatient SET " +
                "patientMR = '" + HospitalRegTextbox.Text.ToString() + "', procedureID = " + procedureIDint.ToString() + ", diagnosisID = " + diagnosisIDint.ToString() + ", doctorID = " + doctorIDint.ToString() + ", doctorComments = '" + DoctorCommentsTextBox.Text.ToString() + "', assistant = '" + AssistantTextBox.Text.ToString() + "', anaesthetist = '" + AnaesthetistTextBox.Text.ToString() + "', anesthesiaType = '" + AnaesthesiaTypeTextBox.Text.ToString() + "', dateOfAdmission = '" + DOAPicker.Value.Date + "', dateOfDischarge = '" + DODPicker.Value.Date + "', wardNumber = '" + WardTextbox.Text.ToString() + "', roomNumber = '" + RoomNumberTextbox.Text.ToString() + "', bedNumber = '" + BedNumberTextbox.Text.ToString() + "', outcome = '" + OutcomeComboBox.SelectedItem.ToString() + "', formtype = '" + FormTypeComboBox.SelectedItem.ToString() + "', subprocedure = '" + subprocedurelist.ToString() + "'" +
                " WHERE oppID = " + SearchScreen.oppID.ToString() + ";";
                MessageBox.Show(qu);
                db.Update(qu);
            }
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
