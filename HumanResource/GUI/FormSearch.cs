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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgbNhanVien.DataSource = Bus.GetListNhanVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            int type = cbbType.SelectedIndex;

            // 0: Mã nhân viên
            // 1: Tên nhân viên
            // 2: Tên phòng ban
            // 3: Quê quán
            // 4: Giới tính
            switch (type)
            {
                case 0: dgbNhanVien.DataSource = Bus.SearchNhanVienByMaNV(key); break;
                case 1: dgbNhanVien.DataSource = Bus.SearchNhanVienByTenNV(key); break;
                case 2:
                    {   dgbNhanVien.DataSource = Bus.SearchNhanVienByPhongBan(key);
                        txtKey.Text = Bus.getTenPhongBanByMaPB(key);
                        break;
                    }
                case 3: dgbNhanVien.DataSource = Bus.SearchNhanVienByQueQuan(key); break;
                case 4: dgbNhanVien.DataSource = Bus.SearchNhanVienByGioiTinh(key); break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
