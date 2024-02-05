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
    public partial class frmQuanLyKho_TT : Form
    {
        public frmQuanLyKho_TT()
        {
            InitializeComponent();
        }
        QuanLyKho_Control db = new QuanLyKho_Control();
        private void frmQuanLyKho_TT_Load(object sender, EventArgs e)
        {
            txtMaHH.Text = frmQuanLyKho.MaHH_save;
            txtTenHH.Text = frmQuanLyKho.TenHH_save;
            nmSoLuongTon.Value = frmQuanLyKho.TonKho_save;
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nmSoLuongTon.Text == "")
            {
                MessageBox.Show("Số lượng không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHH.Focus();
                return;
            }
            db.Sua(txtMaHH.Text.Trim(), nmSoLuongTon.Value);
            MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }
    }
}
