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

namespace HumanResource.GUI
{
    public partial class UCNhanVien : UserControl
    {
        private infoTab tab = null;
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
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
                DataGridViewRow id = dataGridViewNhanVien.SelectedRows[0];
                DataTable thanNhan = Bus.GetListThanNhanNV(id.Cells[0].ToString());
                dataGridViewThanNhan.DataSource = thanNhan;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ( dataGridViewNhanVien.CurrentRow != null)
            {
                string Path = "Resource" ;
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
                        try
                        {
                            pictureBox1.Image.Save(Path);
                        }
                        catch { }
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(open.FileName);
                   
                    }
                
            }
        }
    }
}
