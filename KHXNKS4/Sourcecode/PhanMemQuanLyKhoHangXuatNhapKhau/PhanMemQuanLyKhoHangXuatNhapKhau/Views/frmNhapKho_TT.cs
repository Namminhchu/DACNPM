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
    public partial class frmNhapKho_TT : Form
    {
        public frmNhapKho_TT()
        {
            InitializeComponent();
        }
        NhapKho_Control db = new NhapKho_Control(); // Gọi Controller
        DataTable dt;
        public static string MaHDIn;
        public static string NgayHDIn;
        public static string MaTK_NVIn;
        public static string QuocGiaIn;
        public static string TongTienIn;
        public static string TongSoLuongIn;
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            if (frmNhapKho.save == true)
            {
                GenCode();
                txtMaTK_NV.Text = frmDangNhap.username_save;
                string sqlString = "INSERT INTO PhieuNhap(MaHD,NgayHD,MaTK_NV,QuocGia,TongTien,TongSoLuong)  VALUES ( '" + txtMaHD.Text + "',GETDATE(),'" + txtMaTK_NV.Text + "',N'" + txtQuocGia.Text.Trim() + "',0,0)";
                DB_Connect.ExecuteNonQuery(sqlString);
                HienThiHangHoa();
            }    
            else
            {
                txtMaHD.Text = frmNhapKho.MaHD_save;
                txtMaTK_NV.Text = frmNhapKho.MaTK_NV_save;
                txtQuocGia.Text = frmNhapKho.QuocGia_save;
                HienThiHangHoa();
                HienThiChiTietHoaDon(txtMaHD.Text.Trim());
            }    
        }
        public void TongTienHoaDon()
        {
            txtTongTien.Text = "0";
            txtTongSoLuong.Text = "0";
            if (dtGVCTHD.Rows.Count == 0) // Nếu không có dữ liệu
            {
                return;
            }// Có dữ liệu
            int tien = dtGVCTHD.Rows.Count;
            decimal thanhtien = 0;
            decimal soluong = 0;
            for (int i = 0; i < tien; i++) // i = 0 là sản phẩm đầu tiên,...
            {
                thanhtien += decimal.Parse(dtGVCTHD.Rows[i].Cells["ThanhTien"].Value.ToString()); //Chuyển đổi về decimal
                soluong += decimal.Parse(dtGVCTHD.Rows[i].Cells["SoLuong"].Value.ToString()); //Chuyển đổi về decimal
            }
            txtTongSoLuong.Text = soluong.ToString("#,###"); // Chỉ định dạng đưa về chuỗi
            txtTongTien.Text = thanhtien.ToString("#,###"); // Chỉ định dạng đưa về chuỗi
        }
        private void GenCode() // Mã hóa đơn được tăng tự động
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
            dt = db.LoadGiaNhap();
            dtGVHH.DataSource = dt;
            dtGVHH.Columns[0].HeaderText = "Mã hàng hóa";
            dtGVHH.Columns[1].HeaderText = "Tên hàng hóa";
            dtGVHH.Columns[2].HeaderText = "Giá nhập";
            dtGVHH.Columns[0].Width = 80;
            dtGVHH.Columns[1].Width = 120;
            dtGVHH.Columns[2].Width = 100;
            frmQLTK.CustomDataGridView(dtGVHH);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGVHH.DataSource = db.TimKiemGiaNhap(txtTenHH.Text.Trim());
        }

        private void dtGVHH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            if (db.KiemTraDuLieuTonTai(MaHD, MaHH) == 0) // Nễu dữ liệu đã tồn tại
            {
                string sqlUpdate = "UPDATE ChiTietPhieuNhap SET SoLuong = SoLuong + "+ nmSL.Value + " WHERE MaHD = '" + MaHD + "' And MaHH = '" + MaHH + "'";
                DB_Connect.ExecuteNonQuery(sqlUpdate);

                string sqlUpdate2 = "UPDATE ChiTietPhieuNhap SET ThanhTien = SoLuong * DonGia WHERE MaHD = '" + MaHD + "' And MaHH = '" + MaHH + "'";
                DB_Connect.ExecuteNonQuery(sqlUpdate2);

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // dữ liệu không tồn tại
            {
                string sqlString = "INSERT INTO ChiTietPhieuNhap(MaHD,MaHH,DonGia,SoLuong,ThanhTien)  VALUES ( '" + MaHD + "','" + MaHH + "'," + DonGia + "," + SoLuong + "," + ThanhTien + ")";
                DB_Connect.ExecuteNonQuery(sqlString);

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HienThiChiTietHoaDon(txtMaHD.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVCTHD.Rows.Count == 0) // Không có dữ liệu
            {
                return;
            }
            // Có dữ liệu và thực thi
            DataGridViewRow row = this.dtGVCTHD.Rows[dtGVCTHD.CurrentCell.RowIndex];

            string sqlString = "DELETE ChiTietPhieuNhap WHERE MaHD = '" + txtMaHD.Text + "' AND MaHH = N'" + row.Cells[0].Value.ToString() + "'";
            DB_Connect.ExecuteNonQuery(sqlString);
            HienThiChiTietHoaDon(txtMaHD.Text);
        }

        private void frmNhapKho_TT_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Update dữ liệu sau khi đóng form
            string s = "DELETE PhieuNhap WHERE MaHD NOT IN (SELECT MaHD From ChiTietPhieuNhap) UPDATE PhieuNhap SET QuocGia = N'"+txtQuocGia.Text.Trim()+"' WHERE MaHD = '"+txtMaHD.Text.Trim()+"'";
            if(dtGVCTHD.RowCount != 0)
            {
                s = s + "; UPDATE PhieuNhap SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietPhieuNhap WHERE MaHD ='" + txtMaHD.Text.Trim() + "' ) ";
                s = s + "; UPDATE PhieuNhap SET TongSoLuong = (SELECT SUM(SoLuong) FROM ChiTietPhieuNhap WHERE MaHD ='" + txtMaHD.Text.Trim() + "' ) ";
            }    
            DB_Connect.ExecuteNonQuery(s);
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dtGVCTHD.Rows.Count == 0)
            {
                return;
            }
            frmInPhieu frm = new frmInPhieu();
            frm.Text = "In phiếu nhập kho";
            MaHDIn = txtMaHD.Text.Trim();
            NgayHDIn= dtNgayHD.Value.ToString();
            MaTK_NVIn = txtMaTK_NV.Text.Trim();
            QuocGiaIn = txtQuocGia.Text.Trim();
            TongTienIn = txtTongTien.Text.Trim();
            TongSoLuongIn = txtTongSoLuong.Text.Trim();
            frm.ShowDialog();
        }
    }
}
