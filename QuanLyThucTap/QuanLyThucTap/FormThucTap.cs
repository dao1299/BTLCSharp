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
    public partial class FormThucTap : Form
    {
        public FormThucTap()
        {
            InitializeComponent();
            showList();
        }
        private int statusDate = 0, sttSearch;
        private string maphong;

        private void showList()
        {
            
            string query = "SELECT thuc_tap.ma_tts,thuc_tap.ho_ten,thuc_tap.email,thuc_tap.DOB,thuc_tap.bat_dau_thuc_tap,thuc_tap.ket_thuc_thuc_tap,PHONG.ten_phong,thuc_tap.gioi_tinh FROM thuc_tap LEFT JOIN PHONG ON thuc_tap.ma_phong_thuc_tap = PHONG.ma_phong";
            sqlCnn.Open();

            SqlCommand command = new SqlCommand(query, sqlCnn);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            sqlCnn.Close();
            dgvThucTap.DataSource = data;
            loadCbbPhongBan();
            txtID.Text = "";
            txtHoTen.Text = "";
            rdbNam.Checked = true;
            txtEmail.Text = "";
            dtpNgaySinh.Text = "";
            dtpStart.Text = "";
            dtpEnd.Text = "";
        }

        private void loadCbbPhongBan()
        {
            string query = "SELECT * FROM phong";
            sqlCnn.Open();

            SqlCommand command = new SqlCommand(query, sqlCnn);
            List<PHONG> lstP = new List<PHONG>();
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            foreach (DataRow item in data.Rows)
            {
                PHONG p = new PHONG(item);
                lstP.Add(p);
            }
            cbbPhongBan.DataSource = lstP;
            cbbPhongBan.DisplayMember = "ten_phong";
            sqlCnn.Close();

            //sqlCnn.Open();
            //string query1 = "SELECT * FROM PHONG WHERE ten_phong = N'" + cbbPhongBan.ValueMember + "'";
            //MessageBox.Show(query1);
            //SqlCommand command1 = new SqlCommand(query1, sqlCnn);
            //try
            //{
            //    SqlDataReader sqlDataReader = command1.ExecuteReader();
            //    txtMa_Phong.Text = sqlDataReader.GetString(1);
            //}
            //catch { }
            //sqlCnn.Close();
        }

        private void loadCbbSearchPhong()
        {
            string query = "SELECT * FROM phong";
            sqlCnn.Open();

            SqlCommand command = new SqlCommand(query, sqlCnn);
            List<PHONG> lstP = new List<PHONG>();
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            foreach (DataRow item in data.Rows)
            {
                PHONG p = new PHONG(item);
                lstP.Add(p);
            }
            cbbSearchPhong.DataSource = lstP;
            cbbSearchPhong.DisplayMember = "ten_phong";
            sqlCnn.Close();
        }

        private void dgvThucTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            n = e.RowIndex;

            if (n != -1)
            {
                txtID.Text = dgvThucTap.Rows[n].Cells[0].Value.ToString();
                txtHoTen.Text = dgvThucTap.Rows[n].Cells[1].Value.ToString();
                txtEmail.Text = dgvThucTap.Rows[n].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvThucTap.Rows[n].Cells[3].Value.ToString().Trim();
                dtpStart.Text = dgvThucTap.Rows[n].Cells[4].Value.ToString().Trim();
                dtpEnd.Text = dgvThucTap.Rows[n].Cells[5].Value.ToString().Trim();
                cbbPhongBan.Text = dgvThucTap.Rows[n].Cells[6].Value.ToString();
                string gt = dgvThucTap.Rows[n].Cells[7].Value.ToString();
                if (gt == "Nam") rdbNam.Checked = true;
                else if (gt == "Nữ") rdbNu.Checked = true;
                else if (gt == "Khác") rdbKhac.Checked = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                string query = "DELETE FROM thuc_tap WHERE ma_tts = '" + txtID.Text + "'";
                sqlCnn.Open();
                SqlCommand command = new SqlCommand(query, sqlCnn);
                command.ExecuteNonQuery();
                sqlCnn.Close();
                showList();
            }
        }

        private void btnXoaform_Click(object sender, EventArgs e)
        {
            showList();
        }

        private void cbbTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTieuChi.SelectedIndex == 0)
            {
                sttSearch = 0;
                txtSearch.Visible = true;
                btnSearch.Visible = true;
                cbbSearchPhong.Visible = false;
            }
            else if (cbbTieuChi.SelectedIndex == 1)
            {
                sttSearch = 1;
                txtSearch.Visible = true;
                btnSearch.Visible = true;
                cbbSearchPhong.Visible = false;
            }
            else if (cbbTieuChi.SelectedIndex == 2)
            {
                loadCbbSearchPhong();
                txtSearch.Visible = false;
                btnSearch.Visible = false;
                cbbSearchPhong.Visible = true;
            }
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
                    query = "SELECT thuc_tap.ma_tts,thuc_tap.ho_ten,thuc_tap.email,thuc_tap.DOB,thuc_tap.bat_dau_thuc_tap,thuc_tap.ket_thuc_thuc_tap,PHONG.ten_phong,thuc_tap.gioi_tinh FROM thuc_tap LEFT JOIN PHONG ON thuc_tap.ma_phong_thuc_tap = PHONG.ma_phong WHERE ma_tts LIKE '%" + txtSearch.Text + "%'";
                    command = new SqlCommand(query, sqlCnn);
                    data = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvThucTap.DataSource = data;
                    break;
                case 1:
                    query = "SELECT thuc_tap.ma_tts,thuc_tap.ho_ten,thuc_tap.email,thuc_tap.DOB,thuc_tap.bat_dau_thuc_tap,thuc_tap.ket_thuc_thuc_tap,PHONG.ten_phong,thuc_tap.gioi_tinh FROM thuc_tap LEFT JOIN PHONG ON thuc_tap.ma_phong_thuc_tap = PHONG.ma_phong WHERE ho_ten LIKE N'%" + txtSearch.Text + "%'";
                    command = new SqlCommand(query, sqlCnn);
                    data = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvThucTap.DataSource = data;
                    break;
            }
            sqlCnn.Close();
        }

        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                try
                {
                    PHONG p = cb.SelectedItem as PHONG;
                    maphong = p.ma_phong;
                }
                catch { }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThucTapSinh tt = new ThucTapSinh();
            tt.ma_tts = txtID.Text;
            tt.ho_ten = txtHoTen.Text;
            if (rdbNam.Checked == true) tt.gioi_tinh = rdbNam.Text;
            else if (rdbNu.Checked == true) tt.gioi_tinh = rdbNu.Text;
            else tt.gioi_tinh = rdbKhac.Text;
            tt.ma_phong_thuc_tap = maphong;
            tt.DOB = dtpNgaySinh.Value;
            tt.bat_dau_thuc_tap =  dtpStart.Value;
            tt.ket_thuc_thuc_tap = dtpEnd.Value;
            /*tt.DOB = DateTime.Parse(txtNgaySinh.Text);
            tt.bat_dau_thuc_tap = DateTime.Parse(txtStart.Text);
            tt.ket_thuc_thuc_tap = DateTime.Parse(txtEnd.Text);*/
            tt.email = txtEmail.Text;
            string query = "UPDATE thuc_tap SET " +
                "ho_ten = N'" + tt.ho_ten + "' , " +
                "email = '" + tt.email + "' , " +
                "DOB = '" + tt.DOB + "' , " +
                "bat_dau_thuc_tap = '" + tt.bat_dau_thuc_tap + "' , " +
                "ket_thuc_thuc_tap = '" + tt.ket_thuc_thuc_tap + "' , " +
                "ma_phong_thuc_tap = '" + tt.ma_phong_thuc_tap + "' , " +
                "gioi_tinh = N'" + tt.gioi_tinh + "' " +
                "WHERE ma_tts = '" + tt.ma_tts + "'";

            try
            {
                DateTime dt1, dt2;
                dt1 = dtpStart.Value;
                dt2 = dtpEnd.Value;
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

        private void cbbSearchPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                try
                {
                    PHONG p = cb.SelectedItem as PHONG;
                    string query = "SELECT thuc_tap.ma_tts,thuc_tap.ho_ten,thuc_tap.email,thuc_tap.DOB,thuc_tap.bat_dau_thuc_tap,thuc_tap.ket_thuc_thuc_tap,PHONG.ten_phong,thuc_tap.gioi_tinh FROM thuc_tap LEFT JOIN PHONG ON thuc_tap.ma_phong_thuc_tap = PHONG.ma_phong WHERE ma_phong = '" + p.ma_phong + "'";
                    sqlCnn.Open();

                    SqlCommand command = new SqlCommand(query, sqlCnn);

                    DataTable data = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);
                    sqlCnn.Close();
                    dgvThucTap.DataSource = data;
                }
                catch { }
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucTapSinh tt = new ThucTapSinh();
            tt.ma_tts = txtID.Text;
            tt.ho_ten = txtHoTen.Text;

            if (rdbNam.Checked == true) tt.gioi_tinh = rdbNam.Text;
            else if (rdbNu.Checked == true) tt.gioi_tinh = rdbNu.Text;
            else tt.gioi_tinh = rdbKhac.Text;
            tt.ma_phong_thuc_tap = maphong;
            tt.DOB = dtpNgaySinh.Value;
            tt.bat_dau_thuc_tap = dtpStart.Value;
            tt.ket_thuc_thuc_tap = dtpEnd.Value;
            /*tt.DOB = DateTime.Parse(txtNgaySinh.Text);
            tt.bat_dau_thuc_tap = DateTime.Parse(txtStart.Text);
            tt.ket_thuc_thuc_tap = DateTime.Parse(txtEnd.Text);*/
            tt.email = txtEmail.Text;

            string query = "INSERT into thuc_tap values ('" + tt.ma_tts + "' , N'" +
                   tt.ho_ten + "' , '" + tt.email + "' ,  '" + tt.DOB + "' , '" +
                   tt.bat_dau_thuc_tap + "' , '" + tt.ket_thuc_thuc_tap + "' , '" +
                   tt.ma_phong_thuc_tap +  "' , N'" + tt.gioi_tinh  + "')";
            try
            {
                DateTime dt1, dt2;
                dt1 = dtpStart.Value;
                dt2 = dtpEnd.Value;
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
                        MessageBox.Show("Không thể thêm thực tập mời nhập lại", "Thông báo");
                    }
                }
            }
            catch { }
        }
    }
}
