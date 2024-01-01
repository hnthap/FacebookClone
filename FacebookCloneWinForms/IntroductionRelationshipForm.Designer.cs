namespace FacebookCloneWinForms
{
    partial class IntroductionRelationshipForm
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
            RelationshipNameLabel = new Label();
            RelationshipContentLabel = new Label();
            RelationshipIconPanel = new Panel();
            SuspendLayout();
            // 
            // RelationshipNameLabel
            // 
            RelationshipNameLabel.AutoSize = true;
            RelationshipNameLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            RelationshipNameLabel.ForeColor = SystemColors.Control;
            RelationshipNameLabel.Location = new Point(20, 20);
            RelationshipNameLabel.Name = "RelationshipNameLabel";
            RelationshipNameLabel.Size = new Size(215, 43);
            RelationshipNameLabel.TabIndex = 0;
            RelationshipNameLabel.Text = "Relationship";
            // 
            // RelationshipContentLabel
            // 
            RelationshipContentLabel.AutoSize = true;
            RelationshipContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            RelationshipContentLabel.ForeColor = SystemColors.Control;
            RelationshipContentLabel.Location = new Point(62, 82);
            RelationshipContentLabel.Name = "RelationshipContentLabel";
            RelationshipContentLabel.Size = new Size(116, 36);
            RelationshipContentLabel.TabIndex = 1;
            RelationshipContentLabel.Text = "Married";
            // 
            // RelationshipIconPanel
            // 
            RelationshipIconPanel.BackgroundImage = Properties.Resources.relationship_icon;
            RelationshipIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RelationshipIconPanel.Location = new Point(20, 82);
            RelationshipIconPanel.Name = "RelationshipIconPanel";
            RelationshipIconPanel.Size = new Size(36, 36);
            RelationshipIconPanel.TabIndex = 2;
            // 
            // IntroductionRelationshipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 391);
            Controls.Add(RelationshipIconPanel);
            Controls.Add(RelationshipContentLabel);
            Controls.Add(RelationshipNameLabel);
            Name = "IntroductionRelationshipForm";
            Text = "IntroductionRelationshipForm";
            Load += IntroductionRelationshipForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RelationshipNameLabel;
        private Label RelationshipContentLabel;
        private Panel RelationshipIconPanel;
    }
}