using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Models
{
    /// <summary>
    /// 房间设置信息--用于URoomControl
    /// </summary>
    public class RoomSetInfo
    {
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        //电源状态
        public string PSAddr { get; set; }
        //风机状态
        public string FSAddr { get; set; }
        //卧室灯状态
        public string BRLSAddr { get; set; }

        //房间状态
        public string RSAddr { get; set; }
        //设置温度地址
        public string FSTemperAddr { get; set; }
        //房间温度地址
        public string RTemperAddr { get; set; }
        //房间湿度地址
        public string RHumidityAddr { get; set; }
        //房间CO2地址
        public string CO2Addr { get; set; }
        //卧室灯光强度地址
        public string BRLGradeAddr { get; set; }
    }
}
