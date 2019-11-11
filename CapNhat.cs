using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KiemThuPhanMem
{
    public partial class CapNhat : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=TUANKIET\TUANKIET;Database=QLTHV;User ID=sa;Password=kiet01685258917;Trusted_Connection=True;MultipleActiveResultSets=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Sach";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public CapNhat()
        {
            InitializeComponent();
        }

        private void CapNhat_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void CapNhat_FromClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát chương trình này không ?", "Thông Báo"
              , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSach.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTG.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtNXB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into Sach values('" + txtMaSach.Text + "','" + txtTen.Text + "','" + txtTG.Text + "','" + txtNXB.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update Sach set TenSach= '" + txtTen.Text + "', TenTacGia= '" + txtTG.Text + "',NXB= '" + txtNXB.Text + "'where MaSach = '" + txtMaSach.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from Sach where MaSach= '" + txtMaSach.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtNXB.Clear();
            txtTen.Clear();
            txtTG.Clear();
            txtMaSach.Focus();
        }
    }
}
