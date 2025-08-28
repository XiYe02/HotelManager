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
            //���ÿؼ���ʽ��־----����
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void FrmHotelCenterMain_Paint(object sender, PaintEventArgs e)
        {
            PaintClass.Paint(this, e);
        }

        #region ����ߴ����
        const int WM_NCHITTEST = 0x0084;// �ƶ����
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


        #region ���ڿ���
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = "1";//������ͼ��
            }
            else
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "2";//�ص�������ͼ��
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //�˳�ϵͳ
        private void FrmHotelCenterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Question("ϵͳ�˳�", "��ȷ��Ҫ�˳�ϵͳ��") == DialogResult.OK)
            {
                timeTimer.Stop();
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
        #endregion

        #region �����϶�
        Point point = new Point();//��ʼ���µ�λ�õ�
        bool isMoving = false;//�Ƿ��϶���
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//��ס�ĵ�
            isMoving = true;//�����϶�
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNew;//�϶����ĵ�
            if (e.Button == MouseButtons.Left && isMoving)
            {
                pointNew = e.Location;
                Point fPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//�϶��ľ�������
                this.Location += new Size(fPointNew);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//�ͷ��϶�
        }
        #endregion

        //�򿪷������ҳ��
        private void btnRooms_Click(object sender, EventArgs e)
        {
            FrmRooms frmRooms = new FrmRooms();
            frmRooms.ShowDialog();
            if (CommonHelper.IsRoomsUpdated)
            {
                StatisticsSelectBuilding(selBuilding);
                //���¼��ط������б�
                LoadRooms();
            }
        }

        /// <summary>
        /// ��ϵͳ����ҳ��
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
                //���¸��·������ز���������Ϣ
                foreach (Control c in flpRoomList.Controls)
                {
                    UCRoomControl roomControl = c as UCRoomControl;
                    roomControl.RoomSet = CommonHelper.roomSetList.Find(s => s.RoomId == roomControl.RoomId);
                }
            }
        }



        System.Timers.Timer timeTimer = null;
        System.Timers.Timer readTimer = null;//�ɼ���ʱ��
        Plc plc = null;
        string selBuilding = "";//ѡ���¥��
        List<RoomInfo> selRoomList = new List<RoomInfo>();//��ǰ¥���ķ����б�
        List<int> roomIds = new List<int>();
        List<RoomSetInfo> selSetList = new List<RoomSetInfo>();//��ǰ¥���ķ�������б�
        Dictionary<int, RoomData> dicDatas = new Dictionary<int, RoomData>();//�洢ʵʱ����
        private void FrmHotelCenterMain_Load(object sender, EventArgs e)
        {
            //���ط�����Ϣ�б�
            CommonHelper.LoadRoomList();
            //���ز����б�
            CommonHelper.LoadRoomSetList();
            //ͳ�ƾƵ�������
            StatisticsRoomsData();
            CommonHelper.ReloadStatisticsData = () =>
            {
                StatisticsRoomsData();
                StatisticsSelectBuilding(selBuilding);
            };
            //����¥���б�
            LoadBuidings();
            //���ص�ǰ¥���ķ����б�
            LoadRooms();
            //��ʼ��ͨ������
            InitCommunication();
            //��ʼ����ʱ��
            InitTimers();
        }


        private void StatisticsRoomsData()
        {
            //�ܷ�����
            int totalCount = CommonHelper.roomList.Count;
            //����ס��
            int checkInCount = CommonHelper.roomList.Where(r => r.CheckIn).Count();
            //δ��ס��
            int unCheckInCount = totalCount - checkInCount;
            //��ס��
            int checkInRate = (int)(((decimal)checkInCount / totalCount) * 100);
            numTotalCount.Value = totalCount;
            numHasCount.Value = checkInCount;
            numUnCount.Value = unCheckInCount;
            numRate.Value = checkInRate;
        }

        private void LoadBuidings()
        {
            List<string> buildings = CommonHelper.roomList.Select(r => r.Building).Distinct().ToList();//¥���б�
            flpBuildings.Controls.Clear();//�������
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
                //ͳ�Ƶ�ǰѡ��¥��������
                StatisticsSelectBuilding(selBuilding);
            }
        }

        private void StatisticsSelectBuilding(string building)
        {
            selRoomList = CommonHelper.roomList.Where(r => r.Building == building).ToList();
            roomIds = selRoomList.Select(r => r.RoomId).ToList();
            selSetList = CommonHelper.roomSetList.Where(s => roomIds.Contains(s.RoomId)).ToList();
            var list = selRoomList;
            //�ܷ�����
            int totalCount = list.Count;
            //����ס��
            int checkInCount = list.Where(r => r.CheckIn).Count();
            //δ��ס��
            int unCheckInCount = totalCount - checkInCount;
            //��ס��
            int checkInRate = (int)(((decimal)checkInCount / totalCount) * 100);
            numBuildingTotal.Value = totalCount;
            numBuildingHasCount.Value = checkInCount;
            numBuildingUnCount.Value = unCheckInCount;
            numBuildingRate.Value = checkInRate;
        }

        //¥�����л���Ӧ
        private void Lbl_Click(object sender, EventArgs e)
        {
            string building = (sender as Label).Text;
            selBuilding = building;//�л���ǰ¥��
            CommonHelper.selectBuilding = selBuilding;
            if(plc.IsConnected)
            {
                readTimer.Stop();
                plc.Close();
                isStart = false;
                btnStart.Text = "����";
                lblState.Text = "ֹͣ���";
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

        //���ص�ǰ¥���ķ����б�
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
                            roomControl.InitData(roomData, setInfo);//��ʼ��������Ϣ�����������Ϣ

                            //����ѡ���¼�
                            roomControl.RoomSelected += RoomControl_RoomSelected;
                            flpRoomList.Controls.Add(roomControl);
                        }
                    }


                    flpRoomList.ResumeLayout();
                }
            }
        }

        //���ط��������Ϣ���Ҳ�Ŀ������
        private void RoomControl_RoomSelected(object sender, EventArgs e)
        {
            UCRoomControl roomControl = sender as UCRoomControl;
            RefreshSelRoom(roomControl);
        }

        //ˢ��ѡ�񷿼�Ŀ������
        private void RefreshSelRoom(UCRoomControl uCRoom)
        {
            RoomData data = uCRoom.RoomData;
            RoomSetInfo setInfo = uCRoom.RoomSet;
            if (data != null)
            {
                lblRoomNo.Text = data.RoomNo + "����";
                //����״̬
                if (data.CheckIn)
                {
                    lblCheckState.Text = "����ס";
                    lblCheckState.BackColor = Color.FromArgb(0, 192, 0);
                    lblCheckState.ForeColor = Color.Brown;
                    cirState.ForeColor = Color.MediumSpringGreen;
                }
                else
                {
                    lblCheckState.Text = "����";
                    lblCheckState.BackColor = Color.DarkRed;
                    lblCheckState.ForeColor = Color.White;
                    cirState.ForeColor = Color.Red;
                }
                swPower.Checked = data.PSState;//ͨ��״̬
                swPower.Tag = setInfo.PSAddr;//��ͨ��״̬��ַ

                bdRoomCtrol.IsOn = data.RoomLightState;//���Ƶ�״̬
                bdRoomCtrol.LightGrade = data.RoomLightGrade;//�Ƶ�ǿ��
                bdRoomCtrol.SwitchAddr = setInfo.BRLSAddr;//״̬��ַ
                bdRoomCtrol.GradeAddr = setInfo.BRLGradeAddr;//�ƹ�ǿ�ȵ�ַ

                swFan.Checked = data.FanState;//���״̬
                swFan.Tag = setInfo.FSAddr;//���״̬��ַ
                txtSetTemperature.Value = data.SetTemperature;//����¶�
                txtSetTemperature.ParaName = setInfo.FSTemperAddr;//�����¶ȵ�ַ

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



        //��ʱ��ȡ��ǰʱ��
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
            //����ͨ��������Ϣ
            CommonHelper.LoadPLCSet();

            var plcInfo = CommonHelper.plcInfo;
            //����plcʵ��
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

        bool isStart = false;//�Ƿ�����
        /// <summary>
        /// ������ֹͣ
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
                        //��������
                        plc.Open();
                        if (plc.IsConnected)
                        {
                            isStart = true;//������
                            readTimer.Start();
                            btnStart.Text = "ֹͣ";
                            lblState.Text = "�����...";
                            btnStart.BgColor = Color.DarkRed;
                            btnStart.BgColor2 = Color.Maroon;
                            lblState.ForeColor = Color.Orange;
                            //ͬ������״̬��plc��
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
                            lblState.Text = "����ʧ��";
                            lblState.ForeColor = Color.Red;
                            return;
                        }
                    }
                    else
                    {
                        readTimer.Stop();
                        plc.Close();
                        isStart = false;//��ֹͣ
                        btnStart.Text = "����";
                        lblState.Text = "ֹͣ���";
                        btnStart.BgColor = Color.FromArgb(0, 64, 64);
                        btnStart.BgColor2 = Color.Teal;
                        lblState.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblState.Text = "�����쳣";
                    lblState.ForeColor = Color.Red;
                    return;
                }

            }
        }

        private void ReadTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //��ʱ�ɼ������
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
                //�洢����
                int roomId = setInfo.RoomId;
                if (dicDatas.ContainsKey(roomId))
                {
                    dicDatas[roomId] = roomData;
                }
                else
                    dicDatas.Add(roomId, roomData);
            }

            //���س���
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

        //ͨ��״̬����
        private void swPower_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swPower.Checked;//Ҫ���õ�״̬
            plc.Write(swPower.Tag.ToString(), setState);
            swPower.Checked = setState;
        }

        /// <summary>
        /// �ƹ�ǿ�ȿ���  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdRoomCtrol_LightIntensityChanged(object sender, EventArgs e)
        {
            ushort grade = (ushort)bdRoomCtrol.LightGrade;//��ȡ���õ�ǿ��ֵ
            plc.Write(bdRoomCtrol.GradeAddr, grade);//д��plc
        }

        /// <summary>
        /// �ƵĿ��ؿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdRoomCtrol_LightSwitchChanged(object sender, EventArgs e)
        {
            bool setState = !bdRoomCtrol.IsOn;//Ҫ���õ�״̬

            plc.Write(bdRoomCtrol.SwitchAddr, setState);
            bdRoomCtrol.IsOn = setState;
        }

        /// <summary>
        /// ����Ŀ��ؿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swFan_CheckedChanged(object sender, EventArgs e)
        {
            bool setState = !swFan.Checked;//Ҫ���õ�״̬
            plc.Write(swFan.Tag.ToString(), setState);
            swFan.Checked = setState;
        }

        private void txtSetTemperature_ParaTextBoxDClick(object sender, PTextBoxArgs e)
        {
            gbSet.Visible = true;
            txtSetTemperature.Value = e.DataValue;
            btnSet.ForeColor = Color.Gray;
        }

        //�����¶�
        private void btnSet_Click(object sender, EventArgs e)
        {
            decimal setTemperVal = valTemperature.Value;
            string addr = txtSetTemperature.ParaName;//���ݵ�ַ
            readTimer.Stop();
            plc.Write(addr, (float)setTemperVal);
            readTimer.Start();
            txtSetTemperature.Value = setTemperVal.ToString("0.0").GetDecimal();
            gbSet.Visible = false;
        }
    }
}