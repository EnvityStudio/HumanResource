using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResource.BUS;
using HumanResource.VO;

namespace HumanResource.GUI
{
    public partial class UCChucVu : UserControl
    {
        public UCChucVu()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = Bus.GetListChucVu();
            dgvChucVu.DataSource = dt;
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text =  dgvChucVu.Rows[e.RowIndex].Cells["MaCV"].Value.ToString();
            txtTenChucVu.Text = dgvChucVu.Rows[e.RowIndex].Cells["TenCV"].Value.ToString();
        }

        public void ClearTextBox()
        {
            txtMaCV.Text = "";
            txtTenChucVu.Text = "";
        }
        public void setMaCVNext()
        {
            txtMaCV.Text = Bus.getMaChucVuNext();
            EnableTextBox(true);
        }

        public void EnableTextBox(bool bol)
        {
            txtTenChucVu.Enabled = bol;
        }

        private bool isEmpty()
        {
            if(txtTenChucVu.Text == null || txtTenChucVu.Text == "")
            {
                return false;
            }
            return true;
        }

        private ChucVu getChucVuFromFRM()
        {
            return new ChucVu() { MaCV = txtMaCV.Text, TenCV = txtTenChucVu.Text};
        }

        public void AddChucVu()
        {
            if (!isEmpty())
            {
                MessageBox.Show("Nhập đầy đủ thông tin.","Thông báo!", MessageBoxButtons.OK);
                return;
            }
            ChucVu chucVu = getChucVuFromFRM();
            int result = Bus.AddChucVu(chucVu);
            if (result > 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
                EnableTextBox(false);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void DeleteChucVu()
        {
            if(txtMaCV.Text == "" || txtMaCV.Text == null)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int result = Bus.DeleteChucVu(txtMaCV.Text);
                if(result != -1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                }else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        public void EditChucVu()
        {
            if (txtMaCV.Text == "" || txtMaCV.Text == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK);
                return;
            } else
            {
                ChucVu chucVu = getChucVuFromFRM();
                int result = Bus.UpdateChucVu(chucVu);
                if(result != -1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                    EnableTextBox(false);
                }else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }
    }
}
