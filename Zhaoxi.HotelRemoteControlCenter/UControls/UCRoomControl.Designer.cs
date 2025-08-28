namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    partial class UCRoomControl
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
            panelRoom = new UPanel();
            txtCO2 = new VParaTextBox();
            txtHumidity = new VParaTextBox();
            txtTemperature = new VParaTextBox();
            label4 = new Label();
            lblPowerState = new Label();
            lblRoomState = new Label();
            lblRoomNo = new Label();
            panelRoom.SuspendLayout();
            SuspendLayout();
            // 
            // panelRoom
            // 
            panelRoom.BgColor = Color.DarkSlateGray;
            panelRoom.BgColor2 = Color.Transparent;
            panelRoom.BorderColor = Color.SlateGray;
            panelRoom.BorderWidth = 1;
            panelRoom.Controls.Add(txtCO2);
            panelRoom.Controls.Add(txtHumidity);
            panelRoom.Controls.Add(txtTemperature);
            panelRoom.Controls.Add(label4);
            panelRoom.Controls.Add(lblPowerState);
            panelRoom.Controls.Add(lblRoomState);
            panelRoom.Controls.Add(lblRoomNo);
            panelRoom.Dock = DockStyle.Fill;
            panelRoom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            panelRoom.Location = new Point(0, 0);
            panelRoom.Name = "panelRoom";
            panelRoom.Radius = 5;
            panelRoom.Size = new Size(165, 160);
            panelRoom.TabIndex = 0;
            panelRoom.Click += panelRoom_Click;
            // 
            // txtCO2
            // 
            txtCO2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtCO2.BackColor = Color.Transparent;
            txtCO2.DecimalCount = 0;
            txtCO2.Location = new Point(82, 97);
            txtCO2.Name = "txtCO2";
            txtCO2.Size = new Size(80, 57);
            txtCO2.TabIndex = 2;
            txtCO2.UnitFColor = Color.FromArgb(224, 224, 224);
            txtCO2.UnitFont = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCO2.UnitNote = "CO2(ppm)";
            txtCO2.Value = new decimal(new int[] { 400, 0, 0, 0 });
            txtCO2.ValueFColor = Color.MediumTurquoise;
            txtCO2.ValueFont = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtHumidity
            // 
            txtHumidity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtHumidity.BackColor = Color.Transparent;
            txtHumidity.DecimalCount = 0;
            txtHumidity.Location = new Point(7, 97);
            txtHumidity.Name = "txtHumidity";
            txtHumidity.Size = new Size(69, 57);
            txtHumidity.TabIndex = 2;
            txtHumidity.UnitFColor = Color.FromArgb(224, 224, 224);
            txtHumidity.UnitFont = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtHumidity.UnitNote = "湿度(%)";
            txtHumidity.Value = new decimal(new int[] { 45, 0, 0, 0 });
            txtHumidity.ValueFColor = Color.MediumTurquoise;
            txtHumidity.ValueFont = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtTemperature
            // 
            txtTemperature.BackColor = Color.Transparent;
            txtTemperature.DecimalCount = 1;
            txtTemperature.Location = new Point(7, 38);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(69, 57);
            txtTemperature.TabIndex = 2;
            txtTemperature.UnitFColor = Color.FromArgb(224, 224, 224);
            txtTemperature.UnitFont = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTemperature.UnitNote = "温度(℃)";
            txtTemperature.Value = new decimal(new int[] { 245, 0, 0, 65536 });
            txtTemperature.ValueFColor = Color.MediumTurquoise;
            txtTemperature.ValueFont = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(106, 70);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 1;
            label4.Text = "电源";
            // 
            // lblPowerState
            // 
            lblPowerState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPowerState.AutoSize = true;
            lblPowerState.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPowerState.ForeColor = Color.Brown;
            lblPowerState.Location = new Point(100, 45);
            lblPowerState.Name = "lblPowerState";
            lblPowerState.Size = new Size(54, 19);
            lblPowerState.TabIndex = 1;
            lblPowerState.Text = "已断电";
            // 
            // lblRoomState
            // 
            lblRoomState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRoomState.AutoSize = true;
            lblRoomState.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomState.ForeColor = Color.Red;
            lblRoomState.Location = new Point(101, 10);
            lblRoomState.Name = "lblRoomState";
            lblRoomState.Size = new Size(54, 19);
            lblRoomState.TabIndex = 1;
            lblRoomState.Text = "已入住";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNo.ForeColor = Color.White;
            lblRoomNo.Location = new Point(7, 6);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(81, 27);
            lblRoomNo.TabIndex = 0;
            lblRoomNo.Text = "01-101";
            lblRoomNo.Click += lblRoomNo_Click;
            // 
            // UCRoomControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Transparent;
            Controls.Add(panelRoom);
            Name = "UCRoomControl";
            Size = new Size(165, 160);
            panelRoom.ResumeLayout(false);
            panelRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UPanel panelRoom;
        private Label lblRoomState;
        private Label lblRoomNo;
        private VParaTextBox txtCO2;
        private VParaTextBox txtHumidity;
        private VParaTextBox txtTemperature;
        private Label label4;
        private Label lblPowerState;
    }
}
