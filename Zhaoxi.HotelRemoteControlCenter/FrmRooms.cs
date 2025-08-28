using Newtonsoft.Json;
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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        //导入房间信息数据
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
                    int i = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        RoomInfo info = new RoomInfo();
                        info.RoomId = row["房间编号"].ToString().GetInt();
                        info.RoomNo = row["房间号"].ToString().Trim();
                        info.CheckIn = false;
                        info.Floor = row["所在楼层"].ToString().Trim();
                        info.Building = row["所在楼宇"].ToString().Trim();
                        if (CommonHelper.roomList.Find(r => r.RoomId == info.RoomId) == null)
                            CommonHelper.roomList.Add(info);
                        i++;
                    }
                    if (dt.Rows.Count == i)
                    {
                        //写入文件
                        SaveToFile();
                        MessageHelper.Success("房间数据保存", "房间信息数据导入成功！");
                    }
                }
            }
        }

        private void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(CommonHelper.roomList);
            File.WriteAllText(CommonHelper.roomFilePath, json);
            CommonHelper.IsRoomsUpdated = true;//更新房间信息
        }

        private void FrmRooms_Load(object sender, EventArgs e)
        {
            cboBuildings.SelectedIndex = 0;
            dgvRoomList.AutoGenerateColumns = false;
            LoadRoomList();
        }

        //查询房间列表
        private void LoadRoomList()
        {
            if (CommonHelper.roomList.Count > 0)
            {
                string buiding = cboBuildings.Text.Trim();
                if (buiding != "")
                {
                    var roomList = CommonHelper.roomList.Where(r => r.Building == buiding).ToList();//筛选当前楼栋的房间列表
                    dgvRoomList.DataSource = roomList;
                }
                else
                    dgvRoomList.DataSource = CommonHelper.roomList;

                UpdateList();

            }
            else
                dgvRoomList.DataSource = null;
        }

        private void UpdateList()
        {
            for (int i = 0; i < dgvRoomList.Rows.Count; i++)
            {
                RoomInfo roomInfo = dgvRoomList.Rows[i].DataBoundItem as RoomInfo;
                UpdateCheckCells(i, roomInfo.CheckIn);
            }
        }

        private void cboBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var cell = dgvRoomList.Rows[e.RowIndex].Cells[e.ColumnIndex];//当前单元格
                string cellText = cell.FormattedValue.ToString();//单元格内容
                RoomInfo roomInfo = dgvRoomList.Rows[e.RowIndex].DataBoundItem as RoomInfo;//房间信息对象
                RoomSetInfo setInfo = CommonHelper.roomSetList.Find(s => s.RoomId == roomInfo.RoomId);//房间配置信息对象
                string roomStateAddr = "";//房间状态地址
                if (setInfo != null)
                {
                    roomStateAddr = setInfo.RSAddr;//入住状态地址
                }
                if (cell.ReadOnly == false)
                {
                    bool oldState = roomInfo.CheckIn;
                    if (cellText == "入住")
                    {
                        if (roomStateAddr != "")
                        {
                            //写状态
                            CommonHelper.SetRoomCheckIn(roomStateAddr, true);
                            roomInfo.CheckIn = true;
                            MessageHelper.Success("客户入住", "入住成功！");
                        }
                        else
                        {
                            MessageHelper.Error("客户入住", "请先配置房间状态参数！");
                            return;
                        }
                    }
                    else if (cellText == "退房")
                    {
                        //写状态
                        CommonHelper.SetRoomCheckIn(roomStateAddr, false);
                        roomInfo.CheckIn = false;
                        MessageHelper.Success("客户退房", "退房成功！");
                    }


                    if (roomInfo.CheckIn != oldState)
                    {
                        //刷新操作列表呈现
                        UpdateCheckCells(e.RowIndex, roomInfo.CheckIn);
                        dgvRoomList.Refresh();
                        //更新到文件中----房间信息文件中
                        string json = JsonConvert.SerializeObject(CommonHelper.roomList);
                        File.WriteAllText(CommonHelper.roomFilePath, json);
                        CommonHelper.ReloadStatisticsData();//刷新统计
                    }

                }


            }
        }

        //刷新操作列表呈现
        private void UpdateCheckCells(int index, bool checkIn)
        {
            if (checkIn)
            {
                var checkCell = dgvRoomList.Rows[index].Cells["colCheck"] as DataGridViewLinkCell;
                checkCell.ReadOnly = true;
                checkCell.ActiveLinkColor = Color.Gray;
                checkCell.LinkColor = Color.Gray;
                var checkOutCell = dgvRoomList.Rows[index].Cells["colCheckOut"] as DataGridViewLinkCell;
                checkOutCell.ReadOnly = false;
                checkOutCell.ActiveLinkColor = Color.DarkRed;
                checkOutCell.LinkColor = Color.DarkRed;
            }
            else
            {
                var checkCell = dgvRoomList.Rows[index].Cells["colCheck"] as DataGridViewLinkCell;
                checkCell.ReadOnly = false;
                checkCell.ActiveLinkColor = Color.Green;
                checkCell.LinkColor = Color.Green;
                var checkOutCell = dgvRoomList.Rows[index].Cells["colCheckOut"] as DataGridViewLinkCell;
                checkOutCell.ReadOnly = true;
                checkOutCell.ActiveLinkColor = Color.Gray;
                checkOutCell.LinkColor = Color.Gray;
            }
        }

        private void dgvRoomList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
