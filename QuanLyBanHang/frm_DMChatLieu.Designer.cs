namespace QuanLyBanHang
{
    partial class frm_DMChatLieu
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
            this.txt_MaChatLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenChatLieu = new System.Windows.Forms.TextBox();
            this.dgv_ChatLieu = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaChatLieu
            // 
            this.txt_MaChatLieu.Location = new System.Drawing.Point(192, 84);
            this.txt_MaChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaChatLieu.Name = "txt_MaChatLieu";
            this.txt_MaChatLieu.Size = new System.Drawing.Size(192, 22);
            this.txt_MaChatLieu.TabIndex = 0;
            this.txt_MaChatLieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaChatLieu_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(43, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên chất liệu";
            // 
            // txt_TenChatLieu
            // 
            this.txt_TenChatLieu.Location = new System.Drawing.Point(192, 127);
            this.txt_TenChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenChatLieu.Name = "txt_TenChatLieu";
            this.txt_TenChatLieu.Size = new System.Drawing.Size(192, 22);
            this.txt_TenChatLieu.TabIndex = 2;
            // 
            // dgv_ChatLieu
            // 
            this.dgv_ChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChatLieu.Location = new System.Drawing.Point(23, 163);
            this.dgv_ChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ChatLieu.Name = "dgv_ChatLieu";
            this.dgv_ChatLieu.RowHeadersWidth = 51;
            this.dgv_ChatLieu.RowTemplate.Height = 24;
            this.dgv_ChatLieu.Size = new System.Drawing.Size(1282, 404);
            this.dgv_ChatLieu.TabIndex = 4;
            this.dgv_ChatLieu.Click += new System.EventHandler(this.dgv_ChatLieu_Click);
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
            this.btn_Dong.Location = new System.Drawing.Point(1130, 604);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(131, 46);
            this.btn_Dong.TabIndex = 10;
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
            this.btn_BoQua.Location = new System.Drawing.Point(883, 604);
            this.btn_BoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(131, 46);
            this.btn_BoQua.TabIndex = 9;
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
            this.btn_Luu.Location = new System.Drawing.Point(681, 604);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(131, 46);
            this.btn_Luu.TabIndex = 8;
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
            this.btn_Xoa.Location = new System.Drawing.Point(475, 604);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(131, 46);
            this.btn_Xoa.TabIndex = 7;
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
            this.btn_Sua.Location = new System.Drawing.Point(253, 604);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(131, 46);
            this.btn_Sua.TabIndex = 6;
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
            this.btn_Them.Location = new System.Drawing.Point(47, 604);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(131, 46);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(536, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // frm_DMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 731);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_ChatLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenChatLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaChatLieu);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DMChatLieu";
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.frm_DMChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenChatLieu;
        private System.Windows.Forms.DataGridView dgv_ChatLieu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label3;
    }
}