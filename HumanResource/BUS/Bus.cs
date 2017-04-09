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

        internal static DataTable GetListTheoDoi()
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

        internal static int InsertThanNhan(ThanNhan thanNhan)
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
        public static int InsertNhanVien(NhanVien nhanVien)
        {
            return Dao.InsertNhanVien(nhanVien);
            
        }

        internal static int UpdateThanNhan(ThanNhan thanNhan)
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

        internal static DataTable GetMaThanNhanNext()
        {
            return Dao.GetMaThanNhanNext();
        }

        internal static int InsertTheoDoi(TheoDoi theoDoi)
        {
            return Dao.InsertTheoDoi(theoDoi);
               
        }

        internal static int UpdateNhanVien(NhanVien nhanVien)
        {
            return Dao.UpdateNhanVien(nhanVien);
        }

        internal static int DeleteNhanVien(NhanVien nhanVien)
        {
            return Dao.DeleteNhanVien(nhanVien);
        }

        public static int AddHocVan(TrinhDoHocVan hocVan)
        {
            return Dao.AddHocVan(hocVan);
        }

        internal static int DeleteThanNhan(string maTNCurent)
        {
            return Dao.DeleteThanNhan(maTNCurent);
        }
        public static DataTable SearchThanNhan(string maTN)
        {
            return Dao.SearchThanNhan(maTN);
        }

        public static DataTable GetMaTDNext()
        {
            return Dao.GetMaTheoDoiNext();
        }

        internal static int UpdateTheoDoi(TheoDoi theoDoi)
        {
            return Dao.UpdateTheoDoi(theoDoi);
        }

        internal static int DeleteTheoDoi(string maTDCurrent)
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
