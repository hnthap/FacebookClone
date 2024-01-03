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
    public partial class PostDefault : UserControl
    {
        public static bool isLikeClicked = false;
        public PostDefault()
        {
            InitializeComponent();
        }

        private void LikeClickLabel_Click(object sender, EventArgs e)
        {
            if (isLikeClicked == false)
            {
                LikePanel.BackgroundImage = Properties.Resources.like_clicked__icon;
            }
            else
            {
                LikePanel.BackgroundImage = Properties.Resources.like_icon;
            }
        }

        private void CaptionContentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
