using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class XuatKho_Control
    {
        public DataTable LoadGiaXuat()
        {
            string sqlString = "SELECT MaHH, TenHH,GiaXuat FROM HangHoa";
            return DB_Connect.Load(sqlString);
        }
        public void XoaPhieuXuat(string MaHD)
        {
            string sqlString = string.Format(@"DELETE ChiTietPhieuXuat WHERE MaHD = '" + MaHD + "'; DELETE PhieuXuat WHERE MaHD = '" + MaHD + "' ");
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public DataTable TimKiemGiaXuat(string TenHH)
        {
            string sqlString = "SELECT a.MaHH, b.TenHH,DonGia FROM GiaXuat a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE TenHH  LIKE N'%" + TenHH + "%'";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadPhieuXuat()
        {
            string sqlString = "SELECT CT.MaHD, PX.NgayHD, PX.MaTK_NV, PX.QuocGia, SUM(CT.SoLuong), SUM(CT.ThanhTien) FROM PhieuXuat PX INNER JOIN ChiTietPhieuXuat CT ON PX.MaHD = CT.MaHD GROUP BY CT.MaHD, PX.NgayHD, PX.MaTK_NV, PX.QuocGia";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadPhieuXuatTheoMaHD(string MaHD)
        {
            string sqlString = "SELECT * FROM PhieuXuat WHERE MaHD = '" + MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadChiTietPhieuXuat(string MaHD)
        {
            string sqlString = "SELECT a.MaHD,MaHH,a.DonGia,a.SoLuong,a.ThanhTien FROM ChiTietPhieuXuat a LEFT JOIN PhieuXuat b ON a.MaHD = b.MaHD WHERE a.MaHD = '" + MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
        public int KiemTraDuLieuTonTai(string MaHD, string MaHH)
        {
            int i = 0;
            string s = "SELECT * FROM ChiTietPhieuXuat WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'";
            DataTable dt = DB_Connect.Load(s);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
        public DataTable HienThiChiTietHoaDon(string MaHD)
        {
            string sqlString = "select a.MaHH,b.TenHH,a.DonGia,a.SoLuong,a.ThanhTien from ChiTietPhieuXuat a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE MaHD = '" + MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
    }
}
