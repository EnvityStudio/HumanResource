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

namespace HumanResource.GUI
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
          //  dataGridViewNhanVien.DataSource = Bus.GetListNhanVien();
          //  dataGridViewNhanVien.Columns["Anh"].Visible = false;
          //  dataGridViewNhanVien.Columns["TrangThai"].Visible = false;
          //  dataGridViewNhanVien.Columns["LoaiNV"].Visible = false;
           

          //int x =  dataGridViewNhanVien.ColumnCount;
          //  int y = dataGridViewNhanVien.RowCount;
          //  int z;

          //  for (int i = 0; i < y; i++)
          //  {
          //      dataGridViewNhanVien.Rows[i].Cells[7].Value.ToString();

          //      DataTable dt = Bus.GetNamePhongBan(dataGridViewNhanVien.Rows[i].Cells[7].Value.ToString());
               
          //  }
           

        }

        private void dataGridViewNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridViewNhanVien.Columns[e.ColumnIndex].Name == "PHONG")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("1         ") > -1))
                    {
                        e.CellStyle.BackColor = Color.Pink;
                    }

                }
            }

        }
    }
}
