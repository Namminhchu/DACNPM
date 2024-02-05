using PhanMemQuanLyKhoHangXuatNhapKhau.Control;
using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
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
    public partial class frmXuatKho_TT : Form
    {
        XuatKho_Control db = new XuatKho_Control();
        DataTable dt;
        public frmXuatKho_TT()
        {
            InitializeComponent();
        }

        private void frmXuatKho_TT_Load(object sender, EventArgs e)
        {
            if (frmXuatKho.save == true)
            {
                GenCode();
                txtMaTK_NV.Text = frmDangNhap.username_save;
                string sqlString = "INSERT INTO PhieuXuat(MaHD,NgayHD,MaTK_NV,QuocGia,TongTien,TongSoLuong)  VALUES ( '" + txtMaHD.Text + "',GETDATE(),'" + txtMaTK_NV.Text + "',N'" + txtQuocGia.Text.Trim() + "',0,0)";
                DB_Connect.ExecuteNonQuery(sqlString);
                HienThiHangHoa();
            }
            else
            {
                txtMaHD.Text = frmXuatKho.MaHD_save;
                txtMaTK_NV.Text = frmXuatKho.MaTK_NV_save;
                txtQuocGia.Text = frmXuatKho.QuocGia_save;
                HienThiHangHoa();
                HienThiChiTietHoaDon(txtMaHD.Text.Trim());
            }
        }
        private void HienThiChiTietHoaDon(string MaHD)
        {
            dt = db.HienThiChiTietHoaDon(MaHD);
            dtGVCTHD.DataSource = dt;
            dtGVCTHD.Columns[0].HeaderText = "Mã hàng hóa";
            dtGVCTHD.Columns[1].HeaderText = "Tên hàng hóa";
            dtGVCTHD.Columns[2].HeaderText = "Đơn giá";
            dtGVCTHD.Columns[3].HeaderText = "Số lượng";
            dtGVCTHD.Columns[4].HeaderText = "Thành tiền";
            dtGVCTHD.Columns[0].Width = 80;
            dtGVCTHD.Columns[1].Width = 120;
            dtGVCTHD.Columns[2].Width = 100;
            dtGVCTHD.Columns[3].Width = 80;
            dtGVCTHD.Columns[4].Width = 100;
            frmQLTK.CustomDataGridView(dtGVCTHD);
            TongTienHoaDon();
        }
        public void TongTienHoaDon()
        {
            txtTongTien.Text = "0";
            txtTongSoLuong.Text = "0";
            if (dtGVCTHD.Rows.Count == 0)
            {
                return;
            }
            int tien = dtGVCTHD.Rows.Count;
            decimal thanhtien = 0;
            decimal soluong = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += decimal.Parse(dtGVCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
                soluong += decimal.Parse(dtGVCTHD.Rows[i].Cells["SoLuong"].Value.ToString());
            }
            txtTongTien.Text = thanhtien.ToString("#,###");
            txtTongSoLuong.Text = soluong.ToString("#,###");
        }
        private void GenCode()
        {
            string sTemp = DateTime.Now.ToString("yyMMddhhmmss");
            string sBarcode = sTemp;
            int iSum = 0;
            int iDigit = 0;
            for (int i = sTemp.Length; i >= 1; i += -1)
            {
                iDigit = Convert.ToInt32(sTemp.Substring(i - 1, 1));
                if (i % 2 == 0)
                    iSum += iDigit * 3;
                else
                    iSum += iDigit * 1;
            }
            int iCheckSum = (10 - (iSum % 10)) % 10;
            sBarcode = "HDN_" + sBarcode + iCheckSum.ToString();
            txtMaHD.Text = sBarcode;
        }
        private void HienThiHangHoa()
        {
            dt = db.LoadGiaXuat();
            dtGVHH.DataSource = dt;
            dtGVHH.Columns[0].HeaderText = "Mã hàng hóa";
            dtGVHH.Columns[1].HeaderText = "Tên hàng hóa";
            dtGVHH.Columns[2].HeaderText = "Giá xuất";
            dtGVHH.Columns[0].Width = 80;
            dtGVHH.Columns[1].Width = 120;
            dtGVHH.Columns[2].Width = 100;
            frmQLTK.CustomDataGridView(dtGVHH);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGVHH.DataSource = db.TimKiemGiaXuat(txtTenHH.Text.Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtGVHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có hàng hóa để tạo phiếu, hãy thêm mới", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = this.dtGVHH.Rows[dtGVHH.CurrentCell.RowIndex];
            string MaHD = txtMaHD.Text;
            string MaHH = row.Cells[0].Value.ToString();
            decimal DonGia = decimal.Parse(row.Cells[2].Value.ToString() + "");
            decimal SoLuong = nmSL.Value;
            decimal ThanhTien = DonGia * SoLuong;
            if (db.KiemTraDuLieuTonTai(MaHD, MaHH) == 0)
            {
                string sqlUpdate = "UPDATE ChiTietPhieuXuat SET SoLuong = SoLuong + " + nmSL.Value+" WHERE MaHD = '" + MaHD + "' And MaHH = '" + MaHH + "'";
                DB_Connect.ExecuteNonQuery(sqlUpdate);

                string sqlUpdate2 = "UPDATE ChiTietPhieuXuat SET ThanhTien = SoLuong * DonGia WHERE MaHD = '" + MaHD + "' And MaHH = '" + MaHH + "'";
                DB_Connect.ExecuteNonQuery(sqlUpdate2);

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlString = "INSERT INTO ChiTietPhieuXuat(MaHD,MaHH,DonGia,SoLuong,ThanhTien)  VALUES ( '" + MaHD + "','" + MaHH + "'," + DonGia + "," + SoLuong + "," + ThanhTien + ")";
                DB_Connect.ExecuteNonQuery(sqlString);

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HienThiChiTietHoaDon(txtMaHD.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVCTHD.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVCTHD.Rows[dtGVCTHD.CurrentCell.RowIndex];

            string sqlString = "DELETE ChiTietPhieuXuat WHERE MaHD = '" + txtMaHD.Text + "' AND MaHH = N'" + row.Cells[0].Value.ToString() + "'";
            DB_Connect.ExecuteNonQuery(sqlString);
            HienThiChiTietHoaDon(txtMaHD.Text);
        }

        private void frmXuatKho_TT_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s = "DELETE PhieuXuat WHERE MaHD NOT IN (SELECT MaHD From ChiTietPhieuXuat) UPDATE PhieuXuat SET QuocGia = N'" + txtQuocGia.Text.Trim() + "' WHERE MaHD = '" + txtMaHD.Text.Trim() + "'";
            if (dtGVCTHD.RowCount != 0)
            {
                s = s + "; UPDATE PhieuXuat SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietPhieuXuat WHERE MaHD ='" + txtMaHD.Text.Trim() + "' ) ";
                s = s + "; UPDATE PhieuXuat SET TongSoLuong = (SELECT SUM(SoLuong) FROM ChiTietPhieuXuat WHERE MaHD ='" + txtMaHD.Text.Trim() + "' ) ";
            }
            DB_Connect.ExecuteNonQuery(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtGVCTHD.Rows.Count == 0)
            {
                return;
            }
            frmInPhieu frm = new frmInPhieu();
            frm.Text = "In phiếu xuất kho";
            frmNhapKho_TT.MaHDIn = txtMaHD.Text.Trim();
            frmNhapKho_TT.NgayHDIn = dtNgayHD.Value.ToString();
            frmNhapKho_TT.MaTK_NVIn = txtMaTK_NV.Text.Trim();
            frmNhapKho_TT.QuocGiaIn = txtQuocGia.Text.Trim();
            frmNhapKho_TT.TongTienIn = txtTongTien.Text.Trim();
            frmNhapKho_TT.TongSoLuongIn = txtTongSoLuong.Text.Trim();
            frm.ShowDialog();
        }
    }
}
