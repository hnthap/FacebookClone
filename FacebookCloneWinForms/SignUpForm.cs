using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCloneWinForms
{
    public partial class SignUpForm : Form
    {
        public static bool EmailChanged = false, UserNameChanged = false, DateChanged = false,
            PasswordChanged = false, RePasswordChanged = false;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailChanged == false)
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = SystemColors.ControlText;
                EmailChanged = true;
            }
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserNameChanged == false)
            {
                UserNameTextBox.Text = "";
                UserNameTextBox.ForeColor = SystemColors.ControlText;
                UserNameChanged = true;
            }
        }

        private void DateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DateChanged == false)
            {
                DateOfBirthTextBox.Text = "";
                DateOfBirthTextBox.ForeColor = SystemColors.ControlText;
                DateChanged = true;
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

        private void RePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RePasswordChanged == false)
            {
                RePasswordTextBox.Text = "";
                RePasswordTextBox.ForeColor = SystemColors.ControlText;
                RePasswordChanged = true;
            }
        }

        private void SignUpTextBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
