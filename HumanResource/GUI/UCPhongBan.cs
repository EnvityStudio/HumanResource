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
    public partial class UCPhongBan : UserControl
    {
        public UCPhongBan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvPhongBan.DataSource = Bus.GetListPhongBan();
        }

        private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "Value";
            cbb.DisplayMember = "Name";
        }
        private void LoadNameFromID(ComboBox cbb, string id, List<DataItem> list)
        {
            // cbb.DataSource = list;
            LoadComboboxData(cbb, list);
            int i = 0;
            foreach (DataItem di in list)
            {
                if (di.Value.Contains(id))
                {
                    cbb.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["MaPB"].Value.ToString();
            txtTenPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["TenPB"].Value.ToString();
            LoadNameFromID(cbbTruongPhong, dgvPhongBan.Rows[e.RowIndex].Cells["MaTP"].Value.ToString(), Bus.GetList("GetlistNhanVien"));
            txtDiaChi.Text = dgvPhongBan.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            txtSoDT.Text = dgvPhongBan.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtTongNV.Text = dgvPhongBan.Rows[e.RowIndex].Cells["TongNV"].Value.ToString();
            //DataTable dt = Bus.SearchNhanVienTheoMa(txtMaTP.Text);
            //if (dt.Rows.Count > 0)
            //{
            //    txtTenTruongPhong.Text = dt.Rows[0][1].ToString();
            //} else txtTenTruongPhong.Text ="";
        }

        public void enableTextBox(bool bol)
        {
            txtDiaChi.Enabled = bol;
            cbbTruongPhong.Enabled = bol;
            txtSoDT.Enabled = bol;
            txtTenPB.Enabled = bol;
            //txtTenTruongPhong.Enabled = bol;
        }

        public void ClearTextBox()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtDiaChi.Text = "";
            txtTenTruongPhong.Text = "";
            txtSoDT.Text = "";
            txtTongNV.Text = "0";
            LoadComboboxData(cbbTruongPhong,Bus.GetList("GetListNhanVien"));
        }

        public bool checkNullToolBox()
        {
            if (txtSoDT.Text == "" || txtTenPB.Text == "" || txtSoDT.Text == null || txtTenPB.Text == null || txtDiaChi.Text == "" || txtDiaChi.Text == null)
            {
                return false;
                //MessageBox.Show("Hãy điền đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK);
            }
            return true;
        }

        public void AddPhongBan()
        {
            bool isEmpty = checkNullToolBox();
            if (!isEmpty)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return ;
            }
            PhongBan phongBan = getPhongBan();
            int result = Bus.InsertPhongBan(phongBan);
            if(result != -1)
            {
                MessageBox.Show("Thêm mới phòng ban thành công!","Thông báo",MessageBoxButtons.OK);
                enableTextBox(false);
                ClearTextBox();
                LoadData();
            } else
            {
                MessageBox.Show("Không thành công!","Thông báo",MessageBoxButtons.OK);
            }
        }
        public string getMaPBNext()
        {
            DataTable dt = Bus.GetMaPBNext();
            string ma = dt.Rows[0][0].ToString();
            return ma;
        }
        public void setMaPBNext()
        {
            txtMaPB.Text = getMaPBNext();
        }

        private PhongBan getPhongBan()
        {
            PhongBan phongBan = new PhongBan();
            phongBan.MaPB = txtMaPB.Text;
            phongBan.TenPB = txtTenPB.Text;
            phongBan.MaTP = cbbTruongPhong.SelectedValue.ToString();
            phongBan.SDT = txtSoDT.Text;
            phongBan.DiaChi = txtDiaChi.Text;
            phongBan.SoLuong = int.Parse(txtTongNV.Text);
            return phongBan;
        }

        public void DeletePhongBan()
        {
            PhongBan phongBan = new PhongBan();
            phongBan = getPhongBan();
            int result = Bus.DeletePhongBan(phongBan.MaPB);
            if (result != -1)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ClearTextBox();
                enableTextBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công!","Thông báo",MessageBoxButtons.OK);
            }
        }

        public void UpdatePhongBan()
        {
            PhongBan phongBan = new PhongBan();
            phongBan = getPhongBan();
            int result = Bus.UpdatePhongBan(phongBan);
            if (result != -1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                ClearTextBox();
                enableTextBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

    }
}
