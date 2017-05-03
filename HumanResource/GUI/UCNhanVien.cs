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
using HumanResource.Config;
using static HumanResource.Config.HRUtils;
using HumanResource.VO;
using System.Collections;

namespace HumanResource.GUI
{
    partial class UCNhanVien : UserControl
    {
        private string avataPath;
        private NhanVien nhanVien;
        public string PROC_GET_LIST_PHONGBAN = "GetListPhongBan";
        public string PROC_GET_LIST_CHUC_VU = "GetlistChucVu";
        public string PROC_GET_LIST_TDHV = "GetListTrinhDoHocVan";
        public string PROC_GET_LIST_LUONG = "GetListLuong";
        public string PROC_GET_LIST_THANNHAN_NV = "GetListThanNhanNV";
        Dictionary<String, String> phongBan = new Dictionary<string, string>();
        Dictionary<String, String> chucVu = new Dictionary<string, string>();
        Dictionary<String, String> tdhv = new Dictionary<string, string>();
        Dictionary<string, string> luong = new Dictionary<string, string>();
        List<DataItem> listPhongBan;
        List<DataItem> listChucVu;
        List<DataItem> listTDHV;
        List<DataItem> listLuong;
        private string maNVCurrent;

        public UCNhanVien()
        {
            InitializeComponent();
            Configuration.TAB_CURRENT = Configuration.TAB_NHANVIEN;
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            enableBox(false);
        }

        public void LoadData()
        {
            dataGridViewNhanVien.DataSource = Bus.GetListNhanVien();
            dataGridViewNhanVien.Columns["Anh"].Visible = false;
            dataGridViewNhanVien.Columns["TrangThai"].Visible = false;
            listPhongBan = Bus.GetList(PROC_GET_LIST_PHONGBAN);
            listChucVu = Bus.GetList(PROC_GET_LIST_CHUC_VU);
            listTDHV = Bus.GetList(PROC_GET_LIST_TDHV);
            listLuong = Bus.GetList(PROC_GET_LIST_LUONG);
        }

        private void dataGridViewNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataTable dtPB = Bus.GetListPhongBan();
            Dictionary<String, String> phongBan = new Dictionary<string, string>();
            DataTable dtChucVu = Bus.GetListChucVu();
            Dictionary<String, String> chucVu = new Dictionary<string, string>();
            DataTable dtTdhv = Bus.GetListTDHV();
            Dictionary<String, String> tdhv = new Dictionary<string, string>();
            DataTable dtLuong = Bus.GetListLUONG();
            Dictionary<string, List<decimal>> luong = new Dictionary<string, List<decimal>>();
            foreach (DataRow row in dtLuong.Rows)
            {
                List<decimal> l = new List<decimal>();
                l.Add(decimal.Parse(row["LuongCoBan"].ToString()));
                l.Add(decimal.Parse(row["HeSoLuong"].ToString()));
                l.Add(decimal.Parse(row["HeSoPhuCap"].ToString()));
                luong.Add(row["BacLuong"].ToString(), l);
            }
            foreach (DataRow row in dtPB.Rows)
            {
                phongBan.Add(row["MaPB"].ToString(), row["TenPB"].ToString());
            }
            foreach (DataRow row in dtChucVu.Rows)
            {
                chucVu.Add(row["MaCV"].ToString(), row["TenCV"].ToString());
            }
            foreach (DataRow row in dtTdhv.Rows)
            {
                tdhv.Add(row["MaTDHV"].ToString(), row["TenTDHV"].ToString());
            }
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "MaCV")
            {
                if (e.Value != null)
                {
                    for (int i = 0; i < chucVu.Count; i++)
                    {
                        string x;
                        if (chucVu.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = chucVu[e.Value.ToString()];
                        }
                    }
                }
            }
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "MaPB")
            {
                if (e.Value != null)
                {
                    for (int i = 0; i < phongBan.Count; i++)
                    {
                        string x;
                        if (phongBan.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = phongBan[e.Value.ToString()];

                        }
                    }

                }
            }

            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "MaTDHV")
            {
                if (e.Value != null)
                {
                    for (int i = 0; i < tdhv.Count; i++)
                    {
                        string x;
                        if (tdhv.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = tdhv[e.Value.ToString()];

                        }
                    }

                }
            }

            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "BacLuong")
            {
                if (e.Value != null)
                {
                    for (int i = 0; i < tdhv.Count; i++)
                    {
                        List<decimal> x = new List<decimal>();
                        if (luong.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = HRUtils.getLuong(x[0], float.Parse(x[1].ToString()), float.Parse(x[2].ToString())).ToString();

                        }
                    }

                }
            }
        }

        internal void EditClick()
        {
            if (txtMaNV.Text.Equals("") || txtMaNV.Text.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                enableBox(true);
            }
        }

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows)
            {
                DataTable thanNhan = Bus.GetListThanNhanNV(row.Cells[0].ToString());
                dataGridViewThanNhan.DataSource = thanNhan;
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.CurrentRow != null)
            {
                string Path = "Reesource";
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image|*.jpg;*.png;*.gif;*.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        if (System.IO.File.Exists(Path))
                        {
                            try
                            {
                                System.IO.File.Delete(Path);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    avataPath = open.FileName;
                    try
                    {
                        pictureBox1.Image.Save(Path);
                    }
                    catch { }
                }

            }
        }

        public NhanVien getDataNhanVien()
        {
            string MaNV, HoTen, GioiTinh, MaCV, MaPB, MaTDHV, QueQuan, Anh, Sdt, Email, MatKhau, DanToc, BacLuong, CMND;
            DateTime NgaySinh;
            MaNV = txtMaNV.Text;
            HoTen = txtHoTen.Text;
            if (rdGTNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else GioiTinh = "Nữ";
            MaCV = ((DataItem)cbbChucVu.SelectedItem).Value;
            MaPB = ((DataItem)cbbPhong.SelectedItem).Value;
            MaTDHV = ((DataItem)cbbTrinhDo.SelectedItem).Value;
            QueQuan = txtQueQuan.Text;
            Sdt = txtSoDT.Text;
            if (avataPath != null)
            {
                Anh = avataPath;
            }
            else
            {
                Anh = Configuration.GetProjectLinkDirectory() + @"/Resource/noimage.png";
            }

            Email = txtEmail.Text;
            NgaySinh = (DateTime)dtNgaySInh.Value;
            MatKhau = txtMK.Text;
            DanToc = txtDanToc.Text;
            BacLuong = ((DataItem)cbbLuong.SelectedItem).Value;
            CMND = txtCMND.Text;
            return new NhanVien(MaNV, HoTen, NgaySinh, QueQuan, GioiTinh, DanToc, Sdt, MaTDHV, MaPB, MaCV, BacLuong, Anh, MatKhau, CMND, Email);
        }
        public void setMaNV()
        {
            DataTable dt = Bus.GetMaNVNext();
            txtMaNV.Text = dt.Rows[0][0].ToString();
            setCombobox();
            enableBox(true);
        }

        public void setCombobox()
        {
            DataTable dtPB = Bus.GetListPhongBan();
            DataTable dtChucVu = Bus.GetListChucVu();
            DataTable dtTdhv = Bus.GetListTDHV();
            DataTable dtLuong = Bus.GetListLUONG();
            phongBan.Clear();
            chucVu.Clear();
            luong.Clear();
            tdhv.Clear();
            foreach (DataRow dr in dtPB.Rows)
            {
                phongBan.Add(dr[0].ToString(), dr[1].ToString());
            }
            foreach (DataRow dr in dtChucVu.Rows)
            {
                chucVu.Add(dr[0].ToString(), dr[1].ToString());
            }
            foreach (DataRow dr in dtLuong.Rows)
            {
                luong.Add(dr[0].ToString(), dr[1].ToString());
            }
            foreach (DataRow dr in dtTdhv.Rows)
            {
                tdhv.Add(dr[0].ToString(), dr[1].ToString());
            }

            LoadComboboxData(cbbPhong, listPhongBan);
            LoadComboboxData(cbbChucVu, listChucVu);
            LoadComboboxData(cbbTrinhDo, listTDHV);
            LoadComboboxData(cbbLuong, listLuong);
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        public void ClearTextBoox()
        {
            txtCMND.Text = "";
            txtMaNV.Text = "";
            txtMK.Text = "";
            txtHoTen.Text = "";
            rdGTNam.Checked = true;
            rdGTNu.Checked = false;
            txtQueQuan.Text = "";
            txtEmail.Text = "";
            txtSoDT.Text = "";
            cbbChucVu.Text = "";
            txtDanToc.Text = "";
            cbbLuong.Text = "";
            cbbPhong.Text = "";
            cbbTrinhDo.Text = "";
            enableBox(false);
        }
        private bool checkTextBox()
        {
            if (!checkEmpty(txtCMND) || !checkEmpty(txtMaNV) || !checkEmpty(txtQueQuan)
                || !checkEmpty(txtEmail) || !checkEmpty(txtSoDT) || !checkEmpty(txtDanToc))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }
        private bool checkEmpty(TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                errorProvider1.SetError(txt, "Không được để trống");
                return false;
            }
            errorProvider1.SetError(txt, "");
            return true;
        }
        public void AddNhanVien()
        {
            if (!checkTextBox())
            {
                return;
            }
            int result = Bus.InsertNhanVien(getDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBoox();
                enableBox(false);
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void enableBox(bool bol)
        {
            txtHoTen.Enabled = bol;
            txtCMND.Enabled = bol;
            txtCMND.Enabled = bol;
            //txtMaNV.Enabled = bol;
            txtMK.Enabled = bol;
            dtNgaySInh.Enabled = bol;
            txtQueQuan.Enabled = bol;
            pictureBox1.Enabled = bol;
            txtEmail.Enabled = bol;
            txtSoDT.Enabled = bol;
            cbbChucVu.Enabled = bol;
            txtDanToc.Enabled = bol;
            cbbLuong.Enabled = bol;
            cbbPhong.Enabled = bol;
            cbbTrinhDo.Enabled = bol;
            rdGTNu.Enabled = bol;
            rdGTNam.Enabled = bol;
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtHoTen.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                txtMaNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMK.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[11].Value.ToString();
                if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString().Contains("Nam"))
                {
                    rdGTNam.Checked = true;
                    rdGTNu.Checked = false;
                }
                else
                {
                    rdGTNam.Checked = false;
                    rdGTNu.Checked = true;
                }
                txtQueQuan.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtSoDT.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                LoadNameFromID(cbbChucVu, dataGridViewNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString(), listChucVu);
                LoadNameFromID(cbbLuong, dataGridViewNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString(), listLuong);
                LoadNameFromID(cbbPhong, dataGridViewNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString(), listPhongBan);
                LoadNameFromID(cbbTrinhDo, dataGridViewNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString(), listTDHV);
                txtDanToc.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtNgaySInh.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                string pathImg = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Anh"].Value.ToString();
                if (!pathImg.Equals(""))
                {
                    pictureBox1.Image = Image.FromFile(dataGridViewNhanVien.Rows[e.RowIndex].Cells["Anh"].Value.ToString());
                }
                else
                {
                    string pathImage = Configuration.GetProjectLinkDirectory() + @"\Resource\noimage.PNG";
                    pictureBox1.Image = Image.FromFile(pathImage);
                }
                maNVCurrent = dataGridViewNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                GetThanNhanNhanVien(maNVCurrent);
            } catch (Exception error) {
                Console.WriteLine(error.Message);
            }
        }

        public void UpdateNhanVien()
        {
            if (!checkTextBox())
            {
                return;
            }
            int result = Bus.UpdateNhanVien(getDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBoox();
                enableBox(false);
            }
            else
            {
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void DeleteNhanVien()
        {
            if (txtMaNV.Text.Equals("") || txtMaNV.Text == null)
            {
                return;
            }
            int result = Bus.DeleteNhanVien(getDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                ClearTextBoox();
                enableBox(false);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void GetThanNhanNhanVien(string maNV)
        {
            DataTable dataThanNhan = Bus.GetListThanNhanNV(maNV);
            dataGridViewThanNhan.DataSource = dataThanNhan;
            dataGridViewThanNhan.Columns["MaNV"].Visible = false;
            dataGridViewThanNhan.Columns["MaTN"].Visible = false;
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            FrmThanNhanNV frm = new FrmThanNhanNV(maNVCurrent, "", 1);
            frm.ShowDialog();
            GetThanNhanNhanVien(maNVCurrent);

        }

        private string maTNCurent;
        private void dataGridViewThanNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maTNCurent = dataGridViewThanNhan.Rows[e.RowIndex].Cells["MaTN"].Value.ToString();

        }

        private void btnXoaTN_Click(object sender, EventArgs e)
        {
            int result = Bus.DeleteThanNhan(maTNCurent);
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                GetThanNhanNhanVien(maNVCurrent);
                enableBox(false);
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaTN_Click(object sender, EventArgs e)
        {
            FrmThanNhanNV frm = new FrmThanNhanNV(maNVCurrent, maTNCurent, 2);
            frm.ShowDialog();
            GetThanNhanNhanVien(maNVCurrent);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }

}