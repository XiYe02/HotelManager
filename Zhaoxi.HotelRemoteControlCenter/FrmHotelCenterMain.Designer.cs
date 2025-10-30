namespace Zhaoxi.HotelRemoteControlCenter
{
    partial class FrmHotelCenterMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHotelCenterMain));
            panelTop = new Panel();
            btnConfig = new UControls.CircleButton();
            btnRooms = new UControls.CircleButton();
            lblTime = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnMax = new Button();
            btnMin = new Button();
            uPanel1 = new UControls.UPanel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            numRate = new UControls.UNumericBox();
            numUnCount = new UControls.UNumericBox();
            numHasCount = new UControls.UNumericBox();
            numTotalCount = new UControls.UNumericBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            uPanel2 = new UControls.UPanel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            numBuildingRate = new UControls.UNumericBox();
            numBuildingUnCount = new UControls.UNumericBox();
            numBuildingHasCount = new UControls.UNumericBox();
            numBuildingTotal = new UControls.UNumericBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblBuilding = new Label();
            label20 = new Label();
            label18 = new Label();
            uPanel3 = new UControls.UPanel();
            flpRoomList = new FlowLayoutPanel();
            ucRoomControl11 = new UControls.UCRoomControl();
            ucRoomControl12 = new UControls.UCRoomControl();
            ucRoomControl13 = new UControls.UCRoomControl();
            ucRoomControl14 = new UControls.UCRoomControl();
            ucRoomControl15 = new UControls.UCRoomControl();
            label22 = new Label();
            lblState = new Label();
            flpBuildings = new FlowLayoutPanel();
            btnStart = new UControls.CircleButton();
            label19 = new Label();
            uPanel4 = new UControls.UPanel();
            gbSet = new GroupBox();
            btnSet = new UControls.CircleButton();
            valTemperature = new NumericUpDown();
            txtSetTemperature = new UControls.ParaTextBox();
            bdRoomCtrol = new UControls.ULightSwitch();
            swFan = new UControls.USwitch();
            swPower = new UControls.USwitch();
            cirState = new UControls.UCircle();
            lblRoomNo = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            lblCheckState = new Label();
            label24 = new Label();
            label21 = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uPanel1.SuspendLayout();
            uPanel2.SuspendLayout();
            uPanel3.SuspendLayout();
            flpRoomList.SuspendLayout();
            uPanel4.SuspendLayout();
            gbSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valTemperature).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(39, 52, 61);
            panelTop.Controls.Add(btnConfig);
            panelTop.Controls.Add(btnRooms);
            panelTop.Controls.Add(lblTime);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(btnMax);
            panelTop.Controls.Add(btnMin);
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1490, 60);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfig.BgColor = Color.FromArgb(39, 52, 61);
            btnConfig.BgColor2 = Color.Transparent;
            btnConfig.BorderWidth = 1;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConfig.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.ForeColor = Color.FromArgb(224, 224, 224);
            btnConfig.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnConfig.Location = new Point(1229, 16);
            btnConfig.Name = "btnConfig";
            btnConfig.Radius = 3;
            btnConfig.SelectedColor = Color.DeepSkyBlue;
            btnConfig.Size = new Size(75, 35);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "配置";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnRooms
            // 
            btnRooms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRooms.BgColor = Color.FromArgb(39, 52, 61);
            btnRooms.BgColor2 = Color.Transparent;
            btnRooms.BorderWidth = 1;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRooms.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.ForeColor = Color.FromArgb(224, 224, 224);
            btnRooms.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnRooms.Location = new Point(1093, 15);
            btnRooms.Name = "btnRooms";
            btnRooms.Radius = 3;
            btnRooms.SelectedColor = Color.DeepSkyBlue;
            btnRooms.Size = new Size(116, 35);
            btnRooms.TabIndex = 4;
            btnRooms.Text = "酒店客房信息";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(810, 28);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(193, 24);
            lblTime.TabIndex = 3;
            lblTime.Text = "2023-12-05 10:49:30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 15);
            label2.Name = "label2";
            label2.Size = new Size(243, 30);
            label2.TabIndex = 3;
            label2.Text = "朝夕酒店远程控制中心";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(3, 59);
            label1.Name = "label1";
            label1.Size = new Size(1484, 1);
            label1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(224, 224, 224);
            btnClose.Location = new Point(1454, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "r";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMax.ForeColor = Color.FromArgb(224, 224, 224);
            btnMax.Location = new Point(1426, 5);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 0;
            btnMax.Text = "1";
            btnMax.TextAlign = ContentAlignment.TopCenter;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Webdings", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.ForeColor = Color.FromArgb(224, 224, 224);
            btnMin.Location = new Point(1397, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 0;
            btnMin.Text = "0";
            btnMin.TextAlign = ContentAlignment.TopCenter;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // uPanel1
            // 
            uPanel1.BackColor = Color.FromArgb(39, 52, 61);
            uPanel1.BgColor = Color.FromArgb(39, 52, 61);
            uPanel1.BgColor2 = Color.Transparent;
            uPanel1.BorderColor = Color.CadetBlue;
            uPanel1.BorderWidth = 1;
            uPanel1.Controls.Add(label10);
            uPanel1.Controls.Add(label9);
            uPanel1.Controls.Add(label8);
            uPanel1.Controls.Add(numRate);
            uPanel1.Controls.Add(numUnCount);
            uPanel1.Controls.Add(numHasCount);
            uPanel1.Controls.Add(numTotalCount);
            uPanel1.Controls.Add(label7);
            uPanel1.Controls.Add(label6);
            uPanel1.Controls.Add(label5);
            uPanel1.Controls.Add(label4);
            uPanel1.Controls.Add(label3);
            uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel1.Location = new Point(15, 87);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 5;
            uPanel1.Size = new Size(220, 210);
            uPanel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(168, 161);
            label10.Name = "label10";
            label10.Size = new Size(26, 24);
            label10.TabIndex = 0;
            label10.Text = "%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(168, 111);
            label9.Name = "label9";
            label9.Size = new Size(28, 24);
            label9.TabIndex = 0;
            label9.Text = "间";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(168, 65);
            label8.Name = "label8";
            label8.Size = new Size(28, 24);
            label8.TabIndex = 0;
            label8.Text = "间";
            // 
            // numRate
            // 
            numRate.BackColor = Color.FromArgb(39, 52, 61);
            numRate.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numRate.ForeColor = Color.Green;
            numRate.ItemBgColor = Color.White;
            numRate.ItemSpace = 3;
            numRate.Location = new Point(73, 148);
            numRate.Margin = new Padding(4);
            numRate.Name = "numRate";
            numRate.NumCount = 3;
            numRate.Size = new Size(87, 44);
            numRate.TabIndex = 1;
            numRate.Value = 60;
            // 
            // numUnCount
            // 
            numUnCount.BackColor = Color.FromArgb(39, 52, 61);
            numUnCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numUnCount.ForeColor = Color.Red;
            numUnCount.ItemBgColor = Color.DarkSlateGray;
            numUnCount.ItemSpace = 3;
            numUnCount.Location = new Point(74, 100);
            numUnCount.Margin = new Padding(4);
            numUnCount.Name = "numUnCount";
            numUnCount.NumCount = 3;
            numUnCount.Size = new Size(87, 44);
            numUnCount.TabIndex = 1;
            numUnCount.Value = 100;
            // 
            // numHasCount
            // 
            numHasCount.BackColor = Color.FromArgb(39, 52, 61);
            numHasCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numHasCount.ForeColor = Color.FromArgb(192, 64, 0);
            numHasCount.ItemBgColor = Color.DarkSlateGray;
            numHasCount.ItemSpace = 3;
            numHasCount.Location = new Point(74, 54);
            numHasCount.Margin = new Padding(4);
            numHasCount.Name = "numHasCount";
            numHasCount.NumCount = 3;
            numHasCount.Size = new Size(87, 44);
            numHasCount.TabIndex = 1;
            numHasCount.Value = 100;
            // 
            // numTotalCount
            // 
            numTotalCount.BackColor = Color.FromArgb(39, 52, 61);
            numTotalCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numTotalCount.ForeColor = Color.White;
            numTotalCount.ItemBgColor = Color.DarkSlateGray;
            numTotalCount.ItemSpace = 3;
            numTotalCount.Location = new Point(74, 8);
            numTotalCount.Margin = new Padding(4);
            numTotalCount.Name = "numTotalCount";
            numTotalCount.NumCount = 3;
            numTotalCount.Size = new Size(87, 44);
            numTotalCount.TabIndex = 1;
            numTotalCount.Value = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(168, 18);
            label7.Name = "label7";
            label7.Size = new Size(28, 24);
            label7.TabIndex = 0;
            label7.Text = "间";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(19, 162);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "入住率";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(20, 105);
            label5.Name = "label5";
            label5.Size = new Size(54, 40);
            label5.TabIndex = 0;
            label5.Text = "未入住\r\n客房数";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(19, 56);
            label4.Name = "label4";
            label4.Size = new Size(54, 40);
            label4.TabIndex = 0;
            label4.Text = "已入住\r\n客房数";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(33, 8);
            label3.Name = "label3";
            label3.Size = new Size(39, 40);
            label3.TabIndex = 0;
            label3.Text = "客房\r\n总数";
            // 
            // uPanel2
            // 
            uPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uPanel2.BackColor = Color.FromArgb(39, 52, 61);
            uPanel2.BgColor = Color.FromArgb(39, 52, 61);
            uPanel2.BgColor2 = Color.Transparent;
            uPanel2.BorderColor = Color.CadetBlue;
            uPanel2.BorderWidth = 1;
            uPanel2.Controls.Add(label11);
            uPanel2.Controls.Add(label12);
            uPanel2.Controls.Add(label13);
            uPanel2.Controls.Add(numBuildingRate);
            uPanel2.Controls.Add(numBuildingUnCount);
            uPanel2.Controls.Add(numBuildingHasCount);
            uPanel2.Controls.Add(numBuildingTotal);
            uPanel2.Controls.Add(label14);
            uPanel2.Controls.Add(label15);
            uPanel2.Controls.Add(label16);
            uPanel2.Controls.Add(label17);
            uPanel2.Controls.Add(lblBuilding);
            uPanel2.Controls.Add(label20);
            uPanel2.Controls.Add(label18);
            uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel2.Location = new Point(15, 306);
            uPanel2.Name = "uPanel2";
            uPanel2.Radius = 5;
            uPanel2.Size = new Size(220, 509);
            uPanel2.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(127, 353);
            label11.Name = "label11";
            label11.Size = new Size(26, 24);
            label11.TabIndex = 2;
            label11.Text = "%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(127, 266);
            label12.Name = "label12";
            label12.Size = new Size(28, 24);
            label12.TabIndex = 3;
            label12.Text = "间";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(127, 181);
            label13.Name = "label13";
            label13.Size = new Size(28, 24);
            label13.TabIndex = 4;
            label13.Text = "间";
            // 
            // numBuildingRate
            // 
            numBuildingRate.BackColor = Color.FromArgb(39, 52, 61);
            numBuildingRate.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numBuildingRate.ForeColor = Color.Green;
            numBuildingRate.ItemBgColor = Color.White;
            numBuildingRate.ItemSpace = 3;
            numBuildingRate.Location = new Point(33, 341);
            numBuildingRate.Margin = new Padding(4);
            numBuildingRate.Name = "numBuildingRate";
            numBuildingRate.NumCount = 3;
            numBuildingRate.Size = new Size(87, 44);
            numBuildingRate.TabIndex = 10;
            numBuildingRate.Value = 60;
            // 
            // numBuildingUnCount
            // 
            numBuildingUnCount.BackColor = Color.FromArgb(39, 52, 61);
            numBuildingUnCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numBuildingUnCount.ForeColor = Color.Red;
            numBuildingUnCount.ItemBgColor = Color.DarkSlateGray;
            numBuildingUnCount.ItemSpace = 3;
            numBuildingUnCount.Location = new Point(33, 255);
            numBuildingUnCount.Margin = new Padding(4);
            numBuildingUnCount.Name = "numBuildingUnCount";
            numBuildingUnCount.NumCount = 3;
            numBuildingUnCount.Size = new Size(87, 44);
            numBuildingUnCount.TabIndex = 11;
            numBuildingUnCount.Value = 100;
            // 
            // numBuildingHasCount
            // 
            numBuildingHasCount.BackColor = Color.FromArgb(39, 52, 61);
            numBuildingHasCount.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numBuildingHasCount.ForeColor = Color.FromArgb(192, 64, 0);
            numBuildingHasCount.ItemBgColor = Color.DarkSlateGray;
            numBuildingHasCount.ItemSpace = 3;
            numBuildingHasCount.Location = new Point(33, 168);
            numBuildingHasCount.Margin = new Padding(4);
            numBuildingHasCount.Name = "numBuildingHasCount";
            numBuildingHasCount.NumCount = 3;
            numBuildingHasCount.Size = new Size(87, 44);
            numBuildingHasCount.TabIndex = 12;
            numBuildingHasCount.Value = 100;
            // 
            // numBuildingTotal
            // 
            numBuildingTotal.BackColor = Color.FromArgb(39, 52, 61);
            numBuildingTotal.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            numBuildingTotal.ForeColor = Color.White;
            numBuildingTotal.ItemBgColor = Color.DarkSlateGray;
            numBuildingTotal.ItemSpace = 3;
            numBuildingTotal.Location = new Point(33, 76);
            numBuildingTotal.Margin = new Padding(4);
            numBuildingTotal.Name = "numBuildingTotal";
            numBuildingTotal.NumCount = 3;
            numBuildingTotal.Size = new Size(87, 44);
            numBuildingTotal.TabIndex = 13;
            numBuildingTotal.Value = 100;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(127, 87);
            label14.Name = "label14";
            label14.Size = new Size(28, 24);
            label14.TabIndex = 5;
            label14.Text = "间";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(37, 319);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 6;
            label15.Text = "入住率";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(37, 233);
            label16.Name = "label16";
            label16.Size = new Size(99, 20);
            label16.TabIndex = 7;
            label16.Text = "未入住客房数";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(37, 141);
            label17.Name = "label17";
            label17.Size = new Size(99, 20);
            label17.TabIndex = 8;
            label17.Text = "已入住客房数";
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuilding.ForeColor = Color.DeepSkyBlue;
            lblBuilding.Location = new Point(12, 12);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(56, 27);
            lblBuilding.TabIndex = 9;
            lblBuilding.Text = "01栋";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(69, 17);
            label20.Name = "label20";
            label20.Size = new Size(69, 20);
            label20.TabIndex = 9;
            label20.Text = "客房情况";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(37, 52);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 9;
            label18.Text = "客房总数";
            // 
            // uPanel3
            // 
            uPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uPanel3.BackColor = Color.FromArgb(39, 52, 61);
            uPanel3.BgColor = Color.FromArgb(39, 52, 61);
            uPanel3.BgColor2 = Color.Transparent;
            uPanel3.BorderColor = Color.CadetBlue;
            uPanel3.BorderWidth = 1;
            uPanel3.Controls.Add(flpRoomList);
            uPanel3.Controls.Add(label22);
            uPanel3.Controls.Add(lblState);
            uPanel3.Controls.Add(flpBuildings);
            uPanel3.Controls.Add(btnStart);
            uPanel3.Controls.Add(label19);
            uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel3.Location = new Point(242, 87);
            uPanel3.Name = "uPanel3";
            uPanel3.Radius = 5;
            uPanel3.Size = new Size(947, 728);
            uPanel3.TabIndex = 1;
            // 
            // flpRoomList
            // 
            flpRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpRoomList.AutoScroll = true;
            flpRoomList.BackColor = Color.FromArgb(39, 52, 61);
            flpRoomList.Controls.Add(ucRoomControl11);
            flpRoomList.Controls.Add(ucRoomControl12);
            flpRoomList.Controls.Add(ucRoomControl13);
            flpRoomList.Controls.Add(ucRoomControl14);
            flpRoomList.Controls.Add(ucRoomControl15);
            flpRoomList.Location = new Point(22, 105);
            flpRoomList.Name = "flpRoomList";
            flpRoomList.Padding = new Padding(5);
            flpRoomList.Size = new Size(908, 602);
            flpRoomList.TabIndex = 13;
            // 
            // ucRoomControl11
            // 
            ucRoomControl11.BackColor = Color.Transparent;
            ucRoomControl11.BgColor = Color.DarkSlateGray;
            ucRoomControl11.BgColor2 = Color.FromArgb(54, 65, 92);
            ucRoomControl11.BorderColor = Color.SlateGray;
            ucRoomControl11.CO2Density = new decimal(new int[] { 400, 0, 0, 0 });
            ucRoomControl11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ucRoomControl11.Humidity = new decimal(new int[] { 45, 0, 0, 0 });
            ucRoomControl11.IsCheckIn = true;
            ucRoomControl11.IsSelected = false;
            ucRoomControl11.Location = new Point(10, 10);
            ucRoomControl11.Margin = new Padding(5);
            ucRoomControl11.Name = "ucRoomControl11";
            ucRoomControl11.PanelRadius = 5;
            ucRoomControl11.PSState = false;
            ucRoomControl11.RoomData = null;
            ucRoomControl11.RoomId = 101;
            ucRoomControl11.RoomNo = "01-101";
            ucRoomControl11.RoomSet = null;
            ucRoomControl11.Size = new Size(170, 170);
            ucRoomControl11.TabIndex = 0;
            ucRoomControl11.Temperature = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // ucRoomControl12
            // 
            ucRoomControl12.BackColor = Color.Transparent;
            ucRoomControl12.BgColor = Color.DarkSlateGray;
            ucRoomControl12.BgColor2 = Color.FromArgb(54, 65, 92);
            ucRoomControl12.BorderColor = Color.SlateGray;
            ucRoomControl12.CO2Density = new decimal(new int[] { 400, 0, 0, 0 });
            ucRoomControl12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ucRoomControl12.Humidity = new decimal(new int[] { 45, 0, 0, 0 });
            ucRoomControl12.IsCheckIn = true;
            ucRoomControl12.IsSelected = false;
            ucRoomControl12.Location = new Point(190, 10);
            ucRoomControl12.Margin = new Padding(5);
            ucRoomControl12.Name = "ucRoomControl12";
            ucRoomControl12.PanelRadius = 5;
            ucRoomControl12.PSState = false;
            ucRoomControl12.RoomData = null;
            ucRoomControl12.RoomId = 102;
            ucRoomControl12.RoomNo = "01-102";
            ucRoomControl12.RoomSet = null;
            ucRoomControl12.Size = new Size(170, 170);
            ucRoomControl12.TabIndex = 0;
            ucRoomControl12.Temperature = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // ucRoomControl13
            // 
            ucRoomControl13.BackColor = Color.Transparent;
            ucRoomControl13.BgColor = Color.DarkSlateGray;
            ucRoomControl13.BgColor2 = Color.FromArgb(54, 65, 92);
            ucRoomControl13.BorderColor = Color.SlateGray;
            ucRoomControl13.CO2Density = new decimal(new int[] { 400, 0, 0, 0 });
            ucRoomControl13.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ucRoomControl13.Humidity = new decimal(new int[] { 45, 0, 0, 0 });
            ucRoomControl13.IsCheckIn = true;
            ucRoomControl13.IsSelected = false;
            ucRoomControl13.Location = new Point(370, 10);
            ucRoomControl13.Margin = new Padding(5);
            ucRoomControl13.Name = "ucRoomControl13";
            ucRoomControl13.PanelRadius = 5;
            ucRoomControl13.PSState = false;
            ucRoomControl13.RoomData = null;
            ucRoomControl13.RoomId = 103;
            ucRoomControl13.RoomNo = "01-103";
            ucRoomControl13.RoomSet = null;
            ucRoomControl13.Size = new Size(170, 170);
            ucRoomControl13.TabIndex = 0;
            ucRoomControl13.Temperature = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // ucRoomControl14
            // 
            ucRoomControl14.BackColor = Color.Transparent;
            ucRoomControl14.BgColor = Color.DarkSlateGray;
            ucRoomControl14.BgColor2 = Color.FromArgb(54, 65, 92);
            ucRoomControl14.BorderColor = Color.SlateGray;
            ucRoomControl14.CO2Density = new decimal(new int[] { 400, 0, 0, 0 });
            ucRoomControl14.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ucRoomControl14.Humidity = new decimal(new int[] { 45, 0, 0, 0 });
            ucRoomControl14.IsCheckIn = true;
            ucRoomControl14.IsSelected = false;
            ucRoomControl14.Location = new Point(550, 10);
            ucRoomControl14.Margin = new Padding(5);
            ucRoomControl14.Name = "ucRoomControl14";
            ucRoomControl14.PanelRadius = 5;
            ucRoomControl14.PSState = false;
            ucRoomControl14.RoomData = null;
            ucRoomControl14.RoomId = 104;
            ucRoomControl14.RoomNo = "01-104";
            ucRoomControl14.RoomSet = null;
            ucRoomControl14.Size = new Size(170, 170);
            ucRoomControl14.TabIndex = 0;
            ucRoomControl14.Temperature = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // ucRoomControl15
            // 
            ucRoomControl15.BackColor = Color.Transparent;
            ucRoomControl15.BgColor = Color.DarkSlateGray;
            ucRoomControl15.BgColor2 = Color.FromArgb(54, 65, 92);
            ucRoomControl15.BorderColor = Color.SlateGray;
            ucRoomControl15.CO2Density = new decimal(new int[] { 400, 0, 0, 0 });
            ucRoomControl15.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            ucRoomControl15.Humidity = new decimal(new int[] { 45, 0, 0, 0 });
            ucRoomControl15.IsCheckIn = true;
            ucRoomControl15.IsSelected = false;
            ucRoomControl15.Location = new Point(10, 190);
            ucRoomControl15.Margin = new Padding(5);
            ucRoomControl15.Name = "ucRoomControl15";
            ucRoomControl15.PanelRadius = 5;
            ucRoomControl15.PSState = false;
            ucRoomControl15.RoomData = null;
            ucRoomControl15.RoomId = 105;
            ucRoomControl15.RoomNo = "01-105";
            ucRoomControl15.RoomSet = null;
            ucRoomControl15.Size = new Size(170, 170);
            ucRoomControl15.TabIndex = 0;
            ucRoomControl15.Temperature = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(22, 78);
            label22.Name = "label22";
            label22.Size = new Size(114, 20);
            label22.TabIndex = 12;
            label22.Text = "客房监控列表：";
            // 
            // lblState
            // 
            lblState.BorderStyle = BorderStyle.FixedSingle;
            lblState.ForeColor = Color.FromArgb(192, 0, 0);
            lblState.Location = new Point(643, 22);
            lblState.Name = "lblState";
            lblState.Size = new Size(130, 34);
            lblState.TabIndex = 10;
            lblState.Text = "未启动";
            lblState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBuildings
            // 
            flpBuildings.Location = new Point(112, 10);
            flpBuildings.Name = "flpBuildings";
            flpBuildings.Size = new Size(394, 52);
            flpBuildings.TabIndex = 9;
            // 
            // btnStart
            // 
            btnStart.BgColor = Color.FromArgb(0, 64, 64);
            btnStart.BgColor2 = Color.Teal;
            btnStart.BorderColor = Color.LightGray;
            btnStart.BorderWidth = 1;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.FromArgb(224, 224, 224);
            btnStart.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnStart.Location = new Point(522, 18);
            btnStart.Name = "btnStart";
            btnStart.Radius = 20;
            btnStart.SelectedColor = Color.White;
            btnStart.Size = new Size(100, 35);
            btnStart.TabIndex = 4;
            btnStart.Text = "启动";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(22, 25);
            label19.Name = "label19";
            label19.Size = new Size(84, 20);
            label19.TabIndex = 8;
            label19.Text = "酒店楼宇：";
            // 
            // uPanel4
            // 
            uPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            uPanel4.BackColor = Color.FromArgb(39, 52, 61);
            uPanel4.BgColor = Color.FromArgb(39, 52, 61);
            uPanel4.BgColor2 = Color.Transparent;
            uPanel4.BorderColor = Color.CadetBlue;
            uPanel4.BorderWidth = 1;
            uPanel4.Controls.Add(gbSet);
            uPanel4.Controls.Add(txtSetTemperature);
            uPanel4.Controls.Add(bdRoomCtrol);
            uPanel4.Controls.Add(swFan);
            uPanel4.Controls.Add(swPower);
            uPanel4.Controls.Add(cirState);
            uPanel4.Controls.Add(lblRoomNo);
            uPanel4.Controls.Add(label27);
            uPanel4.Controls.Add(label26);
            uPanel4.Controls.Add(label25);
            uPanel4.Controls.Add(lblCheckState);
            uPanel4.Controls.Add(label24);
            uPanel4.Controls.Add(label21);
            uPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            uPanel4.Location = new Point(1196, 87);
            uPanel4.Name = "uPanel4";
            uPanel4.Radius = 5;
            uPanel4.Size = new Size(282, 728);
            uPanel4.TabIndex = 1;
            // 
            // gbSet
            // 
            gbSet.Controls.Add(btnSet);
            gbSet.Controls.Add(valTemperature);
            gbSet.ForeColor = Color.FromArgb(224, 224, 224);
            gbSet.Location = new Point(21, 389);
            gbSet.Name = "gbSet";
            gbSet.Size = new Size(239, 97);
            gbSet.TabIndex = 17;
            gbSet.TabStop = false;
            gbSet.Text = "温度设置";
            // 
            // btnSet
            // 
            btnSet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSet.BgColor = Color.FromArgb(224, 224, 224);
            btnSet.BgColor2 = Color.Transparent;
            btnSet.BorderWidth = 1;
            btnSet.FlatAppearance.BorderSize = 0;
            btnSet.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSet.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSet.FlatStyle = FlatStyle.Flat;
            btnSet.ForeColor = Color.FromArgb(64, 64, 64);
            btnSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnSet.Location = new Point(145, 40);
            btnSet.Name = "btnSet";
            btnSet.Radius = 5;
            btnSet.SelectedColor = Color.DeepSkyBlue;
            btnSet.Size = new Size(58, 30);
            btnSet.TabIndex = 4;
            btnSet.Text = "设置";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // valTemperature
            // 
            valTemperature.DecimalPlaces = 1;
            valTemperature.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            valTemperature.Location = new Point(29, 40);
            valTemperature.Name = "valTemperature";
            valTemperature.Size = new Size(94, 30);
            valTemperature.TabIndex = 0;
            // 
            // txtSetTemperature
            // 
            txtSetTemperature.AutoSize = true;
            txtSetTemperature.DecimalCount = 0;
            txtSetTemperature.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSetTemperature.ForeColor = Color.SpringGreen;
            txtSetTemperature.Location = new Point(207, 344);
            txtSetTemperature.Name = "txtSetTemperature";
            txtSetTemperature.ParaName = null;
            txtSetTemperature.Size = new Size(59, 19);
            txtSetTemperature.TabIndex = 16;
            txtSetTemperature.Text = "24.5 ℃";
            txtSetTemperature.TextAlign = ContentAlignment.MiddleCenter;
            txtSetTemperature.Unit = "℃";
            txtSetTemperature.Value = new decimal(new int[] { 245, 0, 0, 65536 });
            txtSetTemperature.ParaTextBoxDClick += txtSetTemperature_ParaTextBoxDClick;
            // 
            // bdRoomCtrol
            // 
            bdRoomCtrol.BackColor = Color.FromArgb(39, 52, 61);
            bdRoomCtrol.GradeAddr = null;
            bdRoomCtrol.IsOn = true;
            bdRoomCtrol.LightGrade = 2;
            bdRoomCtrol.Location = new Point(21, 261);
            bdRoomCtrol.Name = "bdRoomCtrol";
            bdRoomCtrol.OffColor = Color.Gray;
            bdRoomCtrol.OnColor = Color.Green;
            bdRoomCtrol.Size = new Size(248, 49);
            bdRoomCtrol.SwitchAddr = null;
            bdRoomCtrol.TabIndex = 15;
            bdRoomCtrol.LightSwitchChanged += bdRoomCtrol_LightSwitchChanged;
            bdRoomCtrol.LightIntensityChanged += bdRoomCtrol_LightIntensityChanged;
            // 
            // swFan
            // 
            swFan.BackColor = Color.Transparent;
            swFan.Location = new Point(91, 335);
            swFan.Name = "swFan";
            swFan.Size = new Size(87, 30);
            swFan.StateTexts = new string[]
    {
    "运行",
    "停止"
    };
            swFan.TabIndex = 14;
            swFan.TrueColor = Color.Green;
            swFan.CheckedChanged += swFan_CheckedChanged;
            // 
            // swPower
            // 
            swPower.BackColor = Color.Transparent;
            swPower.Checked = true;
            swPower.Location = new Point(83, 156);
            swPower.Name = "swPower";
            swPower.Size = new Size(87, 30);
            swPower.StateTexts = new string[]
    {
    "接通",
    "断开"
    };
            swPower.TabIndex = 14;
            swPower.TrueColor = Color.Green;
            swPower.CheckedChanged += swPower_CheckedChanged;
            // 
            // cirState
            // 
            cirState.BackColor = Color.Transparent;
            cirState.ForeColor = Color.Red;
            cirState.Location = new Point(166, 112);
            cirState.Name = "cirState";
            cirState.Size = new Size(25, 25);
            cirState.TabIndex = 14;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.ForeColor = Color.FromArgb(0, 192, 192);
            lblRoomNo.Location = new Point(12, 73);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(94, 20);
            lblRoomNo.TabIndex = 13;
            lblRoomNo.Text = "01-101 客房";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.FromArgb(224, 224, 224);
            label27.Location = new Point(36, 343);
            label27.Name = "label27";
            label27.Size = new Size(39, 20);
            label27.TabIndex = 13;
            label27.Text = "风机";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.FromArgb(224, 224, 224);
            label26.Location = new Point(28, 219);
            label26.Name = "label26";
            label26.Size = new Size(69, 20);
            label26.TabIndex = 13;
            label26.Text = "卧室吊灯";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.FromArgb(224, 224, 224);
            label25.Location = new Point(28, 164);
            label25.Name = "label25";
            label25.Size = new Size(39, 20);
            label25.TabIndex = 13;
            label25.Text = "电源";
            // 
            // lblCheckState
            // 
            lblCheckState.BackColor = Color.DarkRed;
            lblCheckState.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckState.ForeColor = Color.White;
            lblCheckState.Location = new Point(83, 112);
            lblCheckState.Name = "lblCheckState";
            lblCheckState.Size = new Size(68, 25);
            lblCheckState.TabIndex = 13;
            lblCheckState.Text = "空余";
            lblCheckState.TextAlign = ContentAlignment.MiddleCenter;
            lblCheckState.Click += lblCheckState_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.FromArgb(224, 224, 224);
            label24.Location = new Point(28, 115);
            label24.Name = "label24";
            label24.Size = new Size(39, 20);
            label24.TabIndex = 13;
            label24.Text = "状态";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(12, 36);
            label21.Name = "label21";
            label21.Size = new Size(84, 20);
            label21.TabIndex = 13;
            label21.Text = "控制面板：";
            // 
            // FrmHotelCenterMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 52, 61);
            ClientSize = new Size(1496, 831);
            Controls.Add(uPanel3);
            Controls.Add(uPanel4);
            Controls.Add(uPanel2);
            Controls.Add(uPanel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHotelCenterMain";
            Text = "朝夕酒店远程控制中心";
            FormClosing += FrmHotelCenterMain_FormClosing;
            Load += FrmHotelCenterMain_Load;
            Paint += FrmHotelCenterMain_Paint;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            flpRoomList.ResumeLayout(false);
            uPanel4.ResumeLayout(false);
            uPanel4.PerformLayout();
            gbSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)valTemperature).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelTop;
        private Button btnClose;
        private Button btnMax;
        private Button btnMin;
        private UControls.UPanel uPanel1;
        private UControls.UPanel uPanel2;
        private UControls.UPanel uPanel3;
        private Label label1;
        private UControls.UPanel uPanel4;
        private PictureBox pictureBox1;
        private UControls.CircleButton btnRooms;
        private Label lblTime;
        private Label label2;
        private UControls.CircleButton btnConfig;
        private UControls.UNumericBox numTotalCount;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private UControls.UNumericBox numRate;
        private UControls.UNumericBox numUnCount;
        private UControls.UNumericBox numHasCount;
        private Label label11;
        private Label label12;
        private Label label13;
        private UControls.UNumericBox numBuildingRate;
        private UControls.UNumericBox numBuildingUnCount;
        private UControls.UNumericBox numBuildingHasCount;
        private UControls.UNumericBox numBuildingTotal;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label lblBuilding;
        private Label label20;
        private FlowLayoutPanel flpBuildings;
        private Label label19;
        private Label lblState;
        private UControls.CircleButton btnStart;
        private FlowLayoutPanel flpRoomList;
        private UControls.UCRoomControl ucRoomControl1;
        private Label label22;
        private UControls.UCRoomControl ucRoomControl2;
        private UControls.UCRoomControl ucRoomControl3;
        private UControls.UCRoomControl ucRoomControl4;
        private UControls.UCRoomControl ucRoomControl5;
        private UControls.UCRoomControl ucRoomControl6;
        private UControls.UCRoomControl ucRoomControl7;
        private UControls.UCRoomControl ucRoomControl8;
        private UControls.UCRoomControl ucRoomControl9;
        private UControls.UCRoomControl ucRoomControl10;
        private UControls.UCRoomControl ucRoomControl11;
        private UControls.UCRoomControl ucRoomControl12;
        private UControls.UCRoomControl ucRoomControl13;
        private UControls.UCRoomControl ucRoomControl14;
        private UControls.UCRoomControl ucRoomControl15;
        private Label lblRoomNo;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label lblCheckState;
        private Label label24;
        private Label label21;
        private UControls.UCircle cirState;
        private UControls.ULightSwitch bdRoomCtrol;
        private UControls.USwitch swPower;
        private GroupBox gbSet;
        private UControls.CircleButton btnSet;
        private NumericUpDown valTemperature;
        private UControls.ParaTextBox txtSetTemperature;
        private UControls.USwitch swFan;
    }
}