﻿using Sony360.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sony360
{
    public partial class Form1 : Form
    {
        private ViewController viewController;
        public Form1(object viewC)
        {
            viewController = (ViewController) viewC;
            InitializeComponent();
        }
    }
}
