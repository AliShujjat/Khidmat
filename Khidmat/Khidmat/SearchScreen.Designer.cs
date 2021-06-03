
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchResultsText = new System.Windows.Forms.Label();
            this.FilterDropDown = new System.Windows.Forms.ComboBox();
            this.FilterByText = new System.Windows.Forms.Label();
            this.SearchResultsList = new System.Windows.Forms.ListView();
            this.SearchByText = new System.Windows.Forms.Label();
            this.SearchByTextbox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(212, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Database";
            // 
            // SearchResultsText
            // 
            this.SearchResultsText.AutoSize = true;
            this.SearchResultsText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchResultsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.SearchResultsText.Location = new System.Drawing.Point(104, 259);
            this.SearchResultsText.Name = "SearchResultsText";
            this.SearchResultsText.Size = new System.Drawing.Size(136, 18);
            this.SearchResultsText.TabIndex = 2;
            this.SearchResultsText.Text = "Search Results:";
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
            // FilterByText
            // 
            this.FilterByText.AutoSize = true;
            this.FilterByText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilterByText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.FilterByText.Location = new System.Drawing.Point(175, 106);
            this.FilterByText.Name = "FilterByText";
            this.FilterByText.Size = new System.Drawing.Size(82, 18);
            this.FilterByText.TabIndex = 4;
            this.FilterByText.Text = "Filter By:";
            // 
            // SearchResultsList
            // 
            this.SearchResultsList.HideSelection = false;
            this.SearchResultsList.Location = new System.Drawing.Point(104, 290);
            this.SearchResultsList.Name = "SearchResultsList";
            this.SearchResultsList.Size = new System.Drawing.Size(543, 248);
            this.SearchResultsList.TabIndex = 1;
            this.SearchResultsList.UseCompatibleStateImageBehavior = false;
            // 
            // SearchByText
            // 
            this.SearchByText.AutoSize = true;
            this.SearchByText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchByText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(158)))), ((int)(((byte)(176)))));
            this.SearchByText.Location = new System.Drawing.Point(160, 161);
            this.SearchByText.Name = "SearchByText";
            this.SearchByText.Size = new System.Drawing.Size(96, 18);
            this.SearchByText.TabIndex = 11;
            this.SearchByText.Text = "Search By:";
            // 
            // SearchByTextbox
            // 
            this.SearchByTextbox.Location = new System.Drawing.Point(286, 164);
            this.SearchByTextbox.Name = "SearchByTextbox";
            this.SearchByTextbox.Size = new System.Drawing.Size(249, 27);
            this.SearchByTextbox.TabIndex = 12;
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearButton.BackgroundImage")));
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClearButton.Location = new System.Drawing.Point(240, 211);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 55);
            this.ClearButton.TabIndex = 39;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitButton.BackgroundImage")));
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.SubmitButton.Location = new System.Drawing.Point(400, 211);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(122, 57);
            this.SubmitButton.TabIndex = 38;
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.DeleteButton.Location = new System.Drawing.Point(175, 552);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 64);
            this.DeleteButton.TabIndex = 40;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.EditButton.Location = new System.Drawing.Point(329, 552);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(123, 64);
            this.EditButton.TabIndex = 41;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            this.ViewButton.AutoSize = true;
            this.ViewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewButton.BackgroundImage")));
            this.ViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ViewButton.Location = new System.Drawing.Point(479, 552);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(106, 59);
            this.ViewButton.TabIndex = 42;
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.BackButton.Location = new System.Drawing.Point(24, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(66, 55);
            this.BackButton.TabIndex = 43;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.AddButton.Location = new System.Drawing.Point(558, 157);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(46, 41);
            this.AddButton.TabIndex = 44;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(718, 623);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SearchByTextbox);
            this.Controls.Add(this.SearchByText);
            this.Controls.Add(this.FilterByText);
            this.Controls.Add(this.FilterDropDown);
            this.Controls.Add(this.SearchResultsText);
            this.Controls.Add(this.SearchResultsList);
            this.Controls.Add(this.label1);
            this.Name = "SearchScreen";
            this.Text = "SearchScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SearchResultsText;
        private System.Windows.Forms.ComboBox FilterDropDown;
        private System.Windows.Forms.Label FilterByText;
        private System.Windows.Forms.ListView SearchResultsList;
        private System.Windows.Forms.Label SearchByText;
        private System.Windows.Forms.TextBox SearchByTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
    }
}