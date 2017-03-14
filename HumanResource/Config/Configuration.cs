using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Config
{
    class Configuration
    {
        public string GetProjectLinkDirectory()
        {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }
        public string DATA_SOURCE = @"Data Source=DESKTOP-I324HJM\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True";
        //Properties of NhanVien
        public string NHANVIEN_MANV = "MANV";
        public string NHANVIEN_HOTEN = "HoTen";
        public string NHANVIEN_NGAYSINH = "NgaySinh";
        public string NHANVIEN_QUEQUAN = "QueQuan";
        public string NHANVIEN_GIOITINH = "GioiTinh";
        public string NHANVIEN_DANTOC = "DanToc";
        public string NHANVIEN_SDT = "Sdt";
        public string NHANVIEN_MAPB = "MaPB";
        public string NHANVIEN_MACV = "MaCV";
        // Proceduces of NhanVien
        public string PROC_GET_LIST_NHANVIEN = "DanhSachNhanVien";
        public string PROC_UPDATE_NHANVIEN = "SuaNhanVien";
        public string PROC_DELETE_NHANVIEN = "XoaNhanVien";
        public string PROC_INSERT_NHANVIEN = "ThemNhanVien";



        // Get ID NEXT
        public string GET_ID_MANHANVIEN = "GetMaNhanVien";
        public string GET_ID_MACHUCVU = "GetMaChucVu";
        public string GET_ID_MAPHONGBAN = "GetMaPhongBan";
        public string GET_ID_MATRINHDOHOCVAN = "GetMaTrinhDoHocVan";


    }
}
