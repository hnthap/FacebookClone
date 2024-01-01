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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
            // Since were at Posts, Open posts in panel
            UserPostForm child = new UserPostForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void IntroductionLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenIntroductionLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenFriendLabel.BackColor = Color.Transparent;
            ChosenImageLabel.BackColor = Color.Transparent;
            ChosenPostLabel.BackColor = Color.Transparent;
            ChosenReelLabel.BackColor = Color.Transparent;
            ChosenVideoLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserInformationForm child = new UserInformationForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void FriendLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenFriendLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenIntroductionLabel.BackColor = Color.Transparent;
            ChosenImageLabel.BackColor = Color.Transparent;
            ChosenPostLabel.BackColor = Color.Transparent;
            ChosenReelLabel.BackColor = Color.Transparent;
            ChosenVideoLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserFriendForm child = new UserFriendForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void PostLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenPostLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenFriendLabel.BackColor = Color.Transparent;
            ChosenImageLabel.BackColor = Color.Transparent;
            ChosenIntroductionLabel.BackColor = Color.Transparent;
            ChosenReelLabel.BackColor = Color.Transparent;
            ChosenVideoLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserPostForm child = new UserPostForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void ImageLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenImageLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenFriendLabel.BackColor = Color.Transparent;
            ChosenIntroductionLabel.BackColor = Color.Transparent;
            ChosenPostLabel.BackColor = Color.Transparent;
            ChosenReelLabel.BackColor = Color.Transparent;
            ChosenVideoLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserImageForm child = new UserImageForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void VideoLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenVideoLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenFriendLabel.BackColor = Color.Transparent;
            ChosenImageLabel.BackColor = Color.Transparent;
            ChosenPostLabel.BackColor = Color.Transparent;
            ChosenReelLabel.BackColor = Color.Transparent;
            ChosenIntroductionLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserVideoForm child = new UserVideoForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }

        private void ReelLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ChosenReelLabel.BackColor = SystemColors.ButtonHighlight;

            // and other 3 label became transparent
            ChosenFriendLabel.BackColor = Color.Transparent;
            ChosenImageLabel.BackColor = Color.Transparent;
            ChosenPostLabel.BackColor = Color.Transparent;
            ChosenIntroductionLabel.BackColor = Color.Transparent;
            ChosenVideoLabel.BackColor = Color.Transparent;

            // Since were at Posts, Open posts in panel
            ShowPanel.Controls.Clear();
            UserReelForm child = new UserReelForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ShowPanel.Controls.Add(child);
            child.Show();
        }
    }
}
