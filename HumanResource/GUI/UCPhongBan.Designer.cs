namespace HumanResource.GUI
{
    partial class UCPhongBan
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
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texTenPB = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(185, 33);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(175, 20);
            this.txtMaPB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng ban";
            // 
            // dataGridViewPhongBan
            // 
            this.dataGridViewPhongBan.AllowUserToAddRows = false;
            this.dataGridViewPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.SODT,
            this.TenPB,
            this.DiaChi,
            this.TongNV,
            this.MaTP});
            this.dataGridViewPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhongBan.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhongBan.MultiSelect = false;
            this.dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            this.dataGridViewPhongBan.ReadOnly = true;
            this.dataGridViewPhongBan.Size = new System.Drawing.Size(1270, 263);
            this.dataGridViewPhongBan.TabIndex = 72;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaPB);
            this.groupBox4.Controls.Add(this.btnSuaPB);
            this.groupBox4.Controls.Add(this.btnThemPB);
            this.groupBox4.Controls.Add(this.txtTongNV);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSoDT);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtMaTP);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.texTenPB);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtMaPB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1270, 267);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên phòng ban";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPhongBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 263);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 17);
            this.panel1.TabIndex = 5;
            // 
            // texTenPB
            // 
            this.texTenPB.Location = new System.Drawing.Point(185, 101);
            this.texTenPB.Name = "texTenPB";
            this.texTenPB.Size = new System.Drawing.Size(175, 20);
            this.texTenPB.TabIndex = 5;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(563, 101);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(175, 20);
            this.txtSoDT.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(563, 33);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(175, 20);
            this.txtMaTP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã trưởng phòng";
            // 
            // txtTongNV
            // 
            this.txtTongNV.Location = new System.Drawing.Point(563, 164);
            this.txtTongNV.Name = "txtTongNV";
            this.txtTongNV.Size = new System.Drawing.Size(175, 20);
            this.txtTongNV.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng nhân viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(185, 164);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(175, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ";
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.Location = new System.Drawing.Point(1127, 19);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(44, 23);
            this.btnXoaPB.TabIndex = 67;
            this.btnXoaPB.Text = "Xóa";
            this.btnXoaPB.UseVisualStyleBackColor = true;
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.Location = new System.Drawing.Point(1054, 19);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(44, 23);
            this.btnSuaPB.TabIndex = 68;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.UseVisualStyleBackColor = true;
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(980, 19);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(44, 23);
            this.btnThemPB.TabIndex = 69;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MaPB";
            this.MANV.HeaderText = "Mã";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // SODT
            // 
            this.SODT.DataPropertyName = "SDT";
            this.SODT.HeaderText = "Số Điện Thoại";
            this.SODT.Name = "SODT";
            this.SODT.ReadOnly = true;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.HeaderText = "Tên phòng ban";
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TongNV
            // 
            this.TongNV.DataPropertyName = "TongNV";
            this.TongNV.HeaderText = "Tổng nhân viên";
            this.TongNV.Name = "TongNV";
            this.TongNV.ReadOnly = true;
            // 
            // MaTP
            // 
            this.MaTP.DataPropertyName = "MaTP";
            this.MaTP.HeaderText = "Mã trường phòng";
            this.MaTP.Name = "MaTP";
            this.MaTP.ReadOnly = true;
            // 
            // UCPhongBan
            // 
            this.AccessibleDescription = "Phòng Ban";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPhongBan";
            this.Size = new System.Drawing.Size(1270, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPhongBan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texTenPB;
        private System.Windows.Forms.TextBox txtTongNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTP;
    }
}
