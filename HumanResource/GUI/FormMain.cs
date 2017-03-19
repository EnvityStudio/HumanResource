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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
            AddNewTab(new UCNhanVien());
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            AddNewTab(new UCPhongBan());
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
                e.Graphics.DrawImage(img, new Point(e.Bounds.Right - 18, e.Bounds.Top + 1));
                e.Graphics.DrawString(this.tabControlHome.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
        }
       
    }
}
