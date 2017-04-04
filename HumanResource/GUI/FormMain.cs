using HumanResource.BUS;
using HumanResource.Config;
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
using System.Data.SqlClient;

namespace HumanResource.GUI
{
    public partial class FormMain : Form
    {
        UCNhanVien ucNhanVien;
        UCPhongBan ucPhongBan;
        UCTheoDoi ucTheoDoi;

        public FormMain()
        {
            InitializeComponent();
            ucNhanVien = new UCNhanVien();
            ucPhongBan = new UCPhongBan();
            ucTheoDoi = new UCTheoDoi();
        }

        public void AddNewTab(UserControl userControl)
        {

            
            foreach (TabPage tab in tabControlHome.TabPages)
            {
                if(tab.Name == userControl.Name)
                {
                    tabControlHome.SelectedTab = tab;
                    return;
                }
            }

            userControl.Dock = DockStyle.Fill;
            TabPage newTab = new TabPage(userControl.AccessibleDescription + "         ");//Create new tabpage , set name tab
            newTab.Controls.Add(userControl);
            newTab.Name = userControl.Name;
            tabControlHome.TabPages.Add(newTab);
            tabControlHome.SelectedTab = newTab;
        }

        private void SetTabCurrent()
        {
            if(tabControlHome.SelectedTab.Name == "UCHomePage")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_HOME;
            } else if (tabControlHome.SelectedTab.Name == "UCNhanVien")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_NHANVIEN;
            }
            else if(tabControlHome.SelectedTab.Name == "UCTheoDoi")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_THEODOI;
            }
            else if (tabControlHome.SelectedTab.Name == "UCPhongBan")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_PHONGBAN;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddNewTab(new UCHomePage());
            SetTabCurrent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AddNewTab(ucNhanVien);
            disableButton();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            AddNewTab(ucPhongBan);
            disableButton();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {

        }

        private void tabControlHome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Bitmap img = Properties.Resources.close;
        private void tabControlHome_DrawItem(object sender, DrawItemEventArgs e)
        {
           if(e.Index != 0) { 
                e.Graphics.DrawImage(img, new Point(e.Bounds.Right - 18, e.Bounds.Top + 1));
                e.Graphics.DrawString(this.tabControlHome.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
            }
        }

        private void tabControlHome_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = tabControlHome.GetTabRect(this.tabControlHome.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                
                this.tabControlHome.TabPages.Remove(this.tabControlHome.SelectedTab);
            }
        }

        public void enableButton()
        {
            btnAddNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }
        public void disableButton()
        {
            btnAddNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Configuration.ACTION = Configuration.ADD;
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.ClearTextBoox();
                ucNhanVien.setMaNV();
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                ucTheoDoi.ClearTextBox();
  
            }

            enableButton();
        }

        private void clearTextBox()
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            if (Configuration.ACTION == Configuration.ADD)
            {
                if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
                {
                    ucNhanVien.IntsertNhanVien();
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
                {
                    ucTheoDoi.InsertTheoDoi();
                }
                
            } else if (Configuration.ACTION == Configuration.EDIT)
            {
                if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
                {
                    ucNhanVien.UpdateNhanVien();
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
                {
                    ucTheoDoi.UpdateTheoDoi();
                }

            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
                {
                    ucNhanVien.ClearTextBoox();
                }
                disableButton();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Configuration.ACTION = Configuration.EDIT;
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.EditClick();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                ucTheoDoi.EditClick();
            }
            disableButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Configuration.ACTION = Configuration.DELETE;
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.DeleteNhanVien();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                ucTheoDoi.DeleteTheoDoi();
            }
            disableButton();
        }

        private void TheoDoiNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(ucTheoDoi);
            disableButton();
        }
    }
}
