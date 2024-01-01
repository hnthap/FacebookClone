namespace FacebookCloneWinForms
{
    partial class IntroductionWorkAndStudyForm
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
            WorkLabel = new Label();
            WorkContentPanel = new Panel();
            StudyContentPanel = new Panel();
            StudyLabel = new Label();
            WorkIconPanel = new Panel();
            StudyIconPanel = new Panel();
            SuspendLayout();
            // 
            // WorkLabel
            // 
            WorkLabel.AutoSize = true;
            WorkLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            WorkLabel.ForeColor = SystemColors.Control;
            WorkLabel.Location = new Point(61, 9);
            WorkLabel.Name = "WorkLabel";
            WorkLabel.Size = new Size(101, 43);
            WorkLabel.TabIndex = 0;
            WorkLabel.Text = "Work";
            // 
            // WorkContentPanel
            // 
            WorkContentPanel.AutoScroll = true;
            WorkContentPanel.Location = new Point(12, 55);
            WorkContentPanel.Name = "WorkContentPanel";
            WorkContentPanel.Size = new Size(896, 260);
            WorkContentPanel.TabIndex = 1;
            WorkContentPanel.Paint += WorkContentPanel_Paint;
            // 
            // StudyContentPanel
            // 
            StudyContentPanel.AutoScroll = true;
            StudyContentPanel.Location = new Point(12, 404);
            StudyContentPanel.Name = "StudyContentPanel";
            StudyContentPanel.Size = new Size(896, 260);
            StudyContentPanel.TabIndex = 3;
            // 
            // StudyLabel
            // 
            StudyLabel.AutoSize = true;
            StudyLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            StudyLabel.ForeColor = SystemColors.Control;
            StudyLabel.Location = new Point(61, 358);
            StudyLabel.Name = "StudyLabel";
            StudyLabel.Size = new Size(107, 43);
            StudyLabel.TabIndex = 2;
            StudyLabel.Text = "Study";
            // 
            // WorkIconPanel
            // 
            WorkIconPanel.BackgroundImage = Properties.Resources.work_icon;
            WorkIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            WorkIconPanel.Location = new Point(12, 6);
            WorkIconPanel.Name = "WorkIconPanel";
            WorkIconPanel.Size = new Size(43, 43);
            WorkIconPanel.TabIndex = 0;
            // 
            // StudyIconPanel
            // 
            StudyIconPanel.BackgroundImage = Properties.Resources.study_icon;
            StudyIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StudyIconPanel.Location = new Point(12, 355);
            StudyIconPanel.Name = "StudyIconPanel";
            StudyIconPanel.Size = new Size(43, 43);
            StudyIconPanel.TabIndex = 4;
            // 
            // IntroductionWorkAndStudyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 679);
            Controls.Add(StudyIconPanel);
            Controls.Add(WorkIconPanel);
            Controls.Add(StudyContentPanel);
            Controls.Add(StudyLabel);
            Controls.Add(WorkContentPanel);
            Controls.Add(WorkLabel);
            Name = "IntroductionWorkAndStudyForm";
            Text = "IntroductionWorkAndStudyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WorkLabel;
        private Panel WorkContentPanel;
        private Panel StudyContentPanel;
        private Label StudyLabel;
        private Panel WorkIconPanel;
        private Panel StudyIconPanel;
    }
}