using Microsoft.Reporting.WinForms;
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
    public partial class frmInPhieu : Form
    {
        Reports_Control db = new Reports_Control();
        DataTable dt;
        public frmInPhieu()
        {
            InitializeComponent();
        }

        private void frmInNhapKho_Load(object sender, EventArgs e)
        {
            string t = "";
            if(frmMain.isP ==true)
            {
                t = "PHIẾU NHẬP KHO";
                dt = db.LoadPhieuNhap("MaHD = '" + frmNhapKho_TT.MaHDIn + "'");
            }    
            else
            {
                t = "PHIẾU XUẤT KHO";
                dt = db.LoadPhieuXuat("MaHD = '" + frmNhapKho_TT.MaHDIn + "'");
            }    
               
            reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhoHangXuatNhapKhau.ReportNhapKho.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportParameter p1 = new ReportParameter("MaHD","Mã hóa đơn : "+ frmNhapKho_TT.MaHDIn);
            ReportParameter p2 = new ReportParameter("NgayHD", "Ngày lập : " + frmNhapKho_TT.NgayHDIn);
            ReportParameter p3 = new ReportParameter("MaTK_NV", "Người lập : " + frmNhapKho_TT.MaTK_NVIn);
            ReportParameter p4 = new ReportParameter("QuocGia", "Quốc gia : " + frmNhapKho_TT.QuocGiaIn);
            ReportParameter p5 = new ReportParameter("TongTien", "Tổng tiền : " + frmNhapKho_TT.TongTienIn);
            ReportParameter p6 = new ReportParameter("TongSoLuong", "Tổng số lượng : " + frmNhapKho_TT.TongSoLuongIn);
            ReportParameter p7 = new ReportParameter("Title", t);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p4 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p5 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p6 });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p7 });
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
