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
    public partial class IntroductionAboutForm : Form
    {
        public IntroductionAboutForm()
        {
            InitializeComponent();
            OtherNameUserControl name = new OtherNameUserControl();
            OtherNameContentPanel.Controls.Add(name);
        }

        private void IntroductionAboutForm_Load(object sender, EventArgs e)
        {

        }

        private void OtherNameContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
