using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Khidmat
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            new DropShadow().ApplyShadows(Background);
            PasswordTextbox.PasswordChar = '*';


        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "admin" && PasswordTextbox.Text == "admin")
            {
                MainScreen mainscreen = new MainScreen(this);
                mainscreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter ID and Password!");
            }
        }

        private void LoginPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(80, 202, 255), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(area, Color.FromArgb(80, 202, 255), Color.FromArgb(4, 120, 255), LinearGradientMode.Vertical);
            graphics.FillRectangle(LGB, area);
            graphics.DrawRectangle(pen,area);
        }

 

        private void LogIn_Load(object sender, EventArgs e)
        {
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked)
            {
                PasswordTextbox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextbox.PasswordChar = '*';
            }
        }
    }
}
