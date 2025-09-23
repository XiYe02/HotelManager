using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Models
{
    /// <summary>
    /// 用于URoomControl用户控件
    /// </summary>
    public class RoomData
    {
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public bool CheckIn { get; set; }
        public bool PSState { get; set; }
        public decimal Temperature { get; set; }
        public ushort Humidity { get; set; }
        public ushort CO2Density { get; set; }
        public bool FanState { get; set; }
        public decimal SetTemperature { get; set; }
        public bool RoomLightState { get; set; }
        public ushort RoomLightGrade { get; set; }
    }
}
