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
    public partial class frmQuanLyKho : Form
    {
        QuanLyKho_Control db = new QuanLyKho_Control();
        DataTable dt;
        public static string MaHH_save;
        public static string TenHH_save;
        public static decimal TonKho_save;
        public static string isRP;
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            //Phân quyền
            if (frmDangNhap.username_save != "AD")
            {
                btnSua.Enabled = false;

            }
            rbAll.Checked = true; // Check vào rbAll
            HienThiHangHoa("1=1");
        }
        private void HienThiHangHoa(string key)
        {
            dt = db.Load(key);
            dtGVHH.DataSource = dt;
            dtGVHH.Columns[0].HeaderText = "Mã hàng hóa";
            dtGVHH.Columns[1].HeaderText = "Tên hàng hóa";
            dtGVHH.Columns[2].HeaderText = "Số lượng tồn";
            dtGVHH.Columns[0].Width = 120;
            dtGVHH.Columns[1].Width = 200;
            dtGVHH.Columns[2].Width = 120;
            frmQLTK.CustomDataGridView(dtGVHH);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVHH.Rows.Count == 0) // Nếu không có dữ liệu
            {
                return;
            } // Có dữ liệu
            DataGridViewRow row = this.dtGVHH.Rows[dtGVHH.CurrentCell.RowIndex];
            frmQuanLyKho_TT frm = new frmQuanLyKho_TT();
            MaHH_save = row.Cells[0].Value.ToString();
            TenHH_save = row.Cells[1].Value.ToString();
            TonKho_save = decimal.Parse(row.Cells[2].Value.ToString() + "");
            frm.ShowDialog();
            rbAll.Checked = true;
            HienThiHangHoa("1=1");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGVHH.DataSource = db.TimKiem(txtTenHH.Text.Trim());
        }

        private void btnTinhTK_Click(object sender, EventArgs e)
        {
            if (dtGVHH.Rows.Count == 0) // Nếu không có dữ liệu
            {
                return;
            }// Có dữ liệu
            int tien = dtGVHH.Rows.Count; // Khai báo
            for (int i = 0; i < tien; i++)
            {
                string sqlUpdate = "";
                DataTable dtKT1 = db.KiemTra(dtGVHH.Rows[i].Cells["MaHH"].Value.ToString(), "ChiTietPhieuNhap");
                DataTable dtKT2 = db.KiemTra(dtGVHH.Rows[i].Cells["MaHH"].Value.ToString(), "ChiTietPhieuXuat");
                if(dtKT1.Rows[0]["SL"].ToString() != "" && dtKT2.Rows[0]["SL"].ToString() == "")
                {
                    sqlUpdate = sqlUpdate + " UPDATE HangHoa SET SoLuongTon =  (SELECT SUM(SoLuong) From ChiTietPhieuNhap WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "') WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "'";
                }
                if (dtKT1.Rows[0]["SL"].ToString() == "" && dtKT2.Rows[0]["SL"].ToString() != "")
                    
                {
                    sqlUpdate = sqlUpdate + " UPDATE HangHoa SET SoLuongTon = (SELECT SUM(SoLuong) From ChiTietPhieuXuat WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "') WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "'";
                }
                if (dtKT1.Rows[0]["SL"].ToString() != "" && dtKT2.Rows[0]["SL"].ToString() != "")
                {
                    sqlUpdate = sqlUpdate + " UPDATE HangHoa SET SoLuongTon = (SELECT SUM(SoLuong) From ChiTietPhieuNhap WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "') - (SELECT SUM(SoLuong) From ChiTietPhieuXuat WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "') WHERE MaHH ='" + dtGVHH.Rows[i].Cells["MaHH"].Value.ToString() + "'";
                } 
                if(sqlUpdate != "")
                {
                    DB_Connect.ExecuteNonQuery(sqlUpdate);
                }
                rbAll.Checked = true;
                HienThiHangHoa("1=1");
            }
        }

        private void rbDL_CheckedChanged(object sender, EventArgs e)
        {
            HienThiHangHoa("PhanLoai = N'Hàng đông lạnh'");
            isRP = "2";
        }

        private void rbTS_CheckedChanged(object sender, EventArgs e)
        {
            HienThiHangHoa("PhanLoai = N'Hàng tươi sống'");
            isRP = "3";
        }

        private void rbTC_CheckedChanged(object sender, EventArgs e)
        {
            HienThiHangHoa("PhanLoai = N'Trái cây'");
            isRP = "4";
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            HienThiHangHoa("1=1");
            isRP = "1";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtGVHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
