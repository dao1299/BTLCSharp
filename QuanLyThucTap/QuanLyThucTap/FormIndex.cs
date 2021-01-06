using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucTap
{
    public partial class FormIndex : Form
    {
        public FormIndex(int statusLogin)
        {
            InitializeComponent();
            PhanQuyen(statusLogin);
        }
        private void PhanQuyen(int statusLogin)
        {
            switch (statusLogin)
            {
                case 1:
                    break;
                case 3:
                    btnThucTap.Enabled = false;
                    btnPhong.Enabled = false;
                    btnDuAn.Enabled = false;
                    btnUser.Enabled = false;
                    btnWork.Enabled = false;
                    break;
                case 2:
                    btnPhong.Enabled = false;
                    btnUser.Enabled = false;
                    break;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void showFormChild(int index)
        {
            pnlMain.Controls.Clear();
            switch (index)
            {
                case 0:
                    break;
                case 1:
                    FormThucTap formThucTap = new FormThucTap() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formThucTap);
                    formThucTap.Show();
                    break;
                case 2:
                    
                    FormPhong formPhong = new FormPhong() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formPhong);
                    formPhong.Show();
                    break;
                case 3:
                    FormDuAn formDuAn = new FormDuAn() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formDuAn);
                    formDuAn.Show();
                    break;
                case 4:
                    FormUser formUser = new FormUser() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formUser);
                    formUser.Show();
                    break;
                case 5:
                    FormThongKe formThongKe = new FormThongKe() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formThongKe);
                    formThongKe.Show();
                    break;
                case 6:
                    FormWork formWork = new FormWork() { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                    pnlMain.Controls.Add(formWork);
                    formWork.Show();
                    break;
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showFormChild(5);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            showFormChild(2);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            showFormChild(3);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showFormChild(4);
        }

        private void btnThucTap_Click(object sender, EventArgs e)
        {
            showFormChild(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showFormChild(0);
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {

        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            showFormChild(6);
        }
    }
}
