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
    public partial class InformationFriendUserControl : UserControl
    {
        public static bool RequestSent = false;
        public InformationFriendUserControl()
        {
            InitializeComponent();
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {
            DeleteLabel.Text = "Suggest deleted";
            DeleteLabel.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            DeleteLabel.BackColor = SystemColors.ControlLight;
            AddFriendLabel.Visible = false;
        }

        private void AddFriendLabel_Click(object sender, EventArgs e)
        {
            if (RequestSent == false)
            {
                AddFriendLabel.Text = "Request sent";
                RequestSent = true;
                AddFriendLabel.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
                AddFriendLabel.BackColor = SystemColors.ControlLight;
                DeleteLabel.Visible = false;
            }
            else
            {
                AddFriendLabel.Text = "Add friend";
                RequestSent = false;
                AddFriendLabel.Font = new Font("TrebuchetMS", 20, FontStyle.Bold);
                AddFriendLabel.BackColor = SystemColors.HotTrack;
                DeleteLabel.Visible = true;
            }
        }
    }
}
