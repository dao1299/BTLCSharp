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
    public partial class FormLogin : Form
    {
        public static int statusLogin;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void brnLogin_Click(object sender, EventArgs e)
        {
            #region khoa
            /*if (txtUser.Text=="dao1299" && txtPass.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công\n Bạn hãy kiểm tra lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            #endregion
            
            SqlDataReader sqlDataReader;
            sqlCnn.Open(); // sqlConnection
            sqlCom.CommandText = "Select * from taikhoan where username='"+txtUser.Text+"' and password='"+txtPass.Text+"'";
            sqlDataReader = sqlCom.ExecuteReader();
            if (sqlDataReader.Read())
            {
                txtUser.Text = "";txtPass.Text = "";
                statusLogin = sqlDataReader.GetInt32(2);
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormIndex form2 = new FormIndex(statusLogin);
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công\n Bạn hãy kiểm tra lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlCnn.Close();
        }
    }
}
