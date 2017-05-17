using HumanResource.BUS;
using HumanResource.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.GUI
{
    public partial class FormChangePassword : Form
    {
        private NhanVien nhanVien;
        public FormChangePassword(string maNV)
        {
            InitializeComponent();
            this.nhanVien = Bus.getNhanVien(maNV);
            LoadName();
        }

        public void LoadName()
        {
            lblUser.Text = nhanVien.HoTen;
        }
        
    }
}
