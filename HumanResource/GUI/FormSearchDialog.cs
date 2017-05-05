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
    public partial class FormSearchDialog : Form
    {
        public FormSearchDialog()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            int type = cbbType.SelectedIndex;
            // type : 
            // 0 :Mã nhân viên
            // 1 :Tên nhân viên
            // 2 :Tên phòng ban
            // 3 :Quê quán
            // 4 :Giới tính
            
        }
    }
}
