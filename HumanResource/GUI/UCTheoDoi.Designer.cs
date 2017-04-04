namespace HumanResource.GUI
{
    partial class UCTheoDoi
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
            this.dataGridViewTheoDoi = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtNgayThang = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuKien = new System.Windows.Forms.TextBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheoDoi)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 17);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTheoDoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 277);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewTheoDoi
            // 
            this.dataGridViewTheoDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheoDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTheoDoi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTheoDoi.Name = "dataGridViewTheoDoi";
            this.dataGridViewTheoDoi.Size = new System.Drawing.Size(842, 277);
            this.dataGridViewTheoDoi.TabIndex = 0;
            this.dataGridViewTheoDoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheoDoi_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbMaNV);
            this.panel3.Controls.Add(this.dtNgayThang);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSuKien);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 270);
            this.panel3.TabIndex = 5;
            // 
            // dtNgayThang
            // 
            this.dtNgayThang.CustomFormat = "";
            this.dtNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThang.Location = new System.Drawing.Point(496, 54);
            this.dtNgayThang.Name = "dtNgayThang";
            this.dtNgayThang.Size = new System.Drawing.Size(120, 20);
            this.dtNgayThang.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sự kiện :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txtSuKien
            // 
            this.txtSuKien.Location = new System.Drawing.Point(199, 114);
            this.txtSuKien.Multiline = true;
            this.txtSuKien.Name = "txtSuKien";
            this.txtSuKien.Size = new System.Drawing.Size(589, 106);
            this.txtSuKien.TabIndex = 33;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(199, 55);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(121, 21);
            this.cbbMaNV.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Họ tên nhân viên :";
            // 
            // UCTheoDoi
            // 
            this.AccessibleDescription = "Theo dõi";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCTheoDoi";
            this.Size = new System.Drawing.Size(842, 564);
            this.Load += new System.EventHandler(this.UCTheoDoi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheoDoi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTheoDoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtNgayThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuKien;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label label1;
    }
}
