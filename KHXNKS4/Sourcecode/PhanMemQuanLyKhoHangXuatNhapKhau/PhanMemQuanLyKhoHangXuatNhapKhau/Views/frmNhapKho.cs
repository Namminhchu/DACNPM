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
    public partial class frmNhapKho : Form
    {
        NhapKho_Control db = new NhapKho_Control(); // Gọi Controller
        DataTable dt;
        public static Boolean save;
        public static string MaHD_save;
        public static string MaTK_NV_save;
        public static string QuocGia_save;
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
            if(dtGVM.RowCount ==0) // Không có dữ kiệu
            {
                HienThiChiTietPhieuNhap("");
            }    
            else
            {
                // Lấy dữ liệu và hiển thị lên
                DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuNhap(row.Cells[0].Value.ToString());
            }    
        }
        private void HienThiChiTietPhieuNhap(string MaHD)
        {
            dt = db.LoadChiTietPhieuNhap(MaHD);
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
        private void HienThiPhieuNhap()
        {
            dt = db.LoadPhieuNhap();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frmNhapKho_TT frm = new frmNhapKho_TT();
            frm.ShowDialog();
            HienThiPhieuNhap();
            if (dtGVM.RowCount == 0)
            {
                HienThiChiTietPhieuNhap("");
            }
            else
            {
                DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuNhap(row.Cells[0].Value.ToString());
            }
        }

        private void dtGVM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVM.Rows[e.RowIndex];
                HienThiChiTietPhieuNhap(row.Cells[0].Value.ToString());
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
                db.XoaPhieuNhap(dtGVM.Rows[dtGVM.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiPhieuNhap();
                if (dtGVM.RowCount == 0)
                {
                    HienThiChiTietPhieuNhap("");
                }
                else
                {
                    DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                    HienThiChiTietPhieuNhap(row.Cells[0].Value.ToString());
                }
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVM.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
            save = false;
            frmNhapKho_TT frm = new frmNhapKho_TT();
            MaHD_save = row.Cells[0].Value.ToString();
            QuocGia_save = row.Cells[3].Value.ToString();   
            MaTK_NV_save = row.Cells[2].Value.ToString();
            frm.ShowDialog();
            HienThiPhieuNhap();
            if (dtGVM.RowCount == 0)
            {
                HienThiChiTietPhieuNhap("");
            }
            else
            {
                DataGridViewRow row1 = this.dtGVM.Rows[dtGVM.CurrentCell.RowIndex];
                HienThiChiTietPhieuNhap(row1.Cells[0].Value.ToString());
            }
        }

        private void dtGVM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
