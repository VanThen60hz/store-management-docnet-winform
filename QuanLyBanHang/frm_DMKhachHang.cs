using QuanLyBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_DMKhachHang : Form
    {
        DataTable tblKH;
        public frm_DMKhachHang()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DMKhachHang_Load(object sender, EventArgs e)
        {
            txt_MaKhach.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblKhach";
            tblKH = Functions.GetDataToTable(sql);
            dgv_KhachHang.DataSource = tblKH;
            dgv_KhachHang.Columns[0].HeaderText = "Mã khách";
            dgv_KhachHang.Columns[1].HeaderText = "Tên khách";
            dgv_KhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgv_KhachHang.Columns[3].HeaderText = "Điện thoại";
            dgv_KhachHang.Columns[0].Width = 100;
            dgv_KhachHang.Columns[1].Width = 150;
            dgv_KhachHang.Columns[2].Width = 150;
            dgv_KhachHang.Columns[3].Width = 150;
            dgv_KhachHang.AllowUserToAddRows = false;
            dgv_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaKhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_MaKhach.Text = dgv_KhachHang.CurrentRow.Cells["MaKhach"].Value.ToString();
            txt_TenKhach.Text = dgv_KhachHang.CurrentRow.Cells["TenKhach"].Value.ToString();
            txt_DiaChi.Text = dgv_KhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtb_DienThoai.Text = dgv_KhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_BoQua.Enabled = true;
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_BoQua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValues();
            txt_MaKhach.Enabled = true;
            txt_MaKhach.Focus();
        }


        private void ResetValues()
        {
            txt_MaKhach.Text = "";
            txt_TenKhach.Text = "";
            txt_DiaChi.Text = "";
            mtb_DienThoai.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_MaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaKhach.Focus();
                return;
            }
            if (txt_TenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenKhach.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (mtb_DienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_DienThoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKhach FROM tblKhach WHERE MaKhach=N'" + txt_MaKhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaKhach.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO tblKhach VALUES (N'" + txt_MaKhach.Text.Trim() +
                "',N'" + txt_TenKhach.Text.Trim() + "',N'" + txt_DiaChi.Text.Trim() + "','" + mtb_DienThoai.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaKhach.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaKhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_TenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenKhach.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChi.Focus();
                return;
            }
            if (mtb_DienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtb_DienThoai.Focus();
                return;
            }
            sql = "UPDATE tblKhach SET TenKhach=N'" + txt_TenKhach.Text.Trim().ToString() + "',DiaChi=N'" +
                txt_DiaChi.Text.Trim().ToString() + "',DienThoai='" + mtb_DienThoai.Text.ToString() +
                "' WHERE MaKhach=N'" + txt_MaKhach.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_BoQua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhach WHERE MaKhach=N'" + txt_MaKhach.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_BoQua.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            txt_MaKhach.Enabled = false;
        }

        private void txt_MaKhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
