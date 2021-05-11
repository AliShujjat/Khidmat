
namespace Khidmat
{
    partial class AddNewPatientScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneralInfo = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OccupationTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RoomNumberTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BedNumberTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HospitalRegTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WardTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DiagnosisTextbox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DODPicker = new System.Windows.Forms.DateTimePicker();
            this.DOAPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GeneralInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralInfo
            // 
            this.GeneralInfo.Controls.Add(this.richTextBox1);
            this.GeneralInfo.Controls.Add(this.label5);
            this.GeneralInfo.Controls.Add(this.ContactTextBox);
            this.GeneralInfo.Controls.Add(this.label3);
            this.GeneralInfo.Controls.Add(this.GenderListBox);
            this.GeneralInfo.Controls.Add(this.label4);
            this.GeneralInfo.Controls.Add(this.OccupationTextbox);
            this.GeneralInfo.Controls.Add(this.label1);
            this.GeneralInfo.Controls.Add(this.AgeTextBox);
            this.GeneralInfo.Controls.Add(this.AgeText);
            this.GeneralInfo.Controls.Add(this.NameTextBox);
            this.GeneralInfo.Controls.Add(this.NameText);
            this.GeneralInfo.Location = new System.Drawing.Point(31, 89);
            this.GeneralInfo.Name = "GeneralInfo";
            this.GeneralInfo.Size = new System.Drawing.Size(643, 201);
            this.GeneralInfo.TabIndex = 0;
            this.GeneralInfo.TabStop = false;
            this.GeneralInfo.Text = "Patient Information";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(496, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(110, 86);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(428, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(322, 47);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(127, 27);
            this.ContactTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(256, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact";
            // 
            // GenderListBox
            // 
            this.GenderListBox.FormattingEnabled = true;
            this.GenderListBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderListBox.Location = new System.Drawing.Point(74, 109);
            this.GenderListBox.Name = "GenderListBox";
            this.GenderListBox.Size = new System.Drawing.Size(87, 70);
            this.GenderListBox.TabIndex = 9;
            this.GenderListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sex";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OccupationTextbox
            // 
            this.OccupationTextbox.Location = new System.Drawing.Point(284, 125);
            this.OccupationTextbox.Name = "OccupationTextbox";
            this.OccupationTextbox.Size = new System.Drawing.Size(118, 27);
            this.OccupationTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Occupation";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(519, 47);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(61, 27);
            this.AgeTextBox.TabIndex = 3;
            // 
            // AgeText
            // 
            this.AgeText.AutoSize = true;
            this.AgeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeText.Location = new System.Drawing.Point(477, 50);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(36, 20);
            this.AgeText.TabIndex = 2;
            this.AgeText.Text = "Age";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(74, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.Location = new System.Drawing.Point(19, 50);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(49, 20);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Patient";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(433, 591);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(147, 52);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(162, 591);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 52);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoomNumberTextbox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BedNumberTextbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.HospitalRegTextbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.WardTextbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DiagnosisTextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DODPicker);
            this.groupBox1.Controls.Add(this.DOAPicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(31, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hospital Details";
            // 
            // RoomNumberTextbox
            // 
            this.RoomNumberTextbox.Location = new System.Drawing.Point(564, 178);
            this.RoomNumberTextbox.Name = "RoomNumberTextbox";
            this.RoomNumberTextbox.Size = new System.Drawing.Size(61, 27);
            this.RoomNumberTextbox.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(482, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Room No.";
            // 
            // BedNumberTextbox
            // 
            this.BedNumberTextbox.Location = new System.Drawing.Point(564, 128);
            this.BedNumberTextbox.Name = "BedNumberTextbox";
            this.BedNumberTextbox.Size = new System.Drawing.Size(61, 27);
            this.BedNumberTextbox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(496, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bed No.";
            // 
            // HospitalRegTextbox
            // 
            this.HospitalRegTextbox.Location = new System.Drawing.Point(354, 150);
            this.HospitalRegTextbox.Name = "HospitalRegTextbox";
            this.HospitalRegTextbox.Size = new System.Drawing.Size(115, 27);
            this.HospitalRegTextbox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(225, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 65);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hospital Registration No.";
            // 
            // WardTextbox
            // 
            this.WardTextbox.Location = new System.Drawing.Point(96, 147);
            this.WardTextbox.Name = "WardTextbox";
            this.WardTextbox.Size = new System.Drawing.Size(92, 27);
            this.WardTextbox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ward No.";
            // 
            // DiagnosisTextbox
            // 
            this.DiagnosisTextbox.Location = new System.Drawing.Point(402, 41);
            this.DiagnosisTextbox.Name = "DiagnosisTextbox";
            this.DiagnosisTextbox.Size = new System.Drawing.Size(204, 69);
            this.DiagnosisTextbox.TabIndex = 20;
            this.DiagnosisTextbox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(305, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diagnosis";
            // 
            // DODPicker
            // 
            this.DODPicker.Location = new System.Drawing.Point(160, 83);
            this.DODPicker.Name = "DODPicker";
            this.DODPicker.Size = new System.Drawing.Size(89, 27);
            this.DODPicker.TabIndex = 18;
            // 
            // DOAPicker
            // 
            this.DOAPicker.Location = new System.Drawing.Point(160, 41);
            this.DOAPicker.Name = "DOAPicker";
            this.DOAPicker.Size = new System.Drawing.Size(89, 27);
            this.DOAPicker.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date of Discharge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of Admission";
            // 
            // AddNewPatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneralInfo);
            this.Name = "AddNewPatientScreen";
            this.Text = "Cancel";
            this.GeneralInfo.ResumeLayout(false);
            this.GeneralInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GeneralInfo;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeText;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.CheckedListBox GenderListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OccupationTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox RoomNumberTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BedNumberTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HospitalRegTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WardTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox DiagnosisTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DODPicker;
        private System.Windows.Forms.DateTimePicker DOAPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}