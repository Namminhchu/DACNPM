using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class Reports_Control
    {
        public DataTable Load(string key)
        {
            string sqlString = "select MaHH,TenHH,SoLuongTon from HangHoa WHERE " + key + "";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadPhieuNhap(string key)
        {
            string sqlString = "select IDENTITY(INT, 1, 1) AS id,a.*,b.TenHH INTO #t FROM ChiTietPhieuNhap a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE " + key + " SELECT * FROM #t";
            return DB_Connect.Load(sqlString);
        }
        public DataTable LoadPhieuXuat(string key)
        {
            string sqlString = "select IDENTITY(INT, 1, 1) AS id,a.*,b.TenHH INTO #t FROM ChiTietPhieuXuat a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH WHERE " + key + " SELECT * FROM #t";
            return DB_Connect.Load(sqlString);
        }
    }
}
