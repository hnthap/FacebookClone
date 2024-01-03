namespace FacebookCloneWinForms
{
    partial class FriendRequestUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AvatarPanel = new Panel();
            ConfirmLabel = new Label();
            DeleteLabel = new Label();
            UserNameLabel = new Label();
            SuspendLayout();
            // 
            // AvatarPanel
            // 
            AvatarPanel.BackgroundImage = Properties.Resources.default_avatar;
            AvatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPanel.Location = new Point(2, 13);
            AvatarPanel.Name = "AvatarPanel";
            AvatarPanel.Size = new Size(250, 250);
            AvatarPanel.TabIndex = 0;
            // 
            // ConfirmLabel
            // 
            ConfirmLabel.BackColor = SystemColors.HotTrack;
            ConfirmLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmLabel.ForeColor = SystemColors.Control;
            ConfirmLabel.Location = new Point(18, 322);
            ConfirmLabel.Name = "ConfirmLabel";
            ConfirmLabel.Size = new Size(220, 45);
            ConfirmLabel.TabIndex = 1;
            ConfirmLabel.Text = "Confirm";
            ConfirmLabel.TextAlign = ContentAlignment.MiddleCenter;
            ConfirmLabel.Click += ConfirmLabel_Click;
            // 
            // DeleteLabel
            // 
            DeleteLabel.BackColor = SystemColors.ControlDark;
            DeleteLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteLabel.ForeColor = SystemColors.Control;
            DeleteLabel.Location = new Point(18, 378);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(220, 45);
            DeleteLabel.TabIndex = 2;
            DeleteLabel.Text = "Delete";
            DeleteLabel.TextAlign = ContentAlignment.MiddleCenter;
            DeleteLabel.Click += DeleteLabel_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.BackColor = Color.FromArgb(39, 39, 39);
            UserNameLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = SystemColors.Control;
            UserNameLabel.Location = new Point(2, 266);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(220, 45);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "User Name Here";
            UserNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FriendRequestUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(UserNameLabel);
            Controls.Add(DeleteLabel);
            Controls.Add(ConfirmLabel);
            Controls.Add(AvatarPanel);
            Name = "FriendRequestUserControl";
            Size = new Size(255, 445);
            ResumeLayout(false);
        }

        #endregion

        private Panel AvatarPanel;
        private Label ConfirmLabel;
        private Label DeleteLabel;
        private Label UserNameLabel;
    }
}
