
namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    partial class frmQuanLyKho_TT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKho_TT));
            this.frmThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmSoLuongTon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTon)).BeginInit();
            this.SuspendLayout();
            // 
            // frmThoat
            // 
            this.frmThoat.BackColor = System.Drawing.Color.Red;
            this.frmThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmThoat.ForeColor = System.Drawing.Color.White;
            this.frmThoat.Location = new System.Drawing.Point(365, 109);
            this.frmThoat.Margin = new System.Windows.Forms.Padding(4);
            this.frmThoat.Name = "frmThoat";
            this.frmThoat.Size = new System.Drawing.Size(116, 43);
            this.frmThoat.TabIndex = 246;
            this.frmThoat.Text = "Thoát";
            this.frmThoat.UseVisualStyleBackColor = false;
            this.frmThoat.Click += new System.EventHandler(this.frmThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(248, 109);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 43);
            this.btnLuu.TabIndex = 245;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 244;
            this.label3.Text = "Tên hàng hóa";
            // 
            // txtTenHH
            // 
            this.txtTenHH.BackColor = System.Drawing.Color.White;
            this.txtTenHH.Location = new System.Drawing.Point(209, 35);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(271, 22);
            this.txtTenHH.TabIndex = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 243;
            this.label1.Text = "Mã hàng hóa";
            // 
            // txtMaHH
            // 
            this.txtMaHH.BackColor = System.Drawing.Color.White;
            this.txtMaHH.Location = new System.Drawing.Point(209, 10);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(271, 22);
            this.txtMaHH.TabIndex = 241;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 248;
            this.label2.Text = "Số lượng tồn";
            // 
            // nmSoLuongTon
            // 
            this.nmSoLuongTon.Location = new System.Drawing.Point(209, 61);
            this.nmSoLuongTon.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmSoLuongTon.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nmSoLuongTon.Name = "nmSoLuongTon";
            this.nmSoLuongTon.Size = new System.Drawing.Size(271, 22);
            this.nmSoLuongTon.TabIndex = 249;
            this.nmSoLuongTon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmQuanLyKho_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(500, 165);
            this.Controls.Add(this.nmSoLuongTon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frmThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyKho_TT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số lượng tồn";
            this.Load += new System.EventHandler(this.frmQuanLyKho_TT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmSoLuongTon;
    }
}