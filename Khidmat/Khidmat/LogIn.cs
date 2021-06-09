using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Khidmat
{
    public partial class LogIn : Form
    {
        DbConnection db = new DbConnection();
        DataTable dt = new DataTable();

        public LogIn()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            new DropShadow().ApplyShadows(Background);
            PasswordTextbox.PasswordChar = '*';


        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            dt = db.Select("Select * from doctor where doctorname like '" + IdTextBox.Text.ToString() + "';");
            try
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User ID not recognized by the system.");
                    IdTextBox.Text = "";
                    IdTextBox.Focus();
                }
                else
                {
                    if (PasswordTextbox.Text == "admin")
                    {
                        Program.userType = true;
                        MainScreen mainscreen = new MainScreen(this);
                        mainscreen.Show();
                        this.Hide();
                    }
                    else if (PasswordTextbox.Text == "doctor")
                    {
                        Program.userType = false;
                        MainScreen mainscreen = new MainScreen(this);
                        mainscreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                    }

                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
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
