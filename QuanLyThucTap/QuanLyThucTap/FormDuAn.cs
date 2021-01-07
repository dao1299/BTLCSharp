using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThucTap
{
    public partial class FormDuAn : Form
    {
        public FormDuAn()
        {
            InitializeComponent();
            showList();
        }

        private int statusDate = 0, sttSearch;

        private void showList()
        {

            string query = "SELECT * FROM PROJECT";
            sqlCnn.Open();

            SqlCommand command = new SqlCommand(query, sqlCnn);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            sqlCnn.Close();
            dgvDA.DataSource = data;
            txtMaDA.Text = "";
            txtTenDA.Text = "";
            dtpBD.Text = "";
            dtpKT.Text = "";
        }
        private void dgvDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                txtMaDA.Text = dgvDA.Rows[n].Cells[0].Value.ToString();
                txtTenDA.Text = dgvDA.Rows[n].Cells[1].Value.ToString();
                dtpBD.Text = dgvDA.Rows[n].Cells[2].Value.ToString();
                dtpEnd.Text = dgvDA.Rows[n].Cells[3].Value.ToString();
            }
        }

        private void mcd_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                DateTime dt1, dt2;
                dt1 = dtpBD.Value;
                dt2 = dtpKT.Value;
                TimeSpan dt = dt2 - dt1;
                if (dt < TimeSpan.Zero) MessageBox.Show("Ngày kết thúc đang ở trước ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                string query = "DELETE FROM PROJECT WHERE ma_du_an = '" + txtMaDA.Text + "'";
                sqlCnn.Open();
                SqlCommand command = new SqlCommand(query, sqlCnn);
                command.ExecuteNonQuery();
                sqlCnn.Close();
                showList();
            }
        }
        public class DuAn
        {
            public string ma_du_an { get; set; }
            public string ten_du_an { get; set; }
            public DateTime bat_dau_du_an { get; set; }
            public DateTime ket_thuc_du_an { get; set; }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn();
            da.ma_du_an = txtMaDA.Text;
            da.ten_du_an = txtTenDA.Text;
            da.bat_dau_du_an = dtpBD.Value;
            da.ket_thuc_du_an = dtpKT.Value;

            string query = "INSERT into PROJECT values ('" + da.ma_du_an + "' , N'" +
                da.ten_du_an + "' , '" + da.bat_dau_du_an + "' , '" + da.ket_thuc_du_an + "')";
            MessageBox.Show(query);
            try
            {
                DateTime dt1, dt2;
                dt1 = dtpBD.Value;
                dt2 = dtpKT.Value;
                TimeSpan dt = dt2 - dt1;
                if (dt < TimeSpan.Zero) MessageBox.Show("Ngày kết thúc đang ở trước ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        sqlCnn.Open();
                        SqlCommand command = new SqlCommand(query, sqlCnn);
                        command.ExecuteNonQuery();
                        sqlCnn.Close();
                        showList();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể thêm dự án mời nhập lại", "Thông báo");
                    }
                }
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn();
            da.ma_du_an = txtMaDA.Text;
            da.ten_du_an = txtTenDA.Text;
            da.bat_dau_du_an = dtpBD.Value;
            da.ket_thuc_du_an = dtpEnd.Value;

            string query = "UPDATE PROJECT SET " +
                "ten_du_an = N'" + da.ten_du_an + "' , " +
                "bat_dau_du_an = '" + da.bat_dau_du_an + "' , " +
                "ket_thuc_du_an = '" + da.ket_thuc_du_an + "' " +
                "WHERE ma_du_an = '" + da.ma_du_an + "'";
            try
            {
                DateTime dt1, dt2;
                dt1 = dtpBD.Value;
                dt2 = dtpKT.Value;
                TimeSpan dt = dt2 - dt1;
                if (dt < TimeSpan.Zero) MessageBox.Show("Ngày kết thúc đang ở trước ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        sqlCnn.Open();
                        SqlCommand command = new SqlCommand(query, sqlCnn);
                        command.ExecuteNonQuery();
                        sqlCnn.Close();
                        showList();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhập mời nhập lại", "Thông báo");
                    }
                }
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query;
            SqlCommand command;
            DataTable data;
            SqlDataAdapter adapter;

            sqlCnn.Open();
            switch (sttSearch)
            {
                case 0:
                    query = "SELECT * FROM PROJECT WHERE ma_du_an LIKE '%" + txtSearch.Text + "%'";
                    command = new SqlCommand(query, sqlCnn);
                    data = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvDA.DataSource = data;
                    break;
                case 1:
                    query = "SELECT * FROM PROJECT WHERE ten_du_an LIKE N'%" + txtSearch.Text + "%'";
                    command = new SqlCommand(query, sqlCnn);
                    data = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvDA.DataSource = data;
                    break;
                case 2:
                    query = "SELECT * FROM PROJECT WHERE bat_dau_du_an >= '" + dtpStart.Value.ToShortDateString() + "' and " +
                        "ket_thuc_du_an <= '" + dtpEnd.Value.ToShortDateString() + "'";
                    command = new SqlCommand(query, sqlCnn);
                    data = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvDA.DataSource = data;
                    break;

            }
            sqlCnn.Close();
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearch.SelectedIndex == 0)
            {
                sttSearch = 0;
                txtSearch.Visible = true;
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                lblGach.Visible = false;
            }
            else if (cbbSearch.SelectedIndex == 1)
            {
                sttSearch = 1;
                txtSearch.Visible = true;
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                lblGach.Visible = false;
            }
            else if (cbbSearch.SelectedIndex == 2)
            {
                sttSearch = 2;
                txtSearch.Visible = false;
                dtpStart.Visible = true;
                dtpEnd.Visible = true;
                lblGach.Visible = true;
            }
        }
    }
}
