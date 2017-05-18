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
        public NhanVien(string MaNV,string HoTen, DateTime NgaySinh,string QueQuan,string GioiTinh,string DanToc,string Sdt,string MaTDHV ,string MaPB,string MaCV, string BacLuong ,string Anh,string MatKhau , string CMND ,string Email)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.GioiTinh = GioiTinh;
            this.DanToc = DanToc;
            this.Sdt = Sdt;
            this.MaPB = MaPB;
            this.MaTDHV = MaTDHV;
            this.MaCV = MaCV;
            this.Anh = Anh;
            this.BacLuong = BacLuong;
            this.CMND = CMND;
            this.MatKhau = MatKhau;
            this.Email = Email;
        }
        public string MaNV  { get;set;}
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string Sdt { get; set; }
        public string MaPB { get; set; }
        public string MaCV { get; set; }
        public string MaTDHV { get; set; }
        public string Anh { get; set; }
        public string BacLuong { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string CMND { get; set; }
    }
}
