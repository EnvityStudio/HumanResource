using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class ThanNhan
    {
        public string HoTen { get; set; }
        public string QuanHe { get; set; }
        public string GioiTinh { get; set; }
        public string MaNV { get; set; }
        public string MaTN { get; set; }
        public ThanNhan(string maNV , string maTN, string hoTen , string quanHe, string gioiTinh)
        {
            this.MaNV = maNV;
            this.MaTN = maTN;
            this.HoTen = hoTen;
            this.QuanHe = quanHe;
            this.GioiTinh = gioiTinh;
        }
    }
}
