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
                phongBan.Add(row["MaPB"].ToString(),row["TenPB"].ToString());
            }
            foreach (DataRow row in dtChucVu.Rows)
            {
                chucVu.Add(row["MaCV"].ToString(), row["TenCV"].ToString());
            }
            foreach (DataRow row in dtTdhv.Rows)
            {
                tdhv.Add(row["MaTDHV"].ToString(), row["TenTDHV"].ToString());
            }
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "CHUCVU")
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
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "PHONG")
            {
                if (e.Value != null)
                {
                   for(int i = 0; i < phongBan.Count; i++)
                    {
                        string x;
                        if (phongBan.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = phongBan[e.Value.ToString()];
                           
                        }
                    }
                  
                }
            }
            
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "TDHV")
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
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "luong")
            {
                if (e.Value != null)
                {
                    for (int i = 0; i < tdhv.Count; i++)
                    {
                        List<decimal> x = new List<decimal>();
                        if (luong.TryGetValue(e.Value.ToString(), out x))
                        {
                            e.Value = HRUtils.getLuong(x[0],float.Parse(x[1].ToString()), float.Parse(x[2].ToString())).ToString();

                        }
                    }

                }
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
            if (dataGridViewNhanVien.SelectedCells.Count > 0)
            {
                //DataGridViewRow id = dataGridViewNhanVien.SelectedRows[0];
                //DataTable thanNhan = Bus.GetListThanNhanNV(id.Cells[0].ToString());
                //dataGridViewThanNhan.DataSource = thanNhan;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ( dataGridViewNhanVien.CurrentRow != null)
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
            string MaNV , HoTen, GioiTinh ,MaCV ,MaPB ,MaTDHV ,QueQuan ,Anh ,Sdt, Email, MatKhau, DanToc ,BacLuong, CMND;
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
            Anh = avataPath;
            Email = txtEmail.Text;
            NgaySinh = (DateTime)dtNgaySInh.Value; 
            MatKhau = txtMK.Text;
            DanToc = txtDanToc.Text;
            BacLuong = ((DataItem)cbbLuong.SelectedItem).Value;
            CMND = txtCMND.Text;
            return new NhanVien( MaNV,  HoTen,  NgaySinh,  QueQuan,  GioiTinh,  DanToc,  Sdt,  MaTDHV,  MaPB,  MaCV,  BacLuong,  Anh,  MatKhau,  CMND,  Email);
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
            Dictionary<String, String> phongBan = new Dictionary<string, string>();
            DataTable dtChucVu = Bus.GetListChucVu();
            Dictionary<String, String> chucVu = new Dictionary<string, string>();
            DataTable dtTdhv = Bus.GetListTDHV();
            Dictionary<String, String> tdhv = new Dictionary<string, string>();
            DataTable dtLuong = Bus.GetListLUONG();
            Dictionary<string, string> luong = new Dictionary<string, string>();
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

            LoadComboboxData(cbbPhong, Bus.GetList(PROC_GET_LIST_PHONGBAN));
            LoadComboboxData(cbbChucVu, Bus.GetList(PROC_GET_LIST_CHUC_VU));
            LoadComboboxData(cbbTrinhDo, Bus.GetList(PROC_GET_LIST_TDHV));
            LoadComboboxData(cbbLuong, Bus.GetList(PROC_GET_LIST_LUONG));


        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void LoadComboboxData(ComboBox cbb , List<DataItem> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "Value";
            cbb.DisplayMember = "Name";
        }
        public void ClearTextBoox()
        {
            txtCMND.Text = "";
            txtMaNV.Text = "";
            txtMK.Text = "";
            txtHoTen.Text = "";
            rdGTNam.Checked = false;
            rdGTNu.Checked = false;
            txtNoiSinh.Text = "";
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
            if (!checkEmpty(txtCMND) || !checkEmpty(txtMaNV) || !checkEmpty(txtNoiSinh) || !checkEmpty(txtQueQuan) 
                || !checkEmpty(txtEmail) || !checkEmpty(txtSoDT) || !checkEmpty(txtDanToc) )
            {
                MessageBox.Show("Có lỗi không thể lưu");
                return false ;
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
        public void IntsertNhanVien()
        {
            if(!checkTextBox())
            {
                return ;
            }
            int result = Bus.InsertNhanVien(getDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Success", "notification", MessageBoxButtons.OK);
                LoadData();
                ClearTextBoox();
                enableBox(false);
            }
            else
            {
                MessageBox.Show("Fales", "notification", MessageBoxButtons.OK);
            }
        }
        private void enableBox(bool bol)
        {
            txtHoTen.Enabled = bol;
            txtCMND.Enabled = bol;
            txtCMND.Enabled = bol;
            txtMaNV.Enabled = bol;
            txtMK.Enabled = bol;
            txtNoiSinh.Enabled = bol;
            txtQueQuan.Enabled = bol;
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
    }

}