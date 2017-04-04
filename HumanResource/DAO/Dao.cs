﻿using HumanResource.Config;
using HumanResource.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.DAO
{
    class Dao
    {
        public static Configuration config = new Configuration();

        public static DataTable GetListNhanVien()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_NHANVIEN);

        }

        internal static DataTable GetNamePhongBan(String maPB)
     
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@maPB",maPB),

            };
            return DataProvider.GetDataByParameter(config.PROC_SEARCH_PHONGBAN, para);
        }

        internal static DataTable GetListTheoDoi()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_THEO_DOI);
        }

        internal static DataTable GetListChucVu()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_CHUC_VU);
        }
        
        internal static int InsertThanNhan(ThanNhan thanNhan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THAN_NHAN_MANV,thanNhan.MaNV),
                new SqlParameter("@"+config.THAN_NHAN_MATN,thanNhan.MaTN),
                new SqlParameter("@"+config.THAN_NHAN_HOTEN,thanNhan.HoTen),
                new SqlParameter("@"+config.THAN_NHAN_QUAN_HE,thanNhan.QuanHe),
                 new SqlParameter("@"+config.THAN_NHAN_GIOI_TINH,thanNhan.GioiTinh)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_THANH_NHAN,para);
        }

        internal static int UpdateThanNhan(ThanNhan thanNhan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THAN_NHAN_MANV,thanNhan.MaNV),
                new SqlParameter("@"+config.THAN_NHAN_MATN,thanNhan.MaTN),
                new SqlParameter("@"+config.THAN_NHAN_HOTEN,thanNhan.HoTen),
                new SqlParameter("@"+config.THAN_NHAN_QUAN_HE,thanNhan.QuanHe),
                 new SqlParameter("@"+config.THAN_NHAN_GIOI_TINH,thanNhan.GioiTinh)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDAT_THAN_NHAN, para);
        }

        internal static int InsertTheoDoi(TheoDoi theoDoi)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THEO_DOI_MANV,theoDoi.MaNV),
                new SqlParameter("@"+config.THEO_DOI_MATD,theoDoi.MaTD),
                new SqlParameter("@"+config.THEO_DOI_THOI_GIAN,theoDoi.NgayThang),
                new SqlParameter("@"+config.THEO_DOI_SU_KIEN,theoDoi.SuKien)
             
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_THEO_DOI, para);
        }

        internal static int UpdateTheoDoi(TheoDoi theoDoi)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THEO_DOI_MANV,theoDoi.MaNV),
                new SqlParameter("@"+config.THEO_DOI_MATD,theoDoi.MaTD),
                new SqlParameter("@"+config.THEO_DOI_THOI_GIAN,theoDoi.NgayThang),
                new SqlParameter("@"+config.THEO_DOI_SU_KIEN,theoDoi.SuKien)

            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_THEO_DOI, para);
        }

        internal static int DeleteTheoDoi(string MaTD)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THEO_DOI_MATD,MaTD),

            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_THEO_DOI,para);
        }

        public static DataTable SearchThanNhan(string maTN)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THAN_NHAN_MATN,maTN),        
            };
            return DataProvider.GetDataByParameter(config.PROC_SEARCH_THAN_NHAN, para);
        }

        public static DataTable GetMaTheoDoiNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_THEO_DOI_NEXT);
        }

        internal static DataTable GetListLUONG()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_LUONG);
        }

        internal static DataTable GetMaThanNhanNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_THAN_NHAN_NEXT);
        }

        internal static DataTable GetListTDHV()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_TDHV);
        }

      
        internal static DataTable GetListPhongBan()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_PHONGBAN);
        }

        internal static int DeleteThanNhan(string maTNCurent)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THAN_NHAN_MATN,maTNCurent) };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_THAN_NHAN,para);
        }

        public static int InsertNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV),
                new SqlParameter("@"+config.NHANVIEN_HOTEN,nv.HoTen),
                new SqlParameter("@"+config.NHANVIEN_NGAYSINH,nv.NgaySinh),
                new SqlParameter("@"+config.NHANVIEN_QUEQUAN,nv.QueQuan),
                new SqlParameter("@"+config.NHANVIEN_GIOITINH,nv.GioiTinh),
                new SqlParameter("@"+config.NHANVIEN_DANTOC,nv.DanToc),
                new SqlParameter("@"+config.NHANVIEN_SDT,nv.Sdt),
                new SqlParameter("@"+config.NHANVIEN_MAPB,nv.MaPB),
                new SqlParameter("@"+config.NHANVIEN_MACV,nv.MaCV),

                new SqlParameter("@"+config.NHANVIEN_BACLUONG,nv.BacLuong),
                new SqlParameter("@"+config.NHANVIEN_MATKHAU,nv.MatKhau),
                new SqlParameter("@"+config.NHANVIEN_TDHV,nv.MaTDHV),
                new SqlParameter("@"+config.NHANVIEN_EMAIL,nv.Email),
                new SqlParameter("@"+config.NHANVIEN_ANH,nv.Anh),

                new SqlParameter("@"+config.NHANVIEN_CMND,nv.CMND),


            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_NHANVIEN, para);

        }

        public static int UpdateNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                          new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV),
                new SqlParameter("@"+config.NHANVIEN_HOTEN,nv.HoTen),
                new SqlParameter("@"+config.NHANVIEN_NGAYSINH,nv.NgaySinh),
                new SqlParameter("@"+config.NHANVIEN_QUEQUAN,nv.QueQuan),
                new SqlParameter("@"+config.NHANVIEN_GIOITINH,nv.GioiTinh),
                new SqlParameter("@"+config.NHANVIEN_DANTOC,nv.DanToc),
                new SqlParameter("@"+config.NHANVIEN_SDT,nv.Sdt),
                new SqlParameter("@"+config.NHANVIEN_MAPB,nv.MaPB),
                new SqlParameter("@"+config.NHANVIEN_MACV,nv.MaCV),
                new SqlParameter("@"+config.NHANVIEN_TDHV,nv.MaTDHV),
                new SqlParameter("@"+config.NHANVIEN_ANH,nv.Anh),
                new SqlParameter("@"+config.NHANVIEN_EMAIL,nv.Email),
                new SqlParameter("@"+config.NHANVIEN_CMND,nv.CMND),
                new SqlParameter("@"+config.NHANVIEN_BACLUONG,nv.BacLuong),
                new SqlParameter("@"+config.NHANVIEN_MATKHAU,nv.MatKhau)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_NHANVIEN, para);


        }
        public static int DeleteNhanVien(NhanVien nv)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,nv.MaNV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_NHANVIEN, para);
        }



        public static DataTable GetListThanNhanNV(String maNV)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,maNV)
            };
            return DataProvider.GetDataByParameter(config.PROC_GET_LIST_THANNHAN_NV, para);
        }

        public static DataTable GetMaNhanVien()
        {
            return DataProvider.GetData(config.GET_ID_MANHANVIEN);
        }
        public static DataTable GetMaChucVu()
        {
            return DataProvider.GetData(config.GET_ID_MACHUCVU);
        }
        public static DataTable GetMaPhongBan()
        {
            return DataProvider.GetData(config.GET_ID_MAPHONGBAN);
        }
        public static DataTable GetMaTrinhDoHocVan()
        {
            return DataProvider.GetData(config.GET_ID_MATRINHDOHOCVAN);
        }
        public static DataTable GetMaNhanVienNext()
        {
            return DataProvider.GetData(config.PROC_GET_MANV_NEXT);
        }
        public static List<DataItem> GetList(string proc)
        {
            return DataProvider.GetList(proc);
        }
    }
}
