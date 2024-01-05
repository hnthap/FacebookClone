using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCloneWinForms
{
    public partial class LoginForm_ : Form
    {
        public static bool EmailChanged = false, PasswordChanged = false, ForgotPasswordChanged = false;
        public LoginForm_()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordChanged = false;
            ForgotPasswordContentLabel.Visible = false;

            if (EmailChanged == false)
            {
                UserNameTextBox.Text = "";
                UserNameTextBox.ForeColor = SystemColors.ControlText;
                EmailChanged = true;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordChanged == false)
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = SystemColors.ControlText;
                PasswordChanged = true;
            }
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            var frm = new HomePage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            if (PasswordChanged == false)
            {
                // Check for username, GOOO LUCK ***

                //
                ForgotPasswordContentLabel.Text = "";
                string text = "Your account password is: ";
                string password = "/passwordfoundgoeshere";
                ForgotPasswordContentLabel.Text = text + password;
                ForgotPasswordContentLabel.Visible = true;
                PasswordChanged = true;
            }
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            var frm = new SignUpForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
