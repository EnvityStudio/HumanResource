namespace HumanResource.GUI
{
    partial class UCHocVan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHocVan = new System.Windows.Forms.DataGridView();
            this.lbMaHV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenHocVan = new System.Windows.Forms.TextBox();
            this.txtMaHocVan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuyenNganh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1303, 39);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvHocVan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(474, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 443);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(773, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(56, 443);
            this.panel4.TabIndex = 10;
            // 
            // dgvHocVan
            // 
            this.dgvHocVan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocVan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocVan.Location = new System.Drawing.Point(0, 0);
            this.dgvHocVan.Name = "dgvHocVan";
            this.dgvHocVan.ReadOnly = true;
            this.dgvHocVan.Size = new System.Drawing.Size(829, 443);
            this.dgvHocVan.TabIndex = 0;
            this.dgvHocVan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVan_CellClick);
            this.dgvHocVan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocVan_CellContentClick);
            // 
            // lbMaHV
            // 
            this.lbMaHV.AutoSize = true;
            this.lbMaHV.Location = new System.Drawing.Point(29, 46);
            this.lbMaHV.Name = "lbMaHV";
            this.lbMaHV.Size = new System.Drawing.Size(70, 13);
            this.lbMaHV.TabIndex = 13;
            this.lbMaHV.Text = "Mã học vấn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trình độ :";
            // 
            // txtTenHocVan
            // 
            this.txtTenHocVan.Enabled = false;
            this.txtTenHocVan.Location = new System.Drawing.Point(141, 96);
            this.txtTenHocVan.Name = "txtTenHocVan";
            this.txtTenHocVan.Size = new System.Drawing.Size(173, 20);
            this.txtTenHocVan.TabIndex = 2;
            this.txtTenHocVan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaHocVan
            // 
            this.txtMaHocVan.Enabled = false;
            this.txtMaHocVan.Location = new System.Drawing.Point(141, 43);
            this.txtMaHocVan.Name = "txtMaHocVan";
            this.txtMaHocVan.Size = new System.Drawing.Size(173, 20);
            this.txtMaHocVan.TabIndex = 1;
            this.txtMaHocVan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chuyên ngành :";
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Enabled = false;
            this.txtChuyenNganh.Location = new System.Drawing.Point(141, 149);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(173, 20);
            this.txtChuyenNganh.TabIndex = 3;
            this.txtChuyenNganh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số lượng :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(141, 202);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(173, 20);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UCHocVan
            // 
            this.AccessibleDescription = "Học Vấn";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaHocVan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHocVan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaHV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCHocVan";
            this.Size = new System.Drawing.Size(1303, 512);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvHocVan;
        private System.Windows.Forms.Label lbMaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHocVan;
        private System.Windows.Forms.TextBox txtMaHocVan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuyenNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}
