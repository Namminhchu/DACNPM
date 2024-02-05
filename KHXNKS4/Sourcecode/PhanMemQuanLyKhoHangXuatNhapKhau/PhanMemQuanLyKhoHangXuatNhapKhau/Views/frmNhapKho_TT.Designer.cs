
namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    partial class frmNhapKho_TT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKho_TT));
            this.dtGVHH = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.dtGVCTHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTK_NV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.dtNgayHD = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nmSL = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVHH
            // 
            this.dtGVHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGVHH.BackgroundColor = System.Drawing.Color.White;
            this.dtGVHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVHH.Location = new System.Drawing.Point(0, 39);
            this.dtGVHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVHH.Name = "dtGVHH";
            this.dtGVHH.RowHeadersWidth = 51;
            this.dtGVHH.Size = new System.Drawing.Size(481, 439);
            this.dtGVHH.TabIndex = 247;
            this.dtGVHH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHH_CellDoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(380, 2);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 34);
            this.btnTimKiem.TabIndex = 255;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 254;
            this.label2.Text = "Tên hàng hóa";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(137, 10);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(235, 22);
            this.txtTenHH.TabIndex = 253;
            // 
            // dtGVCTHD
            // 
            this.dtGVCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGVCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dtGVCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVCTHD.Location = new System.Drawing.Point(493, 106);
            this.dtGVCTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVCTHD.Name = "dtGVCTHD";
            this.dtGVCTHD.RowHeadersWidth = 51;
            this.dtGVCTHD.Size = new System.Drawing.Size(728, 372);
            this.dtGVCTHD.TabIndex = 256;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 258;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(708, 7);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(271, 22);
            this.txtMaHD.TabIndex = 257;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 260;
            this.label3.Text = "Ngày lập phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(489, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 262;
            this.label4.Text = "Người lập phiếu";
            // 
            // txtMaTK_NV
            // 
            this.txtMaTK_NV.BackColor = System.Drawing.Color.White;
            this.txtMaTK_NV.Location = new System.Drawing.Point(708, 53);
            this.txtMaTK_NV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTK_NV.Name = "txtMaTK_NV";
            this.txtMaTK_NV.ReadOnly = true;
            this.txtMaTK_NV.Size = new System.Drawing.Size(271, 22);
            this.txtMaTK_NV.TabIndex = 261;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(489, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 264;
            this.label5.Text = "Quốc gia";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(708, 76);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(271, 22);
            this.txtQuocGia.TabIndex = 263;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(595, 487);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 266;
            this.label6.Text = "Tổng số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(837, 486);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 268;
            this.label7.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Location = new System.Drawing.Point(941, 485);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(201, 22);
            this.txtTongTien.TabIndex = 267;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnInPhieu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnInPhieu.Location = new System.Drawing.Point(492, 481);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(101, 34);
            this.btnInPhieu.TabIndex = 269;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // dtNgayHD
            // 
            this.dtNgayHD.Enabled = false;
            this.dtNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHD.Location = new System.Drawing.Point(708, 30);
            this.dtNgayHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayHD.Name = "dtNgayHD";
            this.dtNgayHD.Size = new System.Drawing.Size(271, 22);
            this.dtNgayHD.TabIndex = 270;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(1152, 481);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 34);
            this.btnXoa.TabIndex = 271;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(248, 482);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 34);
            this.btnThem.TabIndex = 272;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.BackColor = System.Drawing.Color.White;
            this.txtTongSoLuong.Location = new System.Drawing.Point(731, 487);
            this.txtTongSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.ReadOnly = true;
            this.txtTongSoLuong.Size = new System.Drawing.Size(97, 22);
            this.txtTongSoLuong.TabIndex = 265;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 487);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 274;
            this.label8.Text = "Số lượng";
            // 
            // nmSL
            // 
            this.nmSL.Location = new System.Drawing.Point(96, 486);
            this.nmSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmSL.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmSL.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nmSL.Name = "nmSL";
            this.nmSL.Size = new System.Drawing.Size(144, 22);
            this.nmSL.TabIndex = 275;
            this.nmSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmNhapKho_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1223, 519);
            this.Controls.Add(this.nmSL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtNgayHD);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaTK_NV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dtGVCTHD);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.dtGVHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmNhapKho_TT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhapKho_TT_FormClosed);
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVHH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.DataGridView dtGVCTHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTK_NV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayHD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmSL;
    }
}