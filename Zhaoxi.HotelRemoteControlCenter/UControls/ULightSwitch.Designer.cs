namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    partial class ULightSwitch
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
            uPanel1 = new UPanel();
            panelLight = new Panel();
            cirStrong = new UCircle();
            cirMiddle = new UCircle();
            cirWeak = new UCircle();
            swLight = new USquareSwitch();
            uPanel1.SuspendLayout();
            panelLight.SuspendLayout();
            SuspendLayout();
            // 
            // uPanel1
            // 
            uPanel1.BgColor = Color.FromArgb(39, 52, 61);
            uPanel1.BgColor2 = Color.Transparent;
            uPanel1.BorderWidth = 1;
            uPanel1.Controls.Add(panelLight);
            uPanel1.Controls.Add(swLight);
            uPanel1.Dock = DockStyle.Fill;
            uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel1.Location = new Point(0, 0);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 5;
            uPanel1.Size = new Size(256, 50);
            uPanel1.TabIndex = 0;
            // 
            // panelLight
            // 
            panelLight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLight.BackColor = Color.Transparent;
            panelLight.Controls.Add(cirStrong);
            panelLight.Controls.Add(cirMiddle);
            panelLight.Controls.Add(cirWeak);
            panelLight.Location = new Point(127, 8);
            panelLight.Name = "panelLight";
            panelLight.Size = new Size(121, 38);
            panelLight.TabIndex = 3;
            // 
            // cirStrong
            // 
            cirStrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cirStrong.BackColor = Color.Transparent;
            cirStrong.BorderColor = Color.FromArgb(255, 128, 0);
            cirStrong.ForeColor = Color.Blue;
            cirStrong.Location = new Point(86, 5);
            cirStrong.Name = "cirStrong";
            cirStrong.Size = new Size(27, 27);
            cirStrong.TabIndex = 2;
            cirStrong.Click += cirStrong_Click;
            // 
            // cirMiddle
            // 
            cirMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cirMiddle.BackColor = Color.Transparent;
            cirMiddle.BorderColor = Color.FromArgb(255, 128, 0);
            cirMiddle.ForeColor = Color.RoyalBlue;
            cirMiddle.Location = new Point(48, 5);
            cirMiddle.Name = "cirMiddle";
            cirMiddle.Size = new Size(27, 27);
            cirMiddle.TabIndex = 2;
            cirMiddle.Click += cirMiddle_Click;
            // 
            // cirWeak
            // 
            cirWeak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cirWeak.BackColor = Color.Transparent;
            cirWeak.BorderColor = Color.FromArgb(255, 128, 0);
            cirWeak.BorderWidth = 2;
            cirWeak.ForeColor = Color.CornflowerBlue;
            cirWeak.Location = new Point(7, 5);
            cirWeak.Name = "cirWeak";
            cirWeak.Size = new Size(27, 27);
            cirWeak.TabIndex = 2;
            cirWeak.Click += cirWeak_Click;
            // 
            // swLight
            // 
            swLight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            swLight.BackColor = Color.Transparent;
            swLight.Checked = true;
            swLight.Location = new Point(7, 8);
            swLight.Name = "swLight";
            swLight.Size = new Size(100, 35);
            swLight.StateTexts = new string[] { "开", "关" };
            swLight.TabIndex = 2;
            swLight.TrueColor = Color.Green;
            swLight.CheckedChanged += swLight_CheckedChanged;
            // 
            // ULightSwitch
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(uPanel1);
            Name = "ULightSwitch";
            Size = new Size(256, 50);
            uPanel1.ResumeLayout(false);
            panelLight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UPanel uPanel1;
        private Panel panelLight;
        private UCircle cirStrong;
        private UCircle cirMiddle;
        private UCircle cirWeak;
        private USquareSwitch swLight;
    }
}
