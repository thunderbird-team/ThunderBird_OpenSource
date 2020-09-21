using DSkin.Controls;
using DSkin.DirectUI;
using EO.WebBrowser;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ThunderBirdNS
{
    public partial class Login : DSkinUserControl
    {
        private string loginUrl = @"https://passport.baidu.com/v2/?login&u=https://pan.baidu.com/disk/home";

        public Login()
        {
            InitializeComponent();

            webControl1.WebView.CertificateError += WebView_CertificateError;
            webControl1.WebView.LoadUrl(loginUrl);
            webControl1.WebView.NewWindow += delegate (object s1, NewWindowEventArgs arg1)
            {
                webControl1.WebView.LoadUrl(arg1.TargetUrl);
            };

            duiButton1.MouseClick += DuiButton1_MouseClick;
        }

        private void DuiButton1_MouseClick(object sender, DuiMouseEventArgs e)
        {
            MessageBox.Show("源码释放的目的是让所有人清楚地看到在雷鸟下载中，引发360等安全软件告警的是哪些操作，其后的源码是什么样的，以解除大家的困扰。\n你们可以看到，编译后的exe在单独执行时（非VS开发环境下），360会对其警告提示，甚至偶尔极端情况下，直接提示木马病毒，要求清除掉，但其实后台代码啥都没做！这就是所谓的安全软件干的勾当！\n出于安全保护的考虑，下载功能实现部分的源码未做放出，相信大家可以理解。");
        }

        private void WebView_CertificateError(object sender, CertificateErrorEventArgs e)
        {
            e.Continue();
        }

        private void duiButton1_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            webControl1.WebView.LoadUrl(loginUrl);
            Thread.Sleep(2000);
        }
    }
}
