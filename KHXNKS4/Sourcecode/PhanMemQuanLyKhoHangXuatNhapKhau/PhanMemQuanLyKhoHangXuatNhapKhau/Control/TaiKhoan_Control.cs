using PhanMemQuanLyKhoHangXuatNhapKhau.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Control
{
    public class TaiKhoan_Control
    {
        public DataTable DangNhap(string MaTK_NV, string MatKhau)
        {
            string Query = "select * from TaiKhoan_NhanVien where MaTK_NV='" + MaTK_NV + "' and MatKhau='" + MatKhau + "'";
            return DB_Connect.Load(Query);
        }
        public DataTable ThongTinCaNhan(string MaTK_NV)
        {
            string sqlString = "select * from TaiKhoan_NhanVien where MaTK_NV='" + MaTK_NV + "'";
            return DB_Connect.Load(sqlString);
        }
        public DataTable HienThi()
        {
            string Query = "select MaTK_NV,TenTK_NV,DienThoai,DiaChi from TaiKhoan_NhanVien";
            return DB_Connect.Load(Query);
        }
        public DataTable TimKiem(string TenTK_NV)
        {
            string sqlString = "select MaTK_NV,TenTK_NV,DienThoai,DiaChi from TaiKhoan_NhanVien WHERE TenTK_NV  LIKE N'%" + TenTK_NV + "%'";
            return DB_Connect.Load(sqlString);
        }
        public void Them(string MaTK_NV, string TenTK_NV, string MatKhau, string DienThoai, string DiaChi)
        {
            string Query = "INSERT INTO TaiKhoan_NhanVien(MaTK_NV,TenTK_NV,MatKhau,DienThoai,DiaChi)  VALUES ( '" + MaTK_NV + "',N'" + TenTK_NV + "',N'" + MatKhau + "','" + DienThoai + "',N'" + DiaChi + "')";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Sua(string MaTK_NV, string MaTK_NV2, string TenTK_NV, string MatKhau, string DienThoai, string DiaChi)
        {
            string Query = "UPDATE TaiKhoan_NhanVien SET MaTK_NV = '" + MaTK_NV + "',TenTK_NV=N'" + TenTK_NV + "',MatKhau = N'" + MatKhau + "',DienThoai='" + DienThoai + "',DiaChi =N'" + DiaChi + "' WHERE MaTK_NV = '" + MaTK_NV2 + "'";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Xoa(string MaTK_NV)
        {
            string Query = string.Format(@"DELETE TaiKhoan_NhanVien WHERE MaTK_NV = '" + MaTK_NV + "'");
            DB_Connect.ExecuteNonQuery(Query);
        }
        public int KiemTraDuLieuTonTai(string MaTK_NV)
        {
            int i = 0;
            string Querys = "SELECT * FROM TaiKhoan_NhanVien WHERE MaTK_NV = '" + MaTK_NV + "'";
            DataTable dt = DB_Connect.Load(Querys);
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
        public void DoiMatKhau(string MaTK_NV, string MatKhau)
        {
            string Querys = string.Format(@"UPDATE TaiKhoan_NhanVien set MatKhau = '" + MatKhau + "' where MaTK_NV = '" + MaTK_NV + "'");
            DB_Connect.ExecuteNonQuery(Querys);
        }
        public DataTable MạtKhau(string MaTK_NV)
        {
            string Query = "select MatKhau from TaiKhoan_NhanVien WHERE MaTK_NV = '" + MaTK_NV + "'";
            return DB_Connect.Load(Query);
        }
    }
}
