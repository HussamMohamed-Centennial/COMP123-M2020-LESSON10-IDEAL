﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON10_IDEAL
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SlashFormTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }
    }
}
