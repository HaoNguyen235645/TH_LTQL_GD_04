using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public frmHoaDon(int id)
        {
            InitializeComponent();
            _id = id;


        }
        PrintDocument printDocument = new PrintDocument();
        int invoiceIdToPrint = -1;
        QLBHDbContext context = new QLBHDbContext();
        int id;
        private int _id;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon hoaDon = new frmHoaDon())
            {
                hoaDon.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon hoaDon = new frmHoaDon(id))
            {
                hoaDon.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon lsp = context.HoaDon.Find(id);
                if (lsp != null)
                {
                    context.HoaDon.Remove(lsp);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!");
                return;
            }

            invoiceIdToPrint = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 12);

            int y = 100;

            // Tiêu đề
            g.DrawString("HÓA ĐƠN BÁN HÀNG", fontTitle, Brushes.Black, 250, y);
            y += 50;

            // Lấy dữ liệu hóa đơn từ database
            // (Bạn thay bằng code lấy dữ liệu thật)
            string nhanVien = "Nguyễn Văn A";
            string khachHang = "Trần Thị B";
            string ngayLap = DateTime.Now.ToString("dd/MM/yyyy");
            string tongTien = "1,500,000 VNĐ";

            g.DrawString("Mã hóa đơn: " + invoiceIdToPrint, fontNormal, Brushes.Black, 100, y);
            y += 30;
            g.DrawString("Nhân viên: " + nhanVien, fontNormal, Brushes.Black, 100, y);
            y += 30;
            g.DrawString("Khách hàng: " + khachHang, fontNormal, Brushes.Black, 100, y);
            y += 30;
            g.DrawString("Ngày lập: " + ngayLap, fontNormal, Brushes.Black, 100, y);
            y += 30;
            g.DrawString("Tổng tiền: " + tongTien, fontNormal, Brushes.Black, 100, y);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel file (*.csv)|*.csv";
            save.FileName = "DanhSachHoaDon.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Ghi tiêu đề cột
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sb.Append(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();

                // Ghi dữ liệu
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (!dataGridView.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            sb.Append(dataGridView.Rows[i].Cells[j].Value?.ToString());
                            if (j < dataGridView.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.Unicode);

                MessageBox.Show("Xuất Excel thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = Interaction.InputBox(
        "Nhập tên khách hàng cần tìm:",
        "Tìm kiếm hóa đơn",
        "");

            if (string.IsNullOrEmpty(keyword))
                return;

            string query = "SELECT * FROM HoaDon WHERE TenKhachHang LIKE @keyword";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;
            }
        }
    }
}
