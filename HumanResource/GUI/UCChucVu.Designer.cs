namespace HumanResource.GUI
{
    partial class UCChucVu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvChucVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(451, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 578);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(731, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 552);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 26);
            this.panel4.TabIndex = 9;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(0, 0);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.Size = new System.Drawing.Size(802, 578);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick);
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Enabled = false;
            this.txtTenChucVu.Location = new System.Drawing.Point(151, 111);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(187, 20);
            this.txtTenChucVu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên chức vụ : ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Enabled = false;
            this.txtMaCV.Location = new System.Drawing.Point(151, 58);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(187, 20);
            this.txtMaCV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã chức vụ : ";
            // 
            // UCChucVu
            // 
            this.AccessibleDescription = "Chức vụ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCChucVu";
            this.Size = new System.Drawing.Size(1253, 608);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label label3;
    }
}
