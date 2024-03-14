namespace QuanLyBanHang
{
    partial class frm_TimHDBan
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
            this.btn_TimLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_Nam = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Thang = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaHDBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_TKHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimLai);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.btn_Dong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_TimLai
            // 
            this.btn_TimLai.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TimLai.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_TimLai.FlatAppearance.BorderSize = 2;
            this.btn_TimLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_TimLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimLai.Image = global::QuanLyBanHang.Properties.Resources.timlai1;
            this.btn_TimLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimLai.Location = new System.Drawing.Point(721, 27);
            this.btn_TimLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimLai.Name = "btn_TimLai";
            this.btn_TimLai.Size = new System.Drawing.Size(203, 46);
            this.btn_TimLai.TabIndex = 125;
            this.btn_TimLai.Text = "&Tìm lại";
            this.btn_TimLai.UseVisualStyleBackColor = true;
            this.btn_TimLai.Click += new System.EventHandler(this.btn_TimLai_Click);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(171, 27);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(210, 46);
            this.btn_TimKiem.TabIndex = 124;
            this.btn_TimKiem.Text = "&Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
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
            this.btn_Dong.Location = new System.Drawing.Point(1228, 27);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(177, 46);
            this.btn_Dong.TabIndex = 123;
            this.btn_Dong.Text = "&Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaKhachHang);
            this.groupBox1.Controls.Add(this.txt_MaNhanVien);
            this.groupBox1.Controls.Add(this.txt_Nam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Thang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaHDBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(20, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1426, 216);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(1000, 41);
            this.txt_MaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(323, 27);
            this.txt_MaKhachHang.TabIndex = 99;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(167, 136);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(380, 27);
            this.txt_MaNhanVien.TabIndex = 98;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(418, 93);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(129, 27);
            this.txt_Nam.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(355, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Năm";
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(167, 93);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(166, 27);
            this.txt_Thang.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(845, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(1000, 88);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(323, 27);
            this.txt_TongTien.TabIndex = 87;
            this.txt_TongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TongTien_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(845, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 86;
            this.label8.Text = "Mã khách hàng";
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
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tháng";
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
            this.txt_MaHDBan.Size = new System.Drawing.Size(380, 27);
            this.txt_MaHDBan.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(678, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(16, 602);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(377, 19);
            this.label17.TabIndex = 110;
            this.label17.Text = "Nháy đúp vào hóa đơn để hiển thị thông tin chi tiết";
            // 
            // dgv_TKHoaDon
            // 
            this.dgv_TKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TKHoaDon.Location = new System.Drawing.Point(20, 279);
            this.dgv_TKHoaDon.Name = "dgv_TKHoaDon";
            this.dgv_TKHoaDon.RowHeadersWidth = 51;
            this.dgv_TKHoaDon.RowTemplate.Height = 24;
            this.dgv_TKHoaDon.Size = new System.Drawing.Size(1426, 298);
            this.dgv_TKHoaDon.TabIndex = 109;
            this.dgv_TKHoaDon.Click += new System.EventHandler(this.dgv_TKHoaDon_Click);
            // 
            // frm_TimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 770);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgv_TKHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "frm_TimHDBan";
            this.Text = "Tìm kiếm hóa đơn";
            this.Load += new System.EventHandler(this.frm_TimHDBan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TKHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_TimLai;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaHDBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_Nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Thang;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv_TKHoaDon;
    }
}