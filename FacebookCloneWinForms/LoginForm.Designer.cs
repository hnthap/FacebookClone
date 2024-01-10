namespace FacebookCloneWinForms
{
	partial class LoginForm_
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
			forrealbookLabel = new Label();
			ContentPanel = new Panel();
			ForgotPasswordContentLabel = new Label();
			LoginContentPanel = new Panel();
			CreateAccountLabel = new Label();
			ForgotPasswordLabel = new Label();
			SeparateLineLabel = new Label();
			LoginTextBox = new Label();
			PasswordTextBox = new TextBox();
			UserNameTextBox = new TextBox();
			forrealbookDescriptionLabel = new Label();
			LeftDockLabel = new Label();
			RightDockLabel = new Label();
			TopDockLabel = new Label();
			BotDockLabel = new Label();
			ContentPanel.SuspendLayout();
			LoginContentPanel.SuspendLayout();
			SuspendLayout();
			// 
			// forrealbookLabel
			// 
			forrealbookLabel.FlatStyle = FlatStyle.System;
			forrealbookLabel.Font = new Font("Lucida Sans Unicode", 48F, FontStyle.Bold, GraphicsUnit.Point);
			forrealbookLabel.ForeColor = SystemColors.HotTrack;
			forrealbookLabel.Location = new Point(69, 108);
			forrealbookLabel.Name = "forrealbookLabel";
			forrealbookLabel.Size = new Size(470, 108);
			forrealbookLabel.TabIndex = 0;
			forrealbookLabel.Text = "forrealbook";
			// 
			// ContentPanel
			// 
			ContentPanel.Controls.Add(ForgotPasswordContentLabel);
			ContentPanel.Controls.Add(LoginContentPanel);
			ContentPanel.Controls.Add(forrealbookDescriptionLabel);
			ContentPanel.Controls.Add(forrealbookLabel);
			ContentPanel.Location = new Point(338, 261);
			ContentPanel.Name = "ContentPanel";
			ContentPanel.Size = new Size(1226, 510);
			ContentPanel.TabIndex = 1;
			// 
			// ForgotPasswordContentLabel
			// 
			ForgotPasswordContentLabel.FlatStyle = FlatStyle.System;
			ForgotPasswordContentLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
			ForgotPasswordContentLabel.ForeColor = SystemColors.Control;
			ForgotPasswordContentLabel.Location = new Point(69, 340);
			ForgotPasswordContentLabel.Name = "ForgotPasswordContentLabel";
			ForgotPasswordContentLabel.Size = new Size(602, 53);
			ForgotPasswordContentLabel.TabIndex = 3;
			ForgotPasswordContentLabel.Text = "Your password is: ";
			ForgotPasswordContentLabel.Visible = false;
			// 
			// LoginContentPanel
			// 
			LoginContentPanel.Controls.Add(CreateAccountLabel);
			LoginContentPanel.Controls.Add(ForgotPasswordLabel);
			LoginContentPanel.Controls.Add(SeparateLineLabel);
			LoginContentPanel.Controls.Add(LoginTextBox);
			LoginContentPanel.Controls.Add(PasswordTextBox);
			LoginContentPanel.Controls.Add(UserNameTextBox);
			LoginContentPanel.Location = new Point(728, 23);
			LoginContentPanel.Name = "LoginContentPanel";
			LoginContentPanel.Size = new Size(469, 459);
			LoginContentPanel.TabIndex = 2;
			// 
			// CreateAccountLabel
			// 
			CreateAccountLabel.BackColor = Color.ForestGreen;
			CreateAccountLabel.FlatStyle = FlatStyle.System;
			CreateAccountLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			CreateAccountLabel.ForeColor = SystemColors.Control;
			CreateAccountLabel.Location = new Point(27, 388);
			CreateAccountLabel.Name = "CreateAccountLabel";
			CreateAccountLabel.Size = new Size(423, 41);
			CreateAccountLabel.TabIndex = 5;
			CreateAccountLabel.Text = "Create new account";
			CreateAccountLabel.TextAlign = ContentAlignment.MiddleCenter;
			CreateAccountLabel.Click += CreateAccountLabel_Click;
			// 
			// ForgotPasswordLabel
			// 
			ForgotPasswordLabel.BackColor = Color.FromArgb(36, 36, 36);
			ForgotPasswordLabel.FlatStyle = FlatStyle.System;
			ForgotPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			ForgotPasswordLabel.ForeColor = SystemColors.HotTrack;
			ForgotPasswordLabel.Location = new Point(27, 312);
			ForgotPasswordLabel.Name = "ForgotPasswordLabel";
			ForgotPasswordLabel.Size = new Size(423, 32);
			ForgotPasswordLabel.TabIndex = 4;
			ForgotPasswordLabel.Text = "Forgotten your password?";
			ForgotPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
			ForgotPasswordLabel.Click += ForgotPasswordLabel_Click;
			// 
			// SeparateLineLabel
			// 
			SeparateLineLabel.BorderStyle = BorderStyle.Fixed3D;
			SeparateLineLabel.FlatStyle = FlatStyle.System;
			SeparateLineLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			SeparateLineLabel.ForeColor = SystemColors.Control;
			SeparateLineLabel.Location = new Point(3, 360);
			SeparateLineLabel.Name = "SeparateLineLabel";
			SeparateLineLabel.Size = new Size(469, 1);
			SeparateLineLabel.TabIndex = 3;
			// 
			// LoginTextBox
			// 
			LoginTextBox.BackColor = SystemColors.HotTrack;
			LoginTextBox.FlatStyle = FlatStyle.System;
			LoginTextBox.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			LoginTextBox.ForeColor = SystemColors.Control;
			LoginTextBox.Location = new Point(27, 255);
			LoginTextBox.Name = "LoginTextBox";
			LoginTextBox.Size = new Size(423, 46);
			LoginTextBox.TabIndex = 2;
			LoginTextBox.Text = "Login";
			LoginTextBox.TextAlign = ContentAlignment.MiddleCenter;
			LoginTextBox.Click += LoginTextBox_Click;
			// 
			// PasswordTextBox
			// 
			PasswordTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			PasswordTextBox.ForeColor = SystemColors.ControlDark;
			PasswordTextBox.Location = new Point(27, 147);
			PasswordTextBox.Multiline = true;
			PasswordTextBox.Name = "PasswordTextBox";
			PasswordTextBox.PasswordChar = '*';
			PasswordTextBox.Size = new Size(423, 70);
			PasswordTextBox.TabIndex = 1;
			PasswordTextBox.Text = "okay";
			PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
			// 
			// UserNameTextBox
			// 
			UserNameTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			UserNameTextBox.ForeColor = SystemColors.ControlDark;
			UserNameTextBox.Location = new Point(27, 42);
			UserNameTextBox.Multiline = true;
			UserNameTextBox.Name = "UserNameTextBox";
			UserNameTextBox.Size = new Size(423, 70);
			UserNameTextBox.TabIndex = 0;
			UserNameTextBox.Text = "user001@demo.com";
			UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
			// 
			// forrealbookDescriptionLabel
			// 
			forrealbookDescriptionLabel.FlatStyle = FlatStyle.System;
			forrealbookDescriptionLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			forrealbookDescriptionLabel.ForeColor = SystemColors.Control;
			forrealbookDescriptionLabel.Location = new Point(69, 216);
			forrealbookDescriptionLabel.Name = "forrealbookDescriptionLabel";
			forrealbookDescriptionLabel.Size = new Size(602, 108);
			forrealbookDescriptionLabel.TabIndex = 1;
			forrealbookDescriptionLabel.Text = "forrealbook helps you connect and share with people in your life";
			// 
			// LeftDockLabel
			// 
			LeftDockLabel.Dock = DockStyle.Left;
			LeftDockLabel.Location = new Point(0, 0);
			LeftDockLabel.Name = "LeftDockLabel";
			LeftDockLabel.Size = new Size(332, 1033);
			LeftDockLabel.TabIndex = 2;
			// 
			// RightDockLabel
			// 
			RightDockLabel.Dock = DockStyle.Right;
			RightDockLabel.Location = new Point(1570, 0);
			RightDockLabel.Name = "RightDockLabel";
			RightDockLabel.Size = new Size(332, 1033);
			RightDockLabel.TabIndex = 3;
			// 
			// TopDockLabel
			// 
			TopDockLabel.Dock = DockStyle.Top;
			TopDockLabel.Location = new Point(332, 0);
			TopDockLabel.Name = "TopDockLabel";
			TopDockLabel.Size = new Size(1238, 258);
			TopDockLabel.TabIndex = 4;
			// 
			// BotDockLabel
			// 
			BotDockLabel.Dock = DockStyle.Bottom;
			BotDockLabel.Location = new Point(332, 774);
			BotDockLabel.Name = "BotDockLabel";
			BotDockLabel.Size = new Size(1238, 259);
			BotDockLabel.TabIndex = 5;
			// 
			// LoginForm_
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(36, 36, 36);
			ClientSize = new Size(1902, 1033);
			Controls.Add(BotDockLabel);
			Controls.Add(TopDockLabel);
			Controls.Add(RightDockLabel);
			Controls.Add(LeftDockLabel);
			Controls.Add(ContentPanel);
			Name = "LoginForm_";
			Text = "LoginForm_";
			ContentPanel.ResumeLayout(false);
			LoginContentPanel.ResumeLayout(false);
			LoginContentPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label forrealbookLabel;
		private Panel ContentPanel;
		private Label LeftDockLabel;
		private Label RightDockLabel;
		private Label TopDockLabel;
		private Label BotDockLabel;
		private Panel LoginContentPanel;
		private TextBox UserNameTextBox;
		private Label forrealbookDescriptionLabel;
		private Label LoginTextBox;
		private TextBox PasswordTextBox;
		private Label SeparateLineLabel;
		private Label CreateAccountLabel;
		private Label ForgotPasswordLabel;
		private Label ForgotPasswordContentLabel;
	}
}