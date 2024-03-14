using QuanLyBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_DMNhanvien : Form
    {
        DataTable tblNV;
        public frm_DMNhanvien()
        {
            InitializeComponent();
        }

        private void frm_DMNhanvien_Load(object sender, EventArgs e)
        {
            txt_MaNhanVien.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh FROm tblNhanVien";
            tblNV = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgv_NhanVien.DataSource = tblNV;
            dgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgv_NhanVien.Columns[2].HeaderText = "Giới tính";
            dgv_NhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgv_NhanVien.Columns[4].HeaderText = "Điện thoại";
            dgv_NhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgv_NhanVien.Columns[0].Width = 100;
            dgv_NhanVien.Columns[1].Width = 150;
            dgv_NhanVien.Columns[2].Width = 100;
            dgv_NhanVien.Columns[3].Width = 150;
            dgv_NhanVien.Columns[4].Width = 100;
            dgv_NhanVien.Columns[5].Width = 100;
            dgv_NhanVien.AllowUserToAddRows = false;
            dgv_NhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNhanVien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_MaNhanVien.Text = dgv_NhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_TenNhanVien.Text = dgv_NhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            if (dgv_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            txt_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtb_DienThoai.Text = dgv_NhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            dtp_NgaySinh.Text = dgv_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_BoQua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValues();
            txt_MaNhanVien.Enabled = true;
            txt_MaNhanVien.Focus();
        }


        private void ResetValues()
        {
            txt_MaNhanVien.Text = "";
            txt_TenNhanVien.Text = "";
            chkGioiTinh.Checked = false;
            txt_DiaChi.Text = "";
            dtp_NgaySinh.Text = DateTime.Now.ToString();
            mtb_DienThoai.Text = "";
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txt_MaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                return;
            }
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (mtb_DienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb_DienThoai.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNhanVien FROM tblNhanVien WHERE MaNhanVien=N'" + txt_MaNhanVien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                txt_MaNhanVien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNhanVien,TenNhanVien,GioiTinh, DiaChi,DienThoai, NgaySinh) VALUES (N'" + txt_MaNhanVien.Text.Trim() + "',N'" +
                txt_TenNhanVien.Text.Trim() + "',N'" + gt + "',N'" + txt_DiaChi.Text.Trim() + "','" + mtb_DienThoai.Text + "',Convert (datetime,'" + dtp_NgaySinh.Text + "',103))";
            //dtp_NgaySinh.Value.ToString("dd/MM/yyyy")

            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaNhanVien.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (mtb_DienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb_DienThoai.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET  TenNhanVien=N'" + txt_TenNhanVien.Text.Trim().ToString() +
                    "',DiaChi=N'" + txt_DiaChi.Text.Trim().ToString() +
                    "',DienThoai='" + mtb_DienThoai.Text + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + dtp_NgaySinh.Value.ToString("dd/MM/yyyy") +
                    "' WHERE MaNhanVien=N'" + txt_MaNhanVien.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_BoQua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txt_MaNhanVien.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_BoQua.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            txt_MaNhanVien.Enabled = false;
        }

        private void txt_MaNhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
