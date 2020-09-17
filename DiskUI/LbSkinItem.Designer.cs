namespace ThunderBirdNS
{
    partial class LbSkinItem
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LbSkinItem));
            this.imgHover = new DSkin.DirectUI.DuiPictureBox();
            this.imgSelect = new DSkin.DirectUI.DuiPictureBox();
            // 
            // imgHover
            // 
            this.imgHover.AutoSize = false;
            this.imgHover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgHover.BackgroundImage")));
            this.imgHover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgHover.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imgHover.Images = null;
            this.imgHover.Location = new System.Drawing.Point(0, 0);
            this.imgHover.Name = "imgHover";
            this.imgHover.Size = new System.Drawing.Size(40, 40);
            this.imgHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.imgHover.Visible = false;
            // 
            // imgSelect
            // 
            this.imgSelect.AutoSize = false;
            this.imgSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgSelect.BackgroundImage")));
            this.imgSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgSelect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imgSelect.Images = null;
            this.imgSelect.Location = new System.Drawing.Point(25, 25);
            this.imgSelect.Name = "imgSelect";
            this.imgSelect.Size = new System.Drawing.Size(13, 13);
            this.imgSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.imgSelect.Visible = false;
            // 
            // LbSkinItem
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.imgHover);
            this.Controls.Add(this.imgSelect);
            this.Size = new System.Drawing.Size(40, 40);
            this.IsSelectedChanged += new System.EventHandler(this.LbSkinItem_IsSelectedChanged);
            this.MouseEnter += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.LbSkinItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LbSkinItem_MouseLeave);

        }

        #endregion

        public DSkin.DirectUI.DuiPictureBox imgHover;
        public DSkin.DirectUI.DuiPictureBox imgSelect;

    }
}
