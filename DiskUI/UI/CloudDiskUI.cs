using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DSkin.Controls;

namespace ThunderBirdNS
{
    public partial class CloudDiskUI : DSkinUserControl
    {
        private List<object> curGridListObjs = new List<object>();  
        public CloudDiskUI()
        {
            InitializeComponent();

            IniColumns();
            dSkinGridList1.Columns[0].CellTemplate = typeof(IconCellTemplate);
            dSkinGridList1.Columns[2].CellTemplate = typeof(Way1CellTemplate);
        }

        private void IniColumns()
        {
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn11 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn12 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn13 = new DSkin.Controls.DSkinGridListColumn();

            dSkinGridListColumn11.DataPropertyName = "entry";
            dSkinGridListColumn11.DockStyle = System.Windows.Forms.DockStyle.Fill;
            dSkinGridListColumn11.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn11.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn11.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn11.Item.Location = new System.Drawing.Point(288, 0);
            dSkinGridListColumn11.Item.Name = "";
            dSkinGridListColumn11.Item.Size = new System.Drawing.Size(288, 30);
            dSkinGridListColumn11.Item.Tag = dSkinGridListColumn11;
            dSkinGridListColumn11.Item.Text = " 名称";
            dSkinGridListColumn11.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dSkinGridListColumn11.Name = "名称";
            dSkinGridListColumn11.Visble = true;
            dSkinGridListColumn11.Width = 220;

            dSkinGridListColumn12.DataPropertyName = "size";
            dSkinGridListColumn12.DockStyle = System.Windows.Forms.DockStyle.Left;
            dSkinGridListColumn12.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn12.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn12.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn12.Item.Location = new System.Drawing.Point(432, 0);
            dSkinGridListColumn12.Item.Name = "";
            dSkinGridListColumn12.Item.Size = new System.Drawing.Size(72, 30);
            dSkinGridListColumn12.Item.Tag = dSkinGridListColumn12;
            dSkinGridListColumn12.Item.Text = " 大小";
            dSkinGridListColumn12.Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dSkinGridListColumn12.Name = "大小";
            dSkinGridListColumn12.Visble = true;
            dSkinGridListColumn12.Width = 72;

            dSkinGridListColumn13.DataPropertyName = "way1";
            dSkinGridListColumn13.DockStyle = System.Windows.Forms.DockStyle.Left;
            dSkinGridListColumn13.Item.Font = new System.Drawing.Font("微软雅黑", 9F);
            dSkinGridListColumn13.Item.ForeColor = System.Drawing.Color.Black;
            dSkinGridListColumn13.Item.InheritanceSize = new System.Drawing.SizeF(0F, 1F);
            dSkinGridListColumn13.Item.Location = new System.Drawing.Point(576, 0);
            dSkinGridListColumn13.Item.Name = "";
            dSkinGridListColumn13.Item.Size = new System.Drawing.Size(72, 30);
            dSkinGridListColumn13.Item.Tag = dSkinGridListColumn13;
            dSkinGridListColumn13.Item.Text = " 下载";
            dSkinGridListColumn13.Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dSkinGridListColumn13.Name = "下载";
            dSkinGridListColumn13.Visble = true;
            dSkinGridListColumn13.Width = 60;

            this.dSkinGridList1.Columns.AddRange(new DSkin.Controls.DSkinGridListColumn[] {
            dSkinGridListColumn11,
            dSkinGridListColumn12,
            dSkinGridListColumn13
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadRootView();
        }

        public void LoadRootView()
        {
            loadToListView();
        }

        public void loadToListView()
        {
            dSkinGridList1.DataSource = curGridListObjs;
            dSkinGridList1.LayoutContent();
        }

        public void loadToListView(string path)
        {
           
        }

        private void dSkinGridList1_ItemClick(object sender, DSkinGridListMouseEventArgs e)
        {
        }

        private void dSkinButton7_Click(object sender, EventArgs e)
        {
            LoadRootView();
        }

        private void dSkinButton3_Click(object sender, EventArgs e)
        {

        }

        private void dSkinGridList1_ItemClick_1(object sender, DSkinGridListMouseEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //单行模式响应
        }

        private void dSkinLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dSkinLabel1_Click(object sender, EventArgs e)
        {
            Main.Instance.dSkinTabPage3.Controls.Clear();
            var uc = new Login() { Dock = DockStyle.Fill };
            Main.Instance.dSkinTabPage3.Controls.Add(uc);
            Main.Instance.TL容器.SelectedTab = Main.Instance.dSkinTabPage3;
        }
    }
}
