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
    public partial class UserImageForm : Form
    {
        public UserImageForm()
        {
            InitializeComponent(); 
            InformationImageVideoUserControl img = new InformationImageVideoUserControl();
            ImageContentPanel.Controls.Add(img);
        }

        private void UserImageForm_Load(object sender, EventArgs e)
        {

        }

        private void ImageContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
