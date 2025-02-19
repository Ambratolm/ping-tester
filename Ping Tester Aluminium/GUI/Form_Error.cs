﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTesterAluminium
{
    public partial class Form_Error : AluminiumForm
    {
        public Form_Error(string errorMessage)
        {
            InitializeComponent();
            label_error.Text = errorMessage;
        }

        public static DialogResult Show(string errorMessage, IWin32Window owner = null)
        {
            return new Form_Error(errorMessage).ShowDialog(owner);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
