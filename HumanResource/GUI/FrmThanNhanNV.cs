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
    public partial class FrmThanNhanNV : Form
    {
        private string maNVCurrent;
        private int action; // =1 : them , = 2 : sua
        private string maTN;

        public FrmThanNhanNV(string maNVCurrent, string maTN, int action)
        {
            InitializeComponent();
            this.maNVCurrent = maNVCurrent;
            this.maTN = maTN;
            this.action = action;
            LoadData();
        }

        public void LoadData()
        {
            if (action == 2)
            {
                showInfoThanNhan();
            }
        }

        public void showInfoThanNhan()
        {
            DataTable dt = Bus.SearchThanNhan(maTN);
            txtHoTen.Text = dt.Rows[0][2].ToString();
            txtQuanHe.Text = dt.Rows[0][4].ToString();
            string gioiTinh = dt.Rows[0][3].ToString();
            if (gioiTinh.Contains("Nam"))
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
        }

        private void btnThanNhanLuu_Click(object sender, EventArgs e)
        {
            int result;
            if (action == 1)
            {
                result = Bus.InsertThanNhan(getThanNhanFromFRM());

            }
            else
            {
                result = Bus.UpdateThanNhan(getThanNhanToUpDate());
            }

            if (result > 0)
            {
                MessageBox.Show("thành công!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("không thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private ThanNhan getThanNhanFromFRM()
        {
            string hoTen, quanHe, gioiTinh;
            string maThanNhan = getMaThanNhanNext();
            if (radioButtonNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            hoTen = txtHoTen.Text;
            quanHe = txtQuanHe.Text;
            ThanNhan thanNhan = new ThanNhan(maNVCurrent, maThanNhan, hoTen, quanHe, gioiTinh);
            return thanNhan;
        }

        private ThanNhan getThanNhanToUpDate()
        {
            string hoTen, quanHe, gioiTinh;
            if (radioButtonNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            hoTen = txtHoTen.Text;
            quanHe = txtQuanHe.Text;
            ThanNhan thanNhan = new ThanNhan(maNVCurrent, maTN, hoTen, quanHe, gioiTinh);
            return thanNhan;
        }
        private void clearTextBox()
        {
            txtHoTen.Text = "";
            txtQuanHe.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
        }
        private string getMaThanNhanNext()
        {
            DataTable dtThanNhan = Bus.GetMaThanNhanNext();
            string maTN = dtThanNhan.Rows[0][0].ToString();
            return maTN;
        }
    }
}
