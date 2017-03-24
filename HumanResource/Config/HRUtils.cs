using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Config
{
    class HRUtils
    {
        public static float getLuong(decimal luongCB , float heSoLuong, float heSoPhuCap)
        {
            float luong = float.Parse(luongCB.ToString());
            return luong*heSoLuong + luong*heSoPhuCap*heSoLuong;
        }
    }
}
