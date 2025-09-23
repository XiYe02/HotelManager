using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    /// <summary>
    /// ParaTextBox控件的事件参数
    /// </summary>
    public class PTextBoxArgs:EventArgs
    {
        public decimal DataValue {  get; set; }
        public PTextBoxArgs(decimal val)
        {
            DataValue = val;
        }
    }
}
