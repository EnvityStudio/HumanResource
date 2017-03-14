using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class TrinhDoHocVan
    {
        public TrinhDoHocVan()
        { this.MaTDHV = MaTDHV;
            this.TenTrinhDo = TenTrinhDo;
            this.ChuyenNganh = ChuyenNganh;
        }
        public TrinhDoHocVan(string MaTDHV,string TenTrinhDo,string ChuyenNganh)
        { }
        public string MaTDHV { get; set; }
        public string TenTrinhDo { get; set; }
        public string ChuyenNganh { get; set; }

    }
}
