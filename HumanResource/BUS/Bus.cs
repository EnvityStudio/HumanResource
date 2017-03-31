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

        public static DataTable GetListPhongBan()
        {
            return Dao.GetListPhongBan();
        }

        public static DataTable GetListChucVu()
        {
            return Dao.GetListChucVu();
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
        public static DataTable GetMaNVNext()
        {
            return Dao.GetMaNhanVienNext();
        }
        public static List<DataItem> GetList(string proc)
        {
            return Dao.GetList(proc);
        }

        internal static int UpdateNhanVien(NhanVien nhanVien)
        {
            return Dao.UpdateNhanVien(nhanVien);
        }

        internal static int DeleteNhanVien(NhanVien nhanVien)
        {
            return Dao.DeleteNhanVien(nhanVien);
        }
    }
}
