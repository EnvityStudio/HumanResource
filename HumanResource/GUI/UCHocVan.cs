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
    public partial class UCHocVan : UserControl
    {
        private TrinhDoHocVan hocVanCurrent = new TrinhDoHocVan();
        private bool isAction;
        public UCHocVan()
        {
            InitializeComponent();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void setIsAction(bool v)
        {
            isAction = v;
        }

        private void LoadData()
        {
            dgvHocVan.DataSource = Bus.GetListTDHV();

        }

        private void dgvHocVan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (isAction) return;
                hocVanCurrent.MaTDHV = txtMaHocVan.Text = dgvHocVan.Rows[e.RowIndex].Cells["MaTDHV"].Value.ToString();
                hocVanCurrent.TenTrinhDo = txtTenHocVan.Text = dgvHocVan.Rows[e.RowIndex].Cells["TenTDHV"].Value.ToString();
                hocVanCurrent.ChuyenNganh = txtChuyenNganh.Text = dgvHocVan.Rows[e.RowIndex].Cells["ChuyenNganh"].Value.ToString();
                txtSoLuong.Text = dgvHocVan.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                hocVanCurrent.SoLuong = int.Parse(txtSoLuong.Text);
            }
            catch(Exception er)
            {

            }
           
        }

        public void ClearTextBox()
        {
            txtMaHocVan.Text = "";
            txtTenHocVan.Text = "";
            txtChuyenNganh.Text = "";
            txtSoLuong.Text = "0";
        }

        private string getMaNext()
        {
            DataTable dt = Bus.GetMaTDHVNext();
            string ma = dt.Rows[0][0].ToString();
            return ma;
        }

        public void setMaNextToToolBox()
        {
            txtMaHocVan.Text = getMaNext();
            enableToolBox(true);
        }

        public void enableToolBox(bool bol)
        {

            txtTenHocVan.Enabled = bol;
            txtChuyenNganh.Enabled = bol;
        }


        private TrinhDoHocVan getHocVanToAdd()
        {
            TrinhDoHocVan hocVan = new TrinhDoHocVan();
            hocVan.TenTrinhDo = txtTenHocVan.Text;
            hocVan.ChuyenNganh = txtChuyenNganh.Text;
            hocVan.SoLuong = 0;
            hocVan.MaTDHV = txtMaHocVan.Text;
            return hocVan;
        }
        public bool getIsAction()
        {
            return this.isAction;
        }

        public bool checkEmpty()
        {
            if (txtTenHocVan.Text == "" || txtChuyenNganh.Text == "") return false;
            return true;
        }

        public void AddHocVan()
        {
            if (!checkEmpty()) return;
             TrinhDoHocVan hocVan = getHocVanToAdd();
            int result = Bus.AddHocVan(hocVan);
            if (result != -1)
            {
                MessageBox.Show("Thêm học vấn thành công !", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
                enableToolBox(false);
                isAction = false;
            }
            else
            {
                MessageBox.Show("Không thành công !", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void DeleteHocVan()
        {
            if (hocVanCurrent.SoLuong > 0)
            {
                MessageBox.Show("Bạn không được phép xóa học vấn này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int result = Bus.DeleteHocVan(hocVanCurrent.MaTDHV);
            if (result != -1)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                ClearTextBox();
                enableToolBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private TrinhDoHocVan getHocVanFromFRM()
        {
            TrinhDoHocVan hocVan = new TrinhDoHocVan();
            hocVan.MaTDHV = txtMaHocVan.Text;
            hocVan.TenTrinhDo = txtTenHocVan.Text;
            hocVan.ChuyenNganh = txtChuyenNganh.Text;

            return hocVan;
        }

        public void UpdateHocVan()
        {
            int result = Bus.UpdateHocVan(getHocVanFromFRM());
            if (result != -1)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                ClearTextBox();
                enableToolBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvHocVan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isAction) return;
                hocVanCurrent.MaTDHV = txtMaHocVan.Text = dgvHocVan.Rows[e.RowIndex].Cells["MaTDHV"].Value.ToString();
                hocVanCurrent.TenTrinhDo = txtTenHocVan.Text = dgvHocVan.Rows[e.RowIndex].Cells["TenTDHV"].Value.ToString();
                hocVanCurrent.ChuyenNganh = txtChuyenNganh.Text = dgvHocVan.Rows[e.RowIndex].Cells["ChuyenNganh"].Value.ToString();
                txtSoLuong.Text = dgvHocVan.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                hocVanCurrent.SoLuong = int.Parse(txtSoLuong.Text);
            } catch(Exception er) { }
           
        }
    }
}
