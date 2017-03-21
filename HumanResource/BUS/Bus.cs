using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResource.DAO;
using HumanResource.Config;
using System.Data;

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
    }
}
