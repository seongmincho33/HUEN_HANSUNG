﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerView.Components
{
    public partial class Pop_PlannerCreator : Form
    {
        public string Title { get; private set; }
        public Pop_PlannerCreator()
        {
            InitializeComponent();
            this.btnConfirm.Click += BtnConfirm_Click;
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            this.Title = this.txtTitle.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
