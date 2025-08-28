namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    partial class VParaTextBox
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
            lblUnit = new Label();
            lblValue = new Label();
            SuspendLayout();
            // 
            // lblUnit
            // 
            lblUnit.Dock = DockStyle.Bottom;
            lblUnit.ForeColor = Color.FromArgb(224, 224, 224);
            lblUnit.Location = new Point(0, 45);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(85, 33);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "温度(℃)";
            lblUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValue
            // 
            lblValue.Dock = DockStyle.Fill;
            lblValue.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValue.ForeColor = Color.MediumTurquoise;
            lblValue.Location = new Point(0, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(85, 45);
            lblValue.TabIndex = 0;
            lblValue.Text = "24.5";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VParaTextBox
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.DarkSlateGray;
            Controls.Add(lblValue);
            Controls.Add(lblUnit);
            Name = "VParaTextBox";
            Size = new Size(85, 78);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUnit;
        private Label lblValue;
    }
}
