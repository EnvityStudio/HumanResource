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

        private void btnAccept_Click(object sender, EventArgs e)
        {
           if(txtPassword2.Text != txtPassword1.Text || txtPassword1.Text == "")
            {
                MessageBox.Show("Mật khẩu không đúng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            nhanVien.MatKhau = txtPassword1.Text;
            int result = Bus.UpdateNhanVien(nhanVien);
            if(result != -1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword2.Text != txtPassword1.Text)
            {
                errorProvider1.SetError(txtPassword2, "Mật khẩu không đúng");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
