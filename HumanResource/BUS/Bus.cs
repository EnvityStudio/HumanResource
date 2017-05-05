using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.DAO;
using HumanResource.Config;
using System.Data;
using HumanResource.VO;
using System.Windows.Forms;

namespace HumanResource.BUS
{
    class Bus
    {
        public static bool CheckAccount(NhanVien nhanVien)
        {
            DataTable dtNhanVien = GetListNhanVien();
            var userName = nhanVien.HoTen;
            var matKhau = nhanVien.MatKhau;
            
            foreach (DataRow row in dtNhanVien.Rows)
            {
                var name = row["HoTen"].ToString();
                var passw = row["MatKhau"].ToString();
                if (passw == null) continue;
                if (userName == name && matKhau == passw)
                {
                    return true;
                }
            }
            return false;
        }


        public static DataTable GetListNhanVien()
        {
            return Dao.GetListNhanVien();

        }
        public static DataTable GetNamePhongBan(string maPB)
        {
            return Dao.GetNamePhongBan(maPB);
        }

        public static DataTable GetListTheoDoi()
        {
            return Dao.GetListTheoDoi();
        }

        public static DataTable GetListPhongBan()
        {
            return Dao.GetListPhongBan();
        }

        public static DataTable GetListChucVu()
        {
            return Dao.GetListChucVu();
        }

        public static int InsertThanNhan(ThanNhan thanNhan)
        {
            return Dao.InsertThanNhan(thanNhan);
        }

        public static DataTable GetListTDHV()
        {
            return Dao.GetListTDHV();
        }
        public static DataTable GetListLUONG()
        {
            return Dao.GetListLUONG();
        }

        public static DataTable GetListThanNhanNV(string maNV)
        {
            return Dao.GetListThanNhanNV(maNV);
        }

        public static DataTable SearchNhanVienTheoMa(string MaTP)
        {
            return Dao.SearchNhanVienTheoMa(MaTP);
        }

        public  static DataTable GetBacLuongNext()
        {
            return Dao.GetBacLuongNext();
        }

        public static int InsertNhanVien(NhanVien nhanVien)
        {
            return Dao.InsertNhanVien(nhanVien);
            
        }

        public static int UpdateThanNhan(ThanNhan thanNhan)
        {
            return Dao.UpdateThanNhan(thanNhan);
        }

        public static DataTable GetMaNVNext()
        {
            return Dao.GetMaNhanVienNext();
        }
        public static List<DataItem> GetList(string proc)
        {
            return Dao.GetList(proc);
        }

        public static DataTable GetMaThanNhanNext()
        {
            return Dao.GetMaThanNhanNext();
        }

        public static int InsertTheoDoi(TheoDoi theoDoi)
        {
            return Dao.InsertTheoDoi(theoDoi);
               
        }

        public static int InsertLuong(Luong luong)
        {
            return Dao.InsertLuong(luong);
        }

        public static int UpdateNhanVien(NhanVien nhanVien)
        {
            return Dao.UpdateNhanVien(nhanVien);
        }

        public static int DeleteNhanVien(NhanVien nhanVien)
        {
            return Dao.DeleteNhanVien(nhanVien);
        }

        public static int AddHocVan(TrinhDoHocVan hocVan)
        {
            return Dao.AddHocVan(hocVan);
        }

        public static int DeleteThanNhan(string maTNCurent)
        {
            return Dao.DeleteThanNhan(maTNCurent);
        }

        public static int UpdateLuong(Luong luong)
        {
            return Dao.UpdateLuong(luong);
        }

        public static DataTable SearchThanNhan(string maTN)
        {
            return Dao.SearchThanNhan(maTN);
        }

        public static int InsertPhongBan(PhongBan phongBan)
        {
            return Dao.InsertPhongBan(phongBan);
             
        }

        public static int UpdateChucVu(ChucVu chucVu)
        {
            return Dao.UpdateChucVu(chucVu);
        }

        public static DataTable GetMaPBNext()
        {
            return Dao.GetMaPBNext();
        }

        public static DataTable GetMaTDNext()
        {
            return Dao.GetMaTheoDoiNext();
        }

        public static int UpdateTheoDoi(TheoDoi theoDoi)
        {
            return Dao.UpdateTheoDoi(theoDoi);
        }

        public static int DeleteLuong(string bacLuong)
        {
            return Dao.DeleteLuong(bacLuong);
        }

        public static int DeleteTheoDoi(string maTDCurrent)
        {
            return Dao.DeleteTheoDoi(maTDCurrent);
        }

        public static int DeleteHocVan(string maTDHV)
        {
            return Dao.DeleteHocVan(maTDHV);
        }

        public static DataTable GetListThanNhan()
        {
            return Dao.GetListThanNhan();
        }
        public static DataTable GetMaTDHVNext()
        {
            return Dao.GetMaTDHVNext();
        }

        public static int UpdateHocVan(TrinhDoHocVan hocVan)
        {
            return Dao.UpdateHocVan(hocVan);
        }

        public static int DeletePhongBan(string maPB)
        {
            return Dao.DeletePhongBan(maPB);
        }

        public static int UpdatePhongBan(PhongBan phongBan)
        {
            return Dao.UpdatePhongBan(phongBan);
        }

        public static string getMaChucVuNext()
        {
            DataTable dt = Dao.getMaChucVuNext();
            string ma = dt.Rows[0][0].ToString();
            return ma;
        }

        public static int AddChucVu(ChucVu chucVu)
        {
            return Dao.AddChucVu(chucVu);
        }

        public static int DeleteChucVu(string maCV)
        {
            return Dao.DeleteChucVu(maCV);
        }

        public static string formatKey(string key)
        {
            string newKey = "%" + key + "%";
            return newKey;
        }

        public static DataTable SearchNhanVienByMaNV(string key)
        {
            key = formatKey(key);
            return Dao.SearchNhanVienByMaNV(key);
        }

        public static DataTable SearchNhanVienByTenNV(string key)
        {
            key = formatKey(key);
            return Dao.SearchNhanVienByTenNV(key);
        }
        public static DataTable SearchNhanVienByQueQuan(string key)
        {
            key = formatKey(key);
            return Dao.SearchNhanVienByQueQuan(key);
        }
        public static DataTable SearchNhanVienByGioiTinh(string key)
        {
          //  key = key
          if(key.Contains("nữ") || key.Contains("nu"))
            {
                return getNuNV();
            }
          else if (key.Contains("na"))
            {
                return Dao.getNamNhanVien();
            }
            else if (key.Contains("n"))
            {
                return Dao.GetListNhanVien();
            }
            return Dao.SearchNhanVienByGioiTinh(key);
        }
        public static DataTable SearchNhanVienByPhongBan(string key)
        {
            key = formatKey(key);
            DataTable dtPB = Dao.SearchPhongBanByTenPB(key);
            string maPB = "";
            if(dtPB != null)
            {
                maPB = dtPB.Rows[0]["MaPB"].ToString();
            }
            return Dao.SearchNhanVienByMaPB(maPB);
        }
        public static string getTenPhongBanByMaPB(string key)
        {
            key = formatKey(key);
            DataTable dtPB = Dao.SearchPhongBanByTenPB(key);
            return dtPB.Rows[0]["TenPB"].ToString();
        }
        public static DataTable getNuNV()
        {
            return Dao.getNuNhanVien();
        }

    }
}
