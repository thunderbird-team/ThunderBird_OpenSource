using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.Controls;

namespace ThunderBirdNS
{
    public partial class Way1CellTemplate : DSkinGirdListCellTemplate
    {
        public Way1CellTemplate()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //duiLabel1.Text = "图标" + this.Value.ToString();
        }
    }
}
