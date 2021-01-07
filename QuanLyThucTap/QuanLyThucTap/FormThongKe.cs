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
    public partial class FormThongKe : Form
    {
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string connectString = @"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True";
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            /*SqlConnection sqlConnection = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(thuc_tap.ma_tts) as Số_lượng ,phong.ten_phong as Tên_phòng ,phong.ma_phong from thuc_tap, PHONG where thuc_tap.ma_phong_thuc_tap = phong.ma_phong group by phong.ten_phong, phong.ma_phong", sqlConnection);
            DataTable dataTable=new DataTable();
            sqlDataAdapter.Fill(dataTable);
            chart1.DataSource = dataTable;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Phòng thực tập";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng thực tập viên";
            chart1.Series["Series1"].XValueMember = "Tên_phòng";
            chart1.Series["Series1"].YValueMembers = "Số_lượng"; */
            sqlConnection = new SqlConnection(connectString);
            sqlConnection.Open();
        }

        private void mcd2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtEnd.Text = mcd2.SelectionStart.ToString("yyyy-MM-dd");
            mcd2.Visible = false;
        }

        private void mcd1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtStart.Text = mcd1.SelectionStart.ToString("yyyy-MM-dd");
            mcd1.Visible = false;
        }
        public void xuly0()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(thuc_tap.ma_tts) as Số_lượng ,phong.ten_phong as Tên_phòng ,phong.ma_phong from thuc_tap, PHONG where thuc_tap.ma_phong_thuc_tap = phong.ma_phong group by phong.ten_phong, phong.ma_phong", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            chart1.DataSource = dataTable;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Phòng thực tập";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng thực tập viên";
            chart1.Series["Series1"].XValueMember = "Tên_phòng";
            chart1.Series["Series1"].YValueMembers = "Số_lượng";
            chart1.DataBind();
        }
        public void loadData(string queryString)
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
            dgvInfo.DataSource = dataTable;
        }
        public void xuly1()
        {
            if (txtStart.Text=="" || txtEnd.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đầu và kết thúc");
            }
            else
            {
                string queryString = "select * from thuc_tap where not((bat_dau_thuc_tap <= '"+txtStart.Text+"' and ket_thuc_thuc_tap<= '"+txtStart.Text+ "') or(bat_dau_thuc_tap >= '" + txtEnd.Text + "' and ket_thuc_thuc_tap >= '" + txtEnd.Text+"'))";    
                SqlConnection connection2 = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
                connection2.Open();
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(queryString, connection2);
                DataTable dataTable2 = new DataTable();
                dataAdapter2.Fill(dataTable2);
                dgvInfo.DataSource = dataTable2;
                connection2.Close();
                lblKQ.Text = "Số lượng: "+ (dgvInfo.Rows.Count -1).ToString();
            }
        }
        public void xuly2()
        {    
            SqlConnection connection2 = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
            string queryString = "select count(thuc_tap.ma_tts) as Số_lượng,phong.ten_phong as Tên_phòng ,phong.ma_phong from thuc_tap, phong where not((thuc_tap.bat_dau_thuc_tap <= '2020-07-01' and thuc_tap.ket_thuc_thuc_tap <= '2020-07-30') or(thuc_tap.bat_dau_thuc_tap >= '2020-07-01' and thuc_tap.ket_thuc_thuc_tap >= '2020-07-30')) and thuc_tap.ma_phong_thuc_tap = phong.ma_phong group by phong.ma_phong,PHONG.ten_phong";
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(queryString, connection2);
            DataTable dataTable2 = new DataTable();
            dataAdapter2.Fill(dataTable2);
            chart1.DataSource = dataTable2;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Phòng thực tập";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng thực tập viên";
            chart1.Series["Series1"].XValueMember = "Tên_phòng";
            chart1.Series["Series1"].YValueMembers = "Số_lượng";
        }
        public void xuly3()
        {
            FormWork formWork = new FormWork();
            if (txtTTV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin!");
                txtTTV.Focus();
            }
            else
            {
                if (formWork.checkConflix(txtTTV.Text.Trim(), "") == 1)
                {
                    MessageBox.Show("Không có thực tập viên này! ");
                }
                else
                {
                    
                    SqlConnection connection2 = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = True");
                    string queryString = "select count(*) as Số_lượng_công_việc,tinh_trang as Tình_trạng from work where ma_tts='" + txtTTV.Text.Trim() + "' group by tinh_trang";
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter(queryString, connection2);
                    DataTable dataTable3 = new DataTable();
                    dataAdapter2.Fill(dataTable3);
                    chart1.DataSource = dataTable3;
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tình trạng công việc";
                    chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng công việc";
                    chart1.Series["Series1"].XValueMember = "Tình_trạng";
                    chart1.Series["Series1"].YValueMembers = "Số_lượng_công_việc";
                    MessageBox.Show(chart1.Series["Series1"].YValueMembers.ToString());
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    //xuly0();
                    dgvInfo.Visible = false;
                    lblKQ.Visible = false;
                    chart1.Visible = true;
                    groupBox1.Visible = true;
                    break;
                case 1:
                    //xuly1();
                    dgvInfo.Visible = true;
                    lblKQ.Visible = true;
                    groupBox1.Visible=true;
                    chart1.Visible = false;
                    break;
                case 2:
                    //xuly2();
                    dgvInfo.Visible = false;
                    lblKQ.Visible = false;
                    groupBox1.Visible = true;
                    chart1.Visible = true;
                    break;
                case 3:
                    dgvInfo.Visible = false;
                    lblKQ.Visible = false;
                    chart1.Visible = true;
                    groupBox1.Visible = true;
                    break;
            }
            lblTitle.Text = cbbTieuChi.Text;
        }

        private void btnDate2_Click(object sender, EventArgs e)
        {
            mcd2.Visible = !mcd2.Visible;
        }

        private void btnDate1_Click(object sender, EventArgs e)
        {
            mcd1.Visible = !mcd1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbbTieuChi.SelectedIndex)
            {
                case 0:
                    xuly0();
                    break;
                case 1:
                    xuly1();
                    break;
                case 2:
                    xuly2();
                    break;
                case 3:
                    xuly3();
                    break;
            }
        }
    }
}
