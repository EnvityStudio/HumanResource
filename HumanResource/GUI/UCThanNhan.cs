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
    public partial class UCThanNhan : UserControl
    {
        private string PROC_GET_LIST_NHAN_VIEN = "GetListNhanVien";
        public UCThanNhan()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgvThanNhan.DataSource = Bus.GetListThanNhan();
            LoadComboboxData(cbxMaNV, Bus.GetList(PROC_GET_LIST_NHAN_VIEN));
        }

        private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "Value";
            cbb.DisplayMember = "Name";
        }

        public void enableToolBox(bool bol)
        {
            cbxMaNV.Enabled = bol;
            textBoxQuanHe.Enabled = bol;
            rbNam.Enabled = bol;
            rbNu.Enabled = bol;
            textBoxTenThanNhan.Enabled = bol;
        }

        public string getMaThanNhanNext()
        {
            DataTable dtThanNhan = Bus.GetMaThanNhanNext();
            string maTN = dtThanNhan.Rows[0][0].ToString();
            return maTN;
        }

        private ThanNhan getThanNhanToAdd()
        {
            string hoTen, quanHe, gioiTinh;
            string maThanNhan = getMaThanNhanNext();
            if (rbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            hoTen = textBoxTenThanNhan.Text;
            quanHe = textBoxQuanHe.Text;
            ThanNhan thanNhan = new ThanNhan(cbxMaNV.SelectedValue.ToString(), maThanNhan, hoTen, quanHe, gioiTinh);
            return thanNhan;
        }
        public void ClearTextBox()
        {
            textBoxQuanHe.Text = "";
            textBoxTenThanNhan.Text = "";
        }
        public  void setMaThanNhan()
        {
            textBoxMaTN.Text = getMaThanNhanNext();
            enableToolBox(true);
        }

        private ThanNhan getThanNhanFromFRM()
        {
            string hoTen, quanHe, gioiTinh , maThanNhan;
            maThanNhan = textBoxMaTN.Text;
            if (rbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            hoTen = textBoxTenThanNhan.Text;
            quanHe = textBoxQuanHe.Text;
            ThanNhan thanNhan = new ThanNhan(cbxMaNV.SelectedValue.ToString(), maThanNhan, hoTen, quanHe, gioiTinh);
            return thanNhan;
        }


        public void AddThanNhan()
        {
            ThanNhan thanNhan = getThanNhanToAdd();
            int result = Bus.InsertThanNhan(thanNhan);
            if (result != -1)
            {
                MessageBox.Show("Thêm mới thân nhân thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
                enableToolBox(false);
            } else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvThanNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadNameFromID(cbxMaNV, dgvThanNhan.Rows[e.RowIndex].Cells["MaNV"].Value.ToString()
                ,Bus.GetList(PROC_GET_LIST_NHAN_VIEN));
            textBoxMaTN.Text = dgvThanNhan.Rows[e.RowIndex].Cells["MaTN"].Value.ToString();
            textBoxTenThanNhan.Text = dgvThanNhan.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            textBoxQuanHe.Text = dgvThanNhan.Rows[e.RowIndex].Cells["QuanHe"].Value.ToString();
            string gioiTinh = dgvThanNhan.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            if (gioiTinh.Contains("Nam"))
            {
                rbNam.Checked = true;
            }
            else rbNu.Checked = true;
        }

        private void LoadNameFromID(ComboBox cbb, string id, List<DataItem> list)
        {
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
        public void UpdateThanNhan()
        {
            ThanNhan thanNhan = getThanNhanFromFRM();
            int result = Bus.UpdateThanNhan(thanNhan);
            if (result != -1)
            {
                MessageBox.Show("Sửa thân nhân thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
                enableToolBox(false);
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void DeleteThanNhan()
        {
            int result = Bus.DeleteThanNhan(textBoxMaTN.Text);
            if (result != -1)
            {
                MessageBox.Show("Xóa thân nhân thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBox();
                enableToolBox(false);
            }
            else
            {
                MessageBox.Show("Không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
