using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemThuPhanMem
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show(this, "Bạn chưa nhập tài khoản", "Thông báo");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show(this, "Bạn chưa nhập mật khẩu", "Thông báo");
                return;
            }
            if ((txtMaNV.Text == "admin" || txtMaNV.Text == "000") && (txtMatKhau.Text == "admin"))
            {
                MessageBox.Show(this, "Đăng nhập thành công", "Thông báo");
                //TrangChu ch = new TrangChu();
                //ch.Show();
                //this.Hide();
            }
            else
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu sai", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
