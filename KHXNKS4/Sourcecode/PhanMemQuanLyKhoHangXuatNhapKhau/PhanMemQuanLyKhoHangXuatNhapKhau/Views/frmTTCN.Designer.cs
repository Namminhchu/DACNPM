
namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    partial class frmTTCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTTCN));
            this.frmThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK_NV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTK_NV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmThoat
            // 
            this.frmThoat.BackColor = System.Drawing.Color.Red;
            this.frmThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmThoat.ForeColor = System.Drawing.Color.White;
            this.frmThoat.Location = new System.Drawing.Point(297, 104);
            this.frmThoat.Name = "frmThoat";
            this.frmThoat.Size = new System.Drawing.Size(87, 35);
            this.frmThoat.TabIndex = 246;
            this.frmThoat.Text = "Thoát";
            this.frmThoat.UseVisualStyleBackColor = false;
            this.frmThoat.Click += new System.EventHandler(this.frmThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 244;
            this.label3.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(177, 73);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(207, 20);
            this.txtDiaChi.TabIndex = 240;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 243;
            this.label7.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(177, 52);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(207, 20);
            this.txtDienThoai.TabIndex = 239;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 242;
            this.label2.Text = "Tên tài khoản";
            // 
            // txtTenTK_NV
            // 
            this.txtTenTK_NV.Location = new System.Drawing.Point(177, 31);
            this.txtTenTK_NV.Name = "txtTenTK_NV";
            this.txtTenTK_NV.ReadOnly = true;
            this.txtTenTK_NV.Size = new System.Drawing.Size(207, 20);
            this.txtTenTK_NV.TabIndex = 238;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 241;
            this.label1.Text = "Mã tài khoản";
            // 
            // txtMaTK_NV
            // 
            this.txtMaTK_NV.Location = new System.Drawing.Point(177, 10);
            this.txtMaTK_NV.Name = "txtMaTK_NV";
            this.txtMaTK_NV.ReadOnly = true;
            this.txtMaTK_NV.Size = new System.Drawing.Size(207, 20);
            this.txtMaTK_NV.TabIndex = 237;
            // 
            // frmTTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(399, 148);
            this.Controls.Add(this.frmThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTK_NV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTK_NV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTTCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frmTTCN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTK_NV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTK_NV;
    }
}