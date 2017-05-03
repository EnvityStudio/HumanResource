using HumanResource.Config;
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

        public static DataTable GetNamePhongBan(String maPB)
     
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@maPB",maPB),

            };
            return DataProvider.GetDataByParameter(config.PROC_SEARCH_PHONGBAN, para);
        }

        public static DataTable GetListTheoDoi()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_THEO_DOI);
        }

        public static DataTable GetListChucVu()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_CHUC_VU);
        }
        
        public static int InsertThanNhan(ThanNhan thanNhan)
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

        public static DataTable SearchNhanVienTheoMa(string maTP)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.NHANVIEN_MANV,maTP),
            };
            return DataProvider.GetDataByParameter(config.PROC_SEARCH_NHANVIEN_MANV, para);
        }

        public static DataTable GetBacLuongNext()
        {
            return DataProvider.GetData(config.PROC_GET_BAC_LUONG_NEXT);
        }

        public static int UpdateThanNhan(ThanNhan thanNhan)
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

        internal static int InsertLuong(Luong luong)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BAC_LUONG,luong.BacLuong),
                new SqlParameter("@"+config.HE_SO_LUONG,luong.HeSoLuong),
                new SqlParameter("@"+config.HE_SO_PHU_CAP,luong.HeSoPhuCap),
                new SqlParameter("@"+config.LUONG_CO_BAN,luong.LuongCoBan)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_LUONG, para);
        }

        public static int UpdateLuong(Luong luong)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BAC_LUONG,luong.BacLuong),
                new SqlParameter("@"+config.HE_SO_LUONG,luong.HeSoLuong),
                new SqlParameter("@"+config.HE_SO_PHU_CAP,luong.HeSoPhuCap),
                new SqlParameter("@"+config.LUONG_CO_BAN,luong.LuongCoBan)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_LUONG, para);
        }

        public static int UpdateChucVu(ChucVu chucVu)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHUCVU_MACV,chucVu.MaCV),
                new SqlParameter("@"+config.CHUCVU_TENCV,chucVu.TenCV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_CHUCVU, para);
        }

        public static int InsertPhongBan(PhongBan phongBan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.PHONGBAN_MAPB,phongBan.MaPB),
                new SqlParameter("@"+config.PHONGBAN_TENPB,phongBan.TenPB),
                new SqlParameter("@"+config.PHONGBAN_MATP,phongBan.MaTP),
                new SqlParameter("@"+config.PHONGBAN_SDT,phongBan.SDT),
                new SqlParameter("@"+config.PHONGBAN_DIACHI,phongBan.DiaChi)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_PHONGBAN, para);
        }

        public static DataTable GetMaPBNext()
        {
            return DataProvider.GetData(config.PROC_GET_MAPB_NEXT);
        }

        public static int DeleteLuong(string bacLuong)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.BAC_LUONG,bacLuong)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_LUONG, para);
        }

        public static DataTable getMaChucVuNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_CHUC_VU_NEXT);
        }

        public static int UpdatePhongBan(PhongBan phongBan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.PHONGBAN_MAPB,phongBan.MaPB),
                new SqlParameter("@"+config.PHONGBAN_TENPB,phongBan.TenPB),
                new SqlParameter("@"+config.PHONGBAN_MATP,phongBan.MaTP),
                new SqlParameter("@"+config.PHONGBAN_SDT,phongBan.SDT),
                new SqlParameter("@"+config.PHONGBAN_DIACHI,phongBan.DiaChi)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_PHONGBAN, para);
        }

        public static int DeleteChucVu(string maCV)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHUCVU_MACV,maCV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_CHUCVU, para);
        }

        public static int AddChucVu(ChucVu chucVu)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.CHUCVU_MACV,chucVu.MaCV),
                new SqlParameter("@"+config.CHUCVU_TENCV,chucVu.TenCV)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_ADD_CHUCVU, para);
        }

        public static int DeletePhongBan(string maPB)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.PHONGBAN_MAPB,maPB)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_PHONGBAN, para);
        }

        public static int InsertTheoDoi(TheoDoi theoDoi)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THEO_DOI_MANV,theoDoi.MaNV),
                new SqlParameter("@"+config.THEO_DOI_MATD,theoDoi.MaTD),
                new SqlParameter("@"+config.THEO_DOI_THOI_GIAN,theoDoi.NgayThang),
                new SqlParameter("@"+config.THEO_DOI_SU_KIEN,theoDoi.SuKien)
             
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_THEO_DOI, para);
        }

        public static int AddHocVan(TrinhDoHocVan hocVan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOC_VAN_MAHV,hocVan.MaTDHV),
                new SqlParameter("@"+config.HOC_VAN_TENHV,hocVan.TenTrinhDo),
                new SqlParameter("@"+config.HOC_VAN_SOLUONG,hocVan.SoLuong),
                new SqlParameter("@"+config.HOC_VAN_CHUYENNGANH,hocVan.ChuyenNganh)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_INSERT_TDHV, para);
        }

        public static int DeleteHocVan(string maTDHV)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOC_VAN_MAHV,maTDHV)
                  };
            return DataProvider.ExecuteNonQuery(config.PROC_DELETE_TDHV, para);
        }

        public static int UpdateHocVan(TrinhDoHocVan hocVan)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.HOC_VAN_MAHV,hocVan.MaTDHV),
                new SqlParameter("@"+config.HOC_VAN_TENHV,hocVan.TenTrinhDo),
                new SqlParameter("@"+config.HOC_VAN_CHUYENNGANH,hocVan.ChuyenNganh)
            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_TDHV, para);
        }

        public static int UpdateTheoDoi(TheoDoi theoDoi)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@"+config.THEO_DOI_MANV,theoDoi.MaNV),
                new SqlParameter("@"+config.THEO_DOI_MATD,theoDoi.MaTD),
                new SqlParameter("@"+config.THEO_DOI_THOI_GIAN,theoDoi.NgayThang),
                new SqlParameter("@"+config.THEO_DOI_SU_KIEN,theoDoi.SuKien)

            };
            return DataProvider.ExecuteNonQuery(config.PROC_UPDATE_THEO_DOI, para);
        }

        public static DataTable GetListThanNhan()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_THANNHAN);
        }

        public static int DeleteTheoDoi(string MaTD)
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

        public static DataTable GetListLUONG()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_LUONG);
        }

        public static DataTable GetMaThanNhanNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_THAN_NHAN_NEXT);
        }

        public static DataTable GetListTDHV()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_TDHV);
        }

      
        public static DataTable GetListPhongBan()
        {
            return DataProvider.GetData(config.PROC_GET_LIST_PHONGBAN);
        }

        public static int DeleteThanNhan(string maTNCurent)
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
        public static DataTable GetMaTDHVNext()
        {
            return DataProvider.GetData(config.PROC_GET_MA_TDHV_NEXT);
        }
    }
}
