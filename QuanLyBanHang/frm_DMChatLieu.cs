using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_DMChatLieu : Form
    {
        DataTable tblCL;
        public frm_DMChatLieu()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaChatLieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChatLieu WHERE MaChatLieu=N'" + txt_MaChatLieu.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void frm_DMChatLieu_Load(object sender, EventArgs e)
        {
            txt_MaChatLieu.Enabled = false;
            btn_Luu.Enabled = false;
            btn_BoQua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaChatLieu, TenChatLieu FROM tblChatLieu";
            tblCL = Class.Functions.GetDataToTable(sql);
            dgv_ChatLieu.DataSource = tblCL;
            dgv_ChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgv_ChatLieu.Columns[1].HeaderText = "Mã chất liệu";
            dgv_ChatLieu.Columns[0].Width = 100;
            dgv_ChatLieu.Columns[1].Width = 300;
            dgv_ChatLieu.AllowUserToAddRows = false;
            dgv_ChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_ChatLieu_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaChatLieu.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_MaChatLieu.Text = dgv_ChatLieu.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txt_TenChatLieu.Text = dgv_ChatLieu.CurrentRow.Cells["TenChatLieu"].Value.ToString();
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
            ResetValue(); //Xoá trắng các textbox
            txt_MaChatLieu.Enabled = true; //cho phép nhập mới
            txt_MaChatLieu.Focus();
        }
        private void ResetValue()
        {
            txt_MaChatLieu.Text = "";
            txt_TenChatLieu.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            string sql; //Lưu lệnh sql
            if (txt_MaChatLieu.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaChatLieu.Focus();
                return;
            }
            if (txt_TenChatLieu.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenChatLieu.Focus();
                return;
            }
            sql = "Select MaChatLieu From tblChatLieu where MaChatLieu=N'" + txt_MaChatLieu.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaChatLieu.Focus();
                return;
            }

            sql = "INSERT INTO tblChatLieu VALUES(N'" +
                txt_MaChatLieu.Text + "',N'" + txt_TenChatLieu.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_BoQua.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaChatLieu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaChatLieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_TenChatLieu.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChatLieu SET TenChatLieu=N'" +
                txt_TenChatLieu.Text.ToString() +
                "' WHERE MaChatLieu=N'" + txt_MaChatLieu.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btn_BoQua.Enabled = false;
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btn_BoQua.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            txt_MaChatLieu.Enabled = false;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_MaChatLieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
