namespace QuanLyBanHang
{
    partial class frm_DMKhachHang
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
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_DienThoai = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaKhach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(473, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "DANH MỤC KHÁCH HÀNG";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.btn_Dong.Location = new System.Drawing.Point(1096, 673);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(131, 46);
            this.btn_Dong.TabIndex = 43;
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
            this.btn_BoQua.Location = new System.Drawing.Point(884, 673);
            this.btn_BoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(131, 46);
            this.btn_BoQua.TabIndex = 42;
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
            this.btn_Luu.Location = new System.Drawing.Point(650, 673);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(131, 46);
            this.btn_Luu.TabIndex = 41;
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
            this.btn_Xoa.Location = new System.Drawing.Point(444, 673);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 46);
            this.btn_Xoa.TabIndex = 40;
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
            this.btn_Sua.Location = new System.Drawing.Point(238, 673);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 46);
            this.btn_Sua.TabIndex = 39;
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
            this.btn_Them.Location = new System.Drawing.Point(30, 673);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 46);
            this.btn_Them.TabIndex = 38;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(30, 169);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1197, 452);
            this.dgv_KhachHang.TabIndex = 37;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            this.dgv_KhachHang.Click += new System.EventHandler(this.dgv_KhachHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(774, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Điện thoại";
            // 
            // mtb_DienThoai
            // 
            this.mtb_DienThoai.Location = new System.Drawing.Point(884, 103);
            this.mtb_DienThoai.Mask = "(999) 000-0000";
            this.mtb_DienThoai.Name = "mtb_DienThoai";
            this.mtb_DienThoai.Size = new System.Drawing.Size(220, 22);
            this.mtb_DienThoai.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(774, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(884, 56);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(220, 22);
            this.txt_DiaChi.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(104, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên khách";
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.Location = new System.Drawing.Point(253, 102);
            this.txt_TenKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Size = new System.Drawing.Size(220, 22);
            this.txt_TenKhach.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(104, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã khách";
            // 
            // txt_MaKhach
            // 
            this.txt_MaKhach.Location = new System.Drawing.Point(253, 59);
            this.txt_MaKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKhach.Name = "txt_MaKhach";
            this.txt_MaKhach.Size = new System.Drawing.Size(220, 22);
            this.txt_MaKhach.TabIndex = 26;
            this.txt_MaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaKhach_KeyUp);
            // 
            // frm_DMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_DienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaKhach);
            this.Name = "frm_DMKhachHang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frm_DMKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_DienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaKhach;
    }
}