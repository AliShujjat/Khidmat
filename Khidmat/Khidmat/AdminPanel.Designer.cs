
namespace Khidmat
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.AddUserButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.AdminPanelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddUserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddUserButton.BackgroundImage")));
            this.AddUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddUserButton.Location = new System.Drawing.Point(101, 153);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(541, 180);
            this.AddUserButton.TabIndex = 21;
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
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
            this.LogOutButton.Location = new System.Drawing.Point(185, 543);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(341, 65);
            this.LogOutButton.TabIndex = 20;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditUserButton.BackgroundImage")));
            this.EditUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.EditUserButton.Location = new System.Drawing.Point(101, 339);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(541, 187);
            this.EditUserButton.TabIndex = 19;
            this.EditUserButton.UseVisualStyleBackColor = false;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // AdminPanelText
            // 
            this.AdminPanelText.AutoSize = true;
            this.AdminPanelText.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminPanelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.AdminPanelText.Location = new System.Drawing.Point(249, 70);
            this.AdminPanelText.Name = "AdminPanelText";
            this.AdminPanelText.Size = new System.Drawing.Size(250, 40);
            this.AdminPanelText.TabIndex = 18;
            this.AdminPanelText.Text = "Admin Panel";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(750, 664);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AdminPanelText);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Label AdminPanelText;
    }
}