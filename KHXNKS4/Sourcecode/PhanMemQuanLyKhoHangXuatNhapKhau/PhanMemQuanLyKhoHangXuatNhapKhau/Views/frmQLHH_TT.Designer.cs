
namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    partial class frmQLHH_TT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHH_TT));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.frmThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLHH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.nmGiaXuat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiaXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 237;
            this.label3.Text = "Tên hàng hóa";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(209, 39);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(271, 22);
            this.txtTenHH.TabIndex = 233;
            this.txtTenHH.TextChanged += new System.EventHandler(this.txtTenHH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 236;
            this.label1.Text = "Mã hàng hóa";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(209, 14);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(271, 22);
            this.txtMaHH.TabIndex = 232;
            // 
            // frmThoat
            // 
            this.frmThoat.BackColor = System.Drawing.Color.Red;
            this.frmThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmThoat.ForeColor = System.Drawing.Color.White;
            this.frmThoat.Location = new System.Drawing.Point(365, 153);
            this.frmThoat.Margin = new System.Windows.Forms.Padding(4);
            this.frmThoat.Name = "frmThoat";
            this.frmThoat.Size = new System.Drawing.Size(116, 43);
            this.frmThoat.TabIndex = 240;
            this.frmThoat.Text = "Thoát";
            this.frmThoat.UseVisualStyleBackColor = false;
            this.frmThoat.Click += new System.EventHandler(this.frmThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(248, 153);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 43);
            this.btnLuu.TabIndex = 239;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 242;
            this.label2.Text = "Phân loại";
            // 
            // cboLHH
            // 
            this.cboLHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLHH.FormattingEnabled = true;
            this.cboLHH.Location = new System.Drawing.Point(209, 64);
            this.cboLHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLHH.Name = "cboLHH";
            this.cboLHH.Size = new System.Drawing.Size(271, 24);
            this.cboLHH.TabIndex = 243;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 244;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 246;
            this.label5.Text = "Giá xuất";
            // 
            // nmGiaNhap
            // 
            this.nmGiaNhap.Location = new System.Drawing.Point(209, 92);
            this.nmGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.nmGiaNhap.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmGiaNhap.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmGiaNhap.Name = "nmGiaNhap";
            this.nmGiaNhap.Size = new System.Drawing.Size(272, 22);
            this.nmGiaNhap.TabIndex = 247;
            this.nmGiaNhap.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nmGiaXuat
            // 
            this.nmGiaXuat.Location = new System.Drawing.Point(209, 118);
            this.nmGiaXuat.Margin = new System.Windows.Forms.Padding(4);
            this.nmGiaXuat.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmGiaXuat.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmGiaXuat.Name = "nmGiaXuat";
            this.nmGiaXuat.Size = new System.Drawing.Size(272, 22);
            this.nmGiaXuat.TabIndex = 248;
            this.nmGiaXuat.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // frmQLHH_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(500, 202);
            this.Controls.Add(this.nmGiaXuat);
            this.Controls.Add(this.nmGiaNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frmThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLHH_TT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLHH_TT";
            this.Load += new System.EventHandler(this.frmQLHH_TT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiaXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmGiaNhap;
        private System.Windows.Forms.NumericUpDown nmGiaXuat;
    }
}