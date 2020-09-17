namespace ThunderBirdNS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.duiTextBox1 = new DSkin.DirectUI.DuiTextBox();
            this.duiButton1 = new DSkin.DirectUI.DuiButton();
            this.controlHost1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(353, 323);
            this.webControl1.TabIndex = 2;
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            this.webView1.ObjectForScripting = null;
            // 
            // controlHost1
            // 
            this.controlHost1.Controls.Add(this.webControl1);
            this.controlHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost1.Location = new System.Drawing.Point(0, 0);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(353, 323);
            this.controlHost1.TabIndex = 3;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dSkinPanel1.DUIControls.Add(this.duiTextBox1);
            this.dSkinPanel1.DUIControls.Add(this.duiButton1);
            this.dSkinPanel1.Location = new System.Drawing.Point(0, 323);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(353, 120);
            this.dSkinPanel1.TabIndex = 4;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // duiTextBox1
            // 
            this.duiTextBox1.AutoSize = false;
            this.duiTextBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.duiTextBox1.Borders.AllWidth = 0;
            this.duiTextBox1.Borders.BottomWidth = 0;
            this.duiTextBox1.Borders.LeftWidth = 0;
            this.duiTextBox1.Borders.RightWidth = 0;
            this.duiTextBox1.Borders.TopWidth = 0;
            this.duiTextBox1.Controls.Add(this.duiTextBox1.InnerScrollBar);
            this.duiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duiTextBox1.DesignModeCanMove = false;
            this.duiTextBox1.DesignModeCanResize = false;
            this.duiTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duiTextBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiTextBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.duiTextBox1.Location = new System.Drawing.Point(0, 0);
            this.duiTextBox1.Multiline = true;
            this.duiTextBox1.Name = "duiTextBox1";
            this.duiTextBox1.ReadOnly = true;
            this.duiTextBox1.Size = new System.Drawing.Size(353, 120);
            this.duiTextBox1.Text = "\n   若需验证登录，页面内容显示不全时，\n   可双击顶边栏，最大化窗体，方便操作！";
            // 
            // duiButton1
            // 
            this.duiButton1.AdaptImage = false;
            this.duiButton1.BaseColor = System.Drawing.Color.Thistle;
            this.duiButton1.Borders.AllWidth = 0;
            this.duiButton1.Borders.BottomWidth = 0;
            this.duiButton1.Borders.LeftWidth = 0;
            this.duiButton1.Borders.RightWidth = 0;
            this.duiButton1.Borders.TopWidth = 0;
            this.duiButton1.ButtonBorderWidth = 0;
            this.duiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duiButton1.DesignModeCanMove = false;
            this.duiButton1.DesignModeCanResize = false;
            this.duiButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.duiButton1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.duiButton1.HoverColor = System.Drawing.Color.Empty;
            this.duiButton1.Location = new System.Drawing.Point(0, 70);
            this.duiButton1.Name = "duiButton1";
            this.duiButton1.PressColor = System.Drawing.Color.Empty;
            this.duiButton1.Radius = 0;
            this.duiButton1.Size = new System.Drawing.Size(353, 50);
            this.duiButton1.Text = "登录后，若未自动跳转，请点击我！";
            this.duiButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duiButton1.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.duiButton1_MouseClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlHost1);
            this.Controls.Add(this.dSkinPanel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(353, 443);
            this.controlHost1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.DirectUI.DuiTextBox duiTextBox1;
        private DSkin.DirectUI.DuiButton duiButton1;
    }
}