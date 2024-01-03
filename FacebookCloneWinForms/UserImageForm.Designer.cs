namespace FacebookCloneWinForms
{
    partial class UserImageForm
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
            ImageLabel = new Label();
            ImageContentPanel = new Panel();
            SuspendLayout();
            // 
            // ImageLabel
            // 
            ImageLabel.AutoSize = true;
            ImageLabel.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ImageLabel.ForeColor = SystemColors.Control;
            ImageLabel.Location = new Point(12, 9);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(127, 43);
            ImageLabel.TabIndex = 0;
            ImageLabel.Text = "Images";
            // 
            // ImageContentPanel
            // 
            ImageContentPanel.AutoScroll = true;
            ImageContentPanel.Dock = DockStyle.Bottom;
            ImageContentPanel.Location = new Point(0, 55);
            ImageContentPanel.Name = "ImageContentPanel";
            ImageContentPanel.Size = new Size(1352, 398);
            ImageContentPanel.TabIndex = 1;
            ImageContentPanel.Paint += ImageContentPanel_Paint;
            // 
            // UserImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(39, 39, 39);
            ClientSize = new Size(1352, 453);
            Controls.Add(ImageContentPanel);
            Controls.Add(ImageLabel);
            Name = "UserImageForm";
            Text = "UserImageForm";
            Load += UserImageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ImageLabel;
        private Panel ImageContentPanel;
    }
}