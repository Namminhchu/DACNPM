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
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoan_Control db = new TaiKhoan_Control(); // Gọi Controller
        DataTable dt;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            dt = db.MạtKhau(frmDangNhap.username_save);
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTK_NV.Text != frmDangNhap.username_save)
            {
                MessageBox.Show("Mã đăng nhập không đúng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTK_NV.Focus();
                return;
            }
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Focus();
                return;
            }
            if ((txtMatKhauMoi.Text != txtNLMatKhau.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNLMatKhau.Focus();
                return;
            }
            if (txtMatKhauCu.Text != dt.Rows[0]["MatKhau"].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            db.DoiMatKhau(txtMaTK_NV.Text.Trim(), txtMatKhauMoi.Text.Trim());
            MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }
    }
}
