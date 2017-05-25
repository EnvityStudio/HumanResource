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
        UCThanNhan ucThanNhan;
        UCHocVan ucHocVan;
        UCLuong ucLuong;
        UCChucVu ucChucVu;

        private bool isAction;
        private string tenNV;

        public FormMain(string tenNV)
        {
            InitializeComponent();
            ucNhanVien = new UCNhanVien();
            ucPhongBan = new UCPhongBan();
            ucTheoDoi = new UCTheoDoi();
            ucThanNhan = new UCThanNhan();
            ucHocVan = new UCHocVan();
            ucLuong = new UCLuong();
            ucChucVu = new UCChucVu();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            this.tenNV = tenNV;
        
        }
        public void AddNewTab(UserControl userControl)
        {

            foreach (TabPage tab in tabControl.TabPages)
            {
                if(tab.Name == userControl.Name)
                {
                    tabControl.SelectedTab = tab;
                    return;
                }
            }
            btnAddNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            userControl.Dock = DockStyle.Fill;
            TabPage newTab = new TabPage(userControl.AccessibleDescription + "         ");//Create new tabpage , set name tab
            newTab.Controls.Add(userControl);
            newTab.Name = userControl.Name;
            tabControl.TabPages.Add(newTab);
            tabControl.SelectedTab = newTab;
        }

        private void SetTabCurrent()
        {
            //if(tabControl.SelectedTab.Name == "UCHomePage")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_HOME;
            //} else if (tabControl.SelectedTab.Name == "UCNhanVien")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_NHANVIEN;
            //}
            //else if(tabControl.SelectedTab.Name == "UCTheoDoi")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_THEODOI;
            //}
            //else if (tabControl.SelectedTab.Name == "UCPhongBan")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_PHONGBAN;
            //}
            //else if (tabControl.SelectedTab.Name == "UCThanNhan")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_THAN_NHAN;
            //}
            //else if (tabControl.SelectedTab.Name == "UCHocVan")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_HOC_VAN;
            //}
            //else if (tabControl.SelectedTab.Name == "UCLuong")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_LUONG;
            //}
            //else if (tabControl.SelectedTab.Name == "UCChucVu")
            //{
            //    Configuration.TAB_CURRENT = Configuration.TAB_CHUCVU;
            //}
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddNewTab(new UCHomePage());
            SetTabCurrent();
            tabControl.Selecting += new TabControlCancelEventHandler(tabControl_Selecting);

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setCurrent();
                return;
            }


            TabPage current = (sender as TabControl).SelectedTab;
            if (isAction) e.Cancel = true;
            if (current.Name == "UCHomePage")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_HOME;
            }
            else if (current.Name == "UCNhanVien")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_NHANVIEN;
            }
            else if (current.Name == "UCTheoDoi")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_THEODOI;
            }
            else if (current.Name == "UCPhongBan")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_PHONGBAN;
            }
            else if (current.Name == "UCThanNhan")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_THAN_NHAN;
            }
            else if (current.Name == "UCHocVan")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_HOC_VAN;
            }
            else if (current.Name == "UCLuong")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_LUONG;
            }
            else if (current.Name == "UCChucVu")
            {
                Configuration.TAB_CURRENT = Configuration.TAB_CHUCVU;
            }

            // Validate the current page. To cancel the select, use:
            //e.Cancel = true;
        }

        
        public void setCurrent()
        {
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCNhanVien")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCChucVu")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCHocVan")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCLuong")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCPhongBan")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCThanNhan")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Name == "UCTheoDoi")
                    {
                        tabControl.SelectedTab = tab;
                        return;
                    }
                }
            }

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AddNewTab(ucNhanVien);
            disableButton();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            ucPhongBan = new UCPhongBan();
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
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
            }
        }

        private void tabControlHome_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = tabControl.GetTabRect(this.tabControl.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                
                this.tabControl.TabPages.Remove(this.tabControl.SelectedTab);
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
            //btnAddNew.Enabled = true;
            //btnEdit.Enabled = true;
            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;
            //btnDelete.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Configuration.ACTION = Configuration.ADD;
            isAction = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.ClearTextBoox();
                ucNhanVien.enableBox(true);
                ucNhanVien.setMaNV();
                ucNhanVien.setIsAction(true);
                ucNhanVien.LoadCbbQueQuan();
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                ucTheoDoi.ClearTextBox();
                ucTheoDoi.setIsAction(true);

            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
            {
                ucThanNhan.ClearTextBox();
                ucThanNhan.setMaThanNhan();
                ucThanNhan.setIsAction(true);
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
            {
                ucHocVan.ClearTextBox();
                ucHocVan.setMaNextToToolBox();
                ucHocVan.setIsAction(true);
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
            {
                ucLuong.ClearTextBox();
                ucLuong.setBacLuong();
                ucLuong.setIsAction(true);
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
            {
                ucPhongBan.ClearTextBox();
                ucPhongBan.setMaPBNext();
                ucPhongBan.enableTextBox(true);
                ucPhongBan.setIsAction(true);
            }
            else if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
            {
                ucChucVu.ClearTextBox();
                ucChucVu.setMaCVNext();
                ucChucVu.EnableTextBox(true);
                ucChucVu.setIsAction(true);
            }

         //   enableButton();
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
                    ucNhanVien.AddNhanVien();
                    if (ucNhanVien.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
                {
                    ucTheoDoi.AddTheoDoi();
                    if (ucTheoDoi.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
                {
                    ucThanNhan.AddThanNhan();
                    if (ucTheoDoi.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
                {
                    ucHocVan.AddHocVan();
                    if (ucHocVan.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
                {
                    ucLuong.AddLuong();
                    if (ucLuong.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
                {
                    ucPhongBan.AddPhongBan();
                    if (ucPhongBan.getIsAction() == false) isAction = false; 
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
                {
                    ucChucVu.AddChucVu();
                    if (ucChucVu.getIsAction() == false) isAction = false;
                }
              
            } else if (Configuration.ACTION == Configuration.EDIT)
            {
                if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
                {
                    ucNhanVien.UpdateNhanVien();
                    if (ucNhanVien.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
                {
                    ucTheoDoi.UpdateTheoDoi();
                    if (ucTheoDoi.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
                {
                    ucThanNhan.UpdateThanNhan();
                    if (ucTheoDoi.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
                {
                    ucHocVan.UpdateHocVan();
                    if (ucHocVan.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
                {
                    ucLuong.UpdateLuong();
                    if (ucLuong.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
                {
                    ucPhongBan.UpdatePhongBan();
                    if (ucPhongBan.getIsAction() == false) isAction = false;
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
                {
                    ucChucVu.EditChucVu();
                    if (ucChucVu.getIsAction() == false) isAction = false;
                }
            } 
            if(isAction == false)
            {
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
                btnAddNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                isAction = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnAddNew.Enabled = true;
                btnDelete.Enabled = true;
                if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
                {
                    ucNhanVien.ClearTextBoox();
                    ucNhanVien.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
                {
                    ucChucVu.ClearTextBox();
                    ucChucVu.EnableTextBox(false);
                    ucChucVu.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
                {
                    ucHocVan.ClearTextBox();
                    ucHocVan.enableToolBox(false);
                    ucHocVan.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
                {
                    ucLuong.ClearTextBox();
                    ucLuong.enableTextBox(false);
                    ucLuong.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
                {
                    ucPhongBan.ClearTextBox();
                    ucPhongBan.enableTextBox(false);
                    ucPhongBan.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
                {
                    ucThanNhan.ClearTextBox();
                    ucThanNhan.enableToolBox(false);
                    ucThanNhan.setIsAction(false);
                }
                if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
                {
                    ucTheoDoi.ClearTextBox();
                    ucTheoDoi.EnableDisableToolBox(false);
                    ucTheoDoi.setIsAction(false);
                }
                disableButton();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Configuration.ACTION = Configuration.EDIT;
            isAction = true;
            btnCancel.Enabled = true;
            btnAddNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.EditClick();
                ucTheoDoi.setIsAction(true);

            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THEODOI)
            {
                ucTheoDoi.EditClick();
                ucTheoDoi.setIsAction(true);
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
            {
                ucThanNhan.enableToolBox(true);
                ucThanNhan.setIsAction(true);
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
            {
                ucHocVan.enableToolBox(true);
                ucHocVan.setIsAction(true);
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
            {
                ucLuong.enableTextBox(true);
                ucLuong.setIsAction(true);
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
            {
                ucPhongBan.enableTextBox(true);
                ucPhongBan.setIsAction(true);
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
            {
                ucChucVu.EnableTextBox(true);
                ucChucVu.setIsAction(true);
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
            if (Configuration.TAB_CURRENT == Configuration.TAB_THAN_NHAN)
            {
                ucThanNhan.DeleteThanNhan();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_HOC_VAN)
            {
                ucHocVan.DeleteHocVan();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_LUONG)
            {
                ucLuong.DeleteLuong();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
            {
                ucPhongBan.DeletePhongBan();
            }
            if (Configuration.TAB_CURRENT == Configuration.TAB_CHUCVU)
            {
                ucChucVu.DeleteChucVu();
            }
            disableButton();
        }

        private void TheoDoiNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(ucTheoDoi);
            disableButton();
        }

        private void btnThanNhan_Click(object sender, EventArgs e)
        {
            AddNewTab(ucThanNhan);
            disableButton();
        }

        private void btnHocVan_Click(object sender, EventArgs e)
        {
            AddNewTab(ucHocVan);
            disableButton();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            AddNewTab(ucLuong);
            disableButton();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(Configuration.TAB_CURRENT == Configuration.TAB_PHONGBAN)
            {
                ucPhongBan = new UCPhongBan();
            }
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucNhanVien = new UCNhanVien();
            AddNewTab(ucNhanVien);
            disableButton();
        }

        private void PhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucPhongBan = new UCPhongBan();
            AddNewTab(ucPhongBan);
            disableButton();
        }

        private void ChucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucChucVu = new UCChucVu();
            AddNewTab(ucChucVu);
            disableButton();
        }

        private void TheoDoiNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucTheoDoi = new UCTheoDoi();
            AddNewTab(ucTheoDoi);
            disableButton();
        }

        private void LuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucLuong = new UCLuong();
            AddNewTab(ucLuong);
            disableButton();
        }

        private void ThanNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucThanNhan = new UCThanNhan();
            AddNewTab(ucThanNhan);
            disableButton();
        }

        private void HocVanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAction)
            {
                MessageBox.Show("Bạn chưa hoàn thành tác vụ!\nHãy hoàn thành để mở tab khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ucHocVan = new UCHocVan();
            AddNewTab(ucHocVan);
            disableButton();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new FormLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btnSearchh_Click(object sender, EventArgs e)
        {
            Form frmSearch = new FormSearch();
            frmSearch.FormBorderStyle = FormBorderStyle.FixedSingle;
            frmSearch.ShowDialog();
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword(tenNV);
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/vi-vn/");
        }
    }
}
 