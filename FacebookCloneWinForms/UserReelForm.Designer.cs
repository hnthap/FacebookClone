namespace FacebookCloneWinForms
{
    partial class UserReelForm
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
            ReelContentPanel = new Panel();
            ReelLabel = new Label();
            SuspendLayout();
            // 
            // ReelContentPanel
            // 
            ReelContentPanel.AutoScroll = true;
            ReelContentPanel.Dock = DockStyle.Bottom;
            ReelContentPanel.Location = new Point(0, 55);
            ReelContentPanel.Name = "ReelContentPanel";
            ReelContentPanel.Size = new Size(1352, 398);
            ReelContentPanel.TabIndex = 5;
            ReelContentPanel.Paint += VideoContentPanel_Paint;
            // 
            // ReelLabel
            // 
            ReelLabel.AutoSize = true;
            ReelLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ReelLabel.ForeColor = SystemColors.Control;
            ReelLabel.Location = new Point(12, 9);
            ReelLabel.Name = "ReelLabel";
            ReelLabel.Size = new Size(105, 43);
            ReelLabel.TabIndex = 4;
            ReelLabel.Text = "Reels";
            // 
            // UserReelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1352, 453);
            Controls.Add(ReelContentPanel);
            Controls.Add(ReelLabel);
            Name = "UserReelForm";
            Text = "UserReelForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ReelContentPanel;
        private Label ReelLabel;
    }
}