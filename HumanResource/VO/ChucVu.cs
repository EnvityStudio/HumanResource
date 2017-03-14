using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    class ChucVu
    {
        public ChucVu() { }
        public ChucVu(string MaCV,string TenCV) {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }
        public string MaCV { get; set; }
        public string TenCV { get; set; }

    }
}
