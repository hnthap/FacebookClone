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
    public partial class UserFriendForm : Form
    {
        public UserFriendForm()
        {
            InitializeComponent();
            InformationFriendUserControl friend = new InformationFriendUserControl();
            FriendContentPanel.Controls.Add(friend);
        }

        private void UserFriendForm_Load(object sender, EventArgs e)
        {

        }

        private void FriendContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
