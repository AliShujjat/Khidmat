
namespace Khidmat
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.WelcomeText = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.AddNewProcedureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.WelcomeText.Location = new System.Drawing.Point(232, 104);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(657, 65);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Welcome Dr. Imtiaz! ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.SearchButton.Location = new System.Drawing.Point(156, 498);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(879, 299);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.BackgroundImage")));
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.LogOutButton.Location = new System.Drawing.Point(401, 1062);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(372, 106);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddRecordButton.BackgroundImage")));
            this.AddRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRecordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddRecordButton.Location = new System.Drawing.Point(156, 237);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(868, 269);
            this.AddRecordButton.TabIndex = 8;
            this.AddRecordButton.UseVisualStyleBackColor = false;
            this.AddRecordButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AdminPanelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminPanelButton.BackgroundImage")));
            this.AdminPanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AdminPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdminPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminPanelButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminPanelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AdminPanelButton.Location = new System.Drawing.Point(496, 1178);
            this.AdminPanelButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(172, 46);
            this.AdminPanelButton.TabIndex = 16;
            this.AdminPanelButton.UseVisualStyleBackColor = false;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // AddNewProcedureButton
            // 
            this.AddNewProcedureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddNewProcedureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNewProcedureButton.BackgroundImage")));
            this.AddNewProcedureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddNewProcedureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewProcedureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddNewProcedureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddNewProcedureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProcedureButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewProcedureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddNewProcedureButton.Location = new System.Drawing.Point(167, 786);
            this.AddNewProcedureButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddNewProcedureButton.Name = "AddNewProcedureButton";
            this.AddNewProcedureButton.Size = new System.Drawing.Size(868, 294);
            this.AddNewProcedureButton.TabIndex = 17;
            this.AddNewProcedureButton.UseVisualStyleBackColor = false;
            this.AddNewProcedureButton.Click += new System.EventHandler(this.AddNewProcedureButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1168, 1243);
            this.Controls.Add(this.AddNewProcedureButton);
            this.Controls.Add(this.AdminPanelButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.WelcomeText);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button AdminPanelButton;
        private System.Windows.Forms.Button AddNewProcedureButton;
    }
}