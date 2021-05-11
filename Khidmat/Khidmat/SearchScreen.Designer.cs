
namespace Khidmat
{
    partial class SearchScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchResultsList = new System.Windows.Forms.ListView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchByTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Results:";
            // 
            // FilterDropDown
            // 
            this.FilterDropDown.FormattingEnabled = true;
            this.FilterDropDown.Items.AddRange(new object[] {
            "Name",
            "Age",
            "Sex",
            "Date of Procedure",
            "Diagnosis"});
            this.FilterDropDown.Location = new System.Drawing.Point(286, 110);
            this.FilterDropDown.Name = "FilterDropDown";
            this.FilterDropDown.Size = new System.Drawing.Size(249, 28);
            this.FilterDropDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(175, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter By:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(424, 209);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(78, 38);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(286, 209);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(78, 38);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(187, 561);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 38);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(325, 558);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(78, 38);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // SearchResultsList
            // 
            this.SearchResultsList.HideSelection = false;
            this.SearchResultsList.Location = new System.Drawing.Point(104, 290);
            this.SearchResultsList.Name = "SearchResultsList";
            this.SearchResultsList.Size = new System.Drawing.Size(543, 249);
            this.SearchResultsList.TabIndex = 1;
            this.SearchResultsList.UseCompatibleStateImageBehavior = false;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(475, 558);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(78, 38);
            this.ViewButton.TabIndex = 9;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(22, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(78, 38);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search By:";
            // 
            // SearchByTextbox
            // 
            this.SearchByTextbox.Location = new System.Drawing.Point(286, 165);
            this.SearchByTextbox.Name = "SearchByTextbox";
            this.SearchByTextbox.Size = new System.Drawing.Size(249, 27);
            this.SearchByTextbox.TabIndex = 12;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 623);
            this.Controls.Add(this.SearchByTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchResultsList);
            this.Controls.Add(this.label1);
            this.Name = "SearchScreen";
            this.Text = "SearchScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListView SearchResultsList;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchByTextbox;
    }
}