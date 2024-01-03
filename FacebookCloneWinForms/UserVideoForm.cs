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
    public partial class UserVideoForm : Form
    {
        public UserVideoForm()
        {
            InitializeComponent();
            InformationImageVideoUserControl vid = new InformationImageVideoUserControl();
            VideoContentPanel.Controls.Add(vid);
        }

        private void VideoContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VideoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
