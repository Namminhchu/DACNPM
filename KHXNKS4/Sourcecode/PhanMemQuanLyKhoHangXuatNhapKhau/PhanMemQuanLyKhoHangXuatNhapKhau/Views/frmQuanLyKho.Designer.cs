
namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    partial class frmQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKho));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtGVHH = new System.Windows.Forms.DataGridView();
            this.btnTinhTK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTS = new System.Windows.Forms.RadioButton();
            this.rbDL = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.rbTC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(684, 393);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 43);
            this.btnTimKiem.TabIndex = 259;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 258;
            this.label2.Text = "Tên hàng hóa";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHH.Location = new System.Drawing.Point(300, 401);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(275, 22);
            this.txtTenHH.TabIndex = 257;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(3, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 43);
            this.btnSua.TabIndex = 255;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtGVHH
            // 
            this.dtGVHH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVHH.BackgroundColor = System.Drawing.Color.White;
            this.dtGVHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVHH.Location = new System.Drawing.Point(143, 50);
            this.dtGVHH.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVHH.Name = "dtGVHH";
            this.dtGVHH.RowHeadersWidth = 51;
            this.dtGVHH.Size = new System.Drawing.Size(663, 341);
            this.dtGVHH.TabIndex = 253;
            this.dtGVHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHH_CellContentClick);
            // 
            // btnTinhTK
            // 
            this.btnTinhTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnTinhTK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTK.ForeColor = System.Drawing.Color.Black;
            this.btnTinhTK.Location = new System.Drawing.Point(3, 50);
            this.btnTinhTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhTK.Name = "btnTinhTK";
            this.btnTinhTK.Size = new System.Drawing.Size(132, 43);
            this.btnTinhTK.TabIndex = 260;
            this.btnTinhTK.Text = "Tính Tồn kho";
            this.btnTinhTK.UseVisualStyleBackColor = false;
            this.btnTinhTK.Click += new System.EventHandler(this.btnTinhTK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTC);
            this.groupBox1.Controls.Add(this.rbTS);
            this.groupBox1.Controls.Add(this.rbDL);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(142, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 37);
            this.groupBox1.TabIndex = 261;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbTS
            // 
            this.rbTS.AutoSize = true;
            this.rbTS.Location = new System.Drawing.Point(310, 10);
            this.rbTS.Name = "rbTS";
            this.rbTS.Size = new System.Drawing.Size(125, 21);
            this.rbTS.TabIndex = 2;
            this.rbTS.TabStop = true;
            this.rbTS.Text = "Hàng tươi sống";
            this.rbTS.UseVisualStyleBackColor = true;
            this.rbTS.CheckedChanged += new System.EventHandler(this.rbTS_CheckedChanged);
            // 
            // rbDL
            // 
            this.rbDL.AutoSize = true;
            this.rbDL.Location = new System.Drawing.Point(130, 10);
            this.rbDL.Name = "rbDL";
            this.rbDL.Size = new System.Drawing.Size(130, 21);
            this.rbDL.TabIndex = 1;
            this.rbDL.TabStop = true;
            this.rbDL.Text = "Hàng đông lạnh";
            this.rbDL.UseVisualStyleBackColor = true;
            this.rbDL.CheckedChanged += new System.EventHandler(this.rbDL_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(6, 11);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(69, 21);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(3, 95);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(132, 43);
            this.btnIn.TabIndex = 262;
            this.btnIn.Text = "In danh sách";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // rbTC
            // 
            this.rbTC.AutoSize = true;
            this.rbTC.Location = new System.Drawing.Point(469, 10);
            this.rbTC.Name = "rbTC";
            this.rbTC.Size = new System.Drawing.Size(80, 21);
            this.rbTC.TabIndex = 3;
            this.rbTC.TabStop = true;
            this.rbTC.Text = "Trái cây";
            this.rbTC.UseVisualStyleBackColor = true;
            this.rbTC.CheckedChanged += new System.EventHandler(this.rbTC_CheckedChanged);
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(808, 437);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinhTK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtGVHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtGVHH;
        private System.Windows.Forms.Button btnTinhTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTS;
        private System.Windows.Forms.RadioButton rbDL;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.RadioButton rbTC;
    }
}