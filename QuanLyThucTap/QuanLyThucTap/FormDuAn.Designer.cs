namespace QuanLyThucTap
{
    partial class FormDuAn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.dgvDA = new System.Windows.Forms.DataGridView();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblGach = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpKT);
            this.groupBox1.Controls.Add(this.dtpBD);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.txtTenDA);
            this.groupBox1.Controls.Add(this.lblTenDA);
            this.groupBox1.Controls.Add(this.txtMaDA);
            this.groupBox1.Controls.Add(this.lblMaDA);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dự án";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(7, 188);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(74, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "Ngày kết thúc";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(7, 137);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(72, 13);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Ngày bắt đầu";
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(118, 83);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(219, 20);
            this.txtTenDA.TabIndex = 3;
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Location = new System.Drawing.Point(7, 86);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(56, 13);
            this.lblTenDA.TabIndex = 2;
            this.lblTenDA.Text = "Tên dự án";
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(118, 33);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(219, 20);
            this.txtMaDA.TabIndex = 1;
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Location = new System.Drawing.Point(7, 36);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(52, 13);
            this.lblMaDA.TabIndex = 0;
            this.lblMaDA.Text = "Mã dự án";
            // 
            // dgvDA
            // 
            this.dgvDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDA.Location = new System.Drawing.Point(375, 15);
            this.dgvDA.Name = "dgvDA";
            this.dgvDA.Size = new System.Drawing.Size(647, 434);
            this.dgvDA.TabIndex = 1;
            this.dgvDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDA_CellClick);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Mã dự án",
            "Tên dự án",
            "Ngày"});
            this.cbbSearch.Location = new System.Drawing.Point(10, 29);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(113, 21);
            this.cbbSearch.TabIndex = 2;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.lblGach);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.cbbSearch);
            this.groupBox2.Location = new System.Drawing.Point(13, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(192, 74);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 20);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(10, 74);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(135, 20);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.Visible = false;
            // 
            // lblGach
            // 
            this.lblGach.AutoSize = true;
            this.lblGach.Location = new System.Drawing.Point(165, 81);
            this.lblGach.Name = "lblGach";
            this.lblGach.Size = new System.Drawing.Size(10, 13);
            this.lblGach.TabIndex = 6;
            this.lblGach.Text = "-";
            this.lblGach.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(148, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 393);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 56);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(104, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 56);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(194, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 56);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Cập nhập";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 56);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // sqlCnn
            // 
            this.sqlCnn.ConnectionString = "Data Source = ADMIN\\SQLEXPRESS; Initial Catalog = QLTT; Integrated Security = Tru" +
    "e";
            this.sqlCnn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dtpBD
            // 
            this.dtpBD.Location = new System.Drawing.Point(118, 137);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(219, 20);
            this.dtpBD.TabIndex = 7;
            // 
            // dtpKT
            // 
            this.dtpKT.Location = new System.Drawing.Point(118, 182);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(219, 20);
            this.dtpKT.TabIndex = 8;
            // 
            // FormDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDA);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDuAn";
            this.Text = "FormDuAn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaDA;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.DataGridView dgvDA;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.DateTimePicker dtpBD;
    }
}