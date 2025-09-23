using Newtonsoft.Json;
using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.HotelRemoteControlCenter.Models;

namespace Zhaoxi.HotelRemoteControlCenter.Utils
{
    public  class CommonHelper
    {
        public static bool IsRoomsUpdated = false;//房间信息是否更新 
        public static bool IsRoomSetsUpdated = false;//房间配置信息是否改变
        public static bool IsCommunicateUpdated=false;//通信配置是否改变
        public static Plc plc = null;//plc实例
        public static PLCInfo plcInfo = null;//存储当前的PLC设置信息
        public static string selectBuilding = "01栋";//当前选择的楼栋
        public static string dirFile = Application.StartupPath + "/files";//配置文件存储文件夹路径
        public static string communicatePath = dirFile + "/Communication.txt";//通信配置文件路径 
        public static string setFilePath = dirFile + "/RoomParaSets.json";//房间配置文件路径
        public static string roomFilePath = dirFile + "/RoomInfos.json";//房间信息存储文件路径 
        public static List<RoomInfo> roomList= new List<RoomInfo>();//存储房间信息数据
        public static List<RoomSetInfo> roomSetList= new List<RoomSetInfo>();//存储房间设置信息数据
        public static Action ReloadStatisticsData = null;//刷新统计数据
        public static void LoadPLCSet()
        {
            if(File.Exists(communicatePath))
            {
                string plcSetString=File.ReadAllText(communicatePath);
                if(!string.IsNullOrEmpty(plcSetString) )
                {
                    string[] plcArr = plcSetString.Split('|');
                    string plcStr = plcArr.FirstOrDefault(str => str.Contains(selectBuilding));//筛选出当前的plc设置
                    if(!string.IsNullOrEmpty(plcStr) )
                    {
                        string[] arr = plcStr.Split(';');
                        plcInfo = new PLCInfo();
                        plcInfo.CpuType=(CpuType)Enum.Parse(typeof(CpuType), arr[1].Split(':')[1]);
                        plcInfo.Ip = arr[2].Split(':')[1];
                        plcInfo.Port = arr[3].Split(':')[1].GetInt(); 
                        plcInfo.Rack = arr[4].Split(':')[1].GetShort();
                        plcInfo.Slot = arr[5].Split(':')[1].GetShort();
                    }
                }
            }
        }

        public static void CreatePlc()
        {
            CpuType cpuType = plcInfo.CpuType;
            string ip = plcInfo.Ip;
            int port = plcInfo.Port;
            short rack = plcInfo.Rack;
            short slot = plcInfo.Slot;
            plc = new Plc(cpuType, ip, port, rack, slot);
        }

       //加载房间信息列表--用于主页显示房间信息
        public static void LoadRoomList()
        {
            if(File.Exists(roomFilePath))
            {
                string json=File.ReadAllText(roomFilePath);
                roomList = JsonConvert.DeserializeObject<List<RoomInfo>>(json);//反序列列表
            }
        }

        //加载房间配置信息列表
        public static void LoadRoomSetList()
        {
            if (File.Exists(setFilePath))
            {
                string json = File.ReadAllText(setFilePath);
                roomSetList = JsonConvert.DeserializeObject<List<RoomSetInfo>>(json);//反序列列表
            }
        }

        /// <summary>
        /// 将状态写入PLC
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="checkIn"></param>
        public static void SetRoomCheckIn(string addr,bool checkIn)
        {
            if(!plc.IsConnected)
            {
                plc.Open();
            }
            if(plc.IsConnected)
            {
                plc.Write(addr, checkIn);
            }
        }
    }
}
