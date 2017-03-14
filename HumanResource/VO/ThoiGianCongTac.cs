using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class ThoiGianCongTac
    {
        public ThoiGianCongTac()
        {

        }
        public ThoiGianCongTac(string MaNV,string MaCV,DateTime NgayNhamChuc)
        {
            this.MaNV = MaNV;
            this.MaCV = MaCV;
            this.NgayNhamChuc = NgayNhamChuc;
        }
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public DateTime NgayNhamChuc { get; set; }
    }
}
