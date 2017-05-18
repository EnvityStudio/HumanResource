namespace HumanResource.GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChucVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TheoDoiNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HocVanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnCloseAllTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurrentTab = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearchh = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripHeThong,
            this.NhanVienToolStripMenuItem,
            this.PhongBanToolStripMenuItem,
            this.ChucVuToolStripMenuItem,
            this.TheoDoiNVToolStripMenuItem,
            this.LuongToolStripMenuItem,
            this.ThanNhanToolStripMenuItem,
            this.HocVanToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripHeThong
            // 
            this.menuStripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangXuat,
            this.btnChangePassword});
            this.menuStripHeThong.Name = "menuStripHeThong";
            this.menuStripHeThong.Size = new System.Drawing.Size(72, 20);
            this.menuStripHeThong.Text = "Hệ Thống";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(145, 22);
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(145, 22);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.NhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // PhongBanToolStripMenuItem
            // 
            this.PhongBanToolStripMenuItem.Name = "PhongBanToolStripMenuItem";
            this.PhongBanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.PhongBanToolStripMenuItem.Text = "Phòng Ban";
            this.PhongBanToolStripMenuItem.Click += new System.EventHandler(this.PhongBanToolStripMenuItem_Click);
            // 
            // ChucVuToolStripMenuItem
            // 
            this.ChucVuToolStripMenuItem.Name = "ChucVuToolStripMenuItem";
            this.ChucVuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ChucVuToolStripMenuItem.Text = "Chức Vụ";
            this.ChucVuToolStripMenuItem.Click += new System.EventHandler(this.ChucVuToolStripMenuItem_Click);
            // 
            // TheoDoiNVToolStripMenuItem
            // 
            this.TheoDoiNVToolStripMenuItem.Name = "TheoDoiNVToolStripMenuItem";
            this.TheoDoiNVToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.TheoDoiNVToolStripMenuItem.Text = "Theo Dõi nhân viên";
            this.TheoDoiNVToolStripMenuItem.Click += new System.EventHandler(this.TheoDoiNVToolStripMenuItem_Click);
            // 
            // LuongToolStripMenuItem
            // 
            this.LuongToolStripMenuItem.Name = "LuongToolStripMenuItem";
            this.LuongToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.LuongToolStripMenuItem.Text = "Lương";
            this.LuongToolStripMenuItem.Click += new System.EventHandler(this.LuongToolStripMenuItem_Click);
            // 
            // ThanNhanToolStripMenuItem
            // 
            this.ThanNhanToolStripMenuItem.Name = "ThanNhanToolStripMenuItem";
            this.ThanNhanToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ThanNhanToolStripMenuItem.Text = "Thân nhân";
            this.ThanNhanToolStripMenuItem.Click += new System.EventHandler(this.ThanNhanToolStripMenuItem_Click);
            // 
            // HocVanToolStripMenuItem
            // 
            this.HocVanToolStripMenuItem.Name = "HocVanToolStripMenuItem";
            this.HocVanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.HocVanToolStripMenuItem.Text = "Học vấn";
            this.HocVanToolStripMenuItem.Click += new System.EventHandler(this.HocVanToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnSave,
            this.btnCancel,
            this.toolStripSeparator2,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnPrint,
            this.btnCloseAllTab,
            this.toolStripSeparator4,
            this.lblCurrentTab,
            this.toolStripSeparator5,
            this.btnSearchh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(917, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::HumanResource.Properties.Resources.add;
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(58, 22);
            this.btnAddNew.Text = "Thêm";
            this.btnAddNew.ToolTipText = "Thêm Mới (CTR + N)";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::HumanResource.Properties.Resources.editicon;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.ToolTipText = "Sửa (CTR + E)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::HumanResource.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 22);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.ToolTipText = "Xóa (Delete)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::HumanResource.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 22);
            this.btnSave.Text = "Lưu";
            this.btnSave.ToolTipText = "Lưu (CTR + S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::HumanResource.Properties.Resources.cen1;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 22);
            this.btnCancel.Text = "Hủy";
            this.btnCancel.ToolTipText = "Hủy (CTR + Q)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Image = global::HumanResource.Properties.Resources.refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 22);
            this.btnRefresh.Text = "Cập Nhật";
            this.btnRefresh.ToolTipText = "Cập nhật lại (CTR + R)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::HumanResource.Properties.Resources.iconprint;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(37, 22);
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTipText = "In (CTR + P)";
            // 
            // btnCloseAllTab
            // 
            this.btnCloseAllTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseAllTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseAllTab.Name = "btnCloseAllTab";
            this.btnCloseAllTab.Size = new System.Drawing.Size(79, 22);
            this.btnCloseAllTab.Text = "Close All Tab";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCurrentTab
            // 
            this.lblCurrentTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCurrentTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCurrentTab.Name = "lblCurrentTab";
            this.lblCurrentTab.Size = new System.Drawing.Size(62, 22);
            this.lblCurrentTab.Text = "Trang Chủ";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSearchh
            // 
            this.btnSearchh.Image = global::HumanResource.Properties.Resources.search2;
            this.btnSearchh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(77, 22);
            this.btnSearchh.Text = "Tìm kiếm";
            this.btnSearchh.ToolTipText = "In (CTR + P)";
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(917, 469);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlHome_DrawItem);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControlHome_SelectedIndexChanged);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlHome_MouseDown);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 518);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnCloseAllTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblCurrentTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChucVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TheoDoiNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThanNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HocVanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSearchh;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}