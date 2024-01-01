namespace FacebookCloneWinForms
{
    partial class IntroductionEventForm
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
            EventLabel = new Label();
            EventContentPanel = new Panel();
            SuspendLayout();
            // 
            // EventLabel
            // 
            EventLabel.AutoSize = true;
            EventLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            EventLabel.ForeColor = SystemColors.Control;
            EventLabel.Location = new Point(12, 9);
            EventLabel.Name = "EventLabel";
            EventLabel.Size = new Size(208, 46);
            EventLabel.TabIndex = 0;
            EventLabel.Text = "Event in life";
            // 
            // EventContentPanel
            // 
            EventContentPanel.AutoScroll = true;
            EventContentPanel.Location = new Point(12, 69);
            EventContentPanel.Name = "EventContentPanel";
            EventContentPanel.Size = new Size(893, 825);
            EventContentPanel.TabIndex = 1;
            EventContentPanel.Paint += EventContentPanel_Paint;
            // 
            // IntroductionEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(917, 906);
            Controls.Add(EventContentPanel);
            Controls.Add(EventLabel);
            Name = "IntroductionEventForm";
            Text = "IntroductionEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventLabel;
        private Panel EventContentPanel;
    }
}