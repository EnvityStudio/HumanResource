﻿using System;
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
        public string DATA_SOURCE = @"Data Source=HUNGTRAN;Initial Catalog=HumanResource;Integrated Security=True";

        //name tabpages
        public static string TAB_NHANVIEN = "NHANVIEN";
        public static string TAB_PHONGBAN = "PHONGBAN";

        public static string TAB_CURRENT;
        
        //Properties of NhanVien
        public string NHANVIEN_MANV = "maNV";
        public string NHANVIEN_HOTEN = "hoTen";
        public string NHANVIEN_NGAYSINH = "ngaySinh";
        public string NHANVIEN_QUEQUAN = "queQuan";
        public string NHANVIEN_GIOITINH = "gioiTinh";
        public string NHANVIEN_DANTOC = "danToc";
        public string NHANVIEN_SDT = "SDT";
        public string NHANVIEN_MAPB = "maPB";
        public string NHANVIEN_MACV = "maCV";
        public string NHANVIEN_EMAIL = "email";
        public string NHANVIEN_TDHV = "maTDHV";
        public string NHANVIEN_BACLUONG = "bacLuong";
        public string NHANVIEN_ANH = "Anh";
        public string NHANVIEN_MATKHAU = "matKhau";
        public string NHANVIEN_CMND = "CMND";

        // Proceduces of NhanVien
        public string PROC_GET_LIST_NHANVIEN = "GetListNhanVien";
        public string PROC_UPDATE_NHANVIEN = "SuaNhanVien";
        public string PROC_DELETE_NHANVIEN = "XoaNhanVien";
        public string PROC_INSERT_NHANVIEN = "InsertNhanVien";
        public string PROC_GET_MANV_NEXT = "GetMaNVNext";
        public string PROC_SEARCH_PHONGBAN = "SearchPB";



        // Get ID NEXT
        public string GET_ID_MANHANVIEN = "GetMaNhanVien";
        public string GET_ID_MACHUCVU = "GetMaChucVu";
        public string GET_ID_MAPHONGBAN = "GetMaPhongBan";
        public string GET_ID_MATRINHDOHOCVAN = "GetMaTrinhDoHocVan";


        // Proceduce of PhongBan

        public string PROC_GET_LIST_PHONGBAN = "GetListPhongBan";



        //Proceduces of ChucVu

        public string PROC_GET_LIST_CHUC_VU = "GetlistChucVu";

        //Procdecues of TDHV 

        public string PROC_GET_LIST_TDHV = "GetListTrinhDoHocVan";

        //Procdecues of LUONG
        public string PROC_GET_LIST_LUONG = "GetListLuong";

        //Procdecues of ThanNhan
        public string PROC_GET_LIST_THANNHAN_NV = "GetListThanNhanNV";

    }
}
