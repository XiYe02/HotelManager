namespace Zhaoxi.HotelRemoteControlCenter
{
    partial class FrmRooms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnImport = new UControls.CircleButton();
            dgvRoomList = new DataGridView();
            colRoomId = new DataGridViewTextBoxColumn();
            colRoomNo = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewCheckBoxColumn();
            colFloor = new DataGridViewTextBoxColumn();
            colBuilding = new DataGridViewTextBoxColumn();
            colCheck = new DataGridViewLinkColumn();
            colCheckOut = new DataGridViewLinkColumn();
            label11 = new Label();
            cboBuildings = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            SuspendLayout();
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
            btnImport.Location = new Point(1072, 26);
            btnImport.Name = "btnImport";
            btnImport.Radius = 3;
            btnImport.SelectedColor = Color.SteelBlue;
            btnImport.Size = new Size(133, 36);
            btnImport.TabIndex = 2;
            btnImport.Text = "客房信息导入";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = Color.WhiteSmoke;
            dgvRoomList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoomList.ColumnHeadersHeight = 35;
            dgvRoomList.Columns.AddRange(new DataGridViewColumn[] { colRoomId, colRoomNo, colCheckIn, colFloor, colBuilding, colCheck, colCheckOut });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRoomList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRoomList.EnableHeadersVisualStyles = false;
            dgvRoomList.GridColor = Color.Silver;
            dgvRoomList.Location = new Point(31, 78);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.RowHeadersVisible = false;
            dgvRoomList.RowHeadersWidth = 51;
            dgvRoomList.RowTemplate.Height = 29;
            dgvRoomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomList.Size = new Size(1181, 562);
            dgvRoomList.TabIndex = 3;
            dgvRoomList.CellContentClick += dgvRoomList_CellContentClick;
            dgvRoomList.CurrentCellDirtyStateChanged += dgvRoomList_CurrentCellDirtyStateChanged;
            // 
            // colRoomId
            // 
            colRoomId.DataPropertyName = "RoomId";
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.NullValue = "退房";
            colRoomId.DefaultCellStyle = dataGridViewCellStyle2;
            colRoomId.HeaderText = "房间编号";
            colRoomId.MinimumWidth = 6;
            colRoomId.Name = "colRoomId";
            colRoomId.ReadOnly = true;
            // 
            // colRoomNo
            // 
            colRoomNo.DataPropertyName = "RoomNo";
            colRoomNo.HeaderText = "房间号";
            colRoomNo.MinimumWidth = 6;
            colRoomNo.Name = "colRoomNo";
            colRoomNo.ReadOnly = true;
            // 
            // colCheckIn
            // 
            colCheckIn.DataPropertyName = "CheckIn";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            colCheckIn.DefaultCellStyle = dataGridViewCellStyle3;
            colCheckIn.FillWeight = 80F;
            colCheckIn.HeaderText = "入住状态";
            colCheckIn.MinimumWidth = 6;
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            // 
            // colFloor
            // 
            colFloor.DataPropertyName = "Floor";
            colFloor.FillWeight = 80F;
            colFloor.HeaderText = "楼层";
            colFloor.MinimumWidth = 6;
            colFloor.Name = "colFloor";
            colFloor.ReadOnly = true;
            colFloor.Resizable = DataGridViewTriState.True;
            colFloor.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBuilding
            // 
            colBuilding.DataPropertyName = "Building";
            colBuilding.FillWeight = 80F;
            colBuilding.HeaderText = "楼宇";
            colBuilding.MinimumWidth = 6;
            colBuilding.Name = "colBuilding";
            colBuilding.ReadOnly = true;
            // 
            // colCheck
            // 
            colCheck.ActiveLinkColor = Color.Green;
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.NullValue = "入住";
            colCheck.DefaultCellStyle = dataGridViewCellStyle4;
            colCheck.FillWeight = 50F;
            colCheck.HeaderText = "入住";
            colCheck.LinkBehavior = LinkBehavior.NeverUnderline;
            colCheck.LinkColor = Color.Green;
            colCheck.MinimumWidth = 6;
            colCheck.Name = "colCheck";
            colCheck.TrackVisitedState = false;
            colCheck.VisitedLinkColor = Color.Green;
            // 
            // colCheckOut
            // 
            colCheckOut.ActiveLinkColor = Color.DarkRed;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.NullValue = "退房";
            colCheckOut.DefaultCellStyle = dataGridViewCellStyle5;
            colCheckOut.FillWeight = 50F;
            colCheckOut.HeaderText = "退房";
            colCheckOut.LinkBehavior = LinkBehavior.NeverUnderline;
            colCheckOut.LinkColor = Color.DarkRed;
            colCheckOut.MinimumWidth = 6;
            colCheckOut.Name = "colCheckOut";
            colCheckOut.TrackVisitedState = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(107, 35);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 5;
            label11.Text = "楼栋";
            // 
            // cboBuildings
            // 
            cboBuildings.FormattingEnabled = true;
            cboBuildings.Items.AddRange(new object[] { "", "01栋", "02栋", "03栋", "04栋" });
            cboBuildings.Location = new Point(166, 32);
            cboBuildings.Name = "cboBuildings";
            cboBuildings.Size = new Size(212, 28);
            cboBuildings.TabIndex = 4;
            cboBuildings.SelectedIndexChanged += cboBuildings_SelectedIndexChanged;
            // 
            // FrmRooms
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 52, 61);
            ClientSize = new Size(1240, 667);
            Controls.Add(label11);
            Controls.Add(cboBuildings);
            Controls.Add(dgvRoomList);
            Controls.Add(btnImport);
            MaximizeBox = false;
            Name = "FrmRooms";
            ShowIcon = false;
            Text = "酒店房间信息管理";
            Load += FrmRooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UControls.CircleButton btnImport;
        private DataGridView dgvRoomList;
        private Label label11;
        private ComboBox cboBuildings;
        private DataGridViewTextBoxColumn colRoomId;
        private DataGridViewTextBoxColumn colRoomNo;
        private DataGridViewCheckBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colFloor;
        private DataGridViewTextBoxColumn colBuilding;
        private DataGridViewLinkColumn colCheck;
        private DataGridViewLinkColumn colCheckOut;
    }
}