namespace HumanResource.GUI
{
    partial class UCNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnXoaTN = new System.Windows.Forms.Button();
            this.btnSuaTN = new System.Windows.Forms.Button();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewThanNhan = new System.Windows.Forms.DataGridView();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.cbbLuong = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtNgaySInh = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdGTNu = new System.Windows.Forms.RadioButton();
            this.rdGTNam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanNhan)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 17);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 354);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNhanVien.MultiSelect = false;
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(1314, 354);
            this.dataGridViewNhanVien.TabIndex = 72;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            this.dataGridViewNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellContentClick);
            this.dataGridViewNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewNhanVien_CellFormatting);
            this.dataGridViewNhanVien.SelectionChanged += new System.EventHandler(this.dataGridViewNhanVien_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = "Theo Dõi";
            this.groupBox4.Controls.Add(this.lblMaTN);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.btnXoaTN);
            this.groupBox4.Controls.Add(this.btnSuaTN);
            this.groupBox4.Controls.Add(this.btnThemTN);
            this.groupBox4.Controls.Add(this.txtMaNV);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.dataGridViewThanNhan);
            this.groupBox4.Controls.Add(this.btnResetPass);
            this.groupBox4.Controls.Add(this.cbbLuong);
            this.groupBox4.Controls.Add(this.cbbChucVu);
            this.groupBox4.Controls.Add(this.cbbPhong);
            this.groupBox4.Controls.Add(this.cbbTrinhDo);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.dtNgaySInh);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMK);
            this.groupBox4.Controls.Add(this.txtCMND);
            this.groupBox4.Controls.Add(this.txtDanToc);
            this.groupBox4.Controls.Add(this.txtSoDT);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtQueQuan);
            this.groupBox4.Controls.Add(this.txtHoTen);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1314, 262);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Nhân Viên";
            // 
            // lblMaTN
            // 
            this.lblMaTN.AutoSize = true;
            this.lblMaTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMaTN.Location = new System.Drawing.Point(1251, 38);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(35, 13);
            this.lblMaTN.TabIndex = 68;
            this.lblMaTN.Text = "label2";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 143);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Mã NV:";
            // 
            // btnXoaTN
            // 
            this.btnXoaTN.Location = new System.Drawing.Point(1110, 12);
            this.btnXoaTN.Name = "btnXoaTN";
            this.btnXoaTN.Size = new System.Drawing.Size(44, 23);
            this.btnXoaTN.TabIndex = 66;
            this.btnXoaTN.Text = "Xóa";
            this.btnXoaTN.UseVisualStyleBackColor = true;
            this.btnXoaTN.Click += new System.EventHandler(this.btnXoaTN_Click);
            // 
            // btnSuaTN
            // 
            this.btnSuaTN.Location = new System.Drawing.Point(1037, 12);
            this.btnSuaTN.Name = "btnSuaTN";
            this.btnSuaTN.Size = new System.Drawing.Size(44, 23);
            this.btnSuaTN.TabIndex = 66;
            this.btnSuaTN.Text = "Sửa";
            this.btnSuaTN.UseVisualStyleBackColor = true;
            this.btnSuaTN.Click += new System.EventHandler(this.btnSuaTN_Click);
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(963, 12);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(44, 23);
            this.btnThemTN.TabIndex = 66;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(47, 139);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(65, 20);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HumanResource.Properties.Resources.noimage;
            this.pictureBox1.InitialImage = global::HumanResource.Properties.Resources.erroricon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewThanNhan
            // 
            this.dataGridViewThanNhan.AllowUserToAddRows = false;
            this.dataGridViewThanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThanNhan.Location = new System.Drawing.Point(853, 38);
            this.dataGridViewThanNhan.MultiSelect = false;
            this.dataGridViewThanNhan.Name = "dataGridViewThanNhan";
            this.dataGridViewThanNhan.ReadOnly = true;
            this.dataGridViewThanNhan.Size = new System.Drawing.Size(392, 181);
            this.dataGridViewThanNhan.TabIndex = 67;
            this.dataGridViewThanNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThanNhan_CellContentClick);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(628, 211);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(80, 23);
            this.btnResetPass.TabIndex = 64;
            this.btnResetPass.Text = "Reset";
            this.btnResetPass.UseVisualStyleBackColor = true;
            // 
            // cbbLuong
            // 
            this.cbbLuong.FormattingEnabled = true;
            this.cbbLuong.Location = new System.Drawing.Point(188, 211);
            this.cbbLuong.Name = "cbbLuong";
            this.cbbLuong.Size = new System.Drawing.Size(156, 21);
            this.cbbLuong.TabIndex = 59;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(620, 166);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(122, 21);
            this.cbbChucVu.TabIndex = 52;
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(399, 166);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(122, 21);
            this.cbbPhong.TabIndex = 38;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(187, 166);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(114, 21);
            this.cbbTrinhDo.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(127, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "Lương:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(400, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 63;
            this.label23.Text = "Mật Khẩu:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Chức Vụ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Phòng:";
            // 
            // dtNgaySInh
            // 
            this.dtNgaySInh.CustomFormat = "";
            this.dtNgaySInh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySInh.Location = new System.Drawing.Point(612, 22);
            this.dtNgaySInh.Name = "dtNgaySInh";
            this.dtNgaySInh.Size = new System.Drawing.Size(120, 20);
            this.dtNgaySInh.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Trình Độ:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rdGTNu);
            this.panel4.Controls.Add(this.rdGTNam);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(383, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 30);
            this.panel4.TabIndex = 6;
            // 
            // rdGTNu
            // 
            this.rdGTNu.AutoSize = true;
            this.rdGTNu.Location = new System.Drawing.Point(118, 6);
            this.rdGTNu.Name = "rdGTNu";
            this.rdGTNu.Size = new System.Drawing.Size(39, 17);
            this.rdGTNu.TabIndex = 8;
            this.rdGTNu.TabStop = true;
            this.rdGTNu.Text = "Nữ";
            this.rdGTNu.UseVisualStyleBackColor = true;
            // 
            // rdGTNam
            // 
            this.rdGTNam.AutoSize = true;
            this.rdGTNam.Location = new System.Drawing.Point(65, 6);
            this.rdGTNam.Name = "rdGTNam";
            this.rdGTNam.Size = new System.Drawing.Size(47, 17);
            this.rdGTNam.TabIndex = 8;
            this.rdGTNam.TabStop = true;
            this.rdGTNam.Text = "Nam";
            this.rdGTNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới Tính:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(850, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 16);
            this.label25.TabIndex = 65;
            this.label25.Text = "Thân Nhân:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dân Tộc:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Số ĐT:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(564, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quê quán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(466, 211);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(144, 20);
            this.txtMK.TabIndex = 26;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(613, 118);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(129, 20);
            this.txtCMND.TabIndex = 26;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(424, 55);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(129, 20);
            this.txtDanToc.TabIndex = 26;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(399, 118);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(129, 20);
            this.txtSoDT.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(191, 59);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(167, 20);
            this.txtQueQuan.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(186, 23);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCNhanVien
            // 
            this.AccessibleDescription = "Nhân Viên";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(1314, 633);
            this.Load += new System.EventHandler(this.UCNhanVien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanNhan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnXoaTN;
        private System.Windows.Forms.Button btnSuaTN;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewThanNhan;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.ComboBox cbbLuong;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtNgaySInh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdGTNu;
        private System.Windows.Forms.RadioButton rdGTNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMaTN;
    }
}
