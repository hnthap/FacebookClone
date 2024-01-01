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
    public partial class IntroductionLivingForm : Form
    {
        public IntroductionLivingForm()
        {
            InitializeComponent();
            LocationInformationUserControl loc = new LocationInformationUserControl();

            LivingContentPanel.Controls.Add(loc);
            LivingContentPanel.Controls.Add(loc);
            LivingContentPanel.Controls.Add(loc);
            LivingContentPanel.Controls.Add(loc);
        }
    }
}
