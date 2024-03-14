using QuanLyBanHang.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_DMHangHoa : Form
    {
        DataTable tblH;
        public frm_DMHangHoa()
        {
            InitializeComponent();
        }

        private void frm_DMHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblChatLieu";
            txt_MaHang.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cbo_MaChatLieu, "MaChatLieu", "TenChatLieu");
            cbo_MaChatLieu.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txt_MaHang.Text = "";
            txt_TenHang.Text = "";
            cbo_MaChatLieu.Text = "";
            txt_SoLuong.Text = "0";
            txt_DonGiaNhap.Text = "0";
            txt_DonGiaBan.Text = "0";
            txt_SoLuong.Enabled = true;
            txt_DonGiaNhap.Enabled = false;
            txt_DonGiaBan.Enabled = false;
            txt_Anh.Text = "";
            picAnh.Image = null;
            txt_GhiChu.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblHang";
            tblH = Functions.GetDataToTable(sql);
            dgv_Hang.DataSource = tblH;
            dgv_Hang.Columns[0].HeaderText = "Mã hàng";
            dgv_Hang.Columns[1].HeaderText = "Tên hàng";
            dgv_Hang.Columns[2].HeaderText = "Chất liệu";
            dgv_Hang.Columns[3].HeaderText = "Số lượng";
            dgv_Hang.Columns[4].HeaderText = "Đơn giá nhập";
            dgv_Hang.Columns[5].HeaderText = "Đơn giá bán";
            dgv_Hang.Columns[6].HeaderText = "Ảnh";
            dgv_Hang.Columns[7].HeaderText = "Ghi chú";
            dgv_Hang.Columns[0].Width = 80;
            dgv_Hang.Columns[1].Width = 140;
            dgv_Hang.Columns[2].Width = 80;
            dgv_Hang.Columns[3].Width = 80;
            dgv_Hang.Columns[4].Width = 100;
            dgv_Hang.Columns[5].Width = 100;
            dgv_Hang.Columns[6].Width = 200;
            dgv_Hang.Columns[7].Width = 300;
            dgv_Hang.AllowUserToAddRows = false;
            dgv_Hang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_Hang_Click(object sender, EventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaHang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_MaHang.Text = dgv_Hang.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_TenHang.Text = dgv_Hang.CurrentRow.Cells["TenHang"].Value.ToString();
            MaChatLieu = dgv_Hang.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            sql = "SELECT TenChatLieu FROM tblChatLieu WHERE MaChatLieu=N'" + MaChatLieu + "'";
            cbo_MaChatLieu.Text = Functions.GetFieldValues(sql);
            txt_SoLuong.Text = dgv_Hang.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_DonGiaNhap.Text = dgv_Hang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txt_DonGiaBan.Text = dgv_Hang.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Anh FROM tblHang WHERE MaHang=N'" + txt_MaHang.Text + "'";
            txt_Anh.Text = Functions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txt_Anh.Text);
            sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txt_MaHang.Text + "'";
            txt_GhiChu.Text = Functions.GetFieldValues(sql);
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_BoQua.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_BoQua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValues();
            txt_MaHang.Enabled = true;
            txt_MaHang.Focus();
            txt_SoLuong.Enabled = true;
            txt_DonGiaNhap.Enabled = true;
            txt_DonGiaBan.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_MaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaHang.Focus();
                return;
            }
            if (txt_TenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenHang.Focus();
                return;
            }
            if (cbo_MaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_MaChatLieu.Focus();
                return;
            }
            if (txt_Anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Open.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblHang WHERE MaHang=N'" + txt_MaHang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaHang.Focus();
                return;
            }
            sql = "INSERT INTO tblHang(MaHang,TenHang,MaChatLieu,SoLuong,DonGiaNhap, DonGiaBan,Anh,Ghichu) VALUES(N'"
                + txt_MaHang.Text.Trim() + "',N'" + txt_TenHang.Text.Trim() +
                "',N'" + cbo_MaChatLieu.SelectedValue.ToString() +
                "'," + txt_SoLuong.Text.Trim() + "," + txt_DonGiaNhap.Text +
                "," + txt_DonGiaBan.Text + ",'" + txt_Anh.Text + "',N'" + txt_GhiChu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaHang.Enabled = false;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txt_Anh.Text = dlgOpen.FileName;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaHang.Focus();
                return;
            }
            if (txt_TenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenHang.Focus();
                return;
            }
            if (cbo_MaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_MaChatLieu.Focus();
                return;
            }
            if (txt_Anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Anh.Focus();
                return;
            }
            sql = "UPDATE tblHang SET TenHang=N'" + txt_TenHang.Text.Trim().ToString() +
                "',MaChatLieu=N'" + cbo_MaChatLieu.SelectedValue.ToString() +
                "',SoLuong=" + txt_SoLuong.Text +
                ",Anh='" + txt_Anh.Text + "',Ghichu=N'" + txt_GhiChu.Text + "' WHERE MaHang=N'" + txt_MaHang.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_BoQua.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txt_MaHang.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Them.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaHang.Enabled = false;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_MaHang.Text == "") && (txt_TenHang.Text == "") && (cbo_MaChatLieu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblHang WHERE 1=1";
            if (txt_MaHang.Text != "")
                sql += " AND MaHang LIKE N'%" + txt_MaHang.Text + "%'";
            if (txt_TenHang.Text != "")
                sql += " AND TenHang LIKE N'%" + txt_TenHang.Text + "%'";
            if (cbo_MaChatLieu.Text != "")
                sql += " AND MaChatLieu LIKE N'%" + cbo_MaChatLieu.SelectedValue + "%'";
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Hang.DataSource = tblH;
            ResetValues();
        }

        private void btn_HienTHi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang,TenHang,MaChatLieu,SoLuong,DonGiaNhap,DonGiaBan,Anh,Ghichu FROM tblHang";
            tblH = Functions.GetDataToTable(sql);
            dgv_Hang.DataSource = tblH;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
