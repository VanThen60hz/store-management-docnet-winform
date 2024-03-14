namespace QuanLyBanHang
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_TapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HienTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_VaiNet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_NgayGio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TapTin,
            this.mnu_DanhMuc,
            this.mnu_HoaDon,
            this.mnu_TimKiem,
            this.mnu_BaoCao,
            this.mnu_TroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_TapTin
            // 
            this.mnu_TapTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Thoat});
            this.mnu_TapTin.Name = "mnu_TapTin";
            this.mnu_TapTin.Size = new System.Drawing.Size(69, 24);
            this.mnu_TapTin.Text = "Tập tin";
            // 
            // mnu_Thoat
            // 
            this.mnu_Thoat.Name = "mnu_Thoat";
            this.mnu_Thoat.Size = new System.Drawing.Size(130, 26);
            this.mnu_Thoat.Text = "Thoát";
            this.mnu_Thoat.Click += new System.EventHandler(this.mnu_Thoat_Click);
            // 
            // mnu_DanhMuc
            // 
            this.mnu_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ChatLieu,
            this.mnu_HangHoa,
            this.toolStripSeparator2,
            this.mnu_NhanVien,
            this.mnu_KhachHang});
            this.mnu_DanhMuc.Name = "mnu_DanhMuc";
            this.mnu_DanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnu_DanhMuc.Text = "Danh mục";
            // 
            // mnu_ChatLieu
            // 
            this.mnu_ChatLieu.Name = "mnu_ChatLieu";
            this.mnu_ChatLieu.Size = new System.Drawing.Size(169, 26);
            this.mnu_ChatLieu.Text = "Chất liệu";
            this.mnu_ChatLieu.Click += new System.EventHandler(this.mnu_ChatLieu_Click);
            // 
            // mnu_HangHoa
            // 
            this.mnu_HangHoa.Name = "mnu_HangHoa";
            this.mnu_HangHoa.Size = new System.Drawing.Size(169, 26);
            this.mnu_HangHoa.Text = "Hàng hóa";
            this.mnu_HangHoa.Click += new System.EventHandler(this.mnu_HangHoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // mnu_NhanVien
            // 
            this.mnu_NhanVien.Name = "mnu_NhanVien";
            this.mnu_NhanVien.Size = new System.Drawing.Size(169, 26);
            this.mnu_NhanVien.Text = "Nhân viên";
            this.mnu_NhanVien.Click += new System.EventHandler(this.mnu_NhanVien_Click);
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.Size = new System.Drawing.Size(169, 26);
            this.mnu_KhachHang.Text = "Khách hàng";
            this.mnu_KhachHang.Click += new System.EventHandler(this.mnu_KhachHang_Click);
            // 
            // mnu_HoaDon
            // 
            this.mnu_HoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HoaDonBan});
            this.mnu_HoaDon.Name = "mnu_HoaDon";
            this.mnu_HoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnu_HoaDon.Text = "Hóa đơn";
            // 
            // mnu_HoaDonBan
            // 
            this.mnu_HoaDonBan.Name = "mnu_HoaDonBan";
            this.mnu_HoaDonBan.Size = new System.Drawing.Size(179, 26);
            this.mnu_HoaDonBan.Text = "Hóa đơn bán";
            this.mnu_HoaDonBan.Click += new System.EventHandler(this.mnu_HoaDonBan_Click);
            // 
            // mnu_TimKiem
            // 
            this.mnu_TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TimHoaDon,
            this.mnu_TimHang,
            this.mnu_TimKhachHang});
            this.mnu_TimKiem.Name = "mnu_TimKiem";
            this.mnu_TimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnu_TimKiem.Text = "Tìm kiếm";
            this.mnu_TimKiem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // mnu_TimHoaDon
            // 
            this.mnu_TimHoaDon.Name = "mnu_TimHoaDon";
            this.mnu_TimHoaDon.Size = new System.Drawing.Size(169, 26);
            this.mnu_TimHoaDon.Text = "Hóa đơn";
            this.mnu_TimHoaDon.Click += new System.EventHandler(this.mnu_TimHoaDon_Click);
            // 
            // mnu_TimHang
            // 
            this.mnu_TimHang.Name = "mnu_TimHang";
            this.mnu_TimHang.Size = new System.Drawing.Size(169, 26);
            this.mnu_TimHang.Text = "Hàng";
            this.mnu_TimHang.Click += new System.EventHandler(this.mnu_TimHang_Click);
            // 
            // mnu_TimKhachHang
            // 
            this.mnu_TimKhachHang.Name = "mnu_TimKhachHang";
            this.mnu_TimKhachHang.Size = new System.Drawing.Size(169, 26);
            this.mnu_TimKhachHang.Text = "Khách hàng";
            this.mnu_TimKhachHang.Click += new System.EventHandler(this.mnu_TimKhachHang_Click);
            // 
            // mnu_BaoCao
            // 
            this.mnu_BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HangTon,
            this.mnu_DoanhThu});
            this.mnu_BaoCao.Name = "mnu_BaoCao";
            this.mnu_BaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnu_BaoCao.Text = "Báo cáo";
            // 
            // mnu_HangTon
            // 
            this.mnu_HangTon.Name = "mnu_HangTon";
            this.mnu_HangTon.Size = new System.Drawing.Size(161, 26);
            this.mnu_HangTon.Text = "Hàng tồn";
            // 
            // mnu_DoanhThu
            // 
            this.mnu_DoanhThu.Name = "mnu_DoanhThu";
            this.mnu_DoanhThu.Size = new System.Drawing.Size(161, 26);
            this.mnu_DoanhThu.Text = "Doanh thu";
            // 
            // mnu_TroGiup
            // 
            this.mnu_TroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HienTroGiup,
            this.mnu_VaiNet});
            this.mnu_TroGiup.Name = "mnu_TroGiup";
            this.mnu_TroGiup.Size = new System.Drawing.Size(78, 24);
            this.mnu_TroGiup.Text = "Trợ giúp";
            // 
            // mnu_HienTroGiup
            // 
            this.mnu_HienTroGiup.Name = "mnu_HienTroGiup";
            this.mnu_HienTroGiup.Size = new System.Drawing.Size(182, 26);
            this.mnu_HienTroGiup.Text = "Hiện Trợ giúp";
            // 
            // mnu_VaiNet
            // 
            this.mnu_VaiNet.Name = "mnu_VaiNet";
            this.mnu_VaiNet.Size = new System.Drawing.Size(182, 26);
            this.mnu_VaiNet.Text = "Vài nét";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_NgayGio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_NgayGio
            // 
            this.lb_NgayGio.Name = "lb_NgayGio";
            this.lb_NgayGio.Size = new System.Drawing.Size(151, 20);
            this.lb_NgayGio.Text = "toolStripStatusLabel1";
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Quản lý bán hàng lưu niệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_TapTin;
        private System.Windows.Forms.ToolStripMenuItem mnu_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnu_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnu_HoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_BaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnu_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnu_HangTon;
        private System.Windows.Forms.ToolStripMenuItem mnu_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnu_HienTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnu_VaiNet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem mnu_NhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_NgayGio;
    }
}

