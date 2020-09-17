using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace ThunderBirdNS
{
    public partial class LbSkinItem : DuiBaseControl
    {
        public LbSkinItem(Image Back) {
            this.BackgroundImage = Back;
            InitializeComponent();
        }

        /// <summary>
        /// 悬浮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSkinItem_MouseEnter(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (!this.IsSelected) {
                imgHover.Visible = true;
            }
        }

        /// <summary>
        /// 离开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSkinItem_MouseLeave(object sender, EventArgs e) {
            imgHover.Visible = false;
        }

        /// <summary>
        /// 选中与否时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSkinItem_IsSelectedChanged(object sender, EventArgs e) {
            //处理该项是否选中效果
            if (this.IsSelected) {
                this.imgHover.Visible = false;
                this.imgSelect.Visible = true;
            } else {
                this.imgSelect.Visible = false;
            }
        }
    }
}
