namespace FacebookCloneWinForms
{
    partial class IntroductionContactAndBasisForm
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
            ContactIcon = new Panel();
            ContactLabel = new Label();
            EmailIcon = new Panel();
            EmailLabel = new Label();
            EmaiContentLabel = new Label();
            PhoneContentLabel = new Label();
            PhoneIcon = new Panel();
            PhoneLabel = new Label();
            SuspendLayout();
            // 
            // ContactIcon
            // 
            ContactIcon.BackgroundImage = Properties.Resources.contact_icon;
            ContactIcon.BackgroundImageLayout = ImageLayout.Stretch;
            ContactIcon.Location = new Point(12, 11);
            ContactIcon.Name = "ContactIcon";
            ContactIcon.Size = new Size(43, 43);
            ContactIcon.TabIndex = 2;
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ContactLabel.ForeColor = SystemColors.Control;
            ContactLabel.Location = new Point(61, 11);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(140, 43);
            ContactLabel.TabIndex = 3;
            ContactLabel.Text = "Contact";
            // 
            // EmailIcon
            // 
            EmailIcon.BackgroundImage = Properties.Resources.mail_icon;
            EmailIcon.BackgroundImageLayout = ImageLayout.Stretch;
            EmailIcon.Location = new Point(12, 93);
            EmailIcon.Name = "EmailIcon";
            EmailIcon.Size = new Size(43, 43);
            EmailIcon.TabIndex = 5;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabel.ForeColor = SystemColors.Control;
            EmailLabel.Location = new Point(61, 93);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(105, 43);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // EmaiContentLabel
            // 
            EmaiContentLabel.AutoSize = true;
            EmaiContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EmaiContentLabel.ForeColor = SystemColors.Control;
            EmaiContentLabel.Location = new Point(12, 149);
            EmaiContentLabel.Name = "EmaiContentLabel";
            EmaiContentLabel.Size = new Size(406, 36);
            EmaiContentLabel.TabIndex = 7;
            EmaiContentLabel.Text = "iamsillysnail123@outlook.com";
            // 
            // PhoneContentLabel
            // 
            PhoneContentLabel.AutoSize = true;
            PhoneContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneContentLabel.ForeColor = SystemColors.Control;
            PhoneContentLabel.Location = new Point(12, 283);
            PhoneContentLabel.Name = "PhoneContentLabel";
            PhoneContentLabel.Size = new Size(406, 36);
            PhoneContentLabel.TabIndex = 10;
            PhoneContentLabel.Text = "iamsillysnail123@outlook.com";
            // 
            // PhoneIcon
            // 
            PhoneIcon.BackgroundImage = Properties.Resources.phone_icon;
            PhoneIcon.BackgroundImageLayout = ImageLayout.Stretch;
            PhoneIcon.Location = new Point(12, 227);
            PhoneIcon.Name = "PhoneIcon";
            PhoneIcon.Size = new Size(43, 43);
            PhoneIcon.TabIndex = 8;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneLabel.ForeColor = SystemColors.Control;
            PhoneLabel.Location = new Point(61, 227);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(118, 43);
            PhoneLabel.TabIndex = 9;
            PhoneLabel.Text = "Phone";
            // 
            // IntroductionContactAndBasisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 372);
            Controls.Add(PhoneContentLabel);
            Controls.Add(PhoneIcon);
            Controls.Add(PhoneLabel);
            Controls.Add(EmaiContentLabel);
            Controls.Add(EmailIcon);
            Controls.Add(EmailLabel);
            Controls.Add(ContactIcon);
            Controls.Add(ContactLabel);
            Name = "IntroductionContactAndBasisForm";
            Text = "IntroductionContactAndBasisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ContactIcon;
        private Label ContactLabel;
        private Panel EmailIcon;
        private Label EmailLabel;
        private Label EmaiContentLabel;
        private Label PhoneContentLabel;
        private Panel PhoneIcon;
        private Label PhoneLabel;
    }
}