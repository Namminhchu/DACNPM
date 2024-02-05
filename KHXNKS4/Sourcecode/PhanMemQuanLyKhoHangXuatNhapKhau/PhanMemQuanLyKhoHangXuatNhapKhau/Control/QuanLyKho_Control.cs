using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class QuanLyKho_Control
    {
        public DataTable Load(string key)
        {
            string sqlString = "select MaHH,TenHH,SoLuongTon from HangHoa WHERE "+ key + "";
            return DB_Connect.Load(sqlString);
        }
        public DataTable KiemTra(string MaHH,string Table)
        {
            string sqlString = "SELECT SUM(SoLuong) AS SL From " + Table + " WHERE MaHH ='" + MaHH + "'";
            return DB_Connect.Load(sqlString);
        }
        public void Sua(string MaHH,decimal SLTon)
        {
            string sqlString = "UPDATE HangHoa SET SoLuongTon = " + SLTon + " WHERE MaHH = '" + MaHH + "'";
            DB_Connect.ExecuteNonQuery(sqlString);
        }
        public DataTable TimKiem(string TenHH)
        {
            string sqlString = "select MaHH,TenHH,SoLuongTon from HangHoa WHERE TenHH  LIKE N'%" + TenHH + "%'";
            return DB_Connect.Load(sqlString);
        }
    }
}
