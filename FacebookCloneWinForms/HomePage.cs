using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCloneWinForms
{
    public partial class HomePage : Form
    {
        public static bool PopUpClicked = false;
        public HomePage()
        {
            InitializeComponent();
        }

        private void FriendLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            FriendSelectedLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            PageSelectedLabel.BackColor = Color.Transparent;
            HomeSelectedLabel.BackColor = Color.Transparent;
            GroupSelectedLabel.BackColor = Color.Transparent;

            // open friend page
            FriendLabelClick_Click(sender, e);
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            HomeSelectedLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            PageSelectedLabel.BackColor = Color.Transparent;
            FriendSelectedLabel.BackColor = Color.Transparent;
            GroupSelectedLabel.BackColor = Color.Transparent;

            // Since were Home, nothing happened
        }

        private void PageLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            PageSelectedLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            HomeSelectedLabel.BackColor = Color.Transparent;
            FriendSelectedLabel.BackColor = Color.Transparent;
            GroupSelectedLabel.BackColor = Color.Transparent;

            // open page page
            PageLabelClick_Click((object)sender, e);
        }

        private void GroupLabel_Click(object sender, EventArgs e)
        {

            //when this label get selected its backcolor is ButtonHighlight
            GroupSelectedLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            PageSelectedLabel.BackColor = Color.Transparent;
            FriendSelectedLabel.BackColor = Color.Transparent;
            HomeSelectedLabel.BackColor = Color.Transparent;

            // open group page
            GroupLabelClick_Click((object)sender, e);
        }

        private void UserLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new UserPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void FriendLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new FriendPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void GroupLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new GroupPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void PageLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new PagePage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void SavedLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new SavedPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void MessengerLabelClick_Click(object sender, EventArgs e)
        {
            var frm = new MessengerPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void MessengerLabelIcon_Click(object sender, EventArgs e)
        {
            MessengerLabelClick_Click(sender, e);
        }

        private void NotificationLabelIcon_Click(object sender, EventArgs e)
        {
            var frm = new NotificationPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void UserNamePopUpMenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserNamePopUpMenuClick_Click(object sender, EventArgs e)
        {
            var frm = new UserPage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void SettingLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm_();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserLabelIcon_Click(object sender, EventArgs e)
        {
            if(PopUpClicked == false)
            {
                PopUpMenuPanel.Visible = true;
                PopUpClicked = true;
            }
            else
            {
                PopUpMenuPanel.Visible = false;
                PopUpClicked = false;
            }
        }
    }
}
