using FacebookClone.BLL;
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
				FirstNameTextBox.Text = "";
				FirstNameTextBox.ForeColor = SystemColors.ControlText;
				UserNameChanged = true;
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
			string password = PasswordTextBox.Text;
			if (RePasswordTextBox.Text != password)
			{
				MessageBox.Show("Re-entered password does not match. Please try again.");
				return;
			}

			string firstName = FirstNameTextBox.Text;
			string lastName = LastNameTextBox.Text;
			string email = EmailTextBox.Text;
			DateOnly birthDate = DateOnly.FromDateTime(BirthDateDateTimePicker.Value.Date);
			if (!ProfileBLL.TrySignUp(firstName, lastName, password, email, birthDate))
			{
				MessageBox.Show("Failed to sign in");
				return;
			}

			this.Close();
		}
	}
}
