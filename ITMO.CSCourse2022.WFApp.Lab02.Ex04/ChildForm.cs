﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse2022.WFApp.Lab02.Ex04
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormatMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
