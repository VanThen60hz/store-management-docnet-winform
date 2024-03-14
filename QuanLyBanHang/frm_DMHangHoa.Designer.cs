namespace QuanLyBanHang
{
    partial class frm_DMHangHoa
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Hang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DonGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Anh = new System.Windows.Forms.TextBox();
            this.cbo_MaChatLieu = new System.Windows.Forms.ComboBox();
            this.btn_HienTHi = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(536, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dgv_Hang
            // 
            this.dgv_Hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hang.Location = new System.Drawing.Point(40, 321);
            this.dgv_Hang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Hang.Name = "dgv_Hang";
            this.dgv_Hang.RowHeadersWidth = 51;
            this.dgv_Hang.RowTemplate.Height = 24;
            this.dgv_Hang.Size = new System.Drawing.Size(1448, 309);
            this.dgv_Hang.TabIndex = 54;
            this.dgv_Hang.Click += new System.EventHandler(this.dgv_Hang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên hàng";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(160, 110);
            this.txt_TenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(300, 22);
            this.txt_TenHang.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã hàng";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Location = new System.Drawing.Point(160, 67);
            this.txt_MaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(300, 22);
            this.txt_MaHang.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(29, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(160, 195);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(300, 22);
            this.txt_SoLuong.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Mã chất liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(29, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Đơn giá bán";
            // 
            // txt_DonGiaBan
            // 
            this.txt_DonGiaBan.Location = new System.Drawing.Point(160, 284);
            this.txt_DonGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGiaBan.Name = "txt_DonGiaBan";
            this.txt_DonGiaBan.Size = new System.Drawing.Size(300, 22);
            this.txt_DonGiaBan.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(29, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 67;
            this.label6.Text = "Đơn giá nhập";
            // 
            // txt_DonGiaNhap
            // 
            this.txt_DonGiaNhap.Location = new System.Drawing.Point(160, 241);
            this.txt_DonGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGiaNhap.Name = "txt_DonGiaNhap";
            this.txt_DonGiaNhap.Size = new System.Drawing.Size(300, 22);
            this.txt_DonGiaNhap.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(616, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 73;
            this.label8.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(690, 213);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(323, 88);
            this.txt_GhiChu.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(627, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 71;
            this.label9.Text = "Ảnh";
            // 
            // txt_Anh
            // 
            this.txt_Anh.Location = new System.Drawing.Point(690, 78);
            this.txt_Anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Anh.Multiline = true;
            this.txt_Anh.Name = "txt_Anh";
            this.txt_Anh.Size = new System.Drawing.Size(254, 74);
            this.txt_Anh.TabIndex = 70;
            // 
            // cbo_MaChatLieu
            // 
            this.cbo_MaChatLieu.FormattingEnabled = true;
            this.cbo_MaChatLieu.Location = new System.Drawing.Point(160, 148);
            this.cbo_MaChatLieu.Name = "cbo_MaChatLieu";
            this.cbo_MaChatLieu.Size = new System.Drawing.Size(300, 24);
            this.cbo_MaChatLieu.TabIndex = 75;
            // 
            // btn_HienTHi
            // 
            this.btn_HienTHi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_HienTHi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_HienTHi.FlatAppearance.BorderSize = 2;
            this.btn_HienTHi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_HienTHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HienTHi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HienTHi.Image = global::QuanLyBanHang.Properties.Resources.danhsach;
            this.btn_HienTHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HienTHi.Location = new System.Drawing.Point(1140, 662);
            this.btn_HienTHi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HienTHi.Name = "btn_HienTHi";
            this.btn_HienTHi.Size = new System.Drawing.Size(188, 46);
            this.btn_HienTHi.TabIndex = 126;
            this.btn_HienTHi.Text = "&Hiển thị DS";
            this.btn_HienTHi.UseVisualStyleBackColor = true;
            this.btn_HienTHi.Click += new System.EventHandler(this.btn_HienTHi_Click);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(928, 662);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(168, 46);
            this.btn_TimKiem.TabIndex = 125;
            this.btn_TimKiem.Text = "&Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Open.FlatAppearance.BorderSize = 2;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Open.Image = global::QuanLyBanHang.Properties.Resources.mo1;
            this.btn_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Open.Location = new System.Drawing.Point(986, 95);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(80, 46);
            this.btn_Open.TabIndex = 76;
            this.btn_Open.Text = "&Mở";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(1161, 43);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(327, 258);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 74;
            this.picAnh.TabStop = false;
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
            this.btn_Dong.Location = new System.Drawing.Point(1357, 662);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(131, 46);
            this.btn_Dong.TabIndex = 60;
            this.btn_Dong.Text = "&Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_BoQua.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_BoQua.FlatAppearance.BorderSize = 2;
            this.btn_BoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BoQua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_BoQua.Image = global::QuanLyBanHang.Properties.Resources.boqua1;
            this.btn_BoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BoQua.Location = new System.Drawing.Point(747, 662);
            this.btn_BoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(131, 46);
            this.btn_BoQua.TabIndex = 59;
            this.btn_BoQua.Text = "&Bỏ qua";
            this.btn_BoQua.UseVisualStyleBackColor = true;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
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
            this.btn_Luu.Location = new System.Drawing.Point(578, 662);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(131, 46);
            this.btn_Luu.TabIndex = 58;
            this.btn_Luu.Text = "&Lưu";
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
            this.btn_Xoa.Location = new System.Drawing.Point(395, 662);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 46);
            this.btn_Xoa.TabIndex = 57;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Sua.FlatAppearance.BorderSize = 2;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Image = global::QuanLyBanHang.Properties.Resources.sua;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(217, 662);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 46);
            this.btn_Sua.TabIndex = 56;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(40, 662);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 46);
            this.btn_Them.TabIndex = 55;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_DMHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 1055);
            this.Controls.Add(this.btn_HienTHi);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.cbo_MaChatLieu);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Anh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DonGiaBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_DonGiaNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_Hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaHang);
            this.Name = "frm_DMHangHoa";
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frm_DMHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_Hang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DonGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DonGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Anh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.ComboBox cbo_MaChatLieu;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_HienTHi;
    }
}