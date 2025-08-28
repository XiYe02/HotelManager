using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    public partial class ULightSwitch : UserControl
    {
        public ULightSwitch()
        {
            InitializeComponent();
        }
        //事件：开关状态改变事件、灯光强度改变事件
        public event EventHandler LightSwitchChanged;
        public event EventHandler LightIntensityChanged;
        //属性：灯的状态、开关的背景色、灯光强度、开关状态地址、强度地址、

        // 灯的状态
        public bool IsOn
        {
            get { return swLight.Checked; }
            set { swLight.Checked = value; }
        }

        //开的背景色
        public Color OnColor
        {
            get { return swLight.TrueColor; }
            set { swLight.TrueColor = value; }
        }

        //关的背景色
        public Color OffColor
        {
            get { return swLight.FalseColor; }
            set { swLight.FalseColor = value; }
        }

        private int lightGrade;
        //灯光强度
        public int LightGrade
        {
            get { return lightGrade; }
            set
            {
                lightGrade = value;
                switch (lightGrade)
                {
                    case 1:
                        SetLightIntensity(cirWeak); break;
                    case 2:
                        SetLightIntensity(cirMiddle); break;
                    case 3:
                        SetLightIntensity(cirStrong); break;
                    default:
                        foreach (Control c in panelLight.Controls)
                        {
                            UCircle circle1 = (UCircle)c;
                            circle1.BorderWidth = 0;
                        }
                        break;
                }
            }
        }

        //开关状态地址
        public string SwitchAddr { get; set; }
        //强度地址
        public string GradeAddr { get; set; }


        private void SetLightIntensity(UCircle circle)
        {
            foreach (Control c in panelLight.Controls)
            {
                UCircle circle1 = (UCircle)c;
                if (circle1 != circle)
                {
                    circle1.BorderWidth = 0;
                }
                else
                    circle1.BorderWidth = 2;
            }
        }

        //引发状态改变事件
        private void swLight_CheckedChanged(object sender, EventArgs e)
        {
            LightSwitchChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cirWeak_Click(object sender, EventArgs e)
        {
            LightGrade = 1;
            OnLightIntensityChanged();
        }

        private void cirMiddle_Click(object sender, EventArgs e)
        {
            LightGrade = 2;
            OnLightIntensityChanged();
        }

        private void cirStrong_Click(object sender, EventArgs e)
        {
            LightGrade = 3;
            OnLightIntensityChanged();
        }

        private void OnLightIntensityChanged()
        {
            LightIntensityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
