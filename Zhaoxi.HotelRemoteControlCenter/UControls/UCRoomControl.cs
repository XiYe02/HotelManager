using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.HotelRemoteControlCenter.Models;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    public partial class UCRoomControl : UserControl
    {
        public UCRoomControl()
        {
            InitializeComponent();
        }
        //事件：房间选择事件
        public event EventHandler RoomSelected;//房间选择事件--当房间被选中时，改变右侧的房间信息显示
        //属性：房间编号、房间号、入住状态、电源状态、房间温度、湿度、CO2、背景色1、背景色2、渐变模式、边框颜色、圆角度、选择状态、房间信息属性、设置信息、
        #region 属性
        //房间编号
        public int RoomId { get; set; }
        //房间号
        public string RoomNo
        {
            get { return lblRoomNo.Text; }
            set { lblRoomNo.Text = value; }
        }

        private bool isCheckIn = false;
        //入住状态
        public bool IsCheckIn
        {
            get
            {
                isCheckIn = lblRoomState.Text == "已入住" ? true : false;
                return isCheckIn;
            }
            set
            {
                isCheckIn = value;
                lblRoomState.Text = isCheckIn ? "已入住" : "空余";
                lblRoomState.ForeColor = isCheckIn ? Color.FromArgb(255, 128, 0) : Color.Red;
            }
        }

        private bool psState = false;
        //电源状态
        public bool PSState
        {
            get
            {
                psState = lblPowerState.Text == "已通电" ? true : false;
                return psState;
            }
            set
            {
                psState = value;
                lblPowerState.Text = psState ? "已通电" : "已断开";
                lblPowerState.ForeColor = psState ? Color.MediumSpringGreen : Color.Brown;
            }
        }

        //房间温度
        public decimal Temperature
        {
            get { return txtTemperature.Value; }
            set { txtTemperature.Value = value; }
        }

        //房间湿度
        public decimal Humidity
        {
            get { return txtHumidity.Value; }
            set { txtHumidity.Value = value; }
        }

        //房间CO2含量
        public decimal CO2Density
        {
            get { return txtCO2.Value; }
            set { txtCO2.Value = value; }
        }
        //背景色1
        public Color BgColor
        {
            get { return panelRoom.BgColor; }
            set { panelRoom.BgColor = value; }
        }
        //背景色2
        public Color BgColor2
        {
            get { return panelRoom.BgColor2; }
            set { panelRoom.BgColor2 = value; }
        }
        //渐变模式
        public LinearGradientMode GradientMode
        {
            get { return panelRoom.GradientMode; }
            set { panelRoom.GradientMode = value; }
        }

        private Color oldBorderColor;
        //边框颜色
        public Color BorderColor
        {
            get { return panelRoom.BorderColor; }
            set
            {
                panelRoom.BorderColor = value;
                oldBorderColor = value;
            }
        }
        //圆角度
        public int PanelRadius
        {
            get { return panelRoom.Radius; }
            set { panelRoom.Radius = value; }
        }

        private bool isSelected;
        //选择状态
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                if (isSelected)
                {
                    panelRoom.BorderColor = Color.White;
                    panelRoom.BorderWidth = 2;
                }
                else
                {
                    panelRoom.BorderColor = oldBorderColor;
                    panelRoom.BorderWidth = 1;
                }
            }
        }

        private RoomData roomData;
        //房间数据
        public RoomData RoomData
        {
            get { return roomData; }
            set
            {
                roomData = value;
                if (roomData != null)
                {
                    IsCheckIn = roomData.CheckIn;
                    PSState = roomData.PSState;
                    Temperature = roomData.Temperature;
                    Humidity = roomData.Humidity;
                    CO2Density = RoomData.CO2Density;
                }
            }
        }

        //房间设置信息
        public RoomSetInfo RoomSet { get; set; }//用于刷新房间设置信息，主页面356

        #endregion

        //事件引发方法
        private void OnRoomSelected()
        {
            IsSelected = true;
            RoomSelected?.Invoke(this, EventArgs.Empty);
            if (this.Parent != null)
            {
                foreach (Control c in Parent.Controls)
                {
                    if (c is UCRoomControl)
                    {
                        UCRoomControl uc = (UCRoomControl)c;
                        if (uc.RoomId != RoomId)
                            uc.IsSelected = false;
                    }
                }
            }
        }

        private void lblRoomNo_Click(object sender, EventArgs e)
        {
            OnRoomSelected();
        }

        private void panelRoom_Click(object sender, EventArgs e)
        {
            OnRoomSelected();
        }

        //方法

        //房间数据初始化
        public void InitData(RoomData data, RoomSetInfo setInfo)
        {
            if (data != null)
            {
                RoomId = data.RoomId;
                RoomNo = data.RoomNo;
                RoomData = data;
                if (setInfo != null)
                {
                    RoomSet = setInfo;
                }
            }
        }

        //刷新房间数据
        public void UpdateData(RoomData data)
        {
            RoomData = data;
        }
    }
}
