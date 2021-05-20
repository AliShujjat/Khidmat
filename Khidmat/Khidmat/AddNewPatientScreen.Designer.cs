
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
            this.HospitalRegTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GeneralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralInfo
            // 
            this.GeneralInfo.Controls.Add(this.HospitalRegTextbox);
            this.GeneralInfo.Controls.Add(this.label10);
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
            this.GeneralInfo.Size = new System.Drawing.Size(643, 258);
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
            this.OccupationTextbox.Location = new System.Drawing.Point(282, 125);
            this.OccupationTextbox.Name = "OccupationTextbox";
            this.OccupationTextbox.Size = new System.Drawing.Size(118, 27);
            this.OccupationTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 128);
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
            this.SubmitButton.Location = new System.Drawing.Point(397, 376);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(147, 52);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(170, 376);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 52);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HospitalRegTextbox
            // 
            this.HospitalRegTextbox.Location = new System.Drawing.Point(322, 178);
            this.HospitalRegTextbox.Name = "HospitalRegTextbox";
            this.HospitalRegTextbox.Size = new System.Drawing.Size(115, 27);
            this.HospitalRegTextbox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(191, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 65);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hospital Registration No.";
            // 
            // AddNewPatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 471);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneralInfo);
            this.Name = "AddNewPatientScreen";
            this.Text = "Cancel";
            this.GeneralInfo.ResumeLayout(false);
            this.GeneralInfo.PerformLayout();
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
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox HospitalRegTextbox;
        private System.Windows.Forms.Label label10;
    }
}