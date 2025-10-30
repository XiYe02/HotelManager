using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Models
{
    //房间信息类，用于存储房间号、楼层、楼栋、是否入住等信息
    public class RoomInfo
    {
        public int RoomId {  get; set; }
        public string RoomNo { get; set; }
        public bool CheckIn {  get; set; }
        public string Floor {  get; set; }
        public string Building {  get; set; }
    }
}
