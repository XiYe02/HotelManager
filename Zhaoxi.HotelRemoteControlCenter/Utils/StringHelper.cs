using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Utils
{
    public static class StringHelper
    {
        //转换数字字符串为int
        public static int GetInt(this string str)
        {
            int reInt = 0;
            int.TryParse(str, out reInt);
            return reInt;
        }

        //转换数字字符串为decimal
        public static decimal GetDecimal(this string str)
        {
            decimal reInt = 0;
            decimal.TryParse(str, out reInt);
            return reInt;
        }

        //转换数字字符串为ushort
        public static ushort GetUshort(this string str)
        {
            ushort reInt = 0;
            ushort.TryParse(str, out reInt);
            return reInt;
        }
        //转换数字字符串为short
        public static short GetShort(this string str)
        {
            short reInt = 0;
            short.TryParse(str, out reInt);
            return reInt;
        }


        //转换数字字符串为byte
        public static byte GetByte(this string str)
        {
            byte reInt = 0;
            byte.TryParse(str, out reInt);
            return reInt;
        }
    }
}
