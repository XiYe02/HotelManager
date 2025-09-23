using Newtonsoft.Json;
using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.HotelRemoteControlCenter.Models;
using Zhaoxi.HotelRemoteControlCenter.Utils;

namespace Zhaoxi.HotelRemoteControlCenter
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(CommonHelper.dirFile))
                Directory.CreateDirectory(CommonHelper.dirFile);
            cboBuildings.SelectedIndex = 0;
            //没有plc配置
            if (CommonHelper.plcInfo == null)
            {
                cboCpuTypes.SelectedIndex = 0;
                txtIp.Clear();
                txtPort.Text = "102";
                txtRack.Text = "0";
                txtSlot.Text = "0";
            }
            else
            {
                var plcInfo = CommonHelper.plcInfo;
                cboBuildings.SelectedItem = CommonHelper.selectBuilding;
                cboCpuTypes.SelectedItem = plcInfo.CpuType.ToString();
                txtIp.Text = plcInfo.Ip;
                txtPort.Text = plcInfo.Port.ToString();
                txtRack.Text = plcInfo.Rack.ToString();
                txtSlot.Text = plcInfo.Slot.ToString();
            }
            //房间下拉列表加载
            if (CommonHelper.roomList.Count > 0)
            {
                //var setIds=CommonHelper.roomSetList.Select(r=>r.RoomId).ToList();
                cboRooms.DisplayMember = "RoomNo";
                cboRooms.ValueMember = "RoomId";
                var list = CommonHelper.roomList;
                cboRooms.DataSource = list;
                cboRooms.SelectedIndex = 0;
                RoomSetInfo setInfo = CommonHelper.roomSetList.Find(r => r.RoomId == list[0].RoomId);
                if (setInfo != null)
                {
                    txtStateAddrs.Text = setInfo.PSAddr + "," + setInfo.FSAddr + "," + setInfo.BRLSAddr + "," + setInfo.RSAddr;
                    txtDataAddrs.Text = setInfo.FSTemperAddr + "," + setInfo.RTemperAddr + "," + setInfo.RHumidityAddr + "," + setInfo.CO2Addr + "," + setInfo.BRLGradeAddr;
                }

            }
            else
            {
                var list = new List<RoomInfo>();
                list.Add(new RoomInfo() { RoomId = 0, RoomNo = "请选择" });
                cboRooms.DisplayMember = "RoomNo";
                cboRooms.ValueMember = "RoomId";
                cboRooms.DataSource = list;
                cboRooms.SelectedIndex = 0;
                txtDataAddrs.Text = "";
                txtStateAddrs.Text = "";
            }


        }

        //保存PLC设置
        private void btnPLCSave_Click(object sender, EventArgs e)
        {
            string building = cboBuildings.Text;
            string cpuType = cboCpuTypes.Text;
            string ip = txtIp.Text;
            string port = txtPort.Text;
            string rack = txtRack.Text;
            string slot = txtSlot.Text;
            string setPlcStr = $"Building:{building};CpuType:{cpuType};Ip:{ip};port:{port};rack:{rack};slot:{slot}";
            if (File.Exists(CommonHelper.communicatePath))
            {
                string plcAllString = File.ReadAllText(CommonHelper.communicatePath);
                string[] plcArr = plcAllString.Split('|');
                bool blExist = false;
                for (int i = 0; i < plcArr.Length; i++)
                {
                    if (plcArr[i].Contains(building))
                    {
                        plcArr[i] = setPlcStr;
                        blExist = true;
                        break;
                    }
                }
                string newSetStr = "";
                if (blExist)
                {
                    newSetStr = string.Join("|", plcArr);
                }
                else
                {
                    newSetStr = plcAllString + "|" + setPlcStr;
                }
                File.WriteAllText(CommonHelper.communicatePath, newSetStr);//再次写入文件

            }
            else
            {
                File.WriteAllText(CommonHelper.communicatePath, setPlcStr);//再次写入文件
            }
            MessageHelper.Success("PLC设置", "PLC设置保存成功！");
            if (CommonHelper.selectBuilding == building)
            {
                CommonHelper.plcInfo = new PLCInfo()
                {
                    CpuType = (CpuType)Enum.Parse(typeof(CpuType), cpuType),
                    Ip = ip,
                    Port = port.GetInt(),
                    Rack = rack.GetShort(),
                    Slot = slot.GetShort()
                };
                CommonHelper.IsCommunicateUpdated = true;
            }
        }

        //参数配置导入
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files (*.xlsx)|*.xlsx| Excel Files 2003 (*.xls)|*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                //Excel文件导入 
                DataTable dt = ExcelHelper.ExcelToDataTable(fileName, "Sheet1", true);
                if (dt != null && dt.Rows.Count > 0)
                {
                    //CommonHelper.roomSetList.Clear();
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        RoomSetInfo setInfo = new RoomSetInfo();
                        setInfo.RoomId = row["房间编号"].ToString().GetInt();
                        setInfo.RoomNo = row["房间号"].ToString().Trim();
                        string stateAddrs = row["状态地址"].ToString().Trim();
                        if (stateAddrs.Length > 0)
                        {
                            string[] states = stateAddrs.Split(',');
                            setInfo.PSAddr = states[0];
                            setInfo.FSAddr = states[1];
                            setInfo.BRLSAddr = states[2];
                            setInfo.RSAddr = states[3];
                        }
                        string dataAddrs = row["房间数据地址"].ToString().Trim();
                        if (dataAddrs.Length > 0)
                        {
                            string[] addrs = dataAddrs.Split(',');
                            setInfo.FSTemperAddr = addrs[0];
                            setInfo.RTemperAddr = addrs[1];
                            setInfo.RHumidityAddr = addrs[2];
                            setInfo.CO2Addr = addrs[3];
                            setInfo.BRLGradeAddr = addrs[4];
                        }
                        if (CommonHelper.roomSetList.Find(s => s.RoomId == setInfo.RoomId) == null)
                            CommonHelper.roomSetList.Add(setInfo);
                        i++;
                    }
                    if (dt.Rows.Count == i)
                    {
                        //写入文件
                        SaveToFile();
                        MessageHelper.Success("房间参数保存", "房间参数信息导入成功！");
                    }
                }
            }
        }

        private void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(CommonHelper.roomSetList);
            File.WriteAllText(CommonHelper.setFilePath, json);
            CommonHelper.IsRoomSetsUpdated = true;//更新房间配置
        }

        private void cboBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(CommonHelper.communicatePath))
            {
                string plcSettingStr = File.ReadAllText(CommonHelper.communicatePath);
                string[] plcArrays = plcSettingStr.Split('|');
                string plcStr = plcArrays.FirstOrDefault(str => str.Contains(cboBuildings.Text.Trim()));
                if (!string.IsNullOrEmpty(plcStr))
                {
                    string[] arr = plcStr.Split(";");
                    cboCpuTypes.SelectedItem = arr[1].Split(':')[1];
                    txtIp.Text = arr[2].Split(':')[1];
                    txtPort.Text = arr[3].Split(":")[1];
                    txtRack.Text = arr[4].Split(":")[1];
                    txtSlot.Text = arr[5].Split(":")[1];
                }
                else
                {
                    cboCpuTypes.SelectedIndex = 0;
                    txtIp.Clear();
                    txtPort.Clear();
                    txtRack.Clear();
                    txtSlot.Clear();
                }
            }
        }

        private void cboRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRooms.SelectedValue != null)
            {
                int roomId = cboRooms.SelectedValue.ToString().GetInt();
                RoomSetInfo setInfo = CommonHelper.roomSetList.Find(s => s.RoomId == roomId);
                if (setInfo != null)
                {
                    txtStateAddrs.Text = setInfo.PSAddr + "," + setInfo.FSAddr + "," + setInfo.BRLSAddr + "," + setInfo.RSAddr;
                    txtDataAddrs.Text = setInfo.FSTemperAddr + "," + setInfo.RTemperAddr + "," + setInfo.RHumidityAddr + "," + setInfo.CO2Addr + "," + setInfo.BRLGradeAddr;
                }
                else
                {
                    txtDataAddrs.Clear();
                    txtStateAddrs.Clear();

                }
            }
        }

        //房间参数配置保存----新增、修改
        private void btnRoomSet_Click(object sender, EventArgs e)
        {
            int roomId = 0;
            if(cboRooms.SelectedValue!= null)
            {
                roomId = cboRooms.SelectedValue.ToString().GetInt();
            }
            string roomNo = cboRooms.Text.Trim();
            string stateAddrs=txtStateAddrs.Text.Trim();
            string dataAddrs=txtDataAddrs.Text.Trim();
            string msgTitle = "参数配置";
            if(roomId == 0)
            {
                MessageHelper.Error(msgTitle, "请选择房间！");
                return;
            }
            if(string.IsNullOrEmpty(stateAddrs)) {
                MessageHelper.Error(msgTitle, "请设置房间相关的状态地址！");
                txtStateAddrs.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dataAddrs))
            {
                MessageHelper.Error(msgTitle, "请设置房间相关的数据访问地址！");
                txtDataAddrs.Focus();
                return;
            }
         
            RoomSetInfo setInfo =new RoomSetInfo();
            setInfo.RoomId = roomId;
            setInfo.RoomNo = roomNo;
            if (stateAddrs.Length > 0)
            {
                string[] states = stateAddrs.Split(',');
                setInfo.PSAddr = states[0];
                setInfo.FSAddr = states[1];
                setInfo.BRLSAddr = states[2];
                setInfo.RSAddr = states[3];
            }
            if (dataAddrs.Length > 0)
            {
                string[] addrs = dataAddrs.Split(',');
                setInfo.FSTemperAddr = addrs[0];
                setInfo.RTemperAddr = addrs[1];
                setInfo.RHumidityAddr = addrs[2];
                setInfo.CO2Addr = addrs[3];
                setInfo.BRLGradeAddr = addrs[4];
            }
            RoomSetInfo oldSetInfo=CommonHelper.roomSetList.Find(s=>s.RoomId == roomId);
            if (oldSetInfo!=null)
            {
                int index = CommonHelper.roomSetList.IndexOf(oldSetInfo);
                //存在---更新
                CommonHelper.roomSetList[index] = setInfo;
            }
            else
            {
                //不存在---新增
                CommonHelper.roomSetList.Add(setInfo);
            }
            SaveToFile();//保存到文件
            MessageHelper.Success(msgTitle, $"房间：{roomNo} 参数配置保存成功！");
        }
    }
}
