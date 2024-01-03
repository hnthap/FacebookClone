namespace FacebookCloneWinForms
{
    partial class UserVideoForm
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
            VideoContentPanel = new Panel();
            VideoLabel = new Label();
            SuspendLayout();
            // 
            // VideoContentPanel
            // 
            VideoContentPanel.AutoScroll = true;
            VideoContentPanel.Dock = DockStyle.Bottom;
            VideoContentPanel.Location = new Point(0, 55);
            VideoContentPanel.Name = "VideoContentPanel";
            VideoContentPanel.Size = new Size(1352, 398);
            VideoContentPanel.TabIndex = 3;
            VideoContentPanel.Paint += VideoContentPanel_Paint;
            // 
            // VideoLabel
            // 
            VideoLabel.AutoSize = true;
            VideoLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            VideoLabel.ForeColor = SystemColors.Control;
            VideoLabel.Location = new Point(12, 4);
            VideoLabel.Name = "VideoLabel";
            VideoLabel.Size = new Size(123, 43);
            VideoLabel.TabIndex = 2;
            VideoLabel.Text = "Videos";
            VideoLabel.Click += VideoLabel_Click;
            // 
            // UserVideoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1352, 453);
            Controls.Add(VideoContentPanel);
            Controls.Add(VideoLabel);
            Name = "UserVideoForm";
            Text = "UserVideoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel VideoContentPanel;
        private Label VideoLabel;
    }
}