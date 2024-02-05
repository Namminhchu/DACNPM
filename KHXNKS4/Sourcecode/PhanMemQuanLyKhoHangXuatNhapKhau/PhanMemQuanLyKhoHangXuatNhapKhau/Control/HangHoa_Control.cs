using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class HangHoa_Control
    {
        public DataTable Load()
        {
            string sqlString = "select MaHH,TenHH,PhanLoai,GiaNhap,GiaXuat from HangHoa";
            return DB_Connect.Load(sqlString);
        }
        public void Xoa(string MaHH)
        {
            string sqlString = string.Format(@"DELETE FROM ChiTietPhieuXuat WHERE MaHH = '" + MaHH + "';DELETE FROM ChiTietPhieuNhap WHERE MaHH = '" + MaHH + "';DELETE HangHoa WHERE MaHH = '" + MaHH + "'");
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public void Them(string MaHH, string TenHH,string PhanLoai,decimal GiaNhap,decimal GiaXuat)
        {
            string sqlString = "INSERT INTO HangHoa(MaHH,TenHH,SoLuongTon,PhanLoai,GiaNhap,GiaXuat)  VALUES ( '" + MaHH + "',N'" + TenHH + "',0,N'"+ PhanLoai+"',"+GiaNhap+","+GiaXuat+")";
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public void Sua(string MaHH, string MaHH2, string TenHH,string PhanLoai, decimal GiaNhap, decimal GiaXuat)
        {
            string sqlString = "UPDATE HangHoa SET PhanLoai = N'"+ PhanLoai+"', MaHH = '" + MaHH + "',TenHH=N'" + TenHH + "',GiaNhap = "+GiaNhap+",GiaXuat = "+GiaXuat+" WHERE MaHH = '" + MaHH2 + "'";
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public DataTable TimKiem(string TenHH)
        {
            string sqlString = "select MaHH,TenHH,PhanLoai,GiaNhap,GiaXuat from HangHoa WHERE TenHH  LIKE N'%" + TenHH + "%'";
            return DB_Connect.Load(sqlString);
        }
        public int KiemTraDuLieuTonTai(string MaHH)
        {
            int i = 0;
            string s = "SELECT * FROM HangHoa WHERE MaHH = '" + MaHH + "'";
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
    }
}
