namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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
            labDanhSachHangSanXuat = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            labTenlHangSanXuat = new Label();
            txtTenHangSanXuat = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(3, 158);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(794, 278);
            dataGridView.TabIndex = 8;
            // 
            // grBoxThongtinloaisanpham
            // 
            grBoxThongtinloaisanpham.Controls.Add(labDanhSachHangSanXuat);
            grBoxThongtinloaisanpham.Controls.Add(dataGridView);
            grBoxThongtinloaisanpham.Controls.Add(btnThoat);
            grBoxThongtinloaisanpham.Controls.Add(btnHuyBo);
            grBoxThongtinloaisanpham.Controls.Add(btnLuu);
            grBoxThongtinloaisanpham.Controls.Add(btnXoa);
            grBoxThongtinloaisanpham.Controls.Add(btnSua);
            grBoxThongtinloaisanpham.Controls.Add(btnThem);
            grBoxThongtinloaisanpham.Controls.Add(labTenlHangSanXuat);
            grBoxThongtinloaisanpham.Controls.Add(txtTenHangSanXuat);
            grBoxThongtinloaisanpham.Location = new Point(0, 6);
            grBoxThongtinloaisanpham.Name = "grBoxThongtinloaisanpham";
            grBoxThongtinloaisanpham.Size = new Size(800, 439);
            grBoxThongtinloaisanpham.TabIndex = 1;
            grBoxThongtinloaisanpham.TabStop = false;
            grBoxThongtinloaisanpham.Text = "Thông tin loại sản phẩm";
            // 
            // labDanhSachHangSanXuat
            // 
            labDanhSachHangSanXuat.AutoSize = true;
            labDanhSachHangSanXuat.Location = new Point(11, 140);
            labDanhSachHangSanXuat.Name = "labDanhSachHangSanXuat";
            labDanhSachHangSanXuat.Size = new Size(144, 15);
            labDanhSachHangSanXuat.TabIndex = 9;
            labDanhSachHangSanXuat.Text = "Danh Sách Hãng Sản Xuất";
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
            // labTenlHangSanXuat
            // 
            labTenlHangSanXuat.AutoSize = true;
            labTenlHangSanXuat.Location = new Point(24, 52);
            labTenlHangSanXuat.Name = "labTenlHangSanXuat";
            labTenlHangSanXuat.Size = new Size(125, 15);
            labTenlHangSanXuat.TabIndex = 1;
            labTenlHangSanXuat.Text = "Tên Hãng Sản Xuất (*):";
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(177, 38);
            txtTenHangSanXuat.Multiline = true;
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(596, 41);
            txtTenHangSanXuat.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Tên Hãng Sản Xuất";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grBoxThongtinloaisanpham);
            Name = "frmHangSanXuat";
            Text = "frmHangSanXuat";
            Load += frmHangSanXuat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxThongtinloaisanpham.ResumeLayout(false);
            grBoxThongtinloaisanpham.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox grBoxThongtinloaisanpham;
        private Label labDanhSachHangSanXuat;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label labTenlHangSanXuat;
        private TextBox txtTenHangSanXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
    }
}