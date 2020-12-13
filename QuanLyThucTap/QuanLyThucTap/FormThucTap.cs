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
    public partial class FormThucTap : Form
    {
        public FormThucTap()
        {
            InitializeComponent();
        }
        private int statusDate = 0;
        private void btnNgayBD_Click(object sender, EventArgs e)
        {
            mcd.Visible = !mcd.Visible;
            statusDate = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mcd.Visible = !mcd.Visible;
            statusDate = 1;
        }

        private void btnNgayKT_Click(object sender, EventArgs e)
        {
            mcd.Visible = !mcd.Visible;
            statusDate = 3;
        }

        private void mcd_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            
        }

        private void mcd_DateSelected(object sender, DateRangeEventArgs e)
        {
            switch (statusDate)
            {
                case 1:
                    txtNgaySinh.Text = mcd.SelectionStart.ToShortDateString();
                    break;
                case 2:
                    txtStart.Text = mcd.SelectionStart.ToShortDateString();
                    break;
                case 3:
                    txtEnd.Text = mcd.SelectionStart.ToShortDateString();
                    break;
            }
            mcd.Visible = false;
        }
    }
}
