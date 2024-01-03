namespace FacebookCloneWinForms
{
    partial class InformationFriendUserControl
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
            UserNameLabel = new Label();
            DeleteLabel = new Label();
            AddFriendLabel = new Label();
            AvatarPanel = new Panel();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.BackColor = Color.FromArgb(39, 39, 39);
            UserNameLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = SystemColors.Control;
            UserNameLabel.Location = new Point(2, 270);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(220, 45);
            UserNameLabel.TabIndex = 7;
            UserNameLabel.Text = "User Name Here";
            UserNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteLabel
            // 
            DeleteLabel.BackColor = SystemColors.ControlDark;
            DeleteLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteLabel.ForeColor = SystemColors.Control;
            DeleteLabel.Location = new Point(18, 382);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(220, 45);
            DeleteLabel.TabIndex = 6;
            DeleteLabel.Text = "Delete";
            DeleteLabel.TextAlign = ContentAlignment.MiddleCenter;
            DeleteLabel.Click += DeleteLabel_Click;
            // 
            // AddFriendLabel
            // 
            AddFriendLabel.BackColor = SystemColors.HotTrack;
            AddFriendLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            AddFriendLabel.ForeColor = SystemColors.Control;
            AddFriendLabel.Location = new Point(18, 326);
            AddFriendLabel.Name = "AddFriendLabel";
            AddFriendLabel.Size = new Size(220, 45);
            AddFriendLabel.TabIndex = 5;
            AddFriendLabel.Text = "Add friend";
            AddFriendLabel.TextAlign = ContentAlignment.MiddleCenter;
            AddFriendLabel.Click += AddFriendLabel_Click;
            // 
            // AvatarPanel
            // 
            AvatarPanel.BackgroundImage = Properties.Resources.default_avatar;
            AvatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPanel.Location = new Point(2, 17);
            AvatarPanel.Name = "AvatarPanel";
            AvatarPanel.Size = new Size(250, 250);
            AvatarPanel.TabIndex = 4;
            // 
            // InformationFriendUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(UserNameLabel);
            Controls.Add(DeleteLabel);
            Controls.Add(AddFriendLabel);
            Controls.Add(AvatarPanel);
            Name = "InformationFriendUserControl";
            Size = new Size(255, 445);
            ResumeLayout(false);
        }

        #endregion

        private Label UserNameLabel;
        private Label DeleteLabel;
        private Label AddFriendLabel;
        private Panel AvatarPanel;
    }
}
