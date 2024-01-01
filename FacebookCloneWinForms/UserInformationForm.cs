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
    public partial class UserInformationForm : Form
    {
        public UserInformationForm()
        {
            InitializeComponent();// Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionOverviewForm child = new IntroductionOverviewForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void OverviewLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            OverviewLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionOverviewForm child = new IntroductionOverviewForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void WorkAndStudyLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            WorkAndStudyLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            OverviewLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionWorkAndStudyForm child = new IntroductionWorkAndStudyForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void LivingLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            LivingLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            OverviewLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionLivingForm child = new IntroductionLivingForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void ContactAndBasicsLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            ContactAndBasicsLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            OverviewLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionContactAndBasisForm child = new IntroductionContactAndBasisForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void FamilyAndRelationshipLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            FamilyAndRelationshipLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            OverviewLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionRelationshipForm child = new IntroductionRelationshipForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            AboutLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            OverviewLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            EventLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionAboutForm child = new IntroductionAboutForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }

        private void EventLabel_Click(object sender, EventArgs e)
        {
            //when this label get selected its backcolor is ButtonHighlight
            EventLabel.ForeColor = SystemColors.HotTrack;

            // and other 3 label became transparent
            WorkAndStudyLabel.ForeColor = SystemColors.Control;
            LivingLabel.ForeColor = SystemColors.Control;
            OverviewLabel.ForeColor = SystemColors.Control;
            ContactAndBasicsLabel.ForeColor = SystemColors.Control;
            FamilyAndRelationshipLabel.ForeColor = SystemColors.Control;
            AboutLabel.ForeColor = SystemColors.Control;

            // Since were at Posts, Open posts in panel
            ContentPanel.Controls.Clear();
            IntroductionEventForm child = new IntroductionEventForm() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            ContentPanel.Controls.Add(child);
            child.Show();
        }
    }
}
