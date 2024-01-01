namespace FacebookCloneWinForms
{
    partial class UserInformationForm
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
            OptionPanel = new Panel();
            EventLabel = new Label();
            AboutLabel = new Label();
            FamilyAndRelationshipLabel = new Label();
            ContactAndBasicsLabel = new Label();
            LivingLabel = new Label();
            WorkAndStudyLabel = new Label();
            OverviewLabel = new Label();
            label2 = new Label();
            ContentPanel = new Panel();
            label1 = new Label();
            OptionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OptionPanel
            // 
            OptionPanel.Controls.Add(EventLabel);
            OptionPanel.Controls.Add(AboutLabel);
            OptionPanel.Controls.Add(FamilyAndRelationshipLabel);
            OptionPanel.Controls.Add(ContactAndBasicsLabel);
            OptionPanel.Controls.Add(LivingLabel);
            OptionPanel.Controls.Add(WorkAndStudyLabel);
            OptionPanel.Controls.Add(OverviewLabel);
            OptionPanel.Controls.Add(label2);
            OptionPanel.Dock = DockStyle.Left;
            OptionPanel.Location = new Point(0, 0);
            OptionPanel.Name = "OptionPanel";
            OptionPanel.Size = new Size(411, 953);
            OptionPanel.TabIndex = 0;
            // 
            // EventLabel
            // 
            EventLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EventLabel.ForeColor = SystemColors.Control;
            EventLabel.Location = new Point(12, 395);
            EventLabel.Name = "EventLabel";
            EventLabel.Size = new Size(396, 55);
            EventLabel.TabIndex = 7;
            EventLabel.Text = "Event in life";
            EventLabel.TextAlign = ContentAlignment.MiddleLeft;
            EventLabel.Click += EventLabel_Click;
            // 
            // AboutLabel
            // 
            AboutLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AboutLabel.ForeColor = SystemColors.Control;
            AboutLabel.Location = new Point(12, 340);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(396, 55);
            AboutLabel.TabIndex = 6;
            AboutLabel.Text = "About";
            AboutLabel.TextAlign = ContentAlignment.MiddleLeft;
            AboutLabel.Click += AboutLabel_Click;
            // 
            // FamilyAndRelationshipLabel
            // 
            FamilyAndRelationshipLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.Location = new Point(12, 285);
            FamilyAndRelationshipLabel.Name = "FamilyAndRelationshipLabel";
            FamilyAndRelationshipLabel.Size = new Size(396, 55);
            FamilyAndRelationshipLabel.TabIndex = 5;
            FamilyAndRelationshipLabel.Text = "Family and relationship";
            FamilyAndRelationshipLabel.TextAlign = ContentAlignment.MiddleLeft;
            FamilyAndRelationshipLabel.Click += FamilyAndRelationshipLabel_Click;
            // 
            // ContactAndBasicsLabel
            // 
            ContactAndBasicsLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.Location = new Point(12, 230);
            ContactAndBasicsLabel.Name = "ContactAndBasicsLabel";
            ContactAndBasicsLabel.Size = new Size(396, 55);
            ContactAndBasicsLabel.TabIndex = 4;
            ContactAndBasicsLabel.Text = "Contact and basics";
            ContactAndBasicsLabel.TextAlign = ContentAlignment.MiddleLeft;
            ContactAndBasicsLabel.Click += ContactAndBasicsLabel_Click;
            // 
            // LivingLabel
            // 
            LivingLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LivingLabel.ForeColor = SystemColors.Control;
            LivingLabel.Location = new Point(12, 175);
            LivingLabel.Name = "LivingLabel";
            LivingLabel.Size = new Size(396, 55);
            LivingLabel.TabIndex = 3;
            LivingLabel.Text = "Living";
            LivingLabel.TextAlign = ContentAlignment.MiddleLeft;
            LivingLabel.Click += LivingLabel_Click;
            // 
            // WorkAndStudyLabel
            // 
            WorkAndStudyLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            WorkAndStudyLabel.Location = new Point(12, 120);
            WorkAndStudyLabel.Name = "WorkAndStudyLabel";
            WorkAndStudyLabel.Size = new Size(396, 55);
            WorkAndStudyLabel.TabIndex = 2;
            WorkAndStudyLabel.Text = "Work and study";
            WorkAndStudyLabel.TextAlign = ContentAlignment.MiddleLeft;
            WorkAndStudyLabel.Click += WorkAndStudyLabel_Click;
            // 
            // OverviewLabel
            // 
            OverviewLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            OverviewLabel.ForeColor = SystemColors.HotTrack;
            OverviewLabel.Location = new Point(12, 65);
            OverviewLabel.Name = "OverviewLabel";
            OverviewLabel.Size = new Size(396, 55);
            OverviewLabel.TabIndex = 1;
            OverviewLabel.Text = "Overview";
            OverviewLabel.TextAlign = ContentAlignment.MiddleLeft;
            OverviewLabel.Click += OverviewLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(204, 43);
            label2.TabIndex = 0;
            label2.Text = "Information";
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.Dock = DockStyle.Right;
            ContentPanel.Location = new Point(417, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(935, 953);
            ContentPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(414, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 953);
            label1.TabIndex = 0;
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1352, 953);
            Controls.Add(label1);
            Controls.Add(ContentPanel);
            Controls.Add(OptionPanel);
            Name = "UserInformationForm";
            Text = "UserInformationForm";
            OptionPanel.ResumeLayout(false);
            OptionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel OptionPanel;
        private Panel ContentPanel;
        private Label label1;
        private Label WorkAndStudyLabel;
        private Label OverviewLabel;
        private Label label2;
        private Label AboutLabel;
        private Label FamilyAndRelationshipLabel;
        private Label ContactAndBasicsLabel;
        private Label LivingLabel;
        private Label EventLabel;
    }
}