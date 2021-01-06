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
    public partial class FormUser : Form
    {
        
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string connectString = @"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True";
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public FormUser()
        {
            InitializeComponent();
            //loadData();
        }
        public void loadData()
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText="select * from taikhoan";
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
            dgvUser.DataSource = dataTable;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "delete from taikhoan where username = '" + txtId.Text.Trim() + "'";
                    sqlCommand.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Thành công!");
                }
                catch
                {
                    MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                }
            }
        }
        private bool checkUser(string id)
        {
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command = sqlConnection.CreateCommand();
            command.CommandText = "select * from taikhoan where username='" + id + "'";
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập username");
            }
            else
            {
                if (cbbPhanQuyen.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải phân quyền cho tài khoản này! ");
                }
                else
                {
                    try
                    {   
                        if (checkUser(txtId.Text.Trim())==true)
                        {
                            MessageBox.Show("Đã có user này");
                        }
                        else
                        {
                            sqlCommand.CommandText = "insert into taikhoan values ('" + txtId.Text.Trim() + "','" + txtPass.Text.Trim() + "'," + (cbbPhanQuyen.SelectedIndex + 1) + ")";
                            sqlCommand.ExecuteNonQuery();
                            loadData();
                            MessageBox.Show("Thành công!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbbPhanQuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải phân quyền cho user này!");
            }
            else
            {
                if (txtId.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống user! ");
                }
                else
                {
                    DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn sửa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (kq == DialogResult.Yes)
                    {
                        try
                        {
                            sqlCommand.CommandText = "update taikhoan set password='" + txtPass.Text.Trim() + "', status=" + (cbbPhanQuyen.SelectedIndex+1) + " where username='" + txtId.Text.Trim() + "'";
                            sqlCommand.ExecuteNonQuery();
                            loadData();
                            MessageBox.Show("Thành công! ");
                        }
                        catch
                        {
                            MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                        }
                    }
                }
            }
            
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectString);
            sqlConnection.Open();
            loadData();
            //sqlConnection.Close();
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            var i = dgvUser.CurrentRow.Index;
            txtId.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            txtPass.Text = dgvUser.Rows[i].Cells[1].Value.ToString();
            var phanQuyen = dgvUser.Rows[i].Cells[2].Value.ToString();
            switch (phanQuyen)
            {
                case "1":
                    cbbPhanQuyen.Text = "admin";
                    break;
                case "2":
                    cbbPhanQuyen.Text = "manager";
                    break;
                case "3":
                    cbbPhanQuyen.Text = "guest";
                    break;
            }
        }
    }
}
