namespace FacebookCloneWinForms
{
    partial class SignUpForm
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
            BotDockLabel = new Label();
            forrealbookLabel = new Label();
            ContentPanel = new Panel();
            SignUpContentPanel = new Panel();
            DateOfBirthTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            RePasswordTextBox = new TextBox();
            SignUpTextBox = new Label();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            forrealbookDescriptionLabel = new Label();
            TopDockLabel = new Label();
            RightDockLabel = new Label();
            LeftDockLabel = new Label();
            ContentPanel.SuspendLayout();
            SignUpContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BotDockLabel
            // 
            BotDockLabel.Dock = DockStyle.Bottom;
            BotDockLabel.Location = new Point(332, 774);
            BotDockLabel.Name = "BotDockLabel";
            BotDockLabel.Size = new Size(1238, 259);
            BotDockLabel.TabIndex = 10;
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
            ContentPanel.Controls.Add(SignUpContentPanel);
            ContentPanel.Controls.Add(forrealbookDescriptionLabel);
            ContentPanel.Controls.Add(forrealbookLabel);
            ContentPanel.Location = new Point(338, 261);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1226, 510);
            ContentPanel.TabIndex = 6;
            // 
            // SignUpContentPanel
            // 
            SignUpContentPanel.BorderStyle = BorderStyle.FixedSingle;
            SignUpContentPanel.Controls.Add(DateOfBirthTextBox);
            SignUpContentPanel.Controls.Add(UserNameTextBox);
            SignUpContentPanel.Controls.Add(RePasswordTextBox);
            SignUpContentPanel.Controls.Add(SignUpTextBox);
            SignUpContentPanel.Controls.Add(PasswordTextBox);
            SignUpContentPanel.Controls.Add(EmailTextBox);
            SignUpContentPanel.Location = new Point(731, 13);
            SignUpContentPanel.Name = "SignUpContentPanel";
            SignUpContentPanel.Size = new Size(469, 484);
            SignUpContentPanel.TabIndex = 2;
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DateOfBirthTextBox.ForeColor = SystemColors.ControlDark;
            DateOfBirthTextBox.Location = new Point(27, 173);
            DateOfBirthTextBox.Multiline = true;
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(423, 70);
            DateOfBirthTextBox.TabIndex = 5;
            DateOfBirthTextBox.Text = "Enter your date of birth here...";
            DateOfBirthTextBox.TextChanged += DateOfBirthTextBox_TextChanged;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTextBox.ForeColor = SystemColors.ControlDark;
            UserNameTextBox.Location = new Point(27, 97);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(423, 70);
            UserNameTextBox.TabIndex = 4;
            UserNameTextBox.Text = "Enter your username here...";
            UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
            // 
            // RePasswordTextBox
            // 
            RePasswordTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RePasswordTextBox.ForeColor = SystemColors.ControlDark;
            RePasswordTextBox.Location = new Point(27, 325);
            RePasswordTextBox.Multiline = true;
            RePasswordTextBox.Name = "RePasswordTextBox";
            RePasswordTextBox.Size = new Size(423, 70);
            RePasswordTextBox.TabIndex = 3;
            RePasswordTextBox.Text = "Re-enter your password here...";
            RePasswordTextBox.TextChanged += RePasswordTextBox_TextChanged;
            // 
            // SignUpTextBox
            // 
            SignUpTextBox.BackColor = Color.Green;
            SignUpTextBox.FlatStyle = FlatStyle.System;
            SignUpTextBox.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpTextBox.ForeColor = SystemColors.Control;
            SignUpTextBox.Location = new Point(27, 420);
            SignUpTextBox.Name = "SignUpTextBox";
            SignUpTextBox.Size = new Size(423, 46);
            SignUpTextBox.TabIndex = 2;
            SignUpTextBox.Text = "Sign Up";
            SignUpTextBox.TextAlign = ContentAlignment.MiddleCenter;
            SignUpTextBox.Click += SignUpTextBox_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = SystemColors.ControlDark;
            PasswordTextBox.Location = new Point(27, 249);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(423, 70);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Text = "Enter your password here...";
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.ForeColor = SystemColors.ControlDark;
            EmailTextBox.Location = new Point(27, 21);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(423, 70);
            EmailTextBox.TabIndex = 0;
            EmailTextBox.Text = "Enter your email here...";
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
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
            // TopDockLabel
            // 
            TopDockLabel.Dock = DockStyle.Top;
            TopDockLabel.Location = new Point(332, 0);
            TopDockLabel.Name = "TopDockLabel";
            TopDockLabel.Size = new Size(1238, 258);
            TopDockLabel.TabIndex = 9;
            // 
            // RightDockLabel
            // 
            RightDockLabel.Dock = DockStyle.Right;
            RightDockLabel.Location = new Point(1570, 0);
            RightDockLabel.Name = "RightDockLabel";
            RightDockLabel.Size = new Size(332, 1033);
            RightDockLabel.TabIndex = 8;
            // 
            // LeftDockLabel
            // 
            LeftDockLabel.Dock = DockStyle.Left;
            LeftDockLabel.Location = new Point(0, 0);
            LeftDockLabel.Name = "LeftDockLabel";
            LeftDockLabel.Size = new Size(332, 1033);
            LeftDockLabel.TabIndex = 7;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1902, 1033);
            Controls.Add(BotDockLabel);
            Controls.Add(ContentPanel);
            Controls.Add(TopDockLabel);
            Controls.Add(RightDockLabel);
            Controls.Add(LeftDockLabel);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ContentPanel.ResumeLayout(false);
            SignUpContentPanel.ResumeLayout(false);
            SignUpContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label BotDockLabel;
        private Label forrealbookLabel;
        private Panel ContentPanel;
        private Panel SignUpContentPanel;
        private Label SignUpTextBox;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label forrealbookDescriptionLabel;
        private Label TopDockLabel;
        private Label RightDockLabel;
        private Label LeftDockLabel;
        private TextBox DateOfBirthTextBox;
        private TextBox UserNameTextBox;
        private TextBox RePasswordTextBox;
    }
}