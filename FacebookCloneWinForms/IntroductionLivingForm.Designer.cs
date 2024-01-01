namespace FacebookCloneWinForms
{
    partial class IntroductionLivingForm
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
            LivingLabel = new Label();
            LivingContentPanel = new Panel();
            LivingIcon = new Panel();
            SuspendLayout();
            // 
            // LivingLabel
            // 
            LivingLabel.AutoSize = true;
            LivingLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LivingLabel.ForeColor = SystemColors.Control;
            LivingLabel.Location = new Point(61, 9);
            LivingLabel.Name = "LivingLabel";
            LivingLabel.Size = new Size(114, 43);
            LivingLabel.TabIndex = 0;
            LivingLabel.Text = "Living";
            // 
            // LivingContentPanel
            // 
            LivingContentPanel.Location = new Point(12, 55);
            LivingContentPanel.Name = "LivingContentPanel";
            LivingContentPanel.Size = new Size(893, 863);
            LivingContentPanel.TabIndex = 1;
            // 
            // LivingIcon
            // 
            LivingIcon.BackgroundImage = Properties.Resources.location_icon;
            LivingIcon.BackgroundImageLayout = ImageLayout.Stretch;
            LivingIcon.Location = new Point(12, 9);
            LivingIcon.Name = "LivingIcon";
            LivingIcon.Size = new Size(43, 43);
            LivingIcon.TabIndex = 0;
            // 
            // IntroductionLivingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 930);
            Controls.Add(LivingIcon);
            Controls.Add(LivingContentPanel);
            Controls.Add(LivingLabel);
            Name = "IntroductionLivingForm";
            Text = "IntroductionLivingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LivingLabel;
        private Panel LivingContentPanel;
        private Panel LivingIcon;
    }
}