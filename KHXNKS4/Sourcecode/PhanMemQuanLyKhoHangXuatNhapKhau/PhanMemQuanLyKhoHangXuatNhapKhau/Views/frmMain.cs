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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static Boolean isP;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Phân quyền
            if(frmDangNhap.username_save != "AD")
            {
                btnQLTK.Enabled = false;
                frmQLHH.Enabled = false;
               // btnQLK.Enabled = false;
               
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
            else
                return;
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            frmTTCN frm = new frmTTCN();
            frm.ShowDialog();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            frmQLTK frm = new frmQLTK();
            frm.ShowDialog();
        }

        private void frmQLHH_Click(object sender, EventArgs e)
        {
            frmQLHH frm = new frmQLHH();
            frm.ShowDialog();
        }

        private void btnNK_Click(object sender, EventArgs e)
        {
            isP = true;
            frmNhapKho frm = new frmNhapKho();
            frm.ShowDialog();
        }
        private void btnXK_Click(object sender, EventArgs e)
        {
            isP = false;
            frmXuatKho frm = new frmXuatKho();
            frm.ShowDialog();
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            frm.ShowDialog();
        }
    }
}
