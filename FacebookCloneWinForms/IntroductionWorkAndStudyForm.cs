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
    public partial class IntroductionWorkAndStudyForm : Form
    {
        public IntroductionWorkAndStudyForm()
        {
            InitializeComponent();

            WorkStudyInformationUserControl userControl = new WorkStudyInformationUserControl();
            WorkContentPanel.Controls.Add(userControl);
            WorkContentPanel.Controls.Add(userControl);
            WorkContentPanel.Controls.Add(userControl);
            WorkContentPanel.Controls.Add(userControl);

            StudyContentPanel.Controls.Add(userControl);
            StudyContentPanel.Controls.Add(userControl);
            StudyContentPanel.Controls.Add(userControl);
            StudyContentPanel.Controls.Add(userControl);
        }

        private void WorkContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
