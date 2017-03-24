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

        public FormMain()
        {
            InitializeComponent();
            ucNhanVien = new UCNhanVien();
            ucPhongBan = new UCPhongBan();
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
            TabPage newTab = new TabPage(userControl.AccessibleDescription + "         ");//Create new tabpage
            newTab.Controls.Add(userControl);
            newTab.Name = userControl.Name;
            tabControlHome.TabPages.Add(newTab);
            tabControlHome.SelectedTab = newTab;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddNewTab(new UCHomePage());
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
            btnAddNew.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }
        public void disableButton()
        {
            btnAddNew.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.setMaNV();
            }
            enableButton();
        }

        private void clearTextBox()
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.IntsertNhanVien();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Configuration.TAB_CURRENT == Configuration.TAB_NHANVIEN)
            {
                ucNhanVien.ClearTextBoox();
            }
            disableButton();
        }
    }
}
