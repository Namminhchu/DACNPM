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
    public partial class frmQLHH : Form
    {
        HangHoa_Control db = new HangHoa_Control();
        DataTable dt;
        public static Boolean save;
        public static string MaHH_save;
        public static string TenHH_save;
        public static string LoaiHH_save;
        public static decimal GiaNhap_save;
        public static decimal GiaXuat_save;
        public frmQLHH()
        {
            InitializeComponent();
        }

        private void frmQLHH_Load(object sender, EventArgs e)
        {
            HienThiHangHoa();
        }
        private void HienThiHangHoa()
        {
            dt = db.Load();
            dtGVHH.DataSource = dt;
            dtGVHH.Columns[0].HeaderText = "Mã hàng hóa";
            dtGVHH.Columns[1].HeaderText = "Tên hàng hóa";
            dtGVHH.Columns[2].HeaderText = "Phân loại";
            dtGVHH.Columns[3].HeaderText = "Giá nhập";
            dtGVHH.Columns[4].HeaderText = "Giá xuất";
            dtGVHH.Columns[0].Width = 120;
            dtGVHH.Columns[1].Width = 200;
            dtGVHH.Columns[2].Width = 120;
            dtGVHH.Columns[3].Width = 120;
            dtGVHH.Columns[4].Width = 120;
            frmQLTK.CustomDataGridView(dtGVHH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmQLHH_TT frm = new frmQLHH_TT();
            frm.Text = "Thêm mới hàng hóa";
            frm.ShowDialog();
            HienThiHangHoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVHH.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVHH.Rows[dtGVHH.CurrentCell.RowIndex];
            save = false;
            frmQLHH_TT frm = new frmQLHH_TT();
            MaHH_save = row.Cells[0].Value.ToString();
            TenHH_save = row.Cells[1].Value.ToString();
            LoaiHH_save = row.Cells[2].Value.ToString();
            GiaNhap_save = decimal.Parse(row.Cells[3].Value.ToString());
            GiaXuat_save = decimal.Parse(row.Cells[4].Value.ToString());
            frm.Text = "Sửa thông tin hàng hóa";
            frm.ShowDialog();
            HienThiHangHoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVHH.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVHH.Rows[dtGVHH.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiHangHoa();
            }
            else
                return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGVHH.DataSource = db.TimKiem(txtTenHH.Text.Trim());
        }
    }
}
