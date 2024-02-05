using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class NhapKho_Control
    {
        public DataTable LoadGiaNhap()
        {
            string sqlString = "SELECT MaHH, TenHH,GiaNhap FROM HangHoa ";
            return DB_Connect.Load(sqlString);
        }
        public void XoaPhieuNhap(string MaHD)
        {
            string sqlString = string.Format(@"DELETE ChiTietPhieuNhap WHERE MaHD = '" + MaHD + "'; DELETE PhieuNhap WHERE MaHD = '" + MaHD + "' ");
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public DataTable TimKiemGiaNhap(string TenHH)
        {
            string sqlString = "SELECT a.MaHH, b.TenHH,DonGia FROM GiaNhap a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE TenHH  LIKE N'%" + TenHH + "%'";
            return DB_Connect.Load(sqlString);
        }
     
        public DataTable LoadPhieuNhap()
        {
            string sqlString = "SELECT CT.MaHD, PN.NgayHD, PN.MaTK_NV,PN.QuocGia, SUM(CT.SoLuong), SUM(CT.ThanhTien) FROM PhieuNhap PN INNER JOIN ChiTietPhieuNhap CT ON PN.MaHD = CT.MaHD GROUP BY CT.MaHD, PN.MaTK_NV,PN.NgayHD, PN.QuocGia";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadPhieuNhapTheoMaHD(string MaHD)
        {
            string sqlString = "SELECT * FROM PhieuNhap WHERE MaHD = '" + MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadChiTietPhieuNhap(string MaHD)
        {
            string sqlString = "SELECT a.MaHD,MaHH,a.DonGia,a.SoLuong,a.ThanhTien FROM ChiTietPhieuNhap a LEFT JOIN PhieuNhap b ON a.MaHD = b.MaHD WHERE a.MaHD = '"+ MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
        public int KiemTraDuLieuTonTai(string MaHD, string MaHH)
        {
            int i = 0;
            string s = "SELECT * FROM ChiTietPhieuNhap WHERE MaHD = '" + MaHD + "' AND MaHH = '" + MaHH + "'";
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
            string sqlString = "select a.MaHH,b.TenHH,a.DonGia,a.SoLuong,a.ThanhTien from ChiTietPhieuNhap a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE MaHD = '" + MaHD + "'";
            return DB_Connect.Load(sqlString);
        }
    }
}
