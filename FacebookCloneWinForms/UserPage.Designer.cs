namespace FacebookCloneWinForms
{
    partial class UserPage
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
            CoverPhotoPanel = new Panel();
            AvatarPanel = new Panel();
            NameLabel = new Label();
            FriendsNumberLabel = new Label();
            FollowNumberLabel = new Label();
            CreateStoryLabel = new Label();
            EditInformationLabel = new Label();
            GeneralPanel = new Panel();
            ChosenReelLabel = new Label();
            ChosenVideoLabel = new Label();
            ChosenImageLabel = new Label();
            ChosenFriendLabel = new Label();
            ChosenIntroductionLabel = new Label();
            ChosenPostLabel = new Label();
            ReelLabel = new Label();
            ImageLabel = new Label();
            FriendLabel = new Label();
            VideoLabel = new Label();
            IntroductionLabel = new Label();
            PostLabel = new Label();
            SeparateLine = new Label();
            ShowPanel = new Panel();
            GeneralPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CoverPhotoPanel
            // 
            CoverPhotoPanel.BackColor = SystemColors.Control;
            CoverPhotoPanel.BackgroundImage = Properties.Resources.default_cover;
            CoverPhotoPanel.Location = new Point(231, 1);
            CoverPhotoPanel.Name = "CoverPhotoPanel";
            CoverPhotoPanel.Size = new Size(1370, 510);
            CoverPhotoPanel.TabIndex = 0;
            // 
            // AvatarPanel
            // 
            AvatarPanel.BackColor = SystemColors.Control;
            AvatarPanel.BackgroundImage = Properties.Resources.default_avatar;
            AvatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPanel.Location = new Point(231, 517);
            AvatarPanel.Name = "AvatarPanel";
            AvatarPanel.Size = new Size(218, 218);
            AvatarPanel.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.FromArgb(39, 39, 39);
            NameLabel.Font = new Font("Trebuchet MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = SystemColors.Control;
            NameLabel.Location = new Point(455, 573);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(331, 55);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "UserNameHere";
            // 
            // FriendsNumberLabel
            // 
            FriendsNumberLabel.AutoSize = true;
            FriendsNumberLabel.BackColor = Color.FromArgb(39, 39, 39);
            FriendsNumberLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FriendsNumberLabel.ForeColor = SystemColors.Control;
            FriendsNumberLabel.Location = new Point(455, 628);
            FriendsNumberLabel.Name = "FriendsNumberLabel";
            FriendsNumberLabel.Size = new Size(123, 36);
            FriendsNumberLabel.TabIndex = 3;
            FriendsNumberLabel.Text = "x friends";
            // 
            // FollowNumberLabel
            // 
            FollowNumberLabel.AutoSize = true;
            FollowNumberLabel.BackColor = Color.FromArgb(39, 39, 39);
            FollowNumberLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FollowNumberLabel.ForeColor = SystemColors.Control;
            FollowNumberLabel.Location = new Point(584, 628);
            FollowNumberLabel.Name = "FollowNumberLabel";
            FollowNumberLabel.Size = new Size(162, 36);
            FollowNumberLabel.TabIndex = 4;
            FollowNumberLabel.Text = "y followings";
            // 
            // CreateStoryLabel
            // 
            CreateStoryLabel.BackColor = Color.RoyalBlue;
            CreateStoryLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateStoryLabel.ForeColor = SystemColors.Control;
            CreateStoryLabel.Location = new Point(1037, 573);
            CreateStoryLabel.Name = "CreateStoryLabel";
            CreateStoryLabel.Size = new Size(209, 55);
            CreateStoryLabel.TabIndex = 5;
            CreateStoryLabel.Text = "+ Create story";
            CreateStoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditInformationLabel
            // 
            EditInformationLabel.BackColor = Color.DimGray;
            EditInformationLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EditInformationLabel.ForeColor = SystemColors.Control;
            EditInformationLabel.Location = new Point(1252, 573);
            EditInformationLabel.Name = "EditInformationLabel";
            EditInformationLabel.Size = new Size(349, 55);
            EditInformationLabel.TabIndex = 6;
            EditInformationLabel.Text = "Edit personal information";
            EditInformationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GeneralPanel
            // 
            GeneralPanel.BackColor = Color.FromArgb(39, 39, 39);
            GeneralPanel.Controls.Add(ChosenReelLabel);
            GeneralPanel.Controls.Add(ChosenVideoLabel);
            GeneralPanel.Controls.Add(ChosenImageLabel);
            GeneralPanel.Controls.Add(ChosenFriendLabel);
            GeneralPanel.Controls.Add(ChosenIntroductionLabel);
            GeneralPanel.Controls.Add(ChosenPostLabel);
            GeneralPanel.Controls.Add(ReelLabel);
            GeneralPanel.Controls.Add(ImageLabel);
            GeneralPanel.Controls.Add(FriendLabel);
            GeneralPanel.Controls.Add(VideoLabel);
            GeneralPanel.Controls.Add(IntroductionLabel);
            GeneralPanel.Controls.Add(PostLabel);
            GeneralPanel.Controls.Add(SeparateLine);
            GeneralPanel.Location = new Point(0, 0);
            GeneralPanel.Name = "GeneralPanel";
            GeneralPanel.Size = new Size(1908, 836);
            GeneralPanel.TabIndex = 7;
            // 
            // ChosenReelLabel
            // 
            ChosenReelLabel.BackColor = Color.FromArgb(39, 39, 39);
            ChosenReelLabel.Location = new Point(909, 820);
            ChosenReelLabel.Name = "ChosenReelLabel";
            ChosenReelLabel.Size = new Size(101, 4);
            ChosenReelLabel.TabIndex = 10;
            // 
            // ChosenVideoLabel
            // 
            ChosenVideoLabel.BackColor = Color.FromArgb(39, 39, 39);
            ChosenVideoLabel.Location = new Point(792, 820);
            ChosenVideoLabel.Name = "ChosenVideoLabel";
            ChosenVideoLabel.Size = new Size(111, 4);
            ChosenVideoLabel.TabIndex = 10;
            // 
            // ChosenImageLabel
            // 
            ChosenImageLabel.BackColor = Color.FromArgb(39, 39, 39);
            ChosenImageLabel.Location = new Point(667, 820);
            ChosenImageLabel.Name = "ChosenImageLabel";
            ChosenImageLabel.Size = new Size(119, 4);
            ChosenImageLabel.TabIndex = 10;
            // 
            // ChosenFriendLabel
            // 
            ChosenFriendLabel.BackColor = Color.FromArgb(39, 39, 39);
            ChosenFriendLabel.Location = new Point(538, 820);
            ChosenFriendLabel.Name = "ChosenFriendLabel";
            ChosenFriendLabel.Size = new Size(123, 4);
            ChosenFriendLabel.TabIndex = 10;
            // 
            // ChosenIntroductionLabel
            // 
            ChosenIntroductionLabel.BackColor = Color.FromArgb(39, 39, 39);
            ChosenIntroductionLabel.Location = new Point(338, 820);
            ChosenIntroductionLabel.Name = "ChosenIntroductionLabel";
            ChosenIntroductionLabel.Size = new Size(194, 4);
            ChosenIntroductionLabel.TabIndex = 10;
            // 
            // ChosenPostLabel
            // 
            ChosenPostLabel.BackColor = SystemColors.Control;
            ChosenPostLabel.Location = new Point(231, 820);
            ChosenPostLabel.Name = "ChosenPostLabel";
            ChosenPostLabel.Size = new Size(101, 4);
            ChosenPostLabel.TabIndex = 9;
            // 
            // ReelLabel
            // 
            ReelLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ReelLabel.ForeColor = SystemColors.Control;
            ReelLabel.ImageAlign = ContentAlignment.MiddleRight;
            ReelLabel.Location = new Point(909, 775);
            ReelLabel.Name = "ReelLabel";
            ReelLabel.Size = new Size(101, 45);
            ReelLabel.TabIndex = 8;
            ReelLabel.Text = "Reels";
            ReelLabel.TextAlign = ContentAlignment.MiddleCenter;
            ReelLabel.Click += ReelLabel_Click;
            // 
            // ImageLabel
            // 
            ImageLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ImageLabel.ForeColor = SystemColors.Control;
            ImageLabel.ImageAlign = ContentAlignment.MiddleRight;
            ImageLabel.Location = new Point(667, 775);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(119, 45);
            ImageLabel.TabIndex = 8;
            ImageLabel.Text = "Images";
            ImageLabel.TextAlign = ContentAlignment.MiddleCenter;
            ImageLabel.Click += ImageLabel_Click;
            // 
            // FriendLabel
            // 
            FriendLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FriendLabel.ForeColor = SystemColors.Control;
            FriendLabel.ImageAlign = ContentAlignment.MiddleRight;
            FriendLabel.Location = new Point(538, 775);
            FriendLabel.Name = "FriendLabel";
            FriendLabel.Size = new Size(123, 45);
            FriendLabel.TabIndex = 8;
            FriendLabel.Text = "Friends";
            FriendLabel.TextAlign = ContentAlignment.MiddleCenter;
            FriendLabel.Click += FriendLabel_Click;
            // 
            // VideoLabel
            // 
            VideoLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            VideoLabel.ForeColor = SystemColors.Control;
            VideoLabel.ImageAlign = ContentAlignment.MiddleRight;
            VideoLabel.Location = new Point(792, 775);
            VideoLabel.Name = "VideoLabel";
            VideoLabel.Size = new Size(111, 45);
            VideoLabel.TabIndex = 8;
            VideoLabel.Text = "Videos";
            VideoLabel.TextAlign = ContentAlignment.MiddleCenter;
            VideoLabel.Click += VideoLabel_Click;
            // 
            // IntroductionLabel
            // 
            IntroductionLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            IntroductionLabel.ForeColor = SystemColors.Control;
            IntroductionLabel.ImageAlign = ContentAlignment.MiddleRight;
            IntroductionLabel.Location = new Point(338, 775);
            IntroductionLabel.Name = "IntroductionLabel";
            IntroductionLabel.Size = new Size(194, 45);
            IntroductionLabel.TabIndex = 8;
            IntroductionLabel.Text = "Introduction";
            IntroductionLabel.TextAlign = ContentAlignment.MiddleCenter;
            IntroductionLabel.Click += IntroductionLabel_Click;
            // 
            // PostLabel
            // 
            PostLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PostLabel.ForeColor = SystemColors.Control;
            PostLabel.ImageAlign = ContentAlignment.MiddleRight;
            PostLabel.Location = new Point(231, 775);
            PostLabel.Name = "PostLabel";
            PostLabel.Size = new Size(101, 45);
            PostLabel.TabIndex = 1;
            PostLabel.Text = "Posts";
            PostLabel.TextAlign = ContentAlignment.MiddleCenter;
            PostLabel.Click += PostLabel_Click;
            // 
            // SeparateLine
            // 
            SeparateLine.BorderStyle = BorderStyle.Fixed3D;
            SeparateLine.Location = new Point(231, 756);
            SeparateLine.Name = "SeparateLine";
            SeparateLine.Size = new Size(1374, 1);
            SeparateLine.TabIndex = 0;
            // 
            // ShowPanel
            // 
            ShowPanel.AutoScroll = true;
            ShowPanel.Location = new Point(231, 842);
            ShowPanel.Name = "ShowPanel";
            ShowPanel.Size = new Size(1370, 1000);
            ShowPanel.TabIndex = 8;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(1902, 1055);
            Controls.Add(ShowPanel);
            Controls.Add(EditInformationLabel);
            Controls.Add(CoverPhotoPanel);
            Controls.Add(CreateStoryLabel);
            Controls.Add(FollowNumberLabel);
            Controls.Add(AvatarPanel);
            Controls.Add(FriendsNumberLabel);
            Controls.Add(NameLabel);
            Controls.Add(GeneralPanel);
            Name = "UserPage";
            Text = "UserPage";
            WindowState = FormWindowState.Maximized;
            GeneralPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CoverPhotoPanel;
        private Panel AvatarPanel;
        private Label NameLabel;
        private Label FriendsNumberLabel;
        private Label FollowNumberLabel;
        private Label CreateStoryLabel;
        private Label EditInformationLabel;
        private Panel GeneralPanel;
        private Label SeparateLine;
        private Label ReelLabel;
        private Label ImageLabel;
        private Label FriendLabel;
        private Label VideoLabel;
        private Label IntroductionLabel;
        private Label PostLabel;
        private Label ChosenFriendLabel;
        private Label ChosenIntroductionLabel;
        private Label ChosenPostLabel;
        private Label ChosenVideoLabel;
        private Label ChosenImageLabel;
        private Label ChosenReelLabel;
        private Panel ShowPanel;
    }
}