namespace ThunderBirdNS
{
    partial class WebUI
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
            this.components = new System.ComponentModel.Container();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.controlHost1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(345, 405);
            this.webControl1.TabIndex = 2;
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.ObjectForScripting = null;
            // 
            // controlHost1
            // 
            this.controlHost1.Controls.Add(this.webControl1);
            this.controlHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost1.Location = new System.Drawing.Point(4, 34);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(345, 405);
            this.controlHost1.TabIndex = 3;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(137, 4);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(2, 22);
            this.dSkinLabel1.TabIndex = 5;
            this.dSkinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WebUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(353, 443);
            this.Controls.Add(this.dSkinLabel1);
            this.Controls.Add(this.controlHost1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebUI";
            this.Radius = 20;
            this.ShowShadow = true;
            this.Text = "";
            this.toolTip1.SetToolTip(this, "双击可放大窗体显示");
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebUI_FormClosed);
            this.Resize += new System.EventHandler(this.WebUI_Resize);
            this.controlHost1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}