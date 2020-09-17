using DSkin.Forms;
using EO.WebBrowser;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThunderBirdNS
{
    public partial class WebUI : DSkinForm
    {
        private static WebUI instance = null;
        public static WebUI Instance {
            get {
                if (instance==null|| instance.IsDisposed|| instance.webControl1.IsDisposed) {
                    instance = new WebUI(); 
                }
                return instance;
            }
        }

        public string Title {
            set {
                dSkinLabel1.Text = value;
            }
        }

        public string Url
        {
            set
            {
                webControl1.WebView.Url = value;
            }
        }

        public WebUI()
        {
            InitializeComponent();

            webControl1.WebView.CertificateError += WebView_CertificateError;
            webControl1.WebView.LoadCompleted += WebView_LoadCompleted;
            webControl1.WebView.NewWindow += delegate (object s1, NewWindowEventArgs arg1)
            {
                webControl1.WebView.LoadUrl(arg1.TargetUrl);
            };
        }

        private void WebView_CertificateError(object sender, CertificateErrorEventArgs e)
        {
            e.Continue();
        }

        private void WebView_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    string js = string.Format(@"window.scrollTo({0},{1});", Pos.X, Pos.Y);
                    if (!OverflowVisible)
                    {
                        js += @"document.documentElement.style.overflowX = 'hidden';";
                        js += @"document.documentElement.style.overflowY = 'hidden';";
                    }
                    webControl1.WebView.EvalScript(js);//显示固定区域，隐藏滚动条。
                }));
            }
            catch (Exception)
            { }
        }

        private void WebUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            webControl1.WebView.Dispose();
            webControl1.Dispose();
        }

        public void SetSize(int v1, int v2)
        {
            this.Width = v1;
            this.Height = v2;
        }

        private Point Pos = new Point(0, 0);
        private bool OverflowVisible = true;
        public void SetSize(int v1, int v2,Point pos,bool overflowVisible=false)
        {
            this.Width = v1;
            this.Height = v2;
            Pos = pos;
            OverflowVisible = overflowVisible;
        }

        private void WebUI_Resize(object sender, EventArgs e)
        {
            //this.Text = string.Format("宽：{0}，高:{1}", this.Width, this.Height);
        }
    }
}
