using S7.Net;
using Zhaoxi.HotelRemoteControlCenter.Models;
using Zhaoxi.HotelRemoteControlCenter.UControls;
using Zhaoxi.HotelRemoteControlCenter.Utils;

namespace Zhaoxi.HotelRemoteControlCenter
{
    public partial class FrmHotelCenterMain : Form
    {
        public FrmHotelCenterMain()
        {
            InitializeComponent();
            //设置控件样式标志----绘制
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void FrmHotelCenterMain_Paint(object sender, PaintEventArgs e)
        {
            PaintClass.Paint(this, e);
        }

        #region 窗体尺寸调整
        const int WM_NCHITTEST = 0x0084;// 移动鼠标
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (this.MaximizeBox == true && this.WindowState == FormWindowState.Normal)
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF,
              (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        if (vPoint.X <= 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else m.Result = (IntPtr)HTLEFT;
                        else if (vPoint.X >= ClientSize.Width - 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPRIGHT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            else m.Result = (IntPtr)HTRIGHT;
                        else if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOP;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOM;
                    }
                    break;
            }
        }



        #endregion


        #region 窗口控制
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = "1";//口字形图标
            }
            else
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "2";//重叠口字形图标
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //退出系统
        private void FrmHotelCenterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Question("系统退出", "你确定要退出系统吗？") == DialogResult.OK)
            {
                timeTimer.Stop();
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
        #endregion

        #region 窗口拖动
        Point point = new Point();//开始按下的位置点
        bool isMoving = false;//是否拖动中
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按住的点
            isMoving = true;//启动拖动
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNew;//拖动到的点
            if (e.Button == MouseButtons.Left && isMoving)
            {
                pointNew = e.Location;
                Point fPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//拖动的距离描述
                this.Location += new Size(fPointNew);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//释放拖动
        }
        #endregion

        //打开房间管理页面
        private void btnRooms_Click(object sender, EventArgs e)
        {
            FrmRooms frmRooms = new FrmRooms();
            frmRooms.ShowDialog();
            if (CommonHelper.IsRoomsUpdated)
            {
                StatisticsSelectBuilding(selBuilding);
                //重新加载房间监控列表
                LoadRooms();
            }
        }

        /// <summary>
        /// 打开系统配置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.ShowDialog();
            if (CommonHelper.IsCommunicateUpdated)
            {
                if (plc.IsConnected)
                    plc.Close();
                CommonHelper.CreatePlc();
                plc = CommonHelper.plc;
            }
            if (CommonHelper.IsRoomSetsUpdated)
            {
                //重新更新房间的相关参数设置信息
                foreach (Control c in flpRoomList.Controls)
                {
                    UCRoomControl roomControl = c as UCRoomControl;
                    roomControl.RoomSet = CommonHelper.roomSetList.Find(s => s.RoomId == roomControl.RoomId);
                }
            }
        }



        System.Timers.Timer timeTimer = null;
        System.Timers.Timer readTimer = null;//采集定时器
        Plc plc = null;
        string selBuilding = "";//选择的楼栋
        List<RoomInfo> selRoomList = new List<RoomInfo>();//当前楼栋的房间列表
        List<int> roomIds = new List<int>();
        List<RoomSetInfo> selSetList = new List<RoomSetInfo>();//当前楼栋的房间参数列表
        Dictionary<int, RoomData> dicDatas = new Dictionary<int, RoomData>();//存储实时数据
        private void FrmHotelCenterMain_Load(object sender, EventArgs e)
        {
            //加载房间信息列表
            CommonHelper.LoadRoomList();
            //加载参数列表
            CommonHelper.LoadRoomSetList();
            //统计酒店总数据
            StatisticsRoomsData();
            CommonHelper.ReloadStatisticsData = () =>
            {
                StatisticsRoomsData();
                StatisticsSelectBuilding(selBuilding);
            };
            //加载楼栋列表
            LoadBuidings();
            //加载当前楼栋的房间列表
            LoadRooms();
            //初始化通信设置
            InitCommunication();
            //初始化定时器
            InitTimers();
        }


        private void StatisticsRoomsData()
        {
            //总房间数
            int totalCount = CommonHelper.roomList.Count;
            //已入住数
            int checkInCount = CommonHelper.roomList.Where(r => r.CheckIn).Count();
            //未入住数
            int unCheckInCount = totalCount - checkInCount;
            //入住率
            int checkInRate = (int)(((decimal)checkInCount / totalCount) * 100);
            numTotalCount.Value = totalCount;
            numHasCount.Value = checkInCount;
            numUnCount.Value = unCheckInCount;
            numRate.Value = checkInRate;
        }

        private void LoadBuidings()
        {
            List<string> buildings = CommonHelper.roomList.Select(r => r.Building).Distinct().ToList();//楼栋列表
            flpBuildings.Controls.Clear();//清空容器
            foreach (string building in buildings)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
                lbl.ForeColor = Color.LightSeaGreen;
                lbl.Margin = new Padding(5, 15, 5, 5);
                lbl.Name = "lbl" + building.Substring(0, 2);
                lbl.Size = new Size(52, 25);
                lbl.Text = building;
                lbl.Click += Lbl_Click;
                flpBuildings.Controls.Add(lbl);
            }
            if (buildings.Count > 0)
            {
                selBuilding = buildings[0];
                CommonHelper.selectBuilding = selBuilding;
                lblBuilding.Text = selBuilding;
                flpBuildings.Controls[0].ForeColor = Color.DeepSkyBlue;
                //统计当前选择楼栋的数据
                StatisticsSelectBuilding(selBuilding);
            }
        }

        private void StatisticsSelectBuilding(string building)
        {
            selRoomList = CommonHelper.roomList.Where(r => r.Building == building).ToList();
            roomIds = selRoomList.Select(r => r.RoomId).ToList();
            selSetList = CommonHelper.roomSetList.Where(s => roomIds.Contains(s.RoomId)).ToList();
            var list = selRoomList;
            //总房间数
            int totalCount = list.Count;
            //已入住数
            int checkInCount = list.Where(r => r.CheckIn).Count();
            //未入住数
            int unCheckInCount = totalCount - checkInCount;
            //入住率
            int checkInRate = (int)(((decimal)checkInCount / totalCount) * 100);
            numBuildingTotal.Value = totalCount;
            numBuildingHasCount.Value = checkInCount;
            numBuildingUnCount.Value = unCheckInCount;
            numBuildingRate.Value = checkInRate;
        }

        //楼栋的切换响应
        private void Lbl_Click(object sender, EventArgs e)
        {
            string building = (sender as Label).Text;
            selBuilding = building;//切换当前楼栋
            CommonHelper.selectBuilding = selBuilding;
            if(plc.IsConnected)
            {
                readTimer.Stop();
                plc.Close();
                isStart = false;
                btnStart.Text = "启动";
                lblState.Text = "停止监控";
                btnStart.BgColor = Color.FromArgb(0, 64, 64);
                btnStart.BgColor2 = Color.Teal;
                lblState.ForeColor = Color.Red;
            }
            InitCommunication();
            lblBuilding.Text = selBuilding;
            foreach(Control c in flpBuildings.Controls)
            {
                if (c.Text == selBuilding)
                    c.ForeColor = Color.DeepSkyBlue;
                else
                    c.ForeColor = Color.LightSeaGreen;
            }
            StatisticsSelectBuilding(selBuilding);
            LoadRooms();
        }

        //加载当前楼栋的房间列表
        private void LoadRooms()
        {
            if (CommonHelper.roomList.Count > 0)
            {
                flpRoomList.Controls.Clear();

                if (selRoomList.Count > 0)
                {
                    flpRoomList.SuspendLayout();
                    foreach (var roomInfo in selRoomList)
                    {
                        RoomSetInfo setInfo = selSetList.Find(s => s.RoomId == roomInfo.RoomId);
                        if (setInfo != null)
                        {
                            RoomData roomData = new RoomData();
                            roomData.RoomId = roomInfo.RoomId;
                            roomData.RoomNo = roomInfo.RoomNo;
                            UCRoomControl roomControl = new UCRoomControl();
                            roomControl.Margin = new Padding(5);
                            roomControl.BgColor = Color.DarkSlateGray;
                            roomControl.BgColor2 = Color.FromArgb(54, 65, 92);
                            roomControl.BorderColor = Color.LightGray;
                            roomControl.InitData(roomData, setInfo);//初始化房间信息与参数配置信息

                            //房间选择事件
                            roomControl.RoomSelected += RoomControl_RoomSelected;
                            flpRoomList.Controls.Add(roomControl);
                        }
                    }


                    flpRoomList.ResumeLayout();
                }
            }
        }

        //加载房间相关信息到右侧的控制面板
        private void RoomControl_RoomSelected(object sender, EventArgs e)
        {
            UCRoomControl roomControl = sender as UCRoomControl;
            RefreshSelRoom(roomControl);
        }

        //刷新选择房间的控制面板
        private void RefreshSelRoom(UCRoomControl uCRoom)
        {
            RoomData data = uCRoom.RoomData;
            RoomSetInfo setInfo = uCRoom.RoomSet;
            if (data != null)
            {
                lblRoomNo.Text = data.RoomNo + "房间";
                //房间状态
                if (data.CheckIn)
                {
                    lblCheckState.Text = "已入住";
                    lblCheckState.BackColor = Color.FromArgb(0, 192, 0);
                    lblCheckState.ForeColor = Color.Brown;
                    cirState.ForeColor = Color.MediumSpringGreen;
                }
                else
                {
                    lblCheckState.Text = "空余";
                    lblCheckState.BackColor = Color.DarkRed;
                    lblCheckState.ForeColor = Color.White;
                    cirState.ForeColor = Color.Red;
                }
                swPower.Checked = data.PSState;//通电状态
                swPower.Tag = setInfo.PSAddr;//绑定通电状态地址

                bdRoomCtrol.IsOn = data.RoomLightState;//吊灯的状态
                bdRoomCtrol.LightGrade = data.RoomLightGrade;//灯的强度
                bdRoomCtrol.SwitchAddr = setInfo.BRLSAddr;//状态地址
                bdRoomCtrol.GradeAddr = setInfo.BRLGradeAddr;//灯光强度地址

                swFan.Checked = data.FanState;//风机状态
                swFan.Tag = setInfo.FSAddr;//风机状态地址
                txtSetTemperature.Value = data.SetTemperature;//风机温度
                txtSetTemperature.ParaName = setInfo.FSTemperAddr;//设置温度地址

            }
        }

        private void InitTimers()
        {
            timeTimer = new System.Timers.Timer();
            timeTimer.Interval = 1000;
            timeTimer.AutoReset = true;
            timeTimer.Elapsed += TimeTimer_Elapsed;
            timeTimer.Start();

            readTimer = new System.Timers.Timer();
            readTimer.Interval = 1000;
            readTimer.AutoReset = true;
            readTimer.Elapsed += ReadTimer_Elapsed; ;
        }



        //定时获取当前时间
        private void TimeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
                }));
            }

        }



        private void InitCommunication()
        {
            //加载通信配置信息
            CommonHelper.LoadPLCSet();

            var plcInfo = CommonHelper.plcInfo;
            //创建plc实例
            if (plcInfo == null)
            {
                CommonHelper.plc = new Plc(CpuType.S71500, "192.168.41.127", 102, 0, 1);
            }
            else
            {
                CommonHelper.CreatePlc();
            }
            plc = CommonHelper.plc;
        }

        bool isStart = false;//是否启动
        /// <summary>
        /// 启动与停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (plc != null)
            {
                try
                {
                    if (!isStart)
                    {
                        //启动处理
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            isStart = true;//已启动
                            readTimer.Start();
                            btnStart.Text = "停止";
                            lblState.Text = "监控中...";
                            btnStart.BgColor = Color.DarkRed;
                            btnStart.BgColor2 = Color.Maroon;
                            lblState.ForeColor = Color.Orange;
                            //同步房间状态到plc中
                            foreach (RoomInfo room in selRoomList)
                            {
                                RoomSetInfo setInfo = selSetList.Find(s => s.RoomId == room.RoomId);
                                if (room.CheckIn && setInfo != null)
                                {
                                    string addr = setInfo.RSAddr;
                                    CommonHelper.SetRoomCheckIn(addr, true);
                                }
                            }
                        }
                        else
                        {
                            lblState.Text = "连接失败";
                            lblState.ForeColor = Color.Red;
                            return;
                        }
                    }
                    else
                    {
                        readTimer.Stop();
                        plc.Close();
                        isStart = false;//已停止
                        btnStart.Text = "启动";
                        lblState.Text = "停止监控";
                        btnStart.BgColor = Color.FromArgb(0, 64, 64);
                        btnStart.BgColor2 = Color.Teal;
                        lblState.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblState.Text = "连接异常";
                    lblState.ForeColor = Color.Red;
                    return;
                }

            }
        }

        private void ReadTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //定时采集与加载
            ReadAndLoadDatas();

        }

        private void ReadAndLoadDatas()
        {
            foreach (var setInfo in selSetList)
            {
                RoomData roomData = new RoomData();
                roomData.PSState = (bool)plc.Read(setInfo.PSAddr);
                roomData.FanState = (bool)plc.Read(setInfo.FSAddr);
                roomData.RoomLightState = (bool)plc.Read(setInfo.BRLSAddr);
                roomData.CheckIn = (bool)plc.Read(setInfo.RSAddr);
                roomData.Temperature = ConvertToDecimal((uint)plc.Read(setInfo.RTemperAddr));
                roomData.SetTemperature = ConvertToDecimal((uint)plc.Read(setInfo.FSTemperAddr));
                roomData.Humidity = (ushort)plc.Read(setInfo.RHumidityAddr);
                roomData.CO2Density = (ushort)plc.Read(setInfo.CO2Addr);
                roomData.RoomLightGrade = (ushort)plc.Read(setInfo.BRLGradeAddr);
                //存储问题
                int roomId = setInfo.RoomId;
                if (dicDatas.ContainsKey(roomId))
                {
                    dicDatas[roomId] = roomData;
                }
                else
                    dicDatas.Add(roomId, roomData);
            }

            //加载呈现
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    foreach (Control c in flpRoomList.Controls)
                    {
                        UCRoomControl roomControl = c as UCRoomControl;
                        if (dicDatas.ContainsKey(roomControl.RoomId))
                        {
                            roomControl.RoomData = dicDatas[roomControl.RoomId];
                            if (roomControl.IsSelected)
                            {
                                RefreshSelRoom(roomControl);
                            }
                        }
                    }
                }));
            }
        }

        private decimal ConvertToDecimal(uint intVal)
        {
            decimal fValue = 0.0m;
            byte[] arr = BitConverter.GetBytes(intVal);
            float fVal = BitConverter.ToSingle(arr, 0);
            fValue = (decimal)fVal;
            return fValue;
        }

        //通电状态控制
        private void swPower_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swPower.Checked;//要设置的状态
            plc.Write(swPower.Tag.ToString(), setState);
            swPower.Checked = setState;
        }

        /// <summary>
        /// 灯光强度控制  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdRoomCtrol_LightIntensityChanged(object sender, EventArgs e)
        {
            ushort grade = (ushort)bdRoomCtrol.LightGrade;//获取设置的强度值
            plc.Write(bdRoomCtrol.GradeAddr, grade);//写入plc
        }

        /// <summary>
        /// 灯的开关控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdRoomCtrol_LightSwitchChanged(object sender, EventArgs e)
        {
            bool setState = !bdRoomCtrol.IsOn;//要设置的状态

            plc.Write(bdRoomCtrol.SwitchAddr, setState);
            bdRoomCtrol.IsOn = setState;
        }

        /// <summary>
        /// 风机的开关控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swFan_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swFan.Checked;//要设置的状态
            plc.Write(swFan.Tag.ToString(), setState);
            swFan.Checked = setState;
        }

        private void txtSetTemperature_ParaTextBoxDClick(object sender, PTextBoxArgs e)
        {
            gbSet.Visible = true;
            txtSetTemperature.Value = e.DataValue;
            btnSet.ForeColor = Color.Gray;
        }

        //设置温度
        private void btnSet_Click(object sender, EventArgs e)
        {
            decimal setTemperVal = valTemperature.Value;
            string addr = txtSetTemperature.ParaName;//数据地址
            readTimer.Stop();
            plc.Write(addr, (float)setTemperVal);
            readTimer.Start();
            txtSetTemperature.Value = setTemperVal.ToString("0.0").GetDecimal();
            gbSet.Visible = false;
        }
    }
}