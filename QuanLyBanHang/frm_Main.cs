using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnu_ChatLieu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMChatLieu"] == null)
            {
                frm_DMChatLieu frmChatLieu = new frm_DMChatLieu();
                frmChatLieu.MdiParent = this;
                frmChatLieu.Show();
            }
            else
            {
                Application.OpenForms["frm_DMChatLieu"].Activate();
            }
        }

        private void mnu_HangHoa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMHangHoa"] == null)
            {
                frm_DMHangHoa frmHangHoa = new frm_DMHangHoa();
                frmHangHoa.MdiParent = this;
                frmHangHoa.Show();
            }
            else
            {
                Application.OpenForms["frm_DMHangHoa"].Activate();
            }
        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMNhanvien"] == null)
            {
                frm_DMNhanvien frmNhanVien = new frm_DMNhanvien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
            else
            {
                Application.OpenForms["frm_DMNhanvien"].Activate();
            }
        }

        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMKhachHang"] == null)
            {
                frm_DMKhachHang frmKhachHang = new frm_DMKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Show();
            }
            else
            {
                Application.OpenForms["frm_DMKhachHang"].Activate();
            }
        }

        private void mnu_HoaDonBan_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoaDonBanHang"] == null)
            {
                frm_HoaDonBanHang frmHoaDonBan = new frm_HoaDonBanHang();
                frmHoaDonBan.MdiParent = this;
                frmHoaDonBan.Show();
            }
            else
            {
                Application.OpenForms["frm_HoaDonBanHang"].Activate();
            }
        }

        private void mnu_TimHoaDon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TimHDBan"] == null)
            {
                frm_TimHDBan frmTimHDBan = new frm_TimHDBan();
                frmTimHDBan.MdiParent = this;
                frmTimHDBan.Show();
            }
            else
            {
                Application.OpenForms["frm_TimHDBan"].Activate();
            }
        }

        private void mnu_TimHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMHangHoa"] == null)
            {
                frm_DMHangHoa frmHangHoa = new frm_DMHangHoa();
                frmHangHoa.MdiParent = this;
                frmHangHoa.Show();
            }
            else
            {
                Application.OpenForms["frm_DMHangHoa"].Activate();
            }
        }

        private void mnu_TimKhachHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMKhachHang"] == null)
            {
                frm_DMKhachHang frmKhachHang = new frm_DMKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Show();
            }
            else
            {
                Application.OpenForms["frm_DMKhachHang"].Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_NgayGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
