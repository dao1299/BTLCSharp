namespace QuanLyThucTap
{
    partial class FormIndex
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThucTap = new System.Windows.Forms.Button();
            this.btnDuAn = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.btnUser);
            this.pnlLeft.Controls.Add(this.btnThongKe);
            this.pnlLeft.Controls.Add(this.btnWork);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.btnThucTap);
            this.pnlLeft.Controls.Add(this.btnDuAn);
            this.pnlLeft.Controls.Add(this.btnPhong);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 499);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::QuanLyThucTap.Properties.Resources.logo;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1050, 499);
            this.pnlMain.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUser.Image = global::QuanLyThucTap.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 309);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(200, 50);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Tài khoản";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThongKe.Image = global::QuanLyThucTap.Properties.Resources.report;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-1, 365);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 50);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnWork
            // 
            this.btnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWork.FlatAppearance.BorderSize = 0;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWork.Image = global::QuanLyThucTap.Properties.Resources.work11;
            this.btnWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWork.Location = new System.Drawing.Point(0, 253);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(200, 50);
            this.btnWork.TabIndex = 2;
            this.btnWork.Text = "Công việc";
            this.btnWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThucTap.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(62, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Image = global::QuanLyThucTap.Properties.Resources.power_off_button;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-1, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThucTap
            // 
            this.btnThucTap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucTap.FlatAppearance.BorderSize = 0;
            this.btnThucTap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThucTap.Image = global::QuanLyThucTap.Properties.Resources.student_center;
            this.btnThucTap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucTap.Location = new System.Drawing.Point(0, 85);
            this.btnThucTap.Name = "btnThucTap";
            this.btnThucTap.Size = new System.Drawing.Size(200, 50);
            this.btnThucTap.TabIndex = 0;
            this.btnThucTap.Text = "Thực tập sinh";
            this.btnThucTap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThucTap.UseVisualStyleBackColor = true;
            this.btnThucTap.Click += new System.EventHandler(this.btnThucTap_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuAn.FlatAppearance.BorderSize = 0;
            this.btnDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDuAn.Image = global::QuanLyThucTap.Properties.Resources.project;
            this.btnDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuAn.Location = new System.Drawing.Point(0, 197);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(200, 50);
            this.btnDuAn.TabIndex = 0;
            this.btnDuAn.Text = "Dự án";
            this.btnDuAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuAn.UseVisualStyleBackColor = true;
            this.btnDuAn.Click += new System.EventHandler(this.btnDuAn_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPhong.Image = global::QuanLyThucTap.Properties.Resources.room;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(-1, 141);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(200, 50);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "Phòng ban";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 499);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ký túc xá";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnThucTap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDuAn;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnWork;
    }
}