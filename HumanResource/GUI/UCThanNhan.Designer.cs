namespace HumanResource.GUI
{
    partial class UCThanNhan
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
            this.dgvThanNhan = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBoxTenThanNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuanHe = new System.Windows.Forms.TextBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvThanNhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(424, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 502);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(731, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 476);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 26);
            this.panel4.TabIndex = 9;
            // 
            // dgvThanNhan
            // 
            this.dgvThanNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvThanNhan.Name = "dgvThanNhan";
            this.dgvThanNhan.ReadOnly = true;
            this.dgvThanNhan.Size = new System.Drawing.Size(802, 502);
            this.dgvThanNhan.TabIndex = 0;
            this.dgvThanNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanNhan_CellClick);
            this.dgvThanNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanNhan_CellContentClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(56, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nhân viên : ";
            // 
            // textBoxTenThanNhan
            // 
            this.textBoxTenThanNhan.Enabled = false;
            this.textBoxTenThanNhan.Location = new System.Drawing.Point(153, 153);
            this.textBoxTenThanNhan.Name = "textBoxTenThanNhan";
            this.textBoxTenThanNhan.Size = new System.Drawing.Size(187, 20);
            this.textBoxTenThanNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên thân nhân : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thân nhân : ";
            // 
            // textBoxMaTN
            // 
            this.textBoxMaTN.Enabled = false;
            this.textBoxMaTN.Location = new System.Drawing.Point(153, 100);
            this.textBoxMaTN.Name = "textBoxMaTN";
            this.textBoxMaTN.Size = new System.Drawing.Size(187, 20);
            this.textBoxMaTN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính : ";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(153, 211);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 3;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(258, 211);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quan hệ :";
            // 
            // textBoxQuanHe
            // 
            this.textBoxQuanHe.Enabled = false;
            this.textBoxQuanHe.Location = new System.Drawing.Point(153, 257);
            this.textBoxQuanHe.Name = "textBoxQuanHe";
            this.textBoxQuanHe.Size = new System.Drawing.Size(187, 20);
            this.textBoxQuanHe.TabIndex = 5;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaNV.Enabled = false;
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(153, 50);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(187, 21);
            this.cbxMaNV.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 26);
            this.panel3.TabIndex = 8;
            // 
            // UCThanNhan
            // 
            this.AccessibleDescription = " Thân nhân";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.textBoxQuanHe);
            this.Controls.Add(this.textBoxTenThanNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCThanNhan";
            this.Size = new System.Drawing.Size(1226, 532);
            this.Load += new System.EventHandler(this.UCThanNhan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThanNhan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBoxTenThanNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuanHe;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}
