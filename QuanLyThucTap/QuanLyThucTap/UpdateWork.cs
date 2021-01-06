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
    public partial class UpdateWork : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string connectString = @"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True";
        /*SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();*/
        public UpdateWork()
        {
            InitializeComponent();
        }
        public int checkConflix1()
        {
            
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            FormWork formWork = new FormWork();
            int kq = formWork.checkConflix(txtMaTT1.Text.Trim(), txtMaDA1.Text.Trim());
            switch (kq)
            {
                case 1:
                    MessageBox.Show("Không có thực tập viên này! ");
                    txtMaTT1.Focus();
                    break;
                case 2:
                    MessageBox.Show("Không có mã dự án này! ");
                    txtMaDA1.Focus();
                    break;
                case 3:
                    if (txtMaDA1.Text.Trim().Equals(txtMaDA2.Text.Trim()) && txtMaTT1.Text.Trim().Equals(txtMaTT2.Text.Trim())){
                        DialogResult kq2 = MessageBox.Show("Bạn có chắc chắn muốn sửa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (kq2 == DialogResult.Yes)
                        {
                            try
                            {
                                MessageBox.Show("1");
                                sqlCommand = sqlConnection.CreateCommand();
                                sqlCommand.CommandText = "update work set ma_tts = '"+txtMaTT2.Text.Trim()+"', ma_du_an = '"+txtMaDA2.Text.Trim()+"', tinh_trang = N'"+cbbTT2.SelectedItem.ToString()+"' where ma_du_an = '"+txtMaDA1.Text.Trim()+"' and ma_tts = '"+txtMaTT2.Text.Trim()+"'";
                                MessageBox.Show("2");
                                sqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Thành công! ");
                                formWork.loadData("select * from work");
                            }
                            catch
                            {
                                MessageBox.Show("Không thành công! Vui lòng kiểm tra lại");
                            }
                        }
                    }
                    else
                    {
                        switch(formWork.checkConflix(txtMaTT2.Text.Trim(), txtMaDA2.Text.Trim()))
                        {
                            case 1:
                                MessageBox.Show("Không có thực tập viên này! ");
                                txtMaTT2.Focus();
                                break;
                            case 2:
                                MessageBox.Show("Không có mã dự án này! ");
                                txtMaDA2.Focus();
                                break;
                            case 3:
                                MessageBox.Show("Thông tin này đã có trong dữ liệu!");
                                break;
                        }
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateWork_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectString);
            sqlConnection.Open();
        }
    }
}
