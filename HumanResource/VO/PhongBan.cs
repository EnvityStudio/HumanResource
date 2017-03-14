using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class PhongBan
    {
        public PhongBan()
        { }
        public PhongBan(string MaPB,string TenPB,string DiaChi,string SdtPB,int TongSoNV)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.DiaChi = DiaChi;
            this.SdtPB = SdtPB;
            this.TongSoNV = TongSoNV;
        }
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string DiaChi { get; set; }
        public string SdtPB { get; set; }
        public int TongSoNV { get; set; }
    }
}
