using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class PhongBan
    {
        public PhongBan()
        { }
        public PhongBan(string maPB,string tenPB,string maTP ,string diaChi,string sdt,int soLuong)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.DiaChi = DiaChi;
            this.SDT = sdt;
            this.SoLuong = soLuong;
        }
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int SoLuong { get; set; }
        public string MaTP { get; set; }
    }
}
