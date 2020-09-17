using DSkin.Controls;
using System;
using System.Drawing;

namespace ThunderBirdNS
{
    partial class CloudDiskUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {           
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudDiskUI));
            this.dSkinGridList1 = new DSkin.Controls.DSkinGridList();
            this.dSkinContextMenuStrip1 = new DSkin.Controls.DSkinContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dSkinPanel2 = new DSkin.Controls.DSkinPanel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinButton2 = new DSkin.Controls.DSkinButton();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinButton7 = new DSkin.Controls.DSkinButton();
            this.dSkinButton6 = new DSkin.Controls.DSkinButton();
            this.dSkinPanel3 = new DSkin.Controls.DSkinFlowLayoutPanel();
            this.dSkinButton11 = new DSkin.Controls.DSkinButton();
            this.dSkinButton10 = new DSkin.Controls.DSkinButton();
            this.dSkinButton9 = new DSkin.Controls.DSkinButton();
            this.dSkinButton8 = new DSkin.Controls.DSkinButton();
            this.statusInfo = new DSkin.Controls.DSkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinGridList1)).BeginInit();
            this.dSkinContextMenuStrip1.SuspendLayout();
            this.dSkinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSkinGridList1
            // 
            // 
            // 
            // 
            this.dSkinGridList1.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dSkinGridList1.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinGridList1.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.BackPageButton.Location = new System.Drawing.Point(386, 4);
            this.dSkinGridList1.BackPageButton.Name = "BtnBackPage";
            this.dSkinGridList1.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dSkinGridList1.BackPageButton.Radius = 0;
            this.dSkinGridList1.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.dSkinGridList1.BackPageButton.Text = "上一页";
            this.dSkinGridList1.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinGridList1.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dSkinGridList1.Borders.AllColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.Borders.AllWidth = 0;
            this.dSkinGridList1.Borders.BottomColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.Borders.BottomWidth = 0;
            this.dSkinGridList1.Borders.LeftColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.Borders.LeftWidth = 0;
            this.dSkinGridList1.Borders.RightColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.Borders.RightWidth = 0;
            this.dSkinGridList1.Borders.TopColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.Borders.TopWidth = 0;
            this.dSkinGridList1.ColumnHeight = 30;
            this.dSkinGridList1.ContextMenuStrip = this.dSkinContextMenuStrip1;
            this.dSkinGridList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinGridList1.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dSkinGridList1.EnabledOrder = true;
            this.dSkinGridList1.EnablePage = false;
            // 
            // 
            // 
            this.dSkinGridList1.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dSkinGridList1.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinGridList1.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.FirstPageButton.Location = new System.Drawing.Point(338, 4);
            this.dSkinGridList1.FirstPageButton.Name = "BtnFistPage";
            this.dSkinGridList1.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dSkinGridList1.FirstPageButton.Radius = 0;
            this.dSkinGridList1.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.dSkinGridList1.FirstPageButton.Text = "首页";
            this.dSkinGridList1.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinGridList1.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.dSkinGridList1.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dSkinGridList1.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dSkinGridList1.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinGridList1.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.dSkinGridList1.GoPageButton.Name = "BtnGoPage";
            this.dSkinGridList1.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dSkinGridList1.GoPageButton.Radius = 0;
            this.dSkinGridList1.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.dSkinGridList1.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinGridList1.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dSkinGridList1.GridLineColor = System.Drawing.Color.Silver;
            this.dSkinGridList1.GridLineShowMode = DSkin.Controls.GridLineShowModes.None;
            this.dSkinGridList1.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            // 
            // 
            // 
            this.dSkinGridList1.HScrollBar.AutoSize = false;
            this.dSkinGridList1.HScrollBar.Fillet = true;
            this.dSkinGridList1.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.HScrollBar.Location = new System.Drawing.Point(0, 512);
            this.dSkinGridList1.HScrollBar.Maximum = 216;
            this.dSkinGridList1.HScrollBar.Name = "";
            this.dSkinGridList1.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.dSkinGridList1.HScrollBar.ScrollBarLenght = 669;
            this.dSkinGridList1.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.dSkinGridList1.HScrollBar.Size = new System.Drawing.Size(350, 12);
            this.dSkinGridList1.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.dSkinGridList1.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dSkinGridList1.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinGridList1.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.LastPageButton.Location = new System.Drawing.Point(494, 4);
            this.dSkinGridList1.LastPageButton.Name = "BtnLastPage";
            this.dSkinGridList1.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dSkinGridList1.LastPageButton.Radius = 0;
            this.dSkinGridList1.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.dSkinGridList1.LastPageButton.Text = "末页";
            this.dSkinGridList1.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinGridList1.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dSkinGridList1.Location = new System.Drawing.Point(0, 40);
            this.dSkinGridList1.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinGridList1.Name = "dSkinGridList1";
            // 
            // 
            // 
            this.dSkinGridList1.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dSkinGridList1.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinGridList1.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dSkinGridList1.NextPageButton.Location = new System.Drawing.Point(440, 4);
            this.dSkinGridList1.NextPageButton.Name = "BtnNextPage";
            this.dSkinGridList1.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dSkinGridList1.NextPageButton.Radius = 0;
            this.dSkinGridList1.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.dSkinGridList1.NextPageButton.Text = "下一页";
            this.dSkinGridList1.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinGridList1.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.dSkinGridList1.SelectedItem = null;
            this.dSkinGridList1.SelectedItemsBackColor = System.Drawing.Color.CornflowerBlue;
            this.dSkinGridList1.Size = new System.Drawing.Size(350, 480);
            this.dSkinGridList1.TabIndex = 0;
            // 
            // 
            // 
            this.dSkinGridList1.VScrollBar.AutoSize = false;
            this.dSkinGridList1.VScrollBar.BitmapCache = true;
            this.dSkinGridList1.VScrollBar.Fillet = true;
            this.dSkinGridList1.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinGridList1.VScrollBar.LargeChange = 1000;
            this.dSkinGridList1.VScrollBar.Location = new System.Drawing.Point(337, 1);
            this.dSkinGridList1.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.dSkinGridList1.VScrollBar.Maximum = 10000;
            this.dSkinGridList1.VScrollBar.Name = "";
            this.dSkinGridList1.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.dSkinGridList1.VScrollBar.Size = new System.Drawing.Size(12, 447);
            this.dSkinGridList1.VScrollBar.SmallChange = 500;
            this.dSkinGridList1.VScrollBar.Visible = false;
            this.dSkinGridList1.ItemClick += new System.EventHandler<DSkin.Controls.DSkinGridListMouseEventArgs>(this.dSkinGridList1_ItemClick_1);
            this.dSkinGridList1.ItemDoubleClick += new System.EventHandler<DSkin.Controls.DSkinGridListMouseEventArgs>(this.dSkinGridList1_ItemClick);
            // 
            // dSkinContextMenuStrip1
            // 
            this.dSkinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.dSkinContextMenuStrip1.Back = System.Drawing.Color.White;
            this.dSkinContextMenuStrip1.BackRadius = 1;
            this.dSkinContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dSkinContextMenuStrip1.CheckedImage = null;
            this.dSkinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dSkinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.dSkinContextMenuStrip1.HoverFore = System.Drawing.Color.Black;
            this.dSkinContextMenuStrip1.ItemAnamorphosis = true;
            this.dSkinContextMenuStrip1.ItemBorder = System.Drawing.Color.Transparent;
            this.dSkinContextMenuStrip1.ItemBorderShow = false;
            this.dSkinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dSkinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dSkinContextMenuStrip1.ItemRadius = 1;
            this.dSkinContextMenuStrip1.ItemRadiusStyle = DSkin.Common.RoundStyle.All;
            this.dSkinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.dSkinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dSkinContextMenuStrip1.Name = "dSkinContextMenuStrip1";
            this.dSkinContextMenuStrip1.RadiusStyle = DSkin.Common.RoundStyle.None;
            this.dSkinContextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.dSkinContextMenuStrip1.SkinAllColor = true;
            this.dSkinContextMenuStrip1.Text = "右键菜单";
            this.dSkinContextMenuStrip1.TitleAnamorphosis = true;
            this.dSkinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.dSkinContextMenuStrip1.TitleRadius = 1;
            this.dSkinContextMenuStrip1.TitleRadiusStyle = DSkin.Common.RoundStyle.All;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "高速下载";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "查询属性";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // dSkinPanel2
            // 
            this.dSkinPanel2.BackColor = System.Drawing.Color.White;
            this.dSkinPanel2.Controls.Add(this.dSkinLabel1);
            this.dSkinPanel2.Controls.Add(this.dSkinButton2);
            this.dSkinPanel2.Controls.Add(this.dSkinLabel3);
            this.dSkinPanel2.Controls.Add(this.dSkinButton7);
            this.dSkinPanel2.Controls.Add(this.dSkinButton6);
            this.dSkinPanel2.Controls.Add(this.dSkinPanel3);
            this.dSkinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dSkinPanel2.Location = new System.Drawing.Point(0, 0);
            this.dSkinPanel2.Name = "dSkinPanel2";
            this.dSkinPanel2.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel2.RightBottom")));
            this.dSkinPanel2.Size = new System.Drawing.Size(350, 40);
            this.dSkinPanel2.TabIndex = 2;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinLabel1.Location = new System.Drawing.Point(285, 15);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(54, 16);
            this.dSkinLabel1.TabIndex = 13;
            this.dSkinLabel1.Text = "网盘登录";
            this.dSkinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinLabel1.Click += new System.EventHandler(this.dSkinLabel1_Click);
            this.dSkinLabel1.MouseEnter += new System.EventHandler(this.DynamicPathLabel_MouseEnter);
            this.dSkinLabel1.MouseLeave += new System.EventHandler(this.DynamicPathLabel_MouseLeave);
            // 
            // dSkinButton2
            // 
            this.dSkinButton2.AdaptImage = true;
            this.dSkinButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton2.BaseColor = System.Drawing.Color.Empty;
            this.dSkinButton2.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton2.ButtonBorderWidth = 1;
            this.dSkinButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton2.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton2.HoverImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton2.HoverImage")));
            this.dSkinButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinButton2.IsPureColor = false;
            this.dSkinButton2.Location = new System.Drawing.Point(267, 15);
            this.dSkinButton2.Name = "dSkinButton2";
            this.dSkinButton2.NormalImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton2.NormalImage")));
            this.dSkinButton2.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton2.PressedImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton2.PressedImage")));
            this.dSkinButton2.Radius = 0;
            this.dSkinButton2.ShowButtonBorder = false;
            this.dSkinButton2.Size = new System.Drawing.Size(17, 16);
            this.dSkinButton2.TabIndex = 12;
            this.dSkinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton2.TextInnerPadding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.dSkinButton2.TextPadding = 0;
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinLabel3.Location = new System.Drawing.Point(198, 15);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(54, 16);
            this.dSkinLabel3.TabIndex = 11;
            this.dSkinLabel3.Text = "批量下载";
            this.dSkinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinLabel3.Click += new System.EventHandler(this.dSkinLabel3_Click);
            this.dSkinLabel3.MouseEnter += new System.EventHandler(this.DynamicPathLabel_MouseEnter);
            this.dSkinLabel3.MouseLeave += new System.EventHandler(this.DynamicPathLabel_MouseLeave);
            // 
            // dSkinButton7
            // 
            this.dSkinButton7.AdaptImage = true;
            this.dSkinButton7.BackColor = System.Drawing.Color.White;
            this.dSkinButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dSkinButton7.BaseColor = System.Drawing.Color.White;
            this.dSkinButton7.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.dSkinButton7.ButtonBorderWidth = 1;
            this.dSkinButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton7.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton7.HoverImage = null;
            this.dSkinButton7.Image = global::ThunderBirdNS.Properties.Resources.home1;
            this.dSkinButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinButton7.IsPureColor = true;
            this.dSkinButton7.Location = new System.Drawing.Point(11, 13);
            this.dSkinButton7.Name = "dSkinButton7";
            this.dSkinButton7.NormalImage = null;
            this.dSkinButton7.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton7.PressedImage = null;
            this.dSkinButton7.Radius = 10;
            this.dSkinButton7.ShowButtonBorder = true;
            this.dSkinButton7.Size = new System.Drawing.Size(70, 18);
            this.dSkinButton7.TabIndex = 7;
            this.dSkinButton7.Text = "我的云盘";
            this.dSkinButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton7.TextInnerPadding = new System.Windows.Forms.Padding(17, 3, 0, 0);
            this.dSkinButton7.TextPadding = 0;
            this.dSkinButton7.Click += new System.EventHandler(this.dSkinButton7_Click);
            this.dSkinButton7.MouseEnter += new System.EventHandler(this.DynamicPathLabel_MouseEnter);
            this.dSkinButton7.MouseLeave += new System.EventHandler(this.DynamicPathLabel_MouseLeave);
            // 
            // dSkinButton6
            // 
            this.dSkinButton6.AdaptImage = true;
            this.dSkinButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinButton6.BaseColor = System.Drawing.Color.Empty;
            this.dSkinButton6.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton6.ButtonBorderWidth = 1;
            this.dSkinButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton6.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton6.HoverImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton6.HoverImage")));
            this.dSkinButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinButton6.IsPureColor = false;
            this.dSkinButton6.Location = new System.Drawing.Point(177, 15);
            this.dSkinButton6.Name = "dSkinButton6";
            this.dSkinButton6.NormalImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton6.NormalImage")));
            this.dSkinButton6.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton6.PressedImage = ((System.Drawing.Image)(resources.GetObject("dSkinButton6.PressedImage")));
            this.dSkinButton6.Radius = 0;
            this.dSkinButton6.ShowButtonBorder = false;
            this.dSkinButton6.Size = new System.Drawing.Size(16, 16);
            this.dSkinButton6.TabIndex = 4;
            this.dSkinButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton6.TextInnerPadding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.dSkinButton6.TextPadding = 0;
            // 
            // dSkinPanel3
            // 
            this.dSkinPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel3.BitmapCache = false;
            this.dSkinPanel3.Location = new System.Drawing.Point(89, 5);
            this.dSkinPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinPanel3.Name = "dSkinPanel3";
            this.dSkinPanel3.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel3.RightBottom")));
            this.dSkinPanel3.Size = new System.Drawing.Size(71, 32);
            this.dSkinPanel3.TabIndex = 3;
            this.dSkinPanel3.Text = "dSkinPanel3";
            // 
            // dSkinButton11
            // 
            this.dSkinButton11.AdaptImage = true;
            this.dSkinButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton11.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton11.ButtonBorderWidth = 1;
            this.dSkinButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton11.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton11.HoverImage = null;
            this.dSkinButton11.IsPureColor = false;
            this.dSkinButton11.Location = new System.Drawing.Point(0, 0);
            this.dSkinButton11.Name = "dSkinButton11";
            this.dSkinButton11.NormalImage = null;
            this.dSkinButton11.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton11.PressedImage = null;
            this.dSkinButton11.Radius = 10;
            this.dSkinButton11.ShowButtonBorder = true;
            this.dSkinButton11.Size = new System.Drawing.Size(100, 40);
            this.dSkinButton11.TabIndex = 0;
            this.dSkinButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton11.TextPadding = 0;
            // 
            // dSkinButton10
            // 
            this.dSkinButton10.AdaptImage = true;
            this.dSkinButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton10.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton10.ButtonBorderWidth = 1;
            this.dSkinButton10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton10.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton10.HoverImage = null;
            this.dSkinButton10.IsPureColor = false;
            this.dSkinButton10.Location = new System.Drawing.Point(0, 0);
            this.dSkinButton10.Name = "dSkinButton10";
            this.dSkinButton10.NormalImage = null;
            this.dSkinButton10.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton10.PressedImage = null;
            this.dSkinButton10.Radius = 10;
            this.dSkinButton10.ShowButtonBorder = true;
            this.dSkinButton10.Size = new System.Drawing.Size(100, 40);
            this.dSkinButton10.TabIndex = 0;
            this.dSkinButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton10.TextPadding = 0;
            // 
            // dSkinButton9
            // 
            this.dSkinButton9.AdaptImage = true;
            this.dSkinButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton9.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton9.ButtonBorderWidth = 1;
            this.dSkinButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton9.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton9.HoverImage = null;
            this.dSkinButton9.IsPureColor = false;
            this.dSkinButton9.Location = new System.Drawing.Point(0, 0);
            this.dSkinButton9.Name = "dSkinButton9";
            this.dSkinButton9.NormalImage = null;
            this.dSkinButton9.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton9.PressedImage = null;
            this.dSkinButton9.Radius = 10;
            this.dSkinButton9.ShowButtonBorder = true;
            this.dSkinButton9.Size = new System.Drawing.Size(100, 40);
            this.dSkinButton9.TabIndex = 0;
            this.dSkinButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton9.TextPadding = 0;
            // 
            // dSkinButton8
            // 
            this.dSkinButton8.AdaptImage = true;
            this.dSkinButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton8.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton8.ButtonBorderWidth = 1;
            this.dSkinButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton8.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton8.HoverImage = null;
            this.dSkinButton8.IsPureColor = false;
            this.dSkinButton8.Location = new System.Drawing.Point(0, 0);
            this.dSkinButton8.Name = "dSkinButton8";
            this.dSkinButton8.NormalImage = null;
            this.dSkinButton8.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton8.PressedImage = null;
            this.dSkinButton8.Radius = 10;
            this.dSkinButton8.ShowButtonBorder = true;
            this.dSkinButton8.Size = new System.Drawing.Size(100, 40);
            this.dSkinButton8.TabIndex = 0;
            this.dSkinButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton8.TextPadding = 0;
            // 
            // statusInfo
            // 
            this.statusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusInfo.AutoSize = false;
            this.statusInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statusInfo.ForeColor = System.Drawing.Color.Blue;
            this.statusInfo.Location = new System.Drawing.Point(23, 490);
            this.statusInfo.Margin = new System.Windows.Forms.Padding(0);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(305, 19);
            this.statusInfo.TabIndex = 3;
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusInfo.Visible = false;
            // 
            // 浏览云盘
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.dSkinGridList1);
            this.Controls.Add(this.dSkinPanel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "浏览云盘";
            this.Size = new System.Drawing.Size(350, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dSkinGridList1)).EndInit();
            this.dSkinContextMenuStrip1.ResumeLayout(false);
            this.dSkinPanel2.ResumeLayout(false);
            this.dSkinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void DynamicPathLabel_MouseLeave(object sender, EventArgs e)
        {
            var dynamicPathLabel = sender as DSkinBaseControl;
            dynamicPathLabel.ForeColor = Color.Black;
        }

        private void DynamicPathLabel_MouseEnter(object sender, EventArgs e)
        {
            var dynamicPathLabel = sender as DSkinBaseControl;
            dynamicPathLabel.ForeColor = Color.CornflowerBlue;
        }

        #endregion

        private DSkin.Controls.DSkinGridList dSkinGridList1;
        private DSkin.Controls.DSkinPanel dSkinPanel2;
        private DSkin.Controls.DSkinFlowLayoutPanel dSkinPanel3;
        private DSkin.Controls.DSkinButton dSkinButton11;
        private DSkin.Controls.DSkinButton dSkinButton10;
        private DSkin.Controls.DSkinButton dSkinButton9;
        private DSkin.Controls.DSkinButton dSkinButton8;
        private DSkin.Controls.DSkinContextMenuStrip dSkinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private DSkin.Controls.DSkinLabel statusInfo;
        private DSkin.Controls.DSkinButton dSkinButton7;
        private DSkin.Controls.DSkinButton dSkinButton2;
        private DSkin.Controls.DSkinButton dSkinButton6;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        public DSkin.Controls.DSkinLabel dSkinLabel1;
    }
}
