
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneralInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralInfo
            // 
            this.GeneralInfo.Controls.Add(this.textBox2);
            this.GeneralInfo.Controls.Add(this.label3);
            this.GeneralInfo.Controls.Add(this.checkedListBox1);
            this.GeneralInfo.Controls.Add(this.label4);
            this.GeneralInfo.Controls.Add(this.textBox1);
            this.GeneralInfo.Controls.Add(this.label1);
            this.GeneralInfo.Controls.Add(this.AgeTextBox);
            this.GeneralInfo.Controls.Add(this.AgeText);
            this.GeneralInfo.Controls.Add(this.NameTextBox);
            this.GeneralInfo.Controls.Add(this.NameText);
            this.GeneralInfo.Location = new System.Drawing.Point(31, 89);
            this.GeneralInfo.Name = "GeneralInfo";
            this.GeneralInfo.Size = new System.Drawing.Size(554, 201);
            this.GeneralInfo.TabIndex = 0;
            this.GeneralInfo.TabStop = false;
            this.GeneralInfo.Text = "General Information";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.checkedListBox1.Location = new System.Drawing.Point(204, 105);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(87, 70);
            this.checkedListBox1.TabIndex = 9;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(142, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sex";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(61, 104);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(61, 27);
            this.AgeTextBox.TabIndex = 3;
            // 
            // AgeText
            // 
            this.AgeText.AutoSize = true;
            this.AgeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeText.Location = new System.Drawing.Point(19, 102);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(36, 20);
            this.AgeText.TabIndex = 2;
            this.AgeText.Text = "Age";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.Location = new System.Drawing.Point(19, 53);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(80, 20);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "First Name";
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
            this.SubmitButton.Location = new System.Drawing.Point(353, 707);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(147, 52);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(123, 707);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 52);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(31, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical History";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(398, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 27);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(322, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact";
            // 
            // AddNewPatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 793);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}