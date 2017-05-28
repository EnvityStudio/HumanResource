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
        private bool isAction;
        public UCLuong()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvLuong.DataSource = Bus.GetListLUONG();

        }

        public void setIsAction(bool v)
        {
            isAction = v;
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isAction) return;
                txtBacLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["BacLuong"].Value.ToString();
                txtHeSoLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
                txtHeSoPhuCap.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoPhuCap"].Value.ToString();
                txtLuongCoBan.Text = dgvLuong.Rows[e.RowIndex].Cells["LuongCoBan"].Value.ToString();
            }
            catch (Exception er) { }


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
            
        }

        public void enableTextBox(bool bol)
        {
           
        }

        private Luong getLuongFromFRM()
        {
          
        }
        public bool getIsAction()
        {
            return this.isAction;
        }
        public void AddLuong()
        {
          
        }

        public void UpdateLuong()
        {
           
        }

        public void DeleteLuong()
        {
           
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isAction) return;
                txtBacLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["BacLuong"].Value.ToString();
                txtHeSoLuong.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
                txtHeSoPhuCap.Text = dgvLuong.Rows[e.RowIndex].Cells["HeSoPhuCap"].Value.ToString();
                txtLuongCoBan.Text = dgvLuong.Rows[e.RowIndex].Cells["LuongCoBan"].Value.ToString();
            }
            catch (Exception er) { }
        }
    }
}
