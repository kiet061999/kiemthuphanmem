using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemThuPhanMem
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.InitialDirectory = @"F:\";
            sv.RestoreDirectory = true;
            sv.FileName = "*.txt";
            sv.DefaultExt = "txt";
            sv.Filter = "txt files (*.txt) | *.txt";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                Stream filesStream = sv.OpenFile();
                StreamWriter sw = new StreamWriter(filesStream);
                filesStream.Close();
                MessageBox.Show(this, "Lưu thành công", "Thông báo");
            }
            else
                MessageBox.Show(this, "Lưu không thành công", "Thông báo");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MuonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("MuonSach"))
            //{
            //    MuonSach ms = new MuonSach();
            //    ms.MdiParent = this;
            //    ms.Show();
            //    //this.Hide();
            //}
            //else
            //    ActiveChildForm("MuonSach");
        }

        private void CapNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!CheckExistForm("CapNhat"))
            //{
            //    CapNhat cn = new CapNhat();
            //    cn.MdiParent = this;
            //    cn.Show();
            //}
            //else
            //    ActiveChildForm("CapNhat");
        }
    }
}
