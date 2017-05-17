namespace HumanResource.GUI
{
    partial class FrmThanNhanNV
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
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.btnThanNhanDong = new System.Windows.Forms.Button();
            this.btnThanNhanLuu = new System.Windows.Forms.Button();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(194, 92);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 39;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.Location = new System.Drawing.Point(134, 92);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 40;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // btnThanNhanDong
            // 
            this.btnThanNhanDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThanNhanDong.Location = new System.Drawing.Point(194, 176);
            this.btnThanNhanDong.Name = "btnThanNhanDong";
            this.btnThanNhanDong.Size = new System.Drawing.Size(53, 23);
            this.btnThanNhanDong.TabIndex = 38;
            this.btnThanNhanDong.Text = "Đóng";
            this.btnThanNhanDong.UseVisualStyleBackColor = true;
            // 
            // btnThanNhanLuu
            // 
            this.btnThanNhanLuu.Location = new System.Drawing.Point(103, 176);
            this.btnThanNhanLuu.Name = "btnThanNhanLuu";
            this.btnThanNhanLuu.Size = new System.Drawing.Size(51, 23);
            this.btnThanNhanLuu.TabIndex = 37;
            this.btnThanNhanLuu.Text = "Lưu";
            this.btnThanNhanLuu.UseVisualStyleBackColor = true;
            this.btnThanNhanLuu.Click += new System.EventHandler(this.btnThanNhanLuu_Click);
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(134, 125);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(158, 20);
            this.txtQuanHe.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quan Hệ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(134, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 20);
            this.txtHoTen.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giới Tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Họ Tên:";
            // 
            // FrmThanNhanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 266);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.btnThanNhanDong);
            this.Controls.Add(this.btnThanNhanLuu);
            this.Controls.Add(this.txtQuanHe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmThanNhanNV";
            this.Text = "Thân nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.Button btnThanNhanDong;
        private System.Windows.Forms.Button btnThanNhanLuu;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}