using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.VO
{
    public class TheoDoi
    {
        public string MaNV { get; set; }
        public string MaTD { get; set; }
        public string SuKien { get; set; }
        public DateTime NgayThang { get; set; }
        public TheoDoi(string maNV , string maTD, DateTime ngayThang ,string suKien)
        {
            this.MaNV = maNV;
            this.MaTD = maTD;
            this.NgayThang = ngayThang;
            this.SuKien = suKien;
        }


    }
}
