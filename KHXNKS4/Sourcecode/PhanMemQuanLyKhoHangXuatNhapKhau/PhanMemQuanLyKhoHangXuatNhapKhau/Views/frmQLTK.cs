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
    public partial class frmQLTK : Form
    {
        TaiKhoan_Control db = new TaiKhoan_Control(); // Gọi hàm contoller
        DataTable dt;
        public static Boolean save;
        public static string MaTK_NV_save;
        public static string MatKhau_save;
        public static string TenTK_NV_save;
        public static string DienThoai_save;
        public static string DiaChi_save;
        public frmQLTK()
        {
            InitializeComponent();
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            HienThiTaiKhoan();
        }
        private void HienThiTaiKhoan()
        {
            // Tạo các cột trong dtGV 
            dt = db.HienThi();
            dtGVTK.DataSource = dt;
            dtGVTK.Columns[0].HeaderText = "Tên đăng nhập";
            dtGVTK.Columns[1].HeaderText = "Họ tên người dùng";
            dtGVTK.Columns[2].HeaderText = "Điện thoại";
            dtGVTK.Columns[3].HeaderText = "Địa chỉ";
            dtGVTK.Columns[0].Width = 110;
            dtGVTK.Columns[1].Width = 130;
            dtGVTK.Columns[2].Width = 100;
            dtGVTK.Columns[3].Width = 120;
            CustomDataGridView(dtGVTK);
        }
        public static void CustomDataGridView(DataGridView dgvMain)
        {
            // Điều chỉnh thao tác của người dùng
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMain.ColumnHeadersHeight = 30;
            dgvMain.ReadOnly = true;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmQLTK_TT frm = new frmQLTK_TT();
            frm.Text = "Thêm mới tài khoản - nhân viên";
            frm.ShowDialog();
            HienThiTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVTK.Rows.Count == 0) // Nếu ko có dữ liệu
            {
                return;
            }// Có dữ liệu
            DataGridViewRow row = this.dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex];
            if (dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString() == "AD")// Nếu là dữ liệu Admin
            {
                MessageBox.Show("Không được phép sửa dữ liệu ADMIN", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Không là Admin
            save = false;
            frmQLTK_TT frm = new frmQLTK_TT();
            MaTK_NV_save = row.Cells[0].Value.ToString();
            DataTable dt2 = db.MạtKhau(row.Cells[0].Value.ToString());
            MatKhau_save = dt2.Rows[0]["MatKhau"].ToString();
            TenTK_NV_save = row.Cells[1].Value.ToString();
            DienThoai_save = row.Cells[2].Value.ToString();
            DiaChi_save = row.Cells[3].Value.ToString();
            frm.Text = "Sửa thông tin tài khoản - nhân viên";
            frm.ShowDialog();
            HienThiTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVTK.Rows.Count == 0) // Nếu dữ liệu rỗng
            {
                return;
            }
            if (dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString() == "AD")// Nếu là dữ liệu Admin
            {
                MessageBox.Show("Không được phép xóa dữ liệu ADMIN", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } // Không là Admin
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Nếu chọn Yes
            {
                db.Xoa(dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiTaiKhoan();
            }
            else // Chọn No
                return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGVTK.DataSource = db.TimKiem(txtTenTK_NV.Text.Trim());
        }
    }
}
