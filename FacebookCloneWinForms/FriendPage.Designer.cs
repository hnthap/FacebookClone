namespace FacebookCloneWinForms
{
    partial class FriendPage
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
            panel1 = new Panel();
            AllFriendChosenLabel = new Label();
            FriendRequestChosenLabel = new Label();
            panel3 = new Panel();
            AllFriendLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            FriendRequestLabel = new Label();
            FriendLabel = new Label();
            FriendContentLabel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 39);
            panel1.Controls.Add(AllFriendChosenLabel);
            panel1.Controls.Add(FriendRequestChosenLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(AllFriendLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FriendRequestLabel);
            panel1.Controls.Add(FriendLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 1033);
            panel1.TabIndex = 0;
            // 
            // AllFriendChosenLabel
            // 
            AllFriendChosenLabel.BackColor = Color.FromArgb(39, 39, 39);
            AllFriendChosenLabel.Location = new Point(459, 165);
            AllFriendChosenLabel.Name = "AllFriendChosenLabel";
            AllFriendChosenLabel.Size = new Size(10, 71);
            AllFriendChosenLabel.TabIndex = 7;
            // 
            // FriendRequestChosenLabel
            // 
            FriendRequestChosenLabel.BackColor = SystemColors.Control;
            FriendRequestChosenLabel.Location = new Point(459, 79);
            FriendRequestChosenLabel.Name = "FriendRequestChosenLabel";
            FriendRequestChosenLabel.Size = new Size(10, 71);
            FriendRequestChosenLabel.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.all_friend_icon;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(12, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(45, 45);
            panel3.TabIndex = 5;
            // 
            // AllFriendLabel
            // 
            AllFriendLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AllFriendLabel.ForeColor = SystemColors.Control;
            AllFriendLabel.Location = new Point(12, 165);
            AllFriendLabel.Name = "AllFriendLabel";
            AllFriendLabel.Size = new Size(441, 71);
            AllFriendLabel.TabIndex = 4;
            AllFriendLabel.Text = "      All friends";
            AllFriendLabel.TextAlign = ContentAlignment.MiddleLeft;
            AllFriendLabel.Click += AllFriendLabel_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.friend_icon;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(12, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 45);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(455, 21);
            label1.TabIndex = 2;
            // 
            // FriendRequestLabel
            // 
            FriendRequestLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FriendRequestLabel.ForeColor = SystemColors.Control;
            FriendRequestLabel.Location = new Point(12, 79);
            FriendRequestLabel.Name = "FriendRequestLabel";
            FriendRequestLabel.Size = new Size(441, 71);
            FriendRequestLabel.TabIndex = 1;
            FriendRequestLabel.Text = "      Friend request";
            FriendRequestLabel.TextAlign = ContentAlignment.MiddleLeft;
            FriendRequestLabel.Click += FriendRequestLabel_Click;
            // 
            // FriendLabel
            // 
            FriendLabel.AutoSize = true;
            FriendLabel.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            FriendLabel.ForeColor = SystemColors.Control;
            FriendLabel.Location = new Point(12, 9);
            FriendLabel.Name = "FriendLabel";
            FriendLabel.Size = new Size(144, 49);
            FriendLabel.TabIndex = 0;
            FriendLabel.Text = "Friend";
            // 
            // FriendContentLabel
            // 
            FriendContentLabel.AutoScroll = true;
            FriendContentLabel.Dock = DockStyle.Right;
            FriendContentLabel.Location = new Point(476, 0);
            FriendContentLabel.Name = "FriendContentLabel";
            FriendContentLabel.Size = new Size(1426, 1033);
            FriendContentLabel.TabIndex = 1;
            FriendContentLabel.Paint += FriendContentLabel_Paint;
            // 
            // FriendPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(1902, 1033);
            Controls.Add(FriendContentLabel);
            Controls.Add(panel1);
            Name = "FriendPage";
            Text = "FriendPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label FriendLabel;
        private Label FriendRequestLabel;
        private Label label1;
        private Panel panel2;
        private Panel FriendContentLabel;
        private Panel panel3;
        private Label AllFriendLabel;
        private Label FriendRequestChosenLabel;
        private Label AllFriendChosenLabel;
    }
}