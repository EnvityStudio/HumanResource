namespace HumanResource.GUI
{
    partial class FormSearch
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgbNhanVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên",
            "Tên phòng ban",
            "Quê quán",
            "Giới tính"});
            this.cbbType.Location = new System.Drawing.Point(545, 76);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(133, 21);
            this.cbbType.TabIndex = 7;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(330, 76);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(146, 20);
            this.txtKey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Theo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm :";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 15);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgbNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 306);
            this.panel2.TabIndex = 11;
            // 
            // dgbNhanVien
            // 
            this.dgbNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgbNhanVien.Name = "dgbNhanVien";
            this.dgbNhanVien.Size = new System.Drawing.Size(959, 306);
            this.dgbNhanVien.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm Kiếm Nhân Viên";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhân viên";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgbNhanVien;
        private System.Windows.Forms.Label label3;
    }
}