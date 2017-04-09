using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.DAO;
using HumanResource.Config;
using System.Data;
using HumanResource.VO;

namespace HumanResource.BUS
{
    class Bus
    {
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
    }
}
