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

        public enum ActionForm
        {
            THEM, SUA, KHONG
        }


        public class infoTab
        {
            public bool Them = true;
            public bool Sua = false;
            public bool CapNhat = false;
            public bool In = false;
            public bool Luu = false;

            public ActionForm action = ActionForm.KHONG;

            public int index = 0;

            public delegate void EventButton();

            public EventButton AddNew = null;
            public EventButton Edit = null;
            public EventButton Delete = null;

            public EventButton Save = null;
            public EventButton Cancel = null;

            public EventButton Refresh = null;

            public EventButton Print = null;

          
        }
    }
}
