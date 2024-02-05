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
    public partial class frmXuatKho : Form
    {
        XuatKho_Control db = new XuatKho_Control();
        DataTable dt;
        public static Boolean save;
        public static string MaHD_save;
        public static string MaTK_NV_save;
        public static string QuocGia_save;
        public frmXuatKho()
        {
            InitializeComponent();
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            HienThiPhieuXuat();
            if (dtGVM.RowCount == 0)
            {
                HienThiChiTietPhieuXuat("");
            }
            else
            {
                DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuXuat(row.Cells[0].Value.ToString());
            }
        }
        private void HienThiChiTietPhieuXuat(string MaHD)
        {
            dt = db.LoadChiTietPhieuXuat(MaHD);
            dtGVD.DataSource = dt;
            dtGVD.Columns[0].HeaderText = "Mã phiếu";
            dtGVD.Columns[1].HeaderText = "Mã hàng hóa";
            dtGVD.Columns[2].HeaderText = "Đơn giá";
            dtGVD.Columns[3].HeaderText = "Số lượng";
            dtGVD.Columns[4].HeaderText = "Thành tiền";
            dtGVD.Columns[0].Width = 120;
            dtGVD.Columns[1].Width = 120;
            dtGVD.Columns[2].Width = 120;
            dtGVD.Columns[3].Width = 120;
            dtGVD.Columns[4].Width = 120;
            frmQLTK.CustomDataGridView(dtGVD);
        }
        private void HienThiPhieuXuat()
        {
            dt = db.LoadPhieuXuat();
            dtGVM.DataSource = dt;
            dtGVM.Columns[0].HeaderText = "Mã phiếu";
            dtGVM.Columns[1].HeaderText = "Ngày lập";
            dtGVM.Columns[2].HeaderText = "Người lập";
            dtGVM.Columns[3].HeaderText = "Quốc gia";
            dtGVM.Columns[4].HeaderText = "Tổng số lượng";
            dtGVM.Columns[5].HeaderText = "Tổng tiền";
            dtGVM.Columns[0].Width = 120;
            dtGVM.Columns[1].Width = 120;
            dtGVM.Columns[2].Width = 120;
            dtGVM.Columns[3].Width = 120;
            dtGVM.Columns[4].Width = 120;
            dtGVM.Columns[5].Width = 120;
            frmQLTK.CustomDataGridView(dtGVM);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmXuatKho_TT frm = new frmXuatKho_TT();
            frm.ShowDialog();
            HienThiPhieuXuat();
            if (dtGVM.RowCount == 0)
            {
                HienThiChiTietPhieuXuat("");
            }
            else
            {
                DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuXuat(row.Cells[0].Value.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVM.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
            save = false;
            frmXuatKho_TT frm = new frmXuatKho_TT();
            MaHD_save = row.Cells[0].Value.ToString();
            QuocGia_save = row.Cells[3].Value.ToString();
            MaTK_NV_save = row.Cells[2].Value.ToString();
            frm.ShowDialog();
            HienThiPhieuXuat();
            if (dtGVM.RowCount == 0)
            {
                HienThiChiTietPhieuXuat("");
            }
            else
            {
                DataGridViewRow row1 = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuXuat(row1.Cells[0].Value.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVM.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.XoaPhieuXuat(dtGVM.Rows[dtGVM.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiPhieuXuat();
                if (dtGVM.RowCount == 0)
                {
                    HienThiChiTietPhieuXuat("");
                }
                else
                {
                    DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                    HienThiChiTietPhieuXuat(row.Cells[0].Value.ToString());
                }
            }
            else
                return;
        }

        private void dtGVM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVM.Rows[e.RowIndex];
                HienThiChiTietPhieuXuat(row.Cells[0].Value.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGVM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
