namespace Windownform_App
{
    partial class UCQLSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.cbo_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_gt = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Checked = false;
            this.dt_ngaysinh.Location = new System.Drawing.Point(57, 298);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(344, 26);
            this.dt_ngaysinh.TabIndex = 24;
            this.dt_ngaysinh.Value = new System.DateTime(2026, 5, 15, 0, 0, 0, 0);
            // 
            // cbo_lop
            // 
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Items.AddRange(new object[] {
            "SelectedValue"});
            this.cbo_lop.Location = new System.Drawing.Point(56, 442);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(346, 28);
            this.cbo_lop.TabIndex = 23;
            // 
            // cbo_gioitinh
            // 
            this.cbo_gioitinh.FormattingEnabled = true;
            this.cbo_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioitinh.Location = new System.Drawing.Point(56, 355);
            this.cbo_gioitinh.Name = "cbo_gioitinh";
            this.cbo_gioitinh.Size = new System.Drawing.Size(346, 28);
            this.cbo_gioitinh.TabIndex = 22;
            this.cbo_gioitinh.SelectedIndexChanged += new System.EventHandler(this.cbo_gioitinh_SelectedIndexChanged);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(56, 205);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(346, 26);
            this.txt_hoten.TabIndex = 20;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(56, 132);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(346, 26);
            this.txtMSSV.TabIndex = 18;
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Location = new System.Drawing.Point(52, 409);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(44, 20);
            this.lbl_lop.TabIndex = 16;
            this.lbl_lop.Text = "Lớp: ";
            this.lbl_lop.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_gt
            // 
            this.lbl_gt.AutoSize = true;
            this.lbl_gt.Location = new System.Drawing.Point(52, 332);
            this.lbl_gt.Name = "lbl_gt";
            this.lbl_gt.Size = new System.Drawing.Size(71, 20);
            this.lbl_gt.TabIndex = 14;
            this.lbl_gt.Text = "Giới tính:";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(52, 262);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(82, 20);
            this.lbl_ngaysinh.TabIndex = 13;
            this.lbl_ngaysinh.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã sinh viên: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(886, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tìm kiếm (Tên /Mã SV/ Lớp):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(496, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 26);
            this.textBox3.TabIndex = 17;
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSSV.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.GridColor = System.Drawing.Color.White;
            this.dgv_DSSV.Location = new System.Drawing.Point(496, 205);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 62;
            this.dgv_DSSV.RowTemplate.Height = 28;
            this.dgv_DSSV.Size = new System.Drawing.Size(914, 434);
            this.dgv_DSSV.TabIndex = 15;
            this.dgv_DSSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(262, 706);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 54);
            this.button5.TabIndex = 29;
            this.button5.Text = "Làm mới";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(262, 629);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 52);
            this.button4.TabIndex = 28;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(69, 706);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 54);
            this.button3.TabIndex = 27;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_them.Location = new System.Drawing.Point(69, 628);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(158, 55);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(710, 672);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 52);
            this.button6.TabIndex = 30;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1160, 672);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 52);
            this.button7.TabIndex = 31;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(777, 672);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 52);
            this.button8.TabIndex = 30;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1088, 672);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 52);
            this.button9.TabIndex = 31;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 689);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Trang 1/1 | bản ghi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UCQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.cbo_lop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_gioitinh);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_gt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ngaysinh);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCQLSV";
            this.Size = new System.Drawing.Size(1432, 842);
            this.Load += new System.EventHandler(this.UCQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.ComboBox cbo_lop;
        private System.Windows.Forms.ComboBox cbo_gioitinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_gt;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}
