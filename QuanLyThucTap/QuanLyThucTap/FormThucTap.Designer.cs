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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mcd = new System.Windows.Forms.MonthCalendar();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.btnNgayKT = new System.Windows.Forms.Button();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.btnNgayBD = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnXoaform = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cmbTieuChi = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.button1);
            this.grbThongTin.Controls.Add(this.radioButton3);
            this.grbThongTin.Controls.Add(this.radioButton2);
            this.grbThongTin.Controls.Add(this.radioButton1);
            this.grbThongTin.Controls.Add(this.mcd);
            this.grbThongTin.Controls.Add(this.lblGioiTinh);
            this.grbThongTin.Controls.Add(this.cmbPhongBan);
            this.grbThongTin.Controls.Add(this.btnNgayKT);
            this.grbThongTin.Controls.Add(this.lblPhongBan);
            this.grbThongTin.Controls.Add(this.txtEnd);
            this.grbThongTin.Controls.Add(this.lblNgayKT);
            this.grbThongTin.Controls.Add(this.btnNgayBD);
            this.grbThongTin.Controls.Add(this.txtStart);
            this.grbThongTin.Controls.Add(this.lblNgayBD);
            this.grbThongTin.Controls.Add(this.txtNgaySinh);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(307, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Khác";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(217, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // mcd
            // 
            this.mcd.Location = new System.Drawing.Point(121, 133);
            this.mcd.Name = "mcd";
            this.mcd.TabIndex = 27;
            this.mcd.Visible = false;
            this.mcd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_DateChanged);
            this.mcd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcd_DateSelected);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(25, 97);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinh.TabIndex = 25;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Items.AddRange(new object[] {
            "Dev1",
            "Dev2"});
            this.cmbPhongBan.Location = new System.Drawing.Point(121, 265);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(305, 21);
            this.cmbPhongBan.TabIndex = 12;
            // 
            // btnNgayKT
            // 
            this.btnNgayKT.Location = new System.Drawing.Point(380, 220);
            this.btnNgayKT.Name = "btnNgayKT";
            this.btnNgayKT.Size = new System.Drawing.Size(46, 23);
            this.btnNgayKT.TabIndex = 19;
            this.btnNgayKT.Text = "...";
            this.btnNgayKT.UseVisualStyleBackColor = true;
            this.btnNgayKT.Click += new System.EventHandler(this.btnNgayKT_Click);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(25, 268);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(62, 13);
            this.lblPhongBan.TabIndex = 11;
            this.lblPhongBan.Text = "Phòng ban:";
            // 
            // txtEnd
            // 
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(121, 222);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(253, 20);
            this.txtEnd.TabIndex = 21;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(25, 225);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(77, 13);
            this.lblNgayKT.TabIndex = 20;
            this.lblNgayKT.Text = "Ngày kết thúc:";
            // 
            // btnNgayBD
            // 
            this.btnNgayBD.Location = new System.Drawing.Point(380, 178);
            this.btnNgayBD.Name = "btnNgayBD";
            this.btnNgayBD.Size = new System.Drawing.Size(46, 23);
            this.btnNgayBD.TabIndex = 11;
            this.btnNgayBD.Text = "...";
            this.btnNgayBD.UseVisualStyleBackColor = true;
            this.btnNgayBD.Click += new System.EventHandler(this.btnNgayBD_Click);
            // 
            // txtStart
            // 
            this.txtStart.Enabled = false;
            this.txtStart.Location = new System.Drawing.Point(121, 180);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(253, 20);
            this.txtStart.TabIndex = 18;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(25, 183);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(75, 13);
            this.lblNgayBD.TabIndex = 17;
            this.lblNgayBD.Text = "Ngày bắt đầu:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Location = new System.Drawing.Point(121, 135);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(253, 20);
            this.txtNgaySinh.TabIndex = 16;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 138);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(121, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(305, 20);
            this.txtHoTen.TabIndex = 14;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 60);
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
            this.txtID.TabIndex = 12;
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
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(243, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 60);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 60);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 60);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(139, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(189, 20);
            this.txtTimKiem.TabIndex = 35;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(345, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 23);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cmbTieuChi
            // 
            this.cmbTieuChi.FormattingEnabled = true;
            this.cmbTieuChi.Items.AddRange(new object[] {
            "ID",
            "Họ tên"});
            this.cmbTieuChi.Location = new System.Drawing.Point(0, 17);
            this.cmbTieuChi.Name = "cmbTieuChi";
            this.cmbTieuChi.Size = new System.Drawing.Size(121, 21);
            this.cmbTieuChi.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 464);
            this.dataGridView1.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cmbTieuChi);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 55);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
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
            // FormThucTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThucTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MonthCalendar mcd;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Button btnXoaform;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.Button btnNgayKT;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Button btnNgayBD;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbTieuChi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}