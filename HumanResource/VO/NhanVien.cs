using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class NhanVien
    {
        public NhanVien()
        {
        }
        public NhanVien(string maNV,string HoTen,DateTime NgaySinh,string QueQuan,string GioiTinh,string DanToc,string Sdt,string MaPB,string MaCV)

        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.GioiTinh = GioiTinh;
            this.DanToc = DanToc;
            this.Sdt = Sdt;
            this.MaPB = MaPB;
            this.MaCV = MaCV;
        }
        public string MaNV
        {
            get;set;
        }
        public string HoTen
        { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string Sdt { get; set; }
        public string MaPB { get; set; }
        public string MaCV { get; set; }



    }
}
