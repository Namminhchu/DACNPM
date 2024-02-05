using PhanMemQuanLyKhoHangXuatNhapKhau.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Views
{
    public partial class frmQLTK_TT : Form
    {
        TaiKhoan_Control db = new TaiKhoan_Control();
        public frmQLTK_TT()
        {
            InitializeComponent();
        }

        private void frmQLTK_TT_Load(object sender, EventArgs e)
        {
            if (frmQLTK.save == false)
            {
                txtMaTK_NV.Text = frmQLTK.MaTK_NV_save;
                txtMatKhau.Text = frmQLTK.MatKhau_save;
                txtNLMatKhau.Text = frmQLTK.MatKhau_save;
                txtTenTK_NV.Text = frmQLTK.TenTK_NV_save;
                txtDienThoai.Text = frmQLTK.DienThoai_save;
                txtDiaChi.Text = frmQLTK.DiaChi_save;
            }
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaTK_NV.Text == "")
            {
                MessageBox.Show("Mã tài khoản - nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaTK_NV.Focus();
                return;
            }
            if (txtTenTK_NV.Text == "")
            {
                MessageBox.Show("Họ tên tài khoản - nhân viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTK_NV.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            if ((txtNLMatKhau.Text == ""))
            {
                MessageBox.Show("Nhập lại mật khẩu không không được bỏ trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNLMatKhau.Focus();
                return;
            }

            if ((txtMatKhau.Text != txtNLMatKhau.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNLMatKhau.Focus();
                return;
            }

            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Điện thoại không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            Regex regexPhoneNumber = new Regex(@"^(03|05|07|08|09)+([0-9]{8})$");
            if (!regexPhoneNumber.IsMatch(txtDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng 03, 05, 07, 08 hoặc 09 và có 10 chữ số", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Text = ""; // Xóa nội dung của TextBox
                txtDienThoai.Focus(); // Di chuyển con trỏ văn bản đến TextBox
                return;
            }

            if (frmQLTK.save == true)
            {
                if (db.KiemTraDuLieuTonTai(txtMaTK_NV.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại, Tài khoản này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMaTK_NV.Text.Trim(), txtTenTK_NV.Text.Trim(), txtMatKhau.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (frmQLTK.save == false)
            {
                if (db.KiemTraDuLieuTonTai(txtMaTK_NV.Text) == 0 && txtMaTK_NV.Text != frmQLTK.MaTK_NV_save)
                {
                    MessageBox.Show("Sửa thất bại, Tài khoản này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Sua(txtMaTK_NV.Text.Trim(), frmQLTK.MaTK_NV_save, txtTenTK_NV.Text.Trim(), txtMatKhau.Text.Trim(), txtDienThoai.Text.Trim(), txtDiaChi.Text.Trim());
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }

        }

        private void txtTenTK_NV_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có chứa ký tự số hay không
            if (txtTenTK_NV.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên tài khoản không được chứa ký tự số", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK_NV.Text = "";
                txtTenTK_NV.Focus();
                return;
            }
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
