namespace FacebookCloneWinForms
{
    partial class IntroductionOverviewForm
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
            StudyIconPanel = new Panel();
            StudyIconLabel = new Label();
            label1 = new Label();
            WorkIconPanel = new Panel();
            label2 = new Label();
            LivingIconPanel = new Panel();
            label3 = new Label();
            HomeIconPanel = new Panel();
            label4 = new Label();
            RelationshipIconPanel = new Panel();
            SuspendLayout();
            // 
            // StudyIconPanel
            // 
            StudyIconPanel.BackgroundImage = Properties.Resources.study_icon;
            StudyIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StudyIconPanel.Location = new Point(21, 18);
            StudyIconPanel.Name = "StudyIconPanel";
            StudyIconPanel.Size = new Size(44, 44);
            StudyIconPanel.TabIndex = 0;
            // 
            // StudyIconLabel
            // 
            StudyIconLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StudyIconLabel.ForeColor = SystemColors.Control;
            StudyIconLabel.Location = new Point(81, 12);
            StudyIconLabel.Name = "StudyIconLabel";
            StudyIconLabel.Size = new Size(813, 50);
            StudyIconLabel.TabIndex = 1;
            StudyIconLabel.Text = "Graduated at Unversity of hahaha";
            StudyIconLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(81, 78);
            label1.Name = "label1";
            label1.Size = new Size(813, 50);
            label1.TabIndex = 3;
            label1.Text = "Working at Metro 1 station";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // WorkIconPanel
            // 
            WorkIconPanel.BackgroundImage = Properties.Resources.work_icon;
            WorkIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            WorkIconPanel.Location = new Point(21, 78);
            WorkIconPanel.Name = "WorkIconPanel";
            WorkIconPanel.Size = new Size(44, 44);
            WorkIconPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(81, 144);
            label2.Name = "label2";
            label2.Size = new Size(813, 50);
            label2.TabIndex = 5;
            label2.Text = "Come from Alabama";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LivingIconPanel
            // 
            LivingIconPanel.BackgroundImage = Properties.Resources.location_icon;
            LivingIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LivingIconPanel.Location = new Point(21, 144);
            LivingIconPanel.Name = "LivingIconPanel";
            LivingIconPanel.Size = new Size(44, 44);
            LivingIconPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(81, 212);
            label3.Name = "label3";
            label3.Size = new Size(813, 50);
            label3.TabIndex = 7;
            label3.Text = "Currently live in Gravity Falls";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeIconPanel
            // 
            HomeIconPanel.BackgroundImage = Properties.Resources.home_icon;
            HomeIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            HomeIconPanel.Location = new Point(21, 212);
            HomeIconPanel.Name = "HomeIconPanel";
            HomeIconPanel.Size = new Size(44, 44);
            HomeIconPanel.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(81, 279);
            label4.Name = "label4";
            label4.Size = new Size(813, 50);
            label4.TabIndex = 9;
            label4.Text = "No information about relationship";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RelationshipIconPanel
            // 
            RelationshipIconPanel.BackgroundImage = Properties.Resources.relationship_icon;
            RelationshipIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RelationshipIconPanel.Location = new Point(21, 279);
            RelationshipIconPanel.Name = "RelationshipIconPanel";
            RelationshipIconPanel.Size = new Size(44, 44);
            RelationshipIconPanel.TabIndex = 8;
            // 
            // IntroductionOverviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 354);
            Controls.Add(label4);
            Controls.Add(RelationshipIconPanel);
            Controls.Add(label3);
            Controls.Add(HomeIconPanel);
            Controls.Add(label2);
            Controls.Add(LivingIconPanel);
            Controls.Add(label1);
            Controls.Add(WorkIconPanel);
            Controls.Add(StudyIconLabel);
            Controls.Add(StudyIconPanel);
            Name = "IntroductionOverviewForm";
            Text = "IntroductionOverviewForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel StudyIconPanel;
        private Label StudyIconLabel;
        private Label label1;
        private Panel WorkIconPanel;
        private Label label2;
        private Panel LivingIconPanel;
        private Label label3;
        private Panel HomeIconPanel;
        private Label label4;
        private Panel RelationshipIconPanel;
    }
}