using QuanLyBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang
{
    public partial class frm_HoaDonBanHang : Form
    {
        DataTable tblCTHDB;
        public frm_HoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frm_HoaDonBanHang_Load(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_InHoaDon.Enabled = false;
            txt_MaHDBan.ReadOnly = true;
            txt_TenNhanVien.ReadOnly = true;
            txt_TenKhach.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
            mtb_DienThoai.ReadOnly = true;
            txt_TenHang.ReadOnly = true;
            txt_DonGia.ReadOnly = true;
            txt_ThanhTien.ReadOnly = true;
            txt_TongTien.ReadOnly = true;
            txt_GiamGia.Text = "0";
            txt_TongTien.Text = "0";
            Functions.FillCombo("SELECT MaKhach, TenKhach FROM tblKhach", cbo_MaKhach, "MaKhach", "MaKhach");
            cbo_MaKhach.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhanVien, TenNhanVien FROM tblNhanVien", cbo_MaNhanVien, "MaNhanVien", "TenKhach");
            cbo_MaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHang, TenHang FROM tblHang", cbo_MaHang, "MaHang", "MaHang");
            cbo_MaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txt_MaHDBan.Text != "")
            {
                LoadInfoHoaDon();
                btn_Xoa.Enabled = true;
                btn_InHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            string sql;
            if (cbo_MaHDBan.Text != "")
            {
                sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.MaHDBan like N'"
                    + txt_MaHDBan.Text + "' AND a.MaHang=b.MaHang";
            }
            else
            {
                sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblChiTietHDBan AS a, tblHang AS b";
            }
            tblCTHDB = Functions.GetDataToTable(sql);
            dgv_HDBanHang.DataSource = tblCTHDB;
            dgv_HDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgv_HDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgv_HDBanHang.Columns[2].HeaderText = "Số lượng";
            dgv_HDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgv_HDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgv_HDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgv_HDBanHang.Columns[0].Width = 120;
            dgv_HDBanHang.Columns[1].Width = 195;
            dgv_HDBanHang.Columns[2].Width = 120;
            dgv_HDBanHang.Columns[3].Width = 135;
            dgv_HDBanHang.Columns[4].Width = 135;
            dgv_HDBanHang.Columns[5].Width = 135;
            dgv_HDBanHang.AllowUserToAddRows = false;
            dgv_HDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
            mtb_NgayBan.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "SELECT MaNhanVien FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
            cbo_MaNhanVien.Text = Functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
            cbo_MaKhach.Text = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
            txt_TongTien.Text = Functions.GetFieldValues(str);
            lb_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txt_TongTien.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop B.A.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHDBan, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNhanVien FROM tblHDBan AS a, tblKhach AS b, tblNhanVien AS c WHERE a.MaHDBan = N'" + txt_MaHDBan.Text + "' AND a.MaKhach = b.MaKhach AND a.MaNhanVien = c.MaNhanVien";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM tblChiTietHDBan AS a , tblHang AS b WHERE a.MaHDBan = N'" +
                  txt_MaHDBan.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM tblHDBan WHERE MaHDBan=N'" + txt_MaHDBan.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (mtb_NgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtb_NgayBan.Focus();
                    return;
                }
                if (cbo_MaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbo_MaNhanVien.Focus();
                    return;
                }
                if (cbo_MaKhach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbo_MaKhach.Focus();
                    return;
                }
                sql = "INSERT INTO tblHDBan(MaHDBan, NgayBan, MaNhanVien, MaKhach, TongTien) VALUES (N'" + txt_MaHDBan.Text.Trim() + "','" +
                        Functions.ConvertDateTime(mtb_NgayBan.Text.Trim()) + "',N'" + cbo_MaNhanVien.SelectedValue + "',N'" +
                        cbo_MaKhach.SelectedValue + "'," + txt_TongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbo_MaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_MaHang.Focus();
                return;
            }
            if ((txt_SoLuong.Text.Trim().Length == 0) || (txt_SoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoLuong.Text = "";
                txt_SoLuong.Focus();
                return;
            }
            if (txt_GiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GiamGia.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblChiTietHDBan WHERE MaHang=N'" + cbo_MaHang.SelectedValue + "' AND MaHDBan = N'" + txt_MaHDBan.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbo_MaHang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHang WHERE MaHang = N'" + cbo_MaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txt_SoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SoLuong.Text = "";
                txt_SoLuong.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietHDBan(MaHDBan,MaHang,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txt_MaHDBan.Text.Trim() + "',N'" + cbo_MaHang.SelectedValue + "'," + txt_SoLuong.Text + "," + txt_DonGia.Text + "," + txt_GiamGia.Text + "," + txt_ThanhTien.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txt_SoLuong.Text);
            sql = "UPDATE tblHang SET SoLuong =" + SLcon + " WHERE MaHang= N'" + cbo_MaHang.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txt_ThanhTien.Text);
            sql = "UPDATE tblHDBan SET TongTien =" + Tongmoi + " WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
            Functions.RunSQL(sql);
            txt_TongTien.Text = Tongmoi.ToString();
            lb_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_InHoaDon.Enabled = true;
        }

        private void ResetValuesHang()
        {
            cbo_MaHang.Text = "";
            txt_SoLuong.Text = "";
            txt_GiamGia.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
            btn_InHoaDon.Enabled = false;
            btn_Them.Enabled = false;
            ResetValues();
            txt_MaHDBan.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txt_MaHDBan.Text = "";
            mtb_NgayBan.Text = DateTime.Now.ToShortDateString();
            cbo_MaNhanVien.Text = "";
            cbo_MaKhach.Text = "";
            txt_TongTien.Text = "0";
            lb_BangChu.Text = "Bằng chữ: ";
            cbo_MaHang.Text = "";
            txt_SoLuong.Text = "";
            txt_GiamGia.Text = "0";
            txt_ThanhTien.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_MaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbo_MaNhanVien.Text == "")
                txt_TenNhanVien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNhanVien from tblNhanVien where MaNhanVien =N'" + cbo_MaNhanVien.SelectedValue + "'";
            txt_TenNhanVien.Text = Functions.GetFieldValues(str);
        }

        private void cbo_MaKhach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbo_MaKhach.Text == "")
            {
                txt_TenKhach.Text = "";
                txt_DiaChi.Text = "";
                mtb_DienThoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKhach from tblKhach where MaKhach = N'" + cbo_MaKhach.SelectedValue + "'";
            txt_TenKhach.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from tblKhach where MaKhach = N'" + cbo_MaKhach.SelectedValue + "'";
            txt_DiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from tblKhach where MaKhach= N'" + cbo_MaKhach.SelectedValue + "'";
            mtb_DienThoai.Text = Functions.GetFieldValues(str);
        }

        private void cbo_MaHang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbo_MaHang.Text == "")
            {
                txt_TenHang.Text = "";
                txt_DonGia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenHang FROM tblHang WHERE MaHang =N'" + cbo_MaHang.SelectedValue + "'";
            txt_TenHang.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM tblHang WHERE MaHang =N'" + cbo_MaHang.SelectedValue + "'";
            txt_DonGia.Text = Functions.GetFieldValues(str);
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_SoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_SoLuong.Text);
            if (txt_GiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_GiamGia.Text);
            if (txt_DonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_DonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_ThanhTien.Text = tt.ToString();
        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txt_SoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_SoLuong.Text);
            if (txt_GiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txt_GiamGia.Text);
            if (txt_DonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txt_DonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txt_ThanhTien.Text = tt.ToString();
        }

        private void dgv_HDBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_MaHDBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (cbo_MaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_MaHDBan.Focus();
                return;
            }
            txt_MaHDBan.Text = cbo_MaHDBan.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = true;
            btn_InHoaDon.Enabled = true;
            cbo_MaHDBan.SelectedIndex = -1;
        }

        private void dgv_HDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgv_HDBanHang.CurrentRow.Cells["MaHang"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgv_HDBanHang.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgv_HDBanHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE tblChiTietHDBan WHERE MaHDBan=N'" + txt_MaHDBan.Text + "' AND MaHang = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHang WHERE MaHang = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblHang SET SoLuong =" + slcon + " WHERE MaHang= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblHDBan SET TongTien =" + tongmoi + " WHERE MaHDBan = N'" + txt_MaHDBan.Text + "'";
                Functions.RunSQL(sql);
                txt_TongTien.Text = tongmoi.ToString();
                lb_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                LoadDataGridView();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cbo_MaHDBan_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHDBan FROM tblHDBan", cbo_MaHDBan, "MaHDBan", "MaHDBan");
            cbo_MaHDBan.SelectedIndex = -1;
        }

        private void frm_HoaDonBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void dgv_HDBanHang_Click(object sender, EventArgs e)
        {


        }

    }
}
