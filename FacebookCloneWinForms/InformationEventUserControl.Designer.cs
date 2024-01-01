namespace FacebookCloneWinForms
{
    partial class InformationEventUserControl
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
            EventContentLabel = new Label();
            EventYearLabel = new Label();
            SuspendLayout();
            // 
            // EventContentLabel
            // 
            EventContentLabel.AutoSize = true;
            EventContentLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EventContentLabel.ForeColor = SystemColors.Control;
            EventContentLabel.Location = new Point(3, 10);
            EventContentLabel.Name = "EventContentLabel";
            EventContentLabel.Size = new Size(348, 36);
            EventContentLabel.TabIndex = 0;
            EventContentLabel.Text = "I was today year old, yay!";
            // 
            // EventYearLabel
            // 
            EventYearLabel.AutoSize = true;
            EventYearLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EventYearLabel.ForeColor = SystemColors.Control;
            EventYearLabel.Location = new Point(357, 10);
            EventYearLabel.Name = "EventYearLabel";
            EventYearLabel.Size = new Size(105, 36);
            EventYearLabel.TabIndex = 1;
            EventYearLabel.Text = "-  2022";
            // 
            // InformationEventUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(EventYearLabel);
            Controls.Add(EventContentLabel);
            Name = "InformationEventUserControl";
            Size = new Size(893, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventContentLabel;
        private Label EventYearLabel;
    }
}
