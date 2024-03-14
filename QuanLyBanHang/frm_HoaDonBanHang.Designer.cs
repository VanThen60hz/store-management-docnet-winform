namespace QuanLyBanHang
{
    partial class frm_HoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cbo_MaHDBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ngay = new System.Windows.Forms.Button();
            this.mtb_NgayBan = new System.Windows.Forms.MaskedTextBox();
            this.cbo_MaKhach = new System.Windows.Forms.ComboBox();
            this.cbo_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_DienThoai = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenKhach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaHDBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lb_BangChu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_HDBanHang = new System.Windows.Forms.DataGridView();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.cbo_MaHang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.cbo_MaHDBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 716);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 75);
            this.panel1.TabIndex = 89;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_TimKiem.FlatAppearance.BorderSize = 2;
            this.btn_TimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::QuanLyBanHang.Properties.Resources.tim;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(388, 12);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(197, 46);
            this.btn_TimKiem.TabIndex = 56;
            this.btn_TimKiem.Text = "&Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cbo_MaHDBan
            // 
            this.cbo_MaHDBan.FormattingEnabled = true;
            this.cbo_MaHDBan.Location = new System.Drawing.Point(145, 21);
            this.cbo_MaHDBan.Name = "cbo_MaHDBan";
            this.cbo_MaHDBan.Size = new System.Drawing.Size(211, 24);
            this.cbo_MaHDBan.TabIndex = 50;
            this.cbo_MaHDBan.DropDown += new System.EventHandler(this.cbo_MaHDBan_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã hóa đơn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1492, 716);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 90;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ngay);
            this.groupBox1.Controls.Add(this.mtb_NgayBan);
            this.groupBox1.Controls.Add(this.cbo_MaKhach);
            this.groupBox1.Controls.Add(this.cbo_MaNhanVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mtb_DienThoai);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TenKhach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaHDBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(38, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1359, 216);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Ngay
            // 
            this.btn_Ngay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Ngay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Ngay.FlatAppearance.BorderSize = 2;
            this.btn_Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ngay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ngay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ngay.Location = new System.Drawing.Point(372, 91);
            this.btn_Ngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ngay.Name = "btn_Ngay";
            this.btn_Ngay.Size = new System.Drawing.Size(51, 31);
            this.btn_Ngay.TabIndex = 119;
            this.btn_Ngay.Text = "...";
            this.btn_Ngay.UseVisualStyleBackColor = true;
            // 
            // mtb_NgayBan
            // 
            this.mtb_NgayBan.Location = new System.Drawing.Point(167, 93);
            this.mtb_NgayBan.Name = "mtb_NgayBan";
            this.mtb_NgayBan.Size = new System.Drawing.Size(177, 27);
            this.mtb_NgayBan.TabIndex = 95;
            // 
            // cbo_MaKhach
            // 
            this.cbo_MaKhach.FormattingEnabled = true;
            this.cbo_MaKhach.Location = new System.Drawing.Point(905, 45);
            this.cbo_MaKhach.Name = "cbo_MaKhach";
            this.cbo_MaKhach.Size = new System.Drawing.Size(330, 28);
            this.cbo_MaKhach.TabIndex = 94;
            this.cbo_MaKhach.TextChanged += new System.EventHandler(this.cbo_MaKhach_TextChanged);
            // 
            // cbo_MaNhanVien
            // 
            this.cbo_MaNhanVien.FormattingEnabled = true;
            this.cbo_MaNhanVien.Location = new System.Drawing.Point(167, 140);
            this.cbo_MaNhanVien.Name = "cbo_MaNhanVien";
            this.cbo_MaNhanVien.Size = new System.Drawing.Size(256, 28);
            this.cbo_MaNhanVien.TabIndex = 93;
            this.cbo_MaNhanVien.TextChanged += new System.EventHandler(this.cbo_MaNhanVien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(795, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 92;
            this.label9.Text = "Điện thoại";
            // 
            // mtb_DienThoai
            // 
            this.mtb_DienThoai.Location = new System.Drawing.Point(905, 184);
            this.mtb_DienThoai.Mask = "(999) 000-0000";
            this.mtb_DienThoai.Name = "mtb_DienThoai";
            this.mtb_DienThoai.Size = new System.Drawing.Size(330, 27);
            this.mtb_DienThoai.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(795, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 90;
            this.label10.Text = "Dịa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(905, 137);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(330, 27);
            this.txt_DiaChi.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(795, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tên khách";
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.Location = new System.Drawing.Point(905, 89);
            this.txt_TenKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Size = new System.Drawing.Size(330, 27);
            this.txt_TenKhach.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(795, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 86;
            this.label8.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Tên nhân viên";
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(167, 180);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(256, 27);
            this.txt_TenNhanVien.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mã hóa đơn";
            // 
            // txt_MaHDBan
            // 
            this.txt_MaHDBan.Location = new System.Drawing.Point(167, 41);
            this.txt_MaHDBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaHDBan.Name = "txt_MaHDBan";
            this.txt_MaHDBan.Size = new System.Drawing.Size(256, 27);
            this.txt_MaHDBan.TabIndex = 76;
            this.txt_MaHDBan.TextChanged += new System.EventHandler(this.txt_MaHDBan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(521, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Dong);
            this.groupBox2.Controls.Add(this.btn_InHoaDon);
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_TongTien);
            this.groupBox2.Controls.Add(this.lb_BangChu);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dgv_HDBanHang);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.txt_TenHang);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_GiamGia);
            this.groupBox2.Controls.Add(this.cbo_MaHang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(38, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1359, 409);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Dong.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Dong.FlatAppearance.BorderSize = 2;
            this.btn_Dong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dong.Image = global::QuanLyBanHang.Properties.Resources.close;
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(1116, 358);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(131, 46);
            this.btn_Dong.TabIndex = 118;
            this.btn_Dong.Text = "&Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_InHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_InHoaDon.FlatAppearance.BorderSize = 2;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_InHoaDon.Image = global::QuanLyBanHang.Properties.Resources.indulieu;
            this.btn_InHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHoaDon.Location = new System.Drawing.Point(833, 357);
            this.btn_InHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(198, 46);
            this.btn_InHoaDon.TabIndex = 117;
            this.btn_InHoaDon.Text = "&In hóa đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Luu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Luu.FlatAppearance.BorderSize = 2;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Image = global::QuanLyBanHang.Properties.Resources.luu;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(302, 357);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(208, 46);
            this.btn_Luu.TabIndex = 116;
            this.btn_Luu.Text = "&Lưu hóa đơn";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Xoa.FlatAppearance.BorderSize = 2;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Image = global::QuanLyBanHang.Properties.Resources.xoa5;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(573, 357);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(220, 46);
            this.btn_Xoa.TabIndex = 115;
            this.btn_Xoa.Text = "&Hủy hóa đơn";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Image = global::QuanLyBanHang.Properties.Resources.them2;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(54, 357);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(207, 46);
            this.btn_Them.TabIndex = 113;
            this.btn_Them.Text = "&Thêm hóa đơn";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(656, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 19);
            this.label19.TabIndex = 112;
            this.label19.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(766, 300);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(232, 27);
            this.txt_TongTien.TabIndex = 111;
            // 
            // lb_BangChu
            // 
            this.lb_BangChu.AutoSize = true;
            this.lb_BangChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_BangChu.Location = new System.Drawing.Point(26, 331);
            this.lb_BangChu.Name = "lb_BangChu";
            this.lb_BangChu.Size = new System.Drawing.Size(84, 19);
            this.lb_BangChu.TabIndex = 109;
            this.lb_BangChu.Text = "Bằng chữ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(22, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 19);
            this.label17.TabIndex = 108;
            this.label17.Text = "Nhấn đúp một dòng để xóa";
            // 
            // dgv_HDBanHang
            // 
            this.dgv_HDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDBanHang.Location = new System.Drawing.Point(26, 118);
            this.dgv_HDBanHang.Name = "dgv_HDBanHang";
            this.dgv_HDBanHang.RowHeadersWidth = 51;
            this.dgv_HDBanHang.RowTemplate.Height = 24;
            this.dgv_HDBanHang.Size = new System.Drawing.Size(1221, 176);
            this.dgv_HDBanHang.TabIndex = 107;
            this.dgv_HDBanHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDBanHang_CellContentClick);
            this.dgv_HDBanHang.Click += new System.EventHandler(this.dgv_HDBanHang_Click);
            this.dgv_HDBanHang.DoubleClick += new System.EventHandler(this.dgv_HDBanHang_DoubleClick);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(1012, 30);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 27);
            this.txt_DonGia.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(902, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 105;
            this.label15.Text = "Thành tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(902, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 19);
            this.label16.TabIndex = 103;
            this.label16.Text = "Đơn giá";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(1012, 73);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(223, 27);
            this.txt_ThanhTien.TabIndex = 104;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(559, 30);
            this.txt_TenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(244, 27);
            this.txt_TenHang.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(449, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 19);
            this.label13.TabIndex = 101;
            this.label13.Text = "Giảm giá %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(449, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 99;
            this.label14.Text = "Tên hàng";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Location = new System.Drawing.Point(559, 73);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(244, 27);
            this.txt_GiamGia.TabIndex = 100;
            this.txt_GiamGia.TextChanged += new System.EventHandler(this.txt_GiamGia_TextChanged);
            // 
            // cbo_MaHang
            // 
            this.cbo_MaHang.FormattingEnabled = true;
            this.cbo_MaHang.Location = new System.Drawing.Point(130, 30);
            this.cbo_MaHang.Name = "cbo_MaHang";
            this.cbo_MaHang.Size = new System.Drawing.Size(243, 28);
            this.cbo_MaHang.TabIndex = 98;
            this.cbo_MaHang.TextChanged += new System.EventHandler(this.cbo_MaHang_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(20, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 97;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(20, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 95;
            this.label12.Text = "Mã hàng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(130, 74);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(243, 27);
            this.txt_SoLuong.TabIndex = 96;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // frm_HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 791);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HoaDonBanHang";
            this.Text = "Hóa đơn bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HoaDonBanHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_HoaDonBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_MaHDBan;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaHDBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenKhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_DienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.ComboBox cbo_MaKhach;
        private System.Windows.Forms.ComboBox cbo_MaNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.ComboBox cbo_MaHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lb_BangChu;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Ngay;
        private System.Windows.Forms.MaskedTextBox mtb_NgayBan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv_HDBanHang;
    }
}