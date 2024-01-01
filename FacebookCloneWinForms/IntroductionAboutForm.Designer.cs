namespace FacebookCloneWinForms
{
    partial class IntroductionAboutForm
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
            AboutLabel = new Label();
            QuotesLabel = new Label();
            OtherNameLabel = new Label();
            OtherNameContentPanel = new Panel();
            FavoriteQuotesLabel = new Label();
            FavoriteQuotesContentLabel = new Label();
            SuspendLayout();
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            AboutLabel.ForeColor = SystemColors.Control;
            AboutLabel.Location = new Point(12, 9);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(113, 43);
            AboutLabel.TabIndex = 0;
            AboutLabel.Text = "About";
            AboutLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuotesLabel
            // 
            QuotesLabel.AutoSize = true;
            QuotesLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuotesLabel.ForeColor = SystemColors.Control;
            QuotesLabel.Location = new Point(12, 63);
            QuotesLabel.Name = "QuotesLabel";
            QuotesLabel.Size = new Size(444, 36);
            QuotesLabel.TabIndex = 1;
            QuotesLabel.Text = "User quotes will be displayed here";
            QuotesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OtherNameLabel
            // 
            OtherNameLabel.AutoSize = true;
            OtherNameLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            OtherNameLabel.ForeColor = SystemColors.Control;
            OtherNameLabel.Location = new Point(12, 167);
            OtherNameLabel.Name = "OtherNameLabel";
            OtherNameLabel.Size = new Size(208, 43);
            OtherNameLabel.TabIndex = 2;
            OtherNameLabel.Text = "Other name";
            OtherNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OtherNameContentPanel
            // 
            OtherNameContentPanel.AutoScroll = true;
            OtherNameContentPanel.Location = new Point(12, 213);
            OtherNameContentPanel.Name = "OtherNameContentPanel";
            OtherNameContentPanel.Size = new Size(893, 229);
            OtherNameContentPanel.TabIndex = 3;
            OtherNameContentPanel.Paint += OtherNameContentPanel_Paint;
            // 
            // FavoriteQuotesLabel
            // 
            FavoriteQuotesLabel.AutoSize = true;
            FavoriteQuotesLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            FavoriteQuotesLabel.ForeColor = SystemColors.Control;
            FavoriteQuotesLabel.Location = new Point(12, 493);
            FavoriteQuotesLabel.Name = "FavoriteQuotesLabel";
            FavoriteQuotesLabel.Size = new Size(267, 43);
            FavoriteQuotesLabel.TabIndex = 4;
            FavoriteQuotesLabel.Text = "Favorite quotes";
            FavoriteQuotesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FavoriteQuotesContentLabel
            // 
            FavoriteQuotesContentLabel.AutoSize = true;
            FavoriteQuotesContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteQuotesContentLabel.ForeColor = SystemColors.Control;
            FavoriteQuotesContentLabel.Location = new Point(12, 553);
            FavoriteQuotesContentLabel.Name = "FavoriteQuotesContentLabel";
            FavoriteQuotesContentLabel.Size = new Size(551, 36);
            FavoriteQuotesContentLabel.TabIndex = 5;
            FavoriteQuotesContentLabel.Text = "User favorite quotes will be displayed here";
            FavoriteQuotesContentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IntroductionAboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 906);
            Controls.Add(FavoriteQuotesContentLabel);
            Controls.Add(FavoriteQuotesLabel);
            Controls.Add(OtherNameContentPanel);
            Controls.Add(OtherNameLabel);
            Controls.Add(QuotesLabel);
            Controls.Add(AboutLabel);
            Name = "IntroductionAboutForm";
            Text = "IntroductionAboutForm";
            Load += IntroductionAboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AboutLabel;
        private Label QuotesLabel;
        private Label OtherNameLabel;
        private Panel OtherNameContentPanel;
        private Label FavoriteQuotesLabel;
        private Label FavoriteQuotesContentLabel;
    }
}