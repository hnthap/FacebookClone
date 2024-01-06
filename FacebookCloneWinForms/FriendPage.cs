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
    public partial class FriendPage : Form
    {
        public FriendPage()
        {
            InitializeComponent();
            showFriendRequest();
            FriendRequestChosenLabel.BackColor = SystemColors.Control;
            AllFriendChosenLabel.BackColor = Color.Transparent;
        }

        public void showFriendRequest()
        {
            FriendContentLabel.Controls.Clear();
            FriendRequestUserControl friend = new FriendRequestUserControl();
            FriendContentLabel.Controls.Add(friend);
        }

        private void FriendContentLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void showAllFriend()
        {
            FriendContentLabel.Controls.Clear();
            FriendListedUserControl friend = new FriendListedUserControl();
            FriendContentLabel.Controls.Add(friend);
        }

        private void FriendRequestLabel_Click(object sender, EventArgs e)
        {
            showFriendRequest();
            FriendRequestChosenLabel.BackColor = SystemColors.Control;
            AllFriendChosenLabel.BackColor = Color.Transparent;
        }

        private void AllFriendLabel_Click(object sender, EventArgs e)
        {
            showAllFriend();
            AllFriendChosenLabel.BackColor= SystemColors.Control;
            FriendRequestChosenLabel.BackColor =Color.Transparent;
        }
    }
}
