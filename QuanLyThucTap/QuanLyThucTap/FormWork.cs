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
    public partial class FormWork : Form
    {
        public string ma_tts { get; set; }
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string connectString = @"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True";
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public FormWork()
        {
            InitializeComponent();
            
        }
        public void loadData(string queryString)
        {

            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = queryString;
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
            dgvWork.DataSource = dataTable;
        }

        private void FormWork_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectString);
            sqlConnection.Open();
            loadData("select * from work");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    if (txtMaDA.Text.Trim() == "")
                    {
                        if (txtMaTT.Text.Trim() == "")
                        {
                            MessageBox.Show("Bạn không thể xóa nếu không nhập gì !");
                        }
                        else
                        {
                            DialogResult kq2 = MessageBox.Show("Bạn sẽ xóa tất cả thông tin của thực tập sinh: " + txtMaTT + " .?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (kq2 == DialogResult.Yes)
                            {
                                sqlCommand.CommandText = "delete from work where ma_tts = '   " + txtMaTT.Text.Trim() + "   '";
                                sqlCommand.ExecuteNonQuery();
                                loadData("select * from work");
                                MessageBox.Show("Thành công!");
                            }
                        }
                    }
                    else
                    {
                        if (txtMaTT.Text.Trim() == "")
                        {
                            DialogResult kq3 = MessageBox.Show("Bạn sẽ xóa tất cả thông tin của mã dự án: " + txtMaDA + " .?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (kq3 == DialogResult.Yes)
                            {
                                sqlCommand.CommandText = "delete from work where ma_du_an = '" + txtMaDA.Text.Trim() + "'";
                                sqlCommand.ExecuteNonQuery();
                                loadData("select * from work");
                                MessageBox.Show("Thành công!");
                            }
                        }
                        else
                        {
                            sqlCommand.CommandText = "delete from work where ma_tts = '" + txtMaTT.Text.Trim() + "' and ma_du_an = '" + txtMaDA.Text.Trim() + "'";
                            sqlCommand.ExecuteNonQuery();
                            loadData("select * from work");
                            MessageBox.Show("Thành công!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                }
            }
        }

        public bool checkConflix2(string maTT,string maDA)
        {
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command = sqlConnection.CreateCommand();
            command.CommandText = "select * from thuc_tap where ma_tts='" + maTT + "'";
            sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read())
            {
                return false;
            }
            sqlDataReader.Close();
            command = sqlConnection.CreateCommand();
            command.CommandText = "select * from project where ma_du_an='" + maDA + "'";
            sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read())
            {
                return false;
            }
            sqlDataReader.Close();
            return true;
        }
        
        private void loadComboBoxDA()
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            UpdateWork updateWork = new UpdateWork();
            updateWork.ShowDialog();
            
        }
        private bool checkEmpty()
        {
            if (txtMaDA.Text.Trim()=="" || txtMaTT.Text.Trim()=="" || cbbTrangThai.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int checkConflix(string maTT,string maDA)
        {
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command = sqlConnection.CreateCommand();
            command.CommandText = "select * from thuc_tap where ma_tts='" + maTT + "'";
            sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read())
            {
                return 1;
            }
            sqlDataReader.Close();
            command = sqlConnection.CreateCommand();
            command.CommandText = "select * from project where ma_du_an='"+maDA+"'";
            sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read())
            {
                return 2;
            }
            sqlDataReader.Close();
            
            command.CommandText = "select * from work where ma_tts='" + maTT + "' and ma_du_an='" + maDA + "' ";
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return 3;
            }
            sqlConnection.Close();
            return 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == true)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!  ");
            }
            else
            {
                switch(checkConflix(txtMaTT.Text.Trim(), txtMaDA.Text.Trim()))
                {
                    case 1:
                        MessageBox.Show("Không có thực tập sinh có mã như vậy! ");
                        break;
                    case 2:
                        MessageBox.Show("Không có mã dự án nào như vậy ");
                        break;
                    case 3:
                        MessageBox.Show("Thông tin của bạn bị trùng lặp ");
                        break;
                    case 0:
                        try
                        {
                            sqlCommand.CommandText = "insert into work values ('" + txtMaTT.Text.Trim() + "','" + txtMaDA.Text.Trim() + "',N'" + cbbTrangThai.Text.Trim() + "')";
                            sqlCommand.ExecuteNonQuery();
                            loadData("select * from work");
                            MessageBox.Show("Thành công!");
                        }
                        catch
                        {
                            MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                        }
                        break;
                }
            }
        }

        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadData("select * from work where ma_tts like '%"+txtMaTTSTK.Text.Trim()+"%'");
        }

        private void dgvWork_Click(object sender, EventArgs e)
        {
            var i = dgvWork.CurrentRow.Index;
            txtMaTT.Text = dgvWork.Rows[i].Cells[0].Value.ToString();
            txtMaDA.Text = dgvWork.Rows[i].Cells[1].Value.ToString();
            cbbTrangThai.Text = dgvWork.Rows[i].Cells[2].Value.ToString();
        }
    }
}
