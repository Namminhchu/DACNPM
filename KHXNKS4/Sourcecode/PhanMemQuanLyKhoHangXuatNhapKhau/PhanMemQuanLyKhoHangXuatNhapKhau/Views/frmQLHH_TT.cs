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
    public partial class frmQLHH_TT : Form
    {
        HangHoa_Control db = new HangHoa_Control(); // Gọi Controller
        public frmQLHH_TT()
        {
            InitializeComponent();
        }

        private void frmQLHH_TT_Load(object sender, EventArgs e)
        {
            if (frmQLHH.save == false)
            {
                txtMaHH.Text = frmQLHH.MaHH_save;
                txtTenHH.Text = frmQLHH.TenHH_save;
                nmGiaNhap.Value = frmQLHH.GiaNhap_save;
                nmGiaXuat.Value = frmQLHH.GiaXuat_save;
                LoadLoaiHH();
                cboLHH.Text = frmQLHH.LoaiHH_save;
            }
            else
                LoadLoaiHH();
        }
        private void LoadLoaiHH()
        {
            DataTable dataTable = new DataTable();
            cboLHH.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("HangDongLanh", "Hàng đông lạnh");
            dataTable.Rows.Add("HangTuoiSong", "Hàng tươi sống");
            dataTable.Rows.Add("TraiCay", "Trái Cây");
            cboLHH.DataSource = dataTable;
            cboLHH.DisplayMember = "ten";
            cboLHH.ValueMember = "ma";
        }
        private void frmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có chứa ký tự số hay không
            if (txtTenHH.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên hàng hóa không được chứa ký tự số", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHH.Text = "";
                txtTenHH.Focus();
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "")
            {
                MessageBox.Show("Mã hàng hóa không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHH.Focus();
                return;
            }
            if (txtTenHH.Text == "")
            {
                MessageBox.Show("Tên hàng hóa không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenHH.Focus();
                return;
            }

            if (frmQLHH.save == true)
            {
                if (db.KiemTraDuLieuTonTai(txtMaHH.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại, Hàng hóa này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtMaHH.Text.Trim(), txtTenHH.Text.Trim(),cboLHH.Text.Trim(),nmGiaNhap.Value,nmGiaXuat.Value);
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (frmQLHH.save == false)
            {
                if (db.KiemTraDuLieuTonTai(txtMaHH.Text) == 0 && txtMaHH.Text != frmQLHH.MaHH_save)
                {
                    MessageBox.Show("Sửa thất bại, Hàng hóa này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Sua(txtMaHH.Text.Trim(), frmQLHH.MaHH_save, txtTenHH.Text.Trim(), cboLHH.Text.Trim(), nmGiaNhap.Value, nmGiaXuat.Value);
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }
    }
}
