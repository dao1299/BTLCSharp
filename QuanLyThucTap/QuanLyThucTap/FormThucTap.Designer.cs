namespace QuanLyThucTap
{
    partial class FormThucTap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnXoaform = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbTieuChi = new System.Windows.Forms.ComboBox();
            this.dgvThucTap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSearchPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucTap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dtpEnd);
            this.grbThongTin.Controls.Add(this.dtpStart);
            this.grbThongTin.Controls.Add(this.dtpNgaySinh);
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.lblEmail);
            this.grbThongTin.Controls.Add(this.rdbKhac);
            this.grbThongTin.Controls.Add(this.rdbNu);
            this.grbThongTin.Controls.Add(this.rdbNam);
            this.grbThongTin.Controls.Add(this.lblGioiTinh);
            this.grbThongTin.Controls.Add(this.cbbPhongBan);
            this.grbThongTin.Controls.Add(this.lblPhongBan);
            this.grbThongTin.Controls.Add(this.lblNgayKT);
            this.grbThongTin.Controls.Add(this.lblNgayBD);
            this.grbThongTin.Controls.Add(this.lblNgaySinh);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lblHoTen);
            this.grbThongTin.Controls.Add(this.txtID);
            this.grbThongTin.Controls.Add(this.lblID);
            this.grbThongTin.Location = new System.Drawing.Point(25, 85);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(459, 297);
            this.grbThongTin.TabIndex = 37;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin sinh viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // rdbKhac
            // 
            this.rdbKhac.AutoSize = true;
            this.rdbKhac.Location = new System.Drawing.Point(307, 82);
            this.rdbKhac.Name = "rdbKhac";
            this.rdbKhac.Size = new System.Drawing.Size(50, 17);
            this.rdbKhac.TabIndex = 5;
            this.rdbKhac.TabStop = true;
            this.rdbKhac.Text = "Khác";
            this.rdbKhac.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(217, 82);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(121, 82);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(25, 84);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinh.TabIndex = 25;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Items.AddRange(new object[] {
            "Dev1",
            "Dev2"});
            this.cbbPhongBan.Location = new System.Drawing.Point(121, 252);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(305, 21);
            this.cbbPhongBan.TabIndex = 13;
            this.cbbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbbPhongBan_SelectedIndexChanged);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(25, 255);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(62, 13);
            this.lblPhongBan.TabIndex = 11;
            this.lblPhongBan.Text = "Phòng ban:";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(25, 185);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(77, 13);
            this.lblNgayKT.TabIndex = 20;
            this.lblNgayKT.Text = "Ngày kết thúc:";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(25, 152);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(75, 13);
            this.lblNgayBD.TabIndex = 17;
            this.lblNgayBD.Text = "Ngày bắt đầu:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 115);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(121, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(305, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 53);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(305, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(25, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // btnXoaform
            // 
            this.btnXoaform.Location = new System.Drawing.Point(358, 19);
            this.btnXoaform.Name = "btnXoaform";
            this.btnXoaform.Size = new System.Drawing.Size(90, 60);
            this.btnXoaform.TabIndex = 24;
            this.btnXoaform.Text = "Xóa Form";
            this.btnXoaform.UseVisualStyleBackColor = true;
            this.btnXoaform.Click += new System.EventHandler(this.btnXoaform_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(243, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 60);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 60);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Cập nhập";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 60);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 35;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbTieuChi
            // 
            this.cbbTieuChi.FormattingEnabled = true;
            this.cbbTieuChi.Items.AddRange(new object[] {
            "ID",
            "Họ tên",
            "Phòng ban"});
            this.cbbTieuChi.Location = new System.Drawing.Point(0, 17);
            this.cbbTieuChi.Name = "cbbTieuChi";
            this.cbbTieuChi.Size = new System.Drawing.Size(121, 21);
            this.cbbTieuChi.TabIndex = 34;
            this.cbbTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbbTieuChi_SelectedIndexChanged);
            // 
            // dgvThucTap
            // 
            this.dgvThucTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucTap.Location = new System.Drawing.Point(503, 24);
            this.dgvThucTap.Name = "dgvThucTap";
            this.dgvThucTap.Size = new System.Drawing.Size(535, 464);
            this.dgvThucTap.TabIndex = 41;
            this.dgvThucTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucTap_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSearchPhong);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbTieuChi);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 55);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbbSearchPhong
            // 
            this.cbbSearchPhong.FormattingEnabled = true;
            this.cbbSearchPhong.Items.AddRange(new object[] {
            "Dev1",
            "Dev2"});
            this.cbbSearchPhong.Location = new System.Drawing.Point(139, 16);
            this.cbbSearchPhong.Name = "cbbSearchPhong";
            this.cbbSearchPhong.Size = new System.Drawing.Size(189, 21);
            this.cbbSearchPhong.TabIndex = 33;
            this.cbbSearchPhong.Visible = false;
            this.cbbSearchPhong.SelectedIndexChanged += new System.EventHandler(this.cbbSearchPhong_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaform);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(25, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 100);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // sqlCnn
            // 
            this.sqlCnn.ConnectionString = "Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = Tru" +
    "e";
            this.sqlCnn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(121, 109);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(305, 20);
            this.dtpNgaySinh.TabIndex = 31;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(121, 146);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(305, 20);
            this.dtpStart.TabIndex = 32;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(121, 179);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(305, 20);
            this.dtpEnd.TabIndex = 33;
            // 
            // FormThucTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThucTap);
            this.Controls.Add(this.grbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThucTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucTap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.RadioButton rdbKhac;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnXoaform;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbTieuChi;
        private System.Windows.Forms.DataGridView dgvThucTap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Data.SqlClient.SqlCommand sqlCmd;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbSearchPhong;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}