﻿using System;
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
    public partial class UserReelForm : Form
    {
        public UserReelForm()
        {
            InitializeComponent();
            InformationImageVideoUserControl reel = new InformationImageVideoUserControl();
            ReelContentPanel.Controls.Add(reel);
        }

        private void VideoContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
