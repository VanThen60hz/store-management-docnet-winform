using QuanLyBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_TimHDBan : Form
    {
        DataTable tblHDB;
        public frm_TimHDBan()
        {
            InitializeComponent();
        }

        private void frm_TimHDBan_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgv_TKHoaDon.DataSource = null;
        }


        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txt_MaHDBan.Focus();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_MaHDBan.Text == "") && (txt_Thang.Text == "") && (txt_Nam.Text == "") &&
               (txt_MaNhanVien.Text == "") && (txt_MaKhachHang.Text == "") &&
               (txt_TongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHDBan WHERE 1=1";
            if (txt_MaHDBan.Text != "")
                sql = sql + " AND MaHDBan Like N'%" + txt_MaHDBan.Text + "%'";
            if (txt_Thang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txt_Thang.Text;
            if (txt_Nam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txt_Nam.Text;
            if (txt_MaNhanVien.Text != "")
                sql = sql + " AND MaNhanVien Like N'%" + txt_MaNhanVien.Text + "%'";
            if (txt_MaKhachHang.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txt_MaKhachHang.Text + "%'";
            if (txt_TongTien.Text != "")
                sql = sql + " AND TongTien <=" + txt_TongTien.Text;
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_TKHoaDon.DataSource = tblHDB;
            LoadDataGridView();
        }


        private void LoadDataGridView()
        {
            dgv_TKHoaDon.Columns[0].HeaderText = "Mã HĐB";
            dgv_TKHoaDon.Columns[1].HeaderText = "Mã nhân viên";
            dgv_TKHoaDon.Columns[2].HeaderText = "Ngày bán";
            dgv_TKHoaDon.Columns[3].HeaderText = "Mã khách";
            dgv_TKHoaDon.Columns[4].HeaderText = "Tổng tiền";
            dgv_TKHoaDon.Columns[0].Width = 150;
            dgv_TKHoaDon.Columns[1].Width = 100;
            dgv_TKHoaDon.Columns[2].Width = 80;
            dgv_TKHoaDon.Columns[3].Width = 80;
            dgv_TKHoaDon.Columns[4].Width = 80;
            dgv_TKHoaDon.AllowUserToAddRows = false;
            dgv_TKHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_TimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgv_TKHoaDon.DataSource = null;
        }

        private void txt_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgv_TKHoaDon_Click(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgv_TKHoaDon.CurrentRow.Cells["MaHDBan"].Value.ToString();
                frm_HoaDonBanHang frm = new frm_HoaDonBanHang();
                txt_MaHDBan.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
