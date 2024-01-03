namespace FacebookCloneWinForms
{
    partial class UserFriendForm
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
            FriendContentPanel = new Panel();
            FriendLabel = new Label();
            SuspendLayout();
            // 
            // FriendContentPanel
            // 
            FriendContentPanel.AutoScroll = true;
            FriendContentPanel.Dock = DockStyle.Bottom;
            FriendContentPanel.Location = new Point(0, 52);
            FriendContentPanel.Name = "FriendContentPanel";
            FriendContentPanel.Size = new Size(1331, 407);
            FriendContentPanel.TabIndex = 0;
            FriendContentPanel.Paint += FriendContentPanel_Paint;
            // 
            // FriendLabel
            // 
            FriendLabel.AutoSize = true;
            FriendLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            FriendLabel.ForeColor = SystemColors.Control;
            FriendLabel.Location = new Point(12, 9);
            FriendLabel.Name = "FriendLabel";
            FriendLabel.Size = new Size(124, 43);
            FriendLabel.TabIndex = 1;
            FriendLabel.Text = "Friend";
            // 
            // UserFriendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1352, 453);
            Controls.Add(FriendLabel);
            Controls.Add(FriendContentPanel);
            Name = "UserFriendForm";
            Text = "UserFriendForm";
            Load += UserFriendForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel FriendContentPanel;
        private Label FriendLabel;
    }
}