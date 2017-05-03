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
    public partial class UCLuong : UserControl
    {
        public UCLuong()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvLuong.DataSource = Bus.GetListLUONG();

        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBacLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["BacLuong"].Value.ToString();
            txtHeSoLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
            txtHeSoPhuCap.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoPhuCap"].Value.ToString();
            txtLuongCoBan.Text = dgvLuong.Rows[e.RowIndex].Cells["LuongCoBan"].Value.ToString();
        }

        public void ClearTextBox()
        {
            txtBacLuong.Text = "";
            txtHeSoLuong.Text = "";
            txtHeSoPhuCap.Text = "";
            txtLuongCoBan.Text = "";
        }
        public string getBacLuongNext()
        {
            DataTable dt = Bus.GetBacLuongNext();
            string ma = dt.Rows[0][0].ToString();
            return ma;
        }
        public void setBacLuong()
        {
            txtBacLuong.Text = getBacLuongNext();
            enableTextBox(true);
        }

        public void enableTextBox(bool bol)
        {
            txtHeSoLuong.Enabled = bol;
            txtHeSoPhuCap.Enabled = bol;
            txtLuongCoBan.Enabled = bol;
        }

        private Luong getLuongFromFRM()
        {
            Luong luong = new Luong();
            luong.BacLuong = txtBacLuong.Text;
            luong.HeSoLuong = txtHeSoLuong.Text;
            luong.HeSoPhuCap = txtHeSoPhuCap.Text;
            luong.LuongCoBan = txtLuongCoBan.Text;
            return luong;
        }
        
        public void AddLuong()
        {
            setBacLuong();
            Luong luong = getLuongFromFRM();
            int result = Bus.InsertLuong(luong);
            if(result != -1)
            {
                MessageBox.Show("Thêm lương thành công!","Thông báo",MessageBoxButtons.OK);
                ClearTextBox();
                enableTextBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công!","Thông báo",MessageBoxButtons.OK);
            }
        }

        public void UpdateLuong()
        {
            Luong luong = getLuongFromFRM();
            int result = Bus.UpdateLuong(luong);
            if(result != -1)
            {
                MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK);
                ClearTextBox();
                enableTextBox(false);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công!","Thông báo",MessageBoxButtons.OK);
            }
        }

        public void DeleteLuong()
        {
            Luong luong = getLuongFromFRM();
            int result = Bus.DeleteLuong(luong.BacLuong);
            if (result != -1)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
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
