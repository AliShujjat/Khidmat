
namespace Khidmat
{
    partial class AddProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProcedure));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ProcedureNameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.richTextBox1.Location = new System.Drawing.Point(245, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 145);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(89, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sub Procedures:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.NameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.NameTextBox.Location = new System.Drawing.Point(245, 152);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(221, 26);
            this.NameTextBox.TabIndex = 15;
            // 
            // ProcedureNameText
            // 
            this.ProcedureNameText.AutoSize = true;
            this.ProcedureNameText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcedureNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.ProcedureNameText.Location = new System.Drawing.Point(89, 152);
            this.ProcedureNameText.Name = "ProcedureNameText";
            this.ProcedureNameText.Size = new System.Drawing.Size(150, 18);
            this.ProcedureNameText.TabIndex = 14;
            this.ProcedureNameText.Text = "Procedure Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(89, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "(Add each in a new line)";
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.CancelButton.Location = new System.Drawing.Point(110, 429);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 86);
            this.CancelButton.TabIndex = 37;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitButton.BackgroundImage")));
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.SubmitButton.Location = new System.Drawing.Point(318, 434);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(157, 77);
            this.SubmitButton.TabIndex = 36;
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.WelcomeText.Location = new System.Drawing.Point(110, 62);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(382, 40);
            this.WelcomeText.TabIndex = 38;
            this.WelcomeText.Text = "Add New Procedure";
            // 
            // AddProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(589, 569);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProcedureNameText);
            this.Name = "AddProcedure";
            this.Text = "AddProcedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ProcedureNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label WelcomeText;
    }
}