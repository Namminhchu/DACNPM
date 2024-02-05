using PhanMemQuanLyKhoHangXuatNhapKhau.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    public partial class frmTTCN : Form
    {
        TaiKhoan_Control db = new TaiKhoan_Control();
        DataTable dt;
        public frmTTCN()
        {
            InitializeComponent();
        }

        private void frmTTCN_Load(object sender, EventArgs e)
        {
            dt = db.ThongTinCaNhan(frmDangNhap.username_save);
            txtMaTK_NV.Text = dt.Rows[0]["MaTK_NV"].ToString();
            txtTenTK_NV.Text = dt.Rows[0]["TenTK_NV"].ToString();
            txtDienThoai.Text = dt.Rows[0]["DienThoai"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
