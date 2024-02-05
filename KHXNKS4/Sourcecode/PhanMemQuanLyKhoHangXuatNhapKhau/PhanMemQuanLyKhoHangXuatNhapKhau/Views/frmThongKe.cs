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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        Reports_Control db = new Reports_Control();
        DataTable dt;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            string t = "";
            if(frmQuanLyKho.isRP == "1")
            {
                t = "Phân loại : Tất cả";
                 dt = db.Load("1=1");
            }
            if (frmQuanLyKho.isRP == "2")
            {
                t = "Phân loại : Hàng đông lạnh";
                dt = db.Load("PhanLoai = N'Hàng đông lạnh'");
            }
            if (frmQuanLyKho.isRP == "3")
            {
                t = "Phân loại : Hàng tươi sống";
                dt = db.Load("PhanLoai = N'Hàng tươi sống'");
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyKhoHangXuatNhapKhau.ReportThongKe.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportParameter p = new ReportParameter("PhanLoai", t);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p });
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
