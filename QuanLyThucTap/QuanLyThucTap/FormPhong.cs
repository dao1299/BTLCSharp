using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucTap
{
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
            showList();
        }
        string fID;
        private void showList()
        {

            string query = "SELECT * FROM PHONG";
            sqlCnn.Open();

            SqlCommand command = new SqlCommand(query, sqlCnn);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            sqlCnn.Close();
            dgvPhong.DataSource = data;
            txtID.Text = "";
            txtTenPhong.Text = "";
            txtQuanLy.Text = "";
            txtSDT.Text = "";
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                txtID.Text = dgvPhong.Rows[n].Cells[0].Value.ToString();
                txtTenPhong.Text = dgvPhong.Rows[n].Cells[1].Value.ToString();
                txtSDT.Text = dgvPhong.Rows[n].Cells[2].Value.ToString();
                txtQuanLy.Text = dgvPhong.Rows[n].Cells[3].Value.ToString();
                fID = txtID.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq == DialogResult.Yes)
            {
                string query = "DELETE FROM PHONG WHERE ma_phong = '" + txtID.Text + "'";
                sqlCnn.Open();
                SqlCommand command = new SqlCommand(query, sqlCnn);
                command.ExecuteNonQuery();

                //query = "UPDATE thuc_tap SET " +
                //    "ma_phong_thuc_tap = '' WHERE ma_phong_thuc_tap = '" + txtID.Text + "'";
                //SqlCommand command1 = new SqlCommand(query, sqlCnn);
                sqlCnn.Close();
                showList();

            }
            
        }

        private void btnXoaform_Click(object sender, EventArgs e)
        {
            showList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PHONG p = new PHONG();
            p.ma_phong = txtID.Text;
            p.ten_phong = txtTenPhong.Text;
            p.sdt = txtSDT.Text;
            p.nguoi_quan_ly = txtQuanLy.Text;

            string query = "INSERT into PHONG values ('" + p.ma_phong + "' , N'" +
                   p.ten_phong + "' , '" + p.sdt + "' , N'" + p.nguoi_quan_ly + "')";
            sqlCnn.Open();
            try
            {
                SqlCommand command = new SqlCommand(query, sqlCnn);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Không thể thêm phòng mời nhập lại", "Thông báo");
            }
            sqlCnn.Close();
            showList();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PHONG p = new PHONG();

            p.ma_phong = txtID.Text;
            p.ten_phong = txtTenPhong.Text;
            p.sdt = txtSDT.Text;
            p.nguoi_quan_ly = txtQuanLy.Text;
            sqlCnn.Open();
            string query = "UPDATE PHONG SET " +
                "ten_phong = N'" + p.ten_phong + "' , " +
                "sdt = '" + p.sdt + "' , " +
                "nguoi_quan_ly = N'" + p.nguoi_quan_ly + "' " +
                "WHERE ma_phong = '" + p.ma_phong +"'";
            SqlCommand command = new SqlCommand(query, sqlCnn);
            command.ExecuteNonQuery();
            sqlCnn.Close();
            showList();
        }
    }
}
