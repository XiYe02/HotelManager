namespace Zhaoxi.HotelRemoteControlCenter
{
    partial class FrmConfig
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtSlot = new TextBox();
            txtRack = new TextBox();
            txtPort = new TextBox();
            txtIp = new TextBox();
            cboCpuTypes = new ComboBox();
            cboBuildings = new ComboBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            cboRooms = new ComboBox();
            txtDataAddrs = new TextBox();
            txtStateAddrs = new TextBox();
            btnImport = new UControls.CircleButton();
            btnPLCSave = new UControls.CircleButton();
            btnRoomSet = new UControls.CircleButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSlot);
            groupBox1.Controls.Add(txtRack);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIp);
            groupBox1.Controls.Add(cboCpuTypes);
            groupBox1.Controls.Add(cboBuildings);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(63, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 429);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PLC通信设置";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 345);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 3;
            label5.Text = "插槽";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 287);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 4;
            label4.Text = "机架";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 225);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "端口";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 170);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "IP地址";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 7;
            label1.Text = "Cpu类型";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 55);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 2;
            label11.Text = "楼栋";
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(117, 342);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(216, 27);
            txtSlot.TabIndex = 5;
            // 
            // txtRack
            // 
            txtRack.Location = new Point(117, 283);
            txtRack.Name = "txtRack";
            txtRack.Size = new Size(216, 27);
            txtRack.TabIndex = 4;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(117, 222);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(216, 27);
            txtPort.TabIndex = 3;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(117, 166);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(216, 27);
            txtIp.TabIndex = 2;
            // 
            // cboCpuTypes
            // 
            cboCpuTypes.FormattingEnabled = true;
            cboCpuTypes.Items.AddRange(new object[] { "S71500", "S71200" });
            cboCpuTypes.Location = new Point(117, 109);
            cboCpuTypes.Name = "cboCpuTypes";
            cboCpuTypes.Size = new Size(212, 28);
            cboCpuTypes.TabIndex = 1;
            // 
            // cboBuildings
            // 
            cboBuildings.FormattingEnabled = true;
            cboBuildings.Items.AddRange(new object[] { "01栋", "02栋", "03栋", "04栋" });
            cboBuildings.Location = new Point(117, 53);
            cboBuildings.Name = "cboBuildings";
            cboBuildings.Size = new Size(212, 28);
            cboBuildings.TabIndex = 0;
            cboBuildings.SelectedIndexChanged += cboBuildings_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboRooms);
            groupBox2.Controls.Add(txtDataAddrs);
            groupBox2.Controls.Add(txtStateAddrs);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(529, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(697, 420);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "房间参数配置";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(128, 185);
            label8.Name = "label8";
            label8.Size = new Size(430, 40);
            label8.TabIndex = 5;
            label8.Text = "数据地址按设置温度、房间温度、湿度、CO2含量、灯光强度值\r\n地址顺序输入)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(126, 108);
            label7.Name = "label7";
            label7.Size = new Size(349, 20);
            label7.TabIndex = 6;
            label7.Text = "(状态地址按电源、风机、灯光、房间状态顺序输入)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 234);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 2;
            label6.Text = "数据地址";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 139);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 3;
            label9.Text = "状态地址";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 47);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 4;
            label10.Text = "房间";
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(125, 44);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(232, 28);
            cboRooms.TabIndex = 6;
            cboRooms.SelectedIndexChanged += cboRooms_SelectedIndexChanged;
            // 
            // txtDataAddrs
            // 
            txtDataAddrs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDataAddrs.Location = new Point(125, 230);
            txtDataAddrs.Multiline = true;
            txtDataAddrs.Name = "txtDataAddrs";
            txtDataAddrs.Size = new Size(520, 130);
            txtDataAddrs.TabIndex = 8;
            // 
            // txtStateAddrs
            // 
            txtStateAddrs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStateAddrs.Location = new Point(125, 135);
            txtStateAddrs.Name = "txtStateAddrs";
            txtStateAddrs.Size = new Size(520, 27);
            txtStateAddrs.TabIndex = 7;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BgColor = Color.White;
            btnImport.BgColor2 = Color.Transparent;
            btnImport.BorderWidth = 1;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnImport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.ForeColor = Color.FromArgb(64, 64, 64);
            btnImport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnImport.Location = new Point(1093, 36);
            btnImport.Name = "btnImport";
            btnImport.Radius = 3;
            btnImport.SelectedColor = Color.SteelBlue;
            btnImport.Size = new Size(133, 36);
            btnImport.TabIndex = 1;
            btnImport.Text = "参数配置导入";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnPLCSave
            // 
            btnPLCSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPLCSave.BgColor = Color.White;
            btnPLCSave.BgColor2 = Color.Transparent;
            btnPLCSave.BorderWidth = 1;
            btnPLCSave.FlatAppearance.BorderSize = 0;
            btnPLCSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPLCSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPLCSave.FlatStyle = FlatStyle.Flat;
            btnPLCSave.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPLCSave.ForeColor = Color.FromArgb(64, 64, 64);
            btnPLCSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnPLCSave.Location = new Point(180, 529);
            btnPLCSave.Name = "btnPLCSave";
            btnPLCSave.Radius = 3;
            btnPLCSave.SelectedColor = Color.SteelBlue;
            btnPLCSave.Size = new Size(76, 36);
            btnPLCSave.TabIndex = 1;
            btnPLCSave.Text = "确定";
            btnPLCSave.UseVisualStyleBackColor = true;
            btnPLCSave.Click += btnPLCSave_Click;
            // 
            // btnRoomSet
            // 
            btnRoomSet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRoomSet.BgColor = Color.White;
            btnRoomSet.BgColor2 = Color.Transparent;
            btnRoomSet.BorderWidth = 1;
            btnRoomSet.FlatAppearance.BorderSize = 0;
            btnRoomSet.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRoomSet.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRoomSet.FlatStyle = FlatStyle.Flat;
            btnRoomSet.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoomSet.ForeColor = Color.FromArgb(64, 64, 64);
            btnRoomSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnRoomSet.Location = new Point(716, 529);
            btnRoomSet.Name = "btnRoomSet";
            btnRoomSet.Radius = 3;
            btnRoomSet.SelectedColor = Color.SteelBlue;
            btnRoomSet.Size = new Size(76, 36);
            btnRoomSet.TabIndex = 1;
            btnRoomSet.Text = "确定";
            btnRoomSet.UseVisualStyleBackColor = true;
            btnRoomSet.Click += btnRoomSet_Click;
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 52, 61);
            ClientSize = new Size(1291, 617);
            Controls.Add(btnRoomSet);
            Controls.Add(btnPLCSave);
            Controls.Add(btnImport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmConfig";
            ShowIcon = false;
            Text = "系统配置";
            Load += FrmConfig_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private UControls.CircleButton btnImport;
        private UControls.CircleButton btnPLCSave;
        private UControls.CircleButton btnRoomSet;
        private ComboBox cboBuildings;
        private ComboBox cboCpuTypes;
        private ComboBox cboRooms;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private TextBox txtSlot;
        private TextBox txtRack;
        private TextBox txtPort;
        private TextBox txtIp;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox txtDataAddrs;
        private TextBox txtStateAddrs;
        private Label label8;
        private Label label7;
    }
}