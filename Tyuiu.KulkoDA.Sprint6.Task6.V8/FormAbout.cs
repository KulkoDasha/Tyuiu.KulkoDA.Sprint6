﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KulkoDA.Sprint6.Task6.V8
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            
        }

        private void buttonAbout_KDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
