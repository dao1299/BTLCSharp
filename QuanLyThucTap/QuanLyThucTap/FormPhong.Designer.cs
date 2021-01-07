namespace QuanLyThucTap
{
    partial class FormPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtQuanLy = new System.Windows.Forms.TextBox();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaform = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.sqlCmd = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(503, 24);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(535, 464);
            this.dgvPhong.TabIndex = 42;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.lblSDT);
            this.grbThongTin.Controls.Add(this.txtQuanLy);
            this.grbThongTin.Controls.Add(this.lblQuanLy);
            this.grbThongTin.Controls.Add(this.txtTenPhong);
            this.grbThongTin.Controls.Add(this.lblTenPhong);
            this.grbThongTin.Controls.Add(this.txtID);
            this.grbThongTin.Controls.Add(this.lblID);
            this.grbThongTin.Location = new System.Drawing.Point(25, 64);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(459, 297);
            this.grbThongTin.TabIndex = 43;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin phòng ban";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 181);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(305, 20);
            this.txtSDT.TabIndex = 22;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(30, 184);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 13);
            this.lblSDT.TabIndex = 21;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtQuanLy
            // 
            this.txtQuanLy.Location = new System.Drawing.Point(126, 129);
            this.txtQuanLy.Name = "txtQuanLy";
            this.txtQuanLy.Size = new System.Drawing.Size(305, 20);
            this.txtQuanLy.TabIndex = 20;
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Location = new System.Drawing.Point(30, 132);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(46, 13);
            this.lblQuanLy.TabIndex = 19;
            this.lblQuanLy.Text = "Quản lý:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(126, 80);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(305, 20);
            this.txtTenPhong.TabIndex = 18;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(30, 83);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(62, 13);
            this.lblTenPhong.TabIndex = 17;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(305, 20);
            this.txtID.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "Mã phòng:";
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
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
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
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 60);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Cập nhâp";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // sqlCnn
            // 
            this.sqlCnn.ConnectionString = "Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = Tru" +
    "e";
            this.sqlCnn.FireInfoMessageEventOnUserErrors = false;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhong";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtQuanLy;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaform;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Data.SqlClient.SqlCommand sqlCmd;
    }
}