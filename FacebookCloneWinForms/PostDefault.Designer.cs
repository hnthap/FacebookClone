namespace FacebookCloneWinForms
{
    partial class PostDefault
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
            TopDockLabel = new Label();
            BotDockLabel = new Label();
            LeftDockLabel = new Label();
            RightDockLabel = new Label();
            UsernameLabel = new Label();
            TimeLabel = new Label();
            CaptionContentLabel = new Label();
            StatusPanel = new Panel();
            ImageContentPanel = new Panel();
            SeparateLineLabel = new Label();
            LikeCountLabel = new Label();
            LikeCountPanel = new Panel();
            ShareCountLabel = new Label();
            CommentCountLabel = new Label();
            LikePanel = new Panel();
            LikeClickLabel = new Label();
            LikeLabel = new Label();
            CommentLabel = new Label();
            CommentPanel = new Panel();
            CommentClickLabel = new Label();
            label3 = new Label();
            SharePanel = new Panel();
            ShareClickLabel = new Label();
            SepCapImgLabel = new Label();
            LikePanel.SuspendLayout();
            CommentPanel.SuspendLayout();
            SharePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AvatarPanel
            // 
            AvatarPanel.BackgroundImage = Properties.Resources.default_avatar;
            AvatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPanel.Location = new Point(16, 17);
            AvatarPanel.Name = "AvatarPanel";
            AvatarPanel.Size = new Size(50, 50);
            AvatarPanel.TabIndex = 0;
            // 
            // TopDockLabel
            // 
            TopDockLabel.Dock = DockStyle.Top;
            TopDockLabel.Location = new Point(0, 0);
            TopDockLabel.Name = "TopDockLabel";
            TopDockLabel.Size = new Size(750, 14);
            TopDockLabel.TabIndex = 1;
            // 
            // BotDockLabel
            // 
            BotDockLabel.Dock = DockStyle.Bottom;
            BotDockLabel.Location = new Point(0, 952);
            BotDockLabel.Name = "BotDockLabel";
            BotDockLabel.Size = new Size(750, 14);
            BotDockLabel.TabIndex = 2;
            // 
            // LeftDockLabel
            // 
            LeftDockLabel.Dock = DockStyle.Left;
            LeftDockLabel.Location = new Point(0, 14);
            LeftDockLabel.Name = "LeftDockLabel";
            LeftDockLabel.Size = new Size(10, 938);
            LeftDockLabel.TabIndex = 3;
            // 
            // RightDockLabel
            // 
            RightDockLabel.Dock = DockStyle.Right;
            RightDockLabel.Location = new Point(740, 14);
            RightDockLabel.Name = "RightDockLabel";
            RightDockLabel.Size = new Size(10, 938);
            RightDockLabel.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.ForeColor = SystemColors.Control;
            UsernameLabel.Location = new Point(72, 17);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(204, 28);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Default username";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = SystemColors.Control;
            TimeLabel.Location = new Point(72, 44);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(101, 23);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "x hours ago";
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
            CaptionContentLabel.TabIndex = 7;
            CaptionContentLabel.Text = "Caption goes here";
            CaptionContentLabel.Click += CaptionContentLabel_Click;
            // 
            // StatusPanel
            // 
            StatusPanel.BackgroundImage = Properties.Resources.public_icon;
            StatusPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StatusPanel.ForeColor = SystemColors.Control;
            StatusPanel.Location = new Point(179, 48);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(23, 23);
            StatusPanel.TabIndex = 8;
            // 
            // ImageContentPanel
            // 
            ImageContentPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ImageContentPanel.Location = new Point(16, 127);
            ImageContentPanel.Name = "ImageContentPanel";
            ImageContentPanel.Size = new Size(718, 710);
            ImageContentPanel.TabIndex = 9;
            // 
            // SeparateLineLabel
            // 
            SeparateLineLabel.BorderStyle = BorderStyle.Fixed3D;
            SeparateLineLabel.Location = new Point(0, 891);
            SeparateLineLabel.Name = "SeparateLineLabel";
            SeparateLineLabel.Size = new Size(750, 1);
            SeparateLineLabel.TabIndex = 10;
            SeparateLineLabel.Text = "label1";
            // 
            // LikeCountLabel
            // 
            LikeCountLabel.AutoSize = true;
            LikeCountLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LikeCountLabel.ForeColor = SystemColors.Control;
            LikeCountLabel.Location = new Point(57, 840);
            LikeCountLabel.Name = "LikeCountLabel";
            LikeCountLabel.Size = new Size(30, 36);
            LikeCountLabel.TabIndex = 11;
            LikeCountLabel.Text = "0";
            // 
            // LikeCountPanel
            // 
            LikeCountPanel.BackgroundImage = Properties.Resources.like_count_icon;
            LikeCountPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LikeCountPanel.Location = new Point(16, 841);
            LikeCountPanel.Name = "LikeCountPanel";
            LikeCountPanel.Size = new Size(35, 35);
            LikeCountPanel.TabIndex = 12;
            // 
            // ShareCountLabel
            // 
            ShareCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShareCountLabel.AutoSize = true;
            ShareCountLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShareCountLabel.ForeColor = SystemColors.Control;
            ShareCountLabel.Location = new Point(636, 848);
            ShareCountLabel.Name = "ShareCountLabel";
            ShareCountLabel.Size = new Size(99, 26);
            ShareCountLabel.TabIndex = 13;
            ShareCountLabel.Text = "0 share(s)";
            // 
            // CommentCountLabel
            // 
            CommentCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommentCountLabel.AutoSize = true;
            CommentCountLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CommentCountLabel.ForeColor = SystemColors.Control;
            CommentCountLabel.Location = new Point(495, 848);
            CommentCountLabel.Name = "CommentCountLabel";
            CommentCountLabel.Size = new Size(135, 26);
            CommentCountLabel.TabIndex = 14;
            CommentCountLabel.Text = "0 comment(s)";
            // 
            // LikePanel
            // 
            LikePanel.BackgroundImage = Properties.Resources.like_icon;
            LikePanel.BackgroundImageLayout = ImageLayout.Stretch;
            LikePanel.Controls.Add(LikeClickLabel);
            LikePanel.Location = new Point(72, 899);
            LikePanel.Name = "LikePanel";
            LikePanel.Size = new Size(40, 40);
            LikePanel.TabIndex = 15;
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
            // LikeLabel
            // 
            LikeLabel.AutoSize = true;
            LikeLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LikeLabel.ForeColor = SystemColors.Control;
            LikeLabel.Location = new Point(118, 906);
            LikeLabel.Name = "LikeLabel";
            LikeLabel.Size = new Size(58, 28);
            LikeLabel.TabIndex = 16;
            LikeLabel.Text = "Like";
            // 
            // CommentLabel
            // 
            CommentLabel.AutoSize = true;
            CommentLabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CommentLabel.ForeColor = SystemColors.Control;
            CommentLabel.Location = new Point(358, 906);
            CommentLabel.Name = "CommentLabel";
            CommentLabel.Size = new Size(115, 28);
            CommentLabel.TabIndex = 18;
            CommentLabel.Text = "Comment";
            // 
            // CommentPanel
            // 
            CommentPanel.BackgroundImage = Properties.Resources.comment_icon;
            CommentPanel.BackgroundImageLayout = ImageLayout.Stretch;
            CommentPanel.Controls.Add(CommentClickLabel);
            CommentPanel.Location = new Point(312, 899);
            CommentPanel.Name = "CommentPanel";
            CommentPanel.Size = new Size(40, 40);
            CommentPanel.TabIndex = 17;
            // 
            // CommentClickLabel
            // 
            CommentClickLabel.BackColor = Color.Transparent;
            CommentClickLabel.Location = new Point(0, 0);
            CommentClickLabel.Name = "CommentClickLabel";
            CommentClickLabel.Size = new Size(161, 40);
            CommentClickLabel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(621, 906);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 20;
            label3.Text = "Share";
            // 
            // SharePanel
            // 
            SharePanel.BackgroundImage = Properties.Resources.share_icon;
            SharePanel.BackgroundImageLayout = ImageLayout.Stretch;
            SharePanel.Controls.Add(ShareClickLabel);
            SharePanel.Location = new Point(575, 899);
            SharePanel.Name = "SharePanel";
            SharePanel.Size = new Size(40, 40);
            SharePanel.TabIndex = 19;
            // 
            // ShareClickLabel
            // 
            ShareClickLabel.BackColor = Color.Transparent;
            ShareClickLabel.Location = new Point(0, 0);
            ShareClickLabel.Name = "ShareClickLabel";
            ShareClickLabel.Size = new Size(119, 40);
            ShareClickLabel.TabIndex = 0;
            // 
            // SepCapImgLabel
            // 
            SepCapImgLabel.Location = new Point(0, 110);
            SepCapImgLabel.Name = "SepCapImgLabel";
            SepCapImgLabel.Size = new Size(750, 14);
            SepCapImgLabel.TabIndex = 21;
            // 
            // PostDefault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
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
            Controls.Add(ImageContentPanel);
            Controls.Add(StatusPanel);
            Controls.Add(CaptionContentLabel);
            Controls.Add(TimeLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(RightDockLabel);
            Controls.Add(LeftDockLabel);
            Controls.Add(BotDockLabel);
            Controls.Add(TopDockLabel);
            Controls.Add(AvatarPanel);
            Name = "PostDefault";
            Size = new Size(750, 966);
            LikePanel.ResumeLayout(false);
            CommentPanel.ResumeLayout(false);
            SharePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AvatarPanel;
        private Label TopDockLabel;
        private Label BotDockLabel;
        private Label LeftDockLabel;
        private Label RightDockLabel;
        private Label UsernameLabel;
        private Label TimeLabel;
        private Label CaptionContentLabel;
        private Panel StatusPanel;
        private Panel ImageContentPanel;
        private Label SeparateLineLabel;
        private Label LikeCountLabel;
        private Panel LikeCountPanel;
        private Label ShareCountLabel;
        private Label CommentCountLabel;
        private Panel LikePanel;
        private Label LikeClickLabel;
        private Label LikeLabel;
        private Label CommentLabel;
        private Panel CommentPanel;
        private Label CommentClickLabel;
        private Label label3;
        private Panel SharePanel;
        private Label ShareClickLabel;
        private Label SepCapImgLabel;
    }
}
