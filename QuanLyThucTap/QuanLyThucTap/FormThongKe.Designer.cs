namespace QuanLyThucTap
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbTieuChi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDate1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcd2 = new System.Windows.Forms.MonthCalendar();
            this.mcd1 = new System.Windows.Forms.MonthCalendar();
            this.btnDate2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTTV = new System.Windows.Forms.TextBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(514, 22);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 3;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(498, 343);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // cbbTieuChi
            // 
            this.cbbTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTieuChi.FormattingEnabled = true;
            this.cbbTieuChi.Items.AddRange(new object[] {
            "Thống kê số lượng thực tập viên theo phòng",
            "Thống kê số lượng thực tập viên theo thời gian",
            "Thống kê số lượng thực tập viên theo phòng và theo thời gian",
            "Thống kê số lượng công việc và trạng thái của thực tập viên"});
            this.cbbTieuChi.Location = new System.Drawing.Point(93, 19);
            this.cbbTieuChi.Name = "cbbTieuChi";
            this.cbbTieuChi.Size = new System.Drawing.Size(388, 32);
            this.cbbTieuChi.TabIndex = 1;
            this.cbbTieuChi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiêu chí";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(127, 33);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(141, 29);
            this.txtStart.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến ngày";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(128, 84);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(141, 29);
            this.txtEnd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ ngày";
            // 
            // btnDate1
            // 
            this.btnDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate1.Location = new System.Drawing.Point(289, 31);
            this.btnDate1.Name = "btnDate1";
            this.btnDate1.Size = new System.Drawing.Size(122, 35);
            this.btnDate1.TabIndex = 8;
            this.btnDate1.Text = "Chọn ngày";
            this.btnDate1.UseVisualStyleBackColor = true;
            this.btnDate1.Click += new System.EventHandler(this.btnDate1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mcd2);
            this.groupBox1.Controls.Add(this.mcd1);
            this.groupBox1.Controls.Add(this.btnDate2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDate1);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTTV);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 265);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // mcd2
            // 
            this.mcd2.Location = new System.Drawing.Point(36, 69);
            this.mcd2.Name = "mcd2";
            this.mcd2.TabIndex = 11;
            this.mcd2.Visible = false;
            this.mcd2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcd2_DateSelected);
            // 
            // mcd1
            // 
            this.mcd1.Location = new System.Drawing.Point(35, 69);
            this.mcd1.Name = "mcd1";
            this.mcd1.TabIndex = 10;
            this.mcd1.Visible = false;
            this.mcd1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcd1_DateSelected);
            // 
            // btnDate2
            // 
            this.btnDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate2.Location = new System.Drawing.Point(289, 82);
            this.btnDate2.Name = "btnDate2";
            this.btnDate2.Size = new System.Drawing.Size(122, 35);
            this.btnDate2.TabIndex = 9;
            this.btnDate2.Text = "Chọn ngày";
            this.btnDate2.UseVisualStyleBackColor = true;
            this.btnDate2.Click += new System.EventHandler(this.btnDate2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã thực tập viên:";
            // 
            // txtTTV
            // 
            this.txtTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTV.Location = new System.Drawing.Point(189, 145);
            this.txtTTV.Name = "txtTTV";
            this.txtTTV.Size = new System.Drawing.Size(167, 29);
            this.txtTTV.TabIndex = 6;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(514, 22);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(498, 323);
            this.dgvInfo.TabIndex = 10;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(509, 368);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(109, 25);
            this.lblKQ.TabIndex = 11;
            this.lblKQ.Text = "Số lượng: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(460, 413);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 12;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTieuChi);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbbTieuChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDate1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDate2;
        private System.Windows.Forms.MonthCalendar mcd1;
        private System.Windows.Forms.MonthCalendar mcd2;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTTV;
        private System.Windows.Forms.Label lblTitle;
    }
}