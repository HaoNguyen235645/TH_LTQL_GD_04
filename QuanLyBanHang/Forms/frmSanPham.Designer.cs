namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            btnXuat = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            picHinhAnh = new PictureBox();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            numDonGia = new NumericUpDown();
            btnLuu = new Button();
            numSoLuong = new NumericUpDown();
            btnXoa = new Button();
            cboHangSanXuat = new ComboBox();
            btnSua = new Button();
            cboLoaiSanPham = new ComboBox();
            btnThem = new Button();
            btnDoiAnh = new Button();
            txtMoTa = new TextBox();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(927, 205);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(849, 145);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(72, 30);
            btnXuat.TabIndex = 4;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 9F);
            btnThoat.Location = new Point(596, 145);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(91, 32);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(771, 145);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(72, 31);
            btnNhap.TabIndex = 5;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.InitialImage = null;
            picHinhAnh.Location = new Point(534, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(134, 113);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 4;
            picHinhAnh.TabStop = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(693, 145);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 32);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 9F);
            btnHuyBo.Location = new Point(499, 145);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(91, 32);
            btnHuyBo.TabIndex = 12;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(408, 58);
            numDonGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(120, 23);
            numDonGia.TabIndex = 3;
            numDonGia.ThousandsSeparator = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 9F);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(402, 145);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 32);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(408, 29);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 23);
            numSoLuong.TabIndex = 3;
            numSoLuong.ThousandsSeparator = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 9F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(305, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 32);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.BackColor = SystemColors.Menu;
            cboHangSanXuat.ForeColor = SystemColors.WindowFrame;
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(114, 58);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(106, 23);
            cboHangSanXuat.TabIndex = 2;
            cboHangSanXuat.Text = "Apple";
            cboHangSanXuat.SelectedIndexChanged += cboHangSanXuat_SelectedIndexChanged;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 9F);
            btnSua.Location = new Point(208, 145);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 32);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.BackColor = SystemColors.Menu;
            cboLoaiSanPham.ForeColor = SystemColors.WindowFrame;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboLoaiSanPham.Location = new Point(114, 29);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(106, 23);
            cboLoaiSanPham.TabIndex = 2;
            cboLoaiSanPham.Text = "Điện thoại";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 9F);
            btnThem.Location = new Point(111, 145);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 32);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(674, 26);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(72, 30);
            btnDoiAnh.TabIndex = 2;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.BackColor = SystemColors.Menu;
            txtMoTa.ForeColor = SystemColors.WindowFrame;
            txtMoTa.Location = new Point(111, 116);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(417, 23);
            txtMoTa.TabIndex = 1;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.BackColor = SystemColors.Menu;
            txtTenSanPham.ForeColor = SystemColors.WindowFrame;
            txtTenSanPham.Location = new Point(111, 87);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(417, 23);
            txtTenSanPham.TabIndex = 1;
            txtTenSanPham.Text = "iPhone 13";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 61);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Hãng sản xuất(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 120);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 0;
            label6.Text = "Mô tả sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 90);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 61);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 32);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 0;
            label4.Text = "Số lượng (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(2, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(927, 279);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(921, 257);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân Loại";
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Tên Hãng Sản Xuất";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 490);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDoiAnh;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private Label label6;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private PictureBox picHinhAnh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
    }
}