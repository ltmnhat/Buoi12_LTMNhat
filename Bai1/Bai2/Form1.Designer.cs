namespace Bai2
{
    partial class Form1
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
            this.lbThongTin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoiNghi = new System.Windows.Forms.TextBox();
            this.txtTenHoiNghi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoNguoiThamGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuuThemMoi = new System.Windows.Forms.Button();
            this.btnXoaPhongHN = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.gbDSPHN = new System.Windows.Forms.GroupBox();
            this.dgvDSPHN = new System.Windows.Forms.DataGridView();
            this.Hovaten = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.gbDSPHN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPHN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.lbThongTin.Location = new System.Drawing.Point(277, 44);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(293, 22);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "-THONG TIN PHONG HOI NGHI-";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Hoi Nghi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Hoi Nghi:";
            // 
            // txtMaHoiNghi
            // 
            this.txtMaHoiNghi.Location = new System.Drawing.Point(150, 84);
            this.txtMaHoiNghi.Name = "txtMaHoiNghi";
            this.txtMaHoiNghi.Size = new System.Drawing.Size(544, 20);
            this.txtMaHoiNghi.TabIndex = 3;
            // 
            // txtTenHoiNghi
            // 
            this.txtTenHoiNghi.Location = new System.Drawing.Point(150, 114);
            this.txtTenHoiNghi.Name = "txtTenHoiNghi";
            this.txtTenHoiNghi.Size = new System.Drawing.Size(544, 20);
            this.txtTenHoiNghi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loai Phong HN:";
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(150, 155);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(165, 21);
            this.cbbLoaiPhong.TabIndex = 6;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "So Nguoi Tham Gia:";
            // 
            // txtSoNguoiThamGia
            // 
            this.txtSoNguoiThamGia.Location = new System.Drawing.Point(450, 155);
            this.txtSoNguoiThamGia.Name = "txtSoNguoiThamGia";
            this.txtSoNguoiThamGia.Size = new System.Drawing.Size(244, 20);
            this.txtSoNguoiThamGia.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(140, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Them Moi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuuThemMoi
            // 
            this.btnLuuThemMoi.Location = new System.Drawing.Point(296, 221);
            this.btnLuuThemMoi.Name = "btnLuuThemMoi";
            this.btnLuuThemMoi.Size = new System.Drawing.Size(90, 23);
            this.btnLuuThemMoi.TabIndex = 10;
            this.btnLuuThemMoi.Text = "Luu Them Moi";
            this.btnLuuThemMoi.UseVisualStyleBackColor = true;
            this.btnLuuThemMoi.Click += new System.EventHandler(this.btnLuuThemMoi_Click);
            // 
            // btnXoaPhongHN
            // 
            this.btnXoaPhongHN.Location = new System.Drawing.Point(461, 220);
            this.btnXoaPhongHN.Name = "btnXoaPhongHN";
            this.btnXoaPhongHN.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhongHN.TabIndex = 11;
            this.btnXoaPhongHN.Text = "Xoa Phong HN";
            this.btnXoaPhongHN.UseVisualStyleBackColor = true;
            this.btnXoaPhongHN.Click += new System.EventHandler(this.btnXoaPhongHN_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(624, 220);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 12;
            this.btnKetThuc.Text = "Ket Thuc";
            this.btnKetThuc.UseCompatibleTextRendering = true;
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // gbDSPHN
            // 
            this.gbDSPHN.Controls.Add(this.dgvDSPHN);
            this.gbDSPHN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSPHN.Location = new System.Drawing.Point(74, 291);
            this.gbDSPHN.Name = "gbDSPHN";
            this.gbDSPHN.Size = new System.Drawing.Size(625, 121);
            this.gbDSPHN.TabIndex = 13;
            this.gbDSPHN.TabStop = false;
            this.gbDSPHN.Text = "Danh sach phong hoi nghi";
            // 
            // dgvDSPHN
            // 
            this.dgvDSPHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPHN.Location = new System.Drawing.Point(6, 18);
            this.dgvDSPHN.Name = "dgvDSPHN";
            this.dgvDSPHN.Size = new System.Drawing.Size(613, 97);
            this.dgvDSPHN.TabIndex = 0;
            // 
            // Hovaten
            // 
            this.Hovaten.AutoSize = true;
            this.Hovaten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hovaten.ForeColor = System.Drawing.Color.Blue;
            this.Hovaten.Location = new System.Drawing.Point(53, 429);
            this.Hovaten.Name = "Hovaten";
            this.Hovaten.Size = new System.Drawing.Size(230, 15);
            this.Hovaten.TabIndex = 14;
            this.Hovaten.Text = "Ho ten SV: Minh Nhat_MSSV: 2033210404";
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Blue;
            this.btnLoc.Location = new System.Drawing.Point(338, 420);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(355, 23);
            this.btnLoc.TabIndex = 15;
            this.btnLoc.Text = "Loc Danh Sach Theo Phong Hoi Nghi";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.Hovaten);
            this.Controls.Add(this.gbDSPHN);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaPhongHN);
            this.Controls.Add(this.btnLuuThemMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoNguoiThamGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHoiNghi);
            this.Controls.Add(this.txtMaHoiNghi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThongTin);
            this.Name = "Form1";
            this.Text = "Quan Li Hoi Nghi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDSPHN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPHN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHoiNghi;
        private System.Windows.Forms.TextBox txtTenHoiNghi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoNguoiThamGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuuThemMoi;
        private System.Windows.Forms.Button btnXoaPhongHN;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.GroupBox gbDSPHN;
        private System.Windows.Forms.DataGridView dgvDSPHN;
        private System.Windows.Forms.Label Hovaten;
        private System.Windows.Forms.Button btnLoc;
    }
}

