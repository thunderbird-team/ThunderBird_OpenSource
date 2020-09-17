using DotNet.Utilities;
using DSkin.Common;
using DSkin.DirectUI;
using DSkin.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace ThunderBirdNS
{
    public partial class Main : FrmBase
    {
        public static int Version = 100;
        public static string VersionString = @"1.0.0";

        private SystemButton systemButton1 = new SystemButton() { Size = new Size(28, 18) };

        public static Main Instance { set; get; }

        public Main()
        {
            if (!IsAdministrator())
            {
                System.Windows.Forms.MessageBox.Show("为保证高速下载时，能顺利读写磁盘缓存，请右键以管理员身份运行软件！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            ServicePointManager.DefaultConnectionLimit = 1000;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            EO.WebBrowser.Runtime.AddLicense(@"Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP");
            EO.Base.Runtime.Exception += Runtime_Exception;

            InitializeComponent();
            Instance = this;
            JustFormPosition();

            IniInfoSystemButton();
        }

        private void JustFormPosition()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width - 50;
            int y = (Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height) / 2;
            this.SetDesktopLocation(x, y);
        }

        private void BuildVersionInfo()
        {
            string v = Application.ProductVersion;
            v = v.Substring(0, 5);
            Version =int.Parse(v.Replace(".",""));
            VersionString = "v" + v;
        }

        private void Runtime_Exception(object sender, EO.Base.ExceptionEventArgs e)
        {
            //do nothing!
        }
        private void IniInfoSystemButton()
        {
            this.SystemButtons.Add(systemButton1);
            drawDefaultIcon();
            systemButton1.MouseClick += SystemButtonInfo_MouseClick;
        }

        void InnerDuiControl_MouseDown(object sender, DuiMouseEventArgs e)
        {
            DSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region 云盘界面
            var uc = new CloudDiskUI() { Dock = DockStyle.Fill };
            dSkinTabPage1.Controls.Add(uc);
            #endregion

            #region 皮肤相关
            //皮肤列表
            for (int skinI = 0; skinI < 6; skinI++)
            {
                Image btn = Image.FromFile(Application.StartupPath + "//skin//skin_button//skin_button" + skinI + ".png");
                LbSkinItem item = new LbSkinItem(btn);
                item.Tag = skinI;
                LbSkin.Items.Add(item);
            }
            //初始化皮肤配置
            string SkinIndex = ConfigHelper.ReadAppConfig("SkinIndex");
            string SkinVista = ConfigHelper.ReadAppConfig("SkinVista");
            string SkinVistaValue = ConfigHelper.ReadAppConfig("SkinVistaValue");
            if (!string.IsNullOrEmpty(SkinIndex))
            {
                LbSkin.Items[Convert.ToInt32(SkinIndex)].IsSelected = true;
            }
            else
            {
                LbSkin.Items[0].IsSelected = true;
            }
            if (!string.IsNullOrEmpty(SkinVista))
            {
                chkSkinVista.Checked = SkinVista == "1";
                //是否启用Vista
                ChkVista(chkSkinVista.Checked);
            }
            if (!string.IsNullOrEmpty(SkinVistaValue))
            {
                tbVista.Value = Convert.ToInt32(SkinVistaValue);
            }
            #endregion

            BuildVersionInfo();
        }

        private void SystemButtonInfo_MouseClick(object sender, DSkin.Forms.SystemButtonMouseClickEventArgs e)
        {
            drawDefaultIcon();//通知图标复位
        }

        private void dSkinButton1_MouseDown(object sender, MouseEventArgs e)
        {
            DSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void dSkinPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            DSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        public static bool toExit = false;
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            toExit = true;
            Application.Exit();
        }

        #region 窗体事件

        #region 窗体焦点丢失时
        private void FrmMain_Leave(object sender, EventArgs e)
        {
            //隐藏皮肤小窗
            PnlSkin.Visible = false;
        }
        #endregion

        #region 窗体被停用时
        private void FrmMain_Deactivate(object sender, EventArgs e)
        {
            //隐藏皮肤小窗
            PnlSkin.Visible = false;
        }
        #endregion

        #region 窗体被点击时
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            //隐藏皮肤小窗
            PnlSkin.Visible = false;
        }
        #endregion
        #endregion

        #region 皮肤设置模块
        #region 皮肤按钮事件
        private void btnSkin_Click(object sender, EventArgs e)
        {
            PnlSkin.Visible = !PnlSkin.Visible;
            PnlSkin.Focus();
        }
        #endregion

        #region 是否启用Vista效果
        private void chkSkinVista_Click(object sender, EventArgs e)
        {
            //是否启用Vista
            ChkVista(!chkSkinVista.Checked);
            //保存皮肤参数
            SaveSkinCookie();
        }

        /// <summary>
        /// 是否启用Vista
        /// </summary>
        /// <param name="isOpen"></param>
        private void ChkVista(bool isOpen)
        {
            //启用Vista
            if (isOpen)
            {
                tbVista.BackgroundImage = ThunderBirdNS.Properties.Resources.slider_normal;
                tbVista.Enabled = true;
                this.EnabledDWM = true;
                SetBackTmd(tbVista.Value);
            }
            else
            {
                //关闭Vista
                tbVista.BackgroundImage = ThunderBirdNS.Properties.Resources.slider_disable;
                tbVista.Enabled = false;
                this.EnabledDWM = false;
                SetBackTmd(1);
            }
        }
        #endregion

        #region 皮肤小窗失去焦点时
        private void PnlSkin_Leave(object sender, EventArgs e)
        {
            PnlSkin.Visible = false;
        }
        #endregion

        #region 设置Vista透明度
        private void tbVista_ValueChanged(object sender, EventArgs e)
        {
            SetBackTmd(tbVista.Value);
            //保存皮肤参数
            SaveSkinCookie();
        }

        /// <summary>
        /// 设置背景透明度
        /// </summary>
        /// <param name="value"></param>
        private void SetBackTmd(int value)
        {
            LbSkinItem item = (LbSkinItem)LbSkin.SelectedItem;
            if (item.Tag.ToString() == "0")
            {
                this.BackColor = Color.FromArgb(256 - value, this.BackColor);
            }
            else
            {
                Bitmap bk = (Bitmap)Image.FromFile(Application.StartupPath + "//skin//skin_bk//skin_bk_" + item.Tag + ".jpg");
                this.BackColor = Color.FromArgb(256 - value, this.BackColor);
                this.BackgroundImage = PTransparentAdjust(bk, 256 - value);
            }
        }
        #endregion

        #region 定义图像透明度调整函数
        //定义图像透明度调整函数
        public Bitmap PTransparentAdjust(Bitmap src, int num)
        {
            try
            {
                int w = src.Width;
                int h = src.Height;
                Bitmap dstBitmap = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                System.Drawing.Imaging.BitmapData srcData = src.LockBits(new Rectangle(0, 0, w, h), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                System.Drawing.Imaging.BitmapData dstData = dstBitmap.LockBits(new Rectangle(0, 0, w, h), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                unsafe
                {
                    byte* pIn = (byte*)srcData.Scan0.ToPointer();
                    byte* pOut = (byte*)dstData.Scan0.ToPointer();
                    byte* p;
                    int stride = srcData.Stride;
                    int r, g, b;
                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            p = pIn;
                            b = pIn[0];
                            g = pIn[1];
                            r = pIn[2];
                            pOut[1] = (byte)g;
                            pOut[2] = (byte)r;
                            pOut[3] = (byte)num;
                            pOut[0] = (byte)b;
                            pIn += 4;
                            pOut += 4;
                        }
                        pIn += srcData.Stride - w * 4;
                        pOut += srcData.Stride - w * 4;
                    }
                    src.UnlockBits(srcData);
                    dstBitmap.UnlockBits(dstData);
                    return dstBitmap;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion

        #region 选中图片事件
        private void LbSkin_ItemSelectedChanged(object sender, DSkin.DirectUI.DuiControlEventArgs e)
        {
            LbSkinItem item = (LbSkinItem)e.Control;
            Bitmap bk = (Bitmap)Image.FromFile(Application.StartupPath + "//skin//skin_bk//skin_bk_" + item.Tag + ".jpg");
            if (bk.Size.Width == 40)
            {
                Color bc = BitmapHelper.GetImageAverageColor(bk);
                if (chkSkinVista.Checked)
                {
                    this.BackColor = Color.FromArgb(256 - tbVista.Value, bc);
                }
                else
                {
                    this.BackColor = bc;
                }
                this.BackgroundImage = null;
            }
            else
            {
                if (chkSkinVista.Checked)
                {
                    this.BackgroundImage = PTransparentAdjust(bk, 256 - tbVista.Value);
                    Color bc = BitmapHelper.GetImageAverageColor(this.BackgroundImage);
                    this.BackColor = Color.FromArgb(256 - tbVista.Value, bc);
                }
                else
                {
                    this.BackgroundImage = bk;
                    Color bc = BitmapHelper.GetImageAverageColor(this.BackgroundImage);
                    this.BackColor = bc;
                }
            }
            //保存皮肤参数
            SaveSkinCookie();
        }
        #endregion

        #region 保存皮肤参数
        private void SaveSkinCookie()
        {
            try
            {
                if (LbSkin.SelectedItems.Length > 0)
                {
                    LbSkinItem item = (LbSkinItem)LbSkin.SelectedItems[0];
                    ConfigHelper.UpdateAppConfig("SkinIndex", item.Tag.ToString());
                    ConfigHelper.UpdateAppConfig("SkinVista", chkSkinVista.Checked ? "1" : "0");
                    ConfigHelper.UpdateAppConfig("SkinVistaValue", tbVista.Value.ToString());
                }
            }
            catch (Exception)
            { }
        }
        #endregion

        #region 背景色变换时
        private void FrmMain_BackColorChanged(object sender, EventArgs e)
        {
            //悬浮笔刷重置
            HoverBackBrush.Colors[0].Color = Color.FromArgb(25, this.BackColor);
            HoverBackBrush.Colors[1].Color = Color.FromArgb(50, this.BackColor);
            HoverBackBrush.Width = 72;
            HoverBackBrush.Width = 73;
            //选中笔刷重置
            DownBackBrush.Colors[0].Color = Color.FromArgb(50, this.BackColor);
            DownBackBrush.Colors[1].Color = Color.FromArgb(100, this.BackColor);
            DownBackBrush.Width = 72;
            DownBackBrush.Width = 73;
        }
        #endregion

        #endregion

        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            HelpButton_Click(null, null);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            WebUI v = new WebUI();
            v.Width = 1024;
            v.Height = 768;
            v.Url = @"https://www.kancloud.cn/myzfb/thunderbird/1684667";
            v.StartPosition = FormStartPosition.CenterScreen;
            v.ShowDialog();
        }

        #region 消息通知
        private void drawNewMsgIcon()
        {
            systemButton1.NormalImage = ((Image)(ThunderBirdNS.Properties.Resources.msgRedHoverImage));
            systemButton1.HoverImage = ((Image)(ThunderBirdNS.Properties.Resources.msgRedHoverImage));
            systemButton1.PressImage = ((Image)(ThunderBirdNS.Properties.Resources.msgRedPressImage));
        }
        private void drawDefaultIcon()
        {
            systemButton1.NormalImage = ((Image)(ThunderBirdNS.Properties.Resources.msgHoverImage));
            systemButton1.HoverImage = ((Image)(ThunderBirdNS.Properties.Resources.msgHoverImage));
            systemButton1.PressImage = ((Image)(ThunderBirdNS.Properties.Resources.msgPressImage));
        }
        #endregion

        public static bool IsAdministrator()
        {
            try
            {
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
