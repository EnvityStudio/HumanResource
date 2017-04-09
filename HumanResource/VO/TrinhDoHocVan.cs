using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class TrinhDoHocVan
    {
        
        public string MaTDHV { get; set; }
        public string TenTrinhDo { get; set; }
        public string ChuyenNganh { get; set; }
        public int SoLuong { get; set; }
        public TrinhDoHocVan(string maTDHV, string tenTrinhDo, string chuyenNganh, int soLuong)
        {
            this.MaTDHV = maTDHV;
            this.TenTrinhDo = tenTrinhDo;
            this.ChuyenNganh = chuyenNganh;
            this.SoLuong = soLuong;
        }
        public TrinhDoHocVan()
        {
        }

    }
}
