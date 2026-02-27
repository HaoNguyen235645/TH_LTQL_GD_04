namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            btnXuat = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            button9 = new Button();
            btnLuu = new Button();
            button5 = new Button();
            btnThem = new Button();
            button1 = new Button();
            txtDiaChi = new TextBox();
            txtMatKhau = new TextBox();
            txtDienThoai = new TextBox();
            txtTenDangNhap = new TextBox();
            txtHoVaTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHang = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 132);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.BackColor = SystemColors.Menu;
            cboQuyenHan.ForeColor = SystemColors.WindowFrame;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(439, 87);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(106, 23);
            cboQuyenHan.TabIndex = 2;
            cboQuyenHan.Text = "Quản lý";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(746, 89);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(72, 30);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(660, 89);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(72, 30);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(579, 89);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(72, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(746, 53);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(72, 30);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(660, 53);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(72, 30);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(746, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(579, 53);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(72, 30);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // button9
            // 
            button9.Location = new Point(746, 17);
            button9.Name = "button9";
            button9.Size = new Size(72, 30);
            button9.TabIndex = 2;
            button9.Text = "button1";
            button9.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(660, 17);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(72, 30);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // button5
            // 
            button5.Location = new Point(660, 17);
            button5.Name = "button5";
            button5.Size = new Size(72, 30);
            button5.TabIndex = 2;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(579, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(72, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(579, 17);
            button1.Name = "button1";
            button1.Size = new Size(72, 30);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.Menu;
            txtDiaChi.ForeColor = SystemColors.ControlDarkDark;
            txtDiaChi.Location = new Point(89, 87);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 23);
            txtDiaChi.TabIndex = 1;
            txtDiaChi.Text = "Long Xuyên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.Menu;
            txtMatKhau.ForeColor = SystemColors.WindowFrame;
            txtMatKhau.Location = new Point(439, 53);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(106, 23);
            txtMatKhau.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            txtDienThoai.BackColor = SystemColors.Menu;
            txtDienThoai.ForeColor = SystemColors.ControlDarkDark;
            txtDienThoai.Location = new Point(89, 58);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(210, 23);
            txtDienThoai.TabIndex = 1;
            txtDienThoai.Text = "0123456789";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = SystemColors.Menu;
            txtTenDangNhap.ForeColor = SystemColors.WindowFrame;
            txtTenDangNhap.Location = new Point(439, 24);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(106, 23);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.Text = "nhtung";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = SystemColors.Menu;
            txtHoVaTen.ForeColor = SystemColors.ControlDarkDark;
            txtHoVaTen.Location = new Point(89, 29);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(210, 23);
            txtHoVaTen.TabIndex = 1;
            txtHoVaTen.Text = "Nguyễn Tùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 61);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 90);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 90);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 0;
            label6.Text = "Quyền hạn(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 61);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 0;
            label5.Text = "Mật khẩu(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 32);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 0;
            label4.Text = "Tên đăng nhập (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(3, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(831, 279);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHang });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(825, 257);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ Và Tên";
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHang
            // 
            QuyenHang.DataPropertyName = "QuyenHang";
            QuyenHang.HeaderText = "Quyền Hạng";
            QuyenHang.Name = "QuyenHang";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 447);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnNhap;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnSua;
        private Button button9;
        private Button btnLuu;
        private Button button5;
        private Button btnThem;
        private Button button1;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHang;
    }
}