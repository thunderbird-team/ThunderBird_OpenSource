using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSkin.Forms;
using DSkin.Common;

namespace ThunderBirdNS
{
    public partial class FrmBase : Skin_VS_Light
    {
        public FrmBase() {
            InitializeComponent();
        }

        private void FrmBase_DoubleClick(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    break;
            }
        }
    }
}
