namespace FacebookCloneWinForms
{
    partial class InformationImageVideoUserControl
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
            ImagePanel = new Panel();
            ImageCaptionlabel = new Label();
            SuspendLayout();
            // 
            // ImagePanel
            // 
            ImagePanel.BackgroundImage = Properties.Resources.exit;
            ImagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            ImagePanel.Location = new Point(2, 12);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(250, 250);
            ImagePanel.TabIndex = 0;
            // 
            // ImageCaptionlabel
            // 
            ImageCaptionlabel.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ImageCaptionlabel.ForeColor = SystemColors.Control;
            ImageCaptionlabel.Location = new Point(3, 280);
            ImageCaptionlabel.Name = "ImageCaptionlabel";
            ImageCaptionlabel.Size = new Size(249, 96);
            ImageCaptionlabel.TabIndex = 1;
            ImageCaptionlabel.Text = "Now post caption goes here";
            // 
            // InformationImageUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 39);
            Controls.Add(ImageCaptionlabel);
            Controls.Add(ImagePanel);
            Name = "InformationImageUserControl";
            Size = new Size(255, 393);
            ResumeLayout(false);
        }

        #endregion

        private Panel ImagePanel;
        private Label ImageCaptionlabel;
    }
}
