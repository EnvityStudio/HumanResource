namespace HumanResource.GUI
{
    partial class UCLuong
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
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBacLuong = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 30);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 538);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 39);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvLuong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(570, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 508);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(709, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 508);
            this.panel4.TabIndex = 10;
            // 
            // dgvLuong
            // 
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(0, 0);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.Size = new System.Drawing.Size(747, 508);
            this.dgvLuong.TabIndex = 0;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            this.dgvLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã bậc lương :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lương cơ bản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = " Hệ số lương :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hệ số phụ cấp :";
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.Enabled = false;
            this.txtBacLuong.Location = new System.Drawing.Point(181, 50);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(144, 20);
            this.txtBacLuong.TabIndex = 0;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Enabled = false;
            this.txtLuongCoBan.Location = new System.Drawing.Point(181, 98);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(144, 20);
            this.txtLuongCoBan.TabIndex = 1;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Enabled = false;
            this.txtHeSoLuong.Location = new System.Drawing.Point(181, 146);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(144, 20);
            this.txtHeSoLuong.TabIndex = 2;
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Enabled = false;
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(181, 194);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(144, 20);
            this.txtHeSoPhuCap.TabIndex = 3;
            // 
            // UCLuong
            // 
            this.AccessibleDescription = "Quản Lý Lương";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHeSoPhuCap);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtBacLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UCLuong";
            this.Size = new System.Drawing.Size(1317, 577);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBacLuong;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
    }
}
