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
    public partial class HoTro : Form
    {
        public HoTro()
        {
            InitializeComponent();
        }

        private void HoTro_Load(object sender, EventArgs e)
        {

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show(this, "Bạn chưa nhập thắc mắc của mình", "Thông báo");
                return;
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                MessageBox.Show(this, "Gửi thành công", "Thông báo");
                return;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
