namespace ThunderBirdNS
{
    partial class FrmBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.SuspendLayout();
            // 
            // FrmBase
            // 
            this.AnimationType = DSkin.Forms.AnimationTypes.GradualCurtainEffect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.CaptionColor = System.Drawing.Color.White;
            this.CaptionOffset = new System.Drawing.Point(5, 3);
            this.CaptionShowMode = DSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(400, 640);
            this.CloseBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.CloseBox.HoverImage")));
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.CloseBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.CloseBox.NormalImage")));
            this.CloseBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CloseBox.PressImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.CloseBox.PressImage")));
            this.CloseBox.Size = new System.Drawing.Size(37, 18);
            this.DoubleClickMaximized = false;
            this.DrawIcon = false;
            this.DuiBackgroundRender.BorderColor = System.Drawing.Color.Red;
            this.DuiBackgroundRender.BorderWidth = 2;
            this.DuiBackgroundRender.Radius = 4;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconRectangle = new System.Drawing.Rectangle(8, 9, 16, 16);
            this.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.MaxBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MaxBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaximizeBox = false;
            this.MinBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinBox.HoverImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.MinBox.HoverImage")));
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.MinBox.NormalImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.MinBox.NormalImage")));
            this.MinBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MinBox.PressImage = ((System.Drawing.Image)(resources.GetObject("FrmBase.MinBox.PressImage")));
            this.MinBox.Size = new System.Drawing.Size(28, 18);
            this.Name = "FrmBase";
            this.NormalBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NormalBox.NormalColor = System.Drawing.Color.White;
            this.NormalBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Padding = new System.Windows.Forms.Padding(-1, 4, -1, 0);
            this.Radius = 6;
            this.ShadowColor = System.Drawing.Color.Gray;
            this.Text = "樱花下载器";
            this.DoubleClick += new System.EventHandler(this.FrmBase_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

