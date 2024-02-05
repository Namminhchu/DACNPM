using PhanMemQuanLyKhoHangXuatNhapKhau.Control;
using PhanMemQuanLyKhoHangXuatNhapKhau.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoHangXuatNhapKhau
{
    public partial class frmDangNhap : Form
    {
        TaiKhoan_Control db = new TaiKhoan_Control(); // Gọi Controller
        public static string username_save;
        public static string password_save;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Mã đăng nhập không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = db.DangNhap(txtusername.Text.Trim(), txtpassword.Text.Trim());
            if (dt == null || dt.Rows.Count > 0)
            {
                this.Hide();
                frmMain frm = new frmMain();
                username_save = txtusername.Text.Trim();
                password_save = txtpassword.Text.Trim();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
            }
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
