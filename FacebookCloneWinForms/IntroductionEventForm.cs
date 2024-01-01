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
    public partial class IntroductionEventForm : Form
    {
        public IntroductionEventForm()
        {
            InitializeComponent();
            InformationEventUserControl variable = new InformationEventUserControl();
            EventContentPanel.Controls.Add(variable);
        }

        private void EventContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
