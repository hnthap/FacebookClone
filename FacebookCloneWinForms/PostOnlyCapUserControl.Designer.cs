namespace FacebookCloneWinForms
{
    partial class PostOnlyCapUserControl
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
            SepCapImgLabel = new Label();
            label3 = new Label();
            SharePanel = new Panel();
            ShareClickLabel = new Label();
            CommentClickLabel = new Label();
            CommentLabel = new Label();
            CommentPanel = new Panel();
            LikeLabel = new Label();
            LikeClickLabel = new Label();
            LikePanel = new Panel();
            CommentCountLabel = new Label();
            ShareCountLabel = new Label();
            LikeCountPanel = new Panel();
            LikeCountLabel = new Label();
            SeparateLineLabel = new Label();
            StatusPanel = new Panel();
            CaptionContentLabel = new Label();
            TimeLabel = new Label();
            UsernameLabel = new Label();
            RightDockLabel = new Label();
            LeftDockLabel = new Label();
            BotDockLabel = new Label();
            TopDockLabel = new Label();
            AvatarPanel = new Panel();
            SharePanel.SuspendLayout();
            CommentPanel.SuspendLayout();
            LikePanel.SuspendLayout();
            SuspendLayout();
            // 
            // SepCapImgLabel
            // 
            SepCapImgLabel.Location = new Point(3, 110);
            SepCapImgLabel.Name = "SepCapImgLabel";
            SepCapImgLabel.Size = new Size(750, 10);
            SepCapImgLabel.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(622, 200);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 42;
            label3.Text = "Share";
            // 
            // SharePanel
            // 
            SharePanel.BackgroundImage = Properties.Resources.share_icon;
            SharePanel.BackgroundImageLayout = ImageLayout.Stretch;
            SharePanel.Controls.Add(ShareClickLabel);
            SharePanel.Location = new Point(576, 193);
            SharePanel.Name = "SharePanel";
            SharePanel.Size = new Size(40, 40);
            SharePanel.TabIndex = 41;
            // 
            // ShareClickLabel
            // 
            ShareClickLabel.BackColor = Color.Transparent;
            ShareClickLabel.Location = new Point(0, 0);
            ShareClickLabel.Name = "ShareClickLabel";
            ShareClickLabel.Size = new Size(119, 40);
            ShareClickLabel.TabIndex = 0;
            // 
            // CommentClickLabel
            // 
            CommentClickLabel.BackColor = Color.Transparent;
            CommentClickLabel.Location = new Point(0, 0);
            CommentClickLabel.Name = "CommentClickLabel";
            CommentClickLabel.Size = new Size(161, 40);
            CommentClickLabel.TabIndex = 0;
            // 
            // CommentLabel
            // 
            CommentLabel.AutoSize = true;
            CommentLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CommentLabel.ForeColor = SystemColors.Control;
            CommentLabel.Location = new Point(359, 200);
            CommentLabel.Name = "CommentLabel";
            CommentLabel.Size = new Size(115, 28);
            CommentLabel.TabIndex = 40;
            CommentLabel.Text = "Comment";
            // 
            // CommentPanel
            // 
            CommentPanel.BackgroundImage = Properties.Resources.comment_icon;
            CommentPanel.BackgroundImageLayout = ImageLayout.Stretch;
            CommentPanel.Controls.Add(CommentClickLabel);
            CommentPanel.Location = new Point(313, 193);
            CommentPanel.Name = "CommentPanel";
            CommentPanel.Size = new Size(40, 40);
            CommentPanel.TabIndex = 39;
            // 
            // LikeLabel
            // 
            LikeLabel.AutoSize = true;
            LikeLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LikeLabel.ForeColor = SystemColors.Control;
            LikeLabel.Location = new Point(119, 200);
            LikeLabel.Name = "LikeLabel";
            LikeLabel.Size = new Size(58, 28);
            LikeLabel.TabIndex = 38;
            LikeLabel.Text = "Like";
            // 
            // LikeClickLabel
            // 
            LikeClickLabel.BackColor = Color.Transparent;
            LikeClickLabel.Location = new Point(0, 0);
            LikeClickLabel.Name = "LikeClickLabel";
            LikeClickLabel.Size = new Size(104, 40);
            LikeClickLabel.TabIndex = 0;
            LikeClickLabel.Click += LikeClickLabel_Click;
            // 
            // LikePanel
            // 
            LikePanel.BackgroundImage = Properties.Resources.like_icon;
            LikePanel.BackgroundImageLayout = ImageLayout.Stretch;
            LikePanel.Controls.Add(LikeClickLabel);
            LikePanel.Location = new Point(73, 193);
            LikePanel.Name = "LikePanel";
            LikePanel.Size = new Size(40, 40);
            LikePanel.TabIndex = 37;
            // 
            // CommentCountLabel
            // 
            CommentCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommentCountLabel.AutoSize = true;
            CommentCountLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CommentCountLabel.ForeColor = SystemColors.Control;
            CommentCountLabel.Location = new Point(495, 142);
            CommentCountLabel.Name = "CommentCountLabel";
            CommentCountLabel.Size = new Size(135, 26);
            CommentCountLabel.TabIndex = 36;
            CommentCountLabel.Text = "0 comment(s)";
            // 
            // ShareCountLabel
            // 
            ShareCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShareCountLabel.AutoSize = true;
            ShareCountLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShareCountLabel.ForeColor = SystemColors.Control;
            ShareCountLabel.Location = new Point(636, 142);
            ShareCountLabel.Name = "ShareCountLabel";
            ShareCountLabel.Size = new Size(99, 26);
            ShareCountLabel.TabIndex = 35;
            ShareCountLabel.Text = "0 share(s)";
            // 
            // LikeCountPanel
            // 
            LikeCountPanel.BackgroundImage = Properties.Resources.like_count_icon;
            LikeCountPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LikeCountPanel.Location = new Point(17, 135);
            LikeCountPanel.Name = "LikeCountPanel";
            LikeCountPanel.Size = new Size(35, 35);
            LikeCountPanel.TabIndex = 34;
            // 
            // LikeCountLabel
            // 
            LikeCountLabel.AutoSize = true;
            LikeCountLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LikeCountLabel.ForeColor = SystemColors.Control;
            LikeCountLabel.Location = new Point(58, 134);
            LikeCountLabel.Name = "LikeCountLabel";
            LikeCountLabel.Size = new Size(30, 36);
            LikeCountLabel.TabIndex = 33;
            LikeCountLabel.Text = "0";
            // 
            // SeparateLineLabel
            // 
            SeparateLineLabel.BorderStyle = BorderStyle.Fixed3D;
            SeparateLineLabel.Location = new Point(1, 185);
            SeparateLineLabel.Name = "SeparateLineLabel";
            SeparateLineLabel.Size = new Size(750, 1);
            SeparateLineLabel.TabIndex = 32;
            SeparateLineLabel.Text = "label1";
            // 
            // StatusPanel
            // 
            StatusPanel.BackgroundImage = Properties.Resources.public_icon;
            StatusPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StatusPanel.ForeColor = SystemColors.Control;
            StatusPanel.Location = new Point(179, 48);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(23, 23);
            StatusPanel.TabIndex = 30;
            // 
            // CaptionContentLabel
            // 
            CaptionContentLabel.AutoSize = true;
            CaptionContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CaptionContentLabel.ForeColor = SystemColors.Control;
            CaptionContentLabel.Location = new Point(16, 74);
            CaptionContentLabel.MaximumSize = new Size(718, 0);
            CaptionContentLabel.Name = "CaptionContentLabel";
            CaptionContentLabel.Size = new Size(239, 36);
            CaptionContentLabel.TabIndex = 29;
            CaptionContentLabel.Text = "Caption goes here";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = SystemColors.Control;
            TimeLabel.Location = new Point(72, 44);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(101, 23);
            TimeLabel.TabIndex = 28;
            TimeLabel.Text = "x hours ago";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.ForeColor = SystemColors.Control;
            UsernameLabel.Location = new Point(72, 17);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(204, 28);
            UsernameLabel.TabIndex = 27;
            UsernameLabel.Text = "Default username";
            // 
            // RightDockLabel
            // 
            RightDockLabel.Dock = DockStyle.Right;
            RightDockLabel.Location = new Point(740, 14);
            RightDockLabel.Name = "RightDockLabel";
            RightDockLabel.Size = new Size(10, 217);
            RightDockLabel.TabIndex = 26;
            // 
            // LeftDockLabel
            // 
            LeftDockLabel.Dock = DockStyle.Left;
            LeftDockLabel.Location = new Point(0, 14);
            LeftDockLabel.Name = "LeftDockLabel";
            LeftDockLabel.Size = new Size(10, 217);
            LeftDockLabel.TabIndex = 25;
            // 
            // BotDockLabel
            // 
            BotDockLabel.Dock = DockStyle.Bottom;
            BotDockLabel.Location = new Point(0, 231);
            BotDockLabel.Name = "BotDockLabel";
            BotDockLabel.Size = new Size(750, 14);
            BotDockLabel.TabIndex = 24;
            // 
            // TopDockLabel
            // 
            TopDockLabel.Dock = DockStyle.Top;
            TopDockLabel.Location = new Point(0, 0);
            TopDockLabel.Name = "TopDockLabel";
            TopDockLabel.Size = new Size(750, 14);
            TopDockLabel.TabIndex = 23;
            // 
            // AvatarPanel
            // 
            AvatarPanel.BackgroundImage = Properties.Resources.default_avatar;
            AvatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPanel.Location = new Point(16, 17);
            AvatarPanel.Name = "AvatarPanel";
            AvatarPanel.Size = new Size(50, 50);
            AvatarPanel.TabIndex = 22;
            // 
            // PostOnlyCapUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            Controls.Add(SepCapImgLabel);
            Controls.Add(label3);
            Controls.Add(SharePanel);
            Controls.Add(CommentLabel);
            Controls.Add(CommentPanel);
            Controls.Add(LikeLabel);
            Controls.Add(LikePanel);
            Controls.Add(CommentCountLabel);
            Controls.Add(ShareCountLabel);
            Controls.Add(LikeCountPanel);
            Controls.Add(LikeCountLabel);
            Controls.Add(SeparateLineLabel);
            Controls.Add(StatusPanel);
            Controls.Add(CaptionContentLabel);
            Controls.Add(TimeLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(RightDockLabel);
            Controls.Add(LeftDockLabel);
            Controls.Add(BotDockLabel);
            Controls.Add(TopDockLabel);
            Controls.Add(AvatarPanel);
            Name = "PostOnlyCapUserControl";
            Size = new Size(750, 245);
            SharePanel.ResumeLayout(false);
            CommentPanel.ResumeLayout(false);
            LikePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SepCapImgLabel;
        private Label label3;
        private Panel SharePanel;
        private Label ShareClickLabel;
        private Label CommentClickLabel;
        private Label CommentLabel;
        private Panel CommentPanel;
        private Label LikeLabel;
        private Label LikeClickLabel;
        private Panel LikePanel;
        private Label CommentCountLabel;
        private Label ShareCountLabel;
        private Panel LikeCountPanel;
        private Label LikeCountLabel;
        private Label SeparateLineLabel;
        private Panel StatusPanel;
        private Label CaptionContentLabel;
        private Label TimeLabel;
        private Label UsernameLabel;
        private Label RightDockLabel;
        private Label LeftDockLabel;
        private Label BotDockLabel;
        private Label TopDockLabel;
        private Panel AvatarPanel;
    }
}
