﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poddprojektet1
{
    public partial class LaggTillPodcast : Form
    {
        public LaggTillPodcast()
        {
            InitializeComponent();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}