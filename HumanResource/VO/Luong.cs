using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class Luong
    {
        public Luong() { }
        public Luong(string BacLuong,string LuongCoBan,string HeSoLuong,string HeSoPhuCap)
        {
            this.BacLuong = BacLuong;
            this.LuongCoBan = LuongCoBan;
            this.HeSoLuong = HeSoLuong;
            this.HeSoPhuCap = HeSoPhuCap;

        }

        public string BacLuong { get; set; }
        public string LuongCoBan { get; set; }
        public string HeSoLuong { get; set; }
        public string HeSoPhuCap { get; set; }
    }
}
