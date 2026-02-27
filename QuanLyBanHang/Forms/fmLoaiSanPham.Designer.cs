namespace QuanLyBanHang.Forms
{
    partial class fmLoaiSanPham
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
            dataGridView = new DataGridView();
            grBoxThongtinloaisanpham = new GroupBox();
            labDanhSachLoaiSanPham = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            labTenloaisanpham = new Label();
            txtTenLoai = new TextBox();
            MaSP = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxThongtinloaisanpham.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenLoai });
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(3, 158);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(794, 278);
            dataGridView.TabIndex = 8;
            // 
            // grBoxThongtinloaisanpham
            // 
            grBoxThongtinloaisanpham.Controls.Add(labDanhSachLoaiSanPham);
            grBoxThongtinloaisanpham.Controls.Add(dataGridView);
            grBoxThongtinloaisanpham.Controls.Add(btnThoat);
            grBoxThongtinloaisanpham.Controls.Add(btnHuyBo);
            grBoxThongtinloaisanpham.Controls.Add(btnLuu);
            grBoxThongtinloaisanpham.Controls.Add(btnXoa);
            grBoxThongtinloaisanpham.Controls.Add(btnSua);
            grBoxThongtinloaisanpham.Controls.Add(btnThem);
            grBoxThongtinloaisanpham.Controls.Add(labTenloaisanpham);
            grBoxThongtinloaisanpham.Controls.Add(txtTenLoai);
            grBoxThongtinloaisanpham.Location = new Point(0, 6);
            grBoxThongtinloaisanpham.Name = "grBoxThongtinloaisanpham";
            grBoxThongtinloaisanpham.Size = new Size(800, 439);
            grBoxThongtinloaisanpham.TabIndex = 1;
            grBoxThongtinloaisanpham.TabStop = false;
            grBoxThongtinloaisanpham.Text = "Thông tin loại sản phẩm";
            // 
            // labDanhSachLoaiSanPham
            // 
            labDanhSachLoaiSanPham.AutoSize = true;
            labDanhSachLoaiSanPham.Location = new Point(11, 140);
            labDanhSachLoaiSanPham.Name = "labDanhSachLoaiSanPham";
            labDanhSachLoaiSanPham.Size = new Size(169, 15);
            labDanhSachLoaiSanPham.TabIndex = 9;
            labDanhSachLoaiSanPham.Text = "Danh Sách Các Loại Sản Phẩm";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(662, 92);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(91, 32);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(565, 92);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(91, 32);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(468, 92);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(91, 32);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(371, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(274, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 32);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(177, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 32);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // labTenloaisanpham
            // 
            labTenloaisanpham.AutoSize = true;
            labTenloaisanpham.Location = new Point(24, 52);
            labTenloaisanpham.Name = "labTenloaisanpham";
            labTenloaisanpham.Size = new Size(130, 15);
            labTenloaisanpham.TabIndex = 1;
            labTenloaisanpham.Text = "Tên Loại Sản Phẩm (*):";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(177, 38);
            txtTenLoai.Multiline = true;
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(596, 41);
            txtTenLoai.TabIndex = 0;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã Sản Phẩm";
            MaSP.Name = "MaSP";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên Loại Sản Phẩm";
            TenLoai.Name = "TenLoai";
            // 
            // fmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grBoxThongtinloaisanpham);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fmLoaiSanPham";
            Text = "fmLoaiSanPham";
            Load += fmLoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxThongtinloaisanpham.ResumeLayout(false);
            grBoxThongtinloaisanpham.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox grBoxThongtinloaisanpham;
        private Label labDanhSachLoaiSanPham;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label labTenloaisanpham;
        private TextBox txtTenLoai;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenLoai;
    }
}