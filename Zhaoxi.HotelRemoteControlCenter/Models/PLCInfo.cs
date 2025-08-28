using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Models
{
    //PLC设置信息类
    public class PLCInfo
    {
        public CpuType CpuType { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }   
        public short Rack {  get; set; }
        public short Slot { get; set; }
    }
}
