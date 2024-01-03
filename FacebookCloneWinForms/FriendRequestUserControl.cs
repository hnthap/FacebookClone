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
    public partial class FriendRequestUserControl : UserControl
    {
        public FriendRequestUserControl()
        {
            InitializeComponent();
        }

        private void ConfirmLabel_Click(object sender, EventArgs e)
        {
            ConfirmLabel.Text = "Request accepted";
            ConfirmLabel.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            ConfirmLabel.BackColor = SystemColors.ControlLight;
            DeleteLabel.Visible = false;
        }

        private void DeleteLabel_Click(object sender, EventArgs e)
        {
            DeleteLabel.Text = "Request deleted";
            DeleteLabel.Font = new Font("TrebuchetMS", 12, FontStyle.Bold);
            DeleteLabel.BackColor = SystemColors.ControlLight;
            ConfirmLabel.Visible = false;
        }
    }
}
