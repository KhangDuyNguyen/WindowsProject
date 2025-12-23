using Bussiness;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmPhongTro : Form
    {
        private PhongTroService _service;

        public frmPhongTro()
        {
            InitializeComponent();
            _service = new PhongTroService();
        }

        // Sự kiện khi Form vừa mở lên
        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            LoadData();
            

		}

        // Hàm tải dữ liệu lên lưới
        private void LoadData()
        {
            dgvPhongTro.DataSource = _service.GetAllPhong();

            // Đổi tên cột cho đẹp (Optional)
            if (dgvPhongTro.Columns["TenPhong"] != null)
                dgvPhongTro.Columns["TenPhong"].HeaderText = "Tên Phòng";
            if (dgvPhongTro.Columns["GiaPhong"] != null)
                dgvPhongTro.Columns["GiaPhong"].HeaderText = "Giá Tiền";
            if (dgvPhongTro.Columns["DienTich"] != null)
                dgvPhongTro.Columns["DienTich"].HeaderText = "Diện Tích";

            if (dgvPhongTro.Columns["Gia"] != null)
                dgvPhongTro.Columns["Gia"].HeaderText = "Giá";

            if (dgvPhongTro.Columns["TrangThai"] != null)
                dgvPhongTro.Columns["TrangThai"].HeaderText = "Trạng Thái";

            if (dgvPhongTro.Columns["MoTa"] != null)
        
                dgvPhongTro.Columns["MoTa"].HeaderText = "Mô Tả";
			dgvPhongTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}

        // Sự kiện Click vào dòng trong Grid -> Đổ dữ liệu ngược lên ô nhập
        private void dgvPhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhongTro.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                numDienTich.Value = Convert.ToDecimal(row.Cells["DienTich"].Value);
                numGiaPhong.Value = Convert.ToDecimal(row.Cells["GiaPhong"].Value);
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Xử lý trạng thái (0: Trống, 1: Đã thuê)
                int trangThai = Convert.ToInt32(row.Cells["TrangThai"].Value);
                cbTrangThai.SelectedIndex = (trangThai == 0) ? 0 : 1;
            }
        }

        // Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                PhongTro p = GetPhongFromUI();
                if (_service.InsertPhong(p))
                {
                    MessageBox.Show("Thêm phòng thành công!");
                    LoadData();
                    ResetInput();
                }
                else MessageBox.Show("Lỗi khi thêm!");
            }
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (CheckInput())
            {
                PhongTro p = GetPhongFromUI();
                p.MaPhong = int.Parse(txtMaPhong.Text); // Lấy ID để update

                if (_service.UpdatePhong(p))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    ResetInput();
                }
            }
        }

        // Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int maPhong = int.Parse(txtMaPhong.Text);
                    if (_service.DeletePhong(maPhong))
                    {
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        ResetInput();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa phòng đang có người thuê!\n" + ex.Message);
                }
            }
        }

        // Nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        // --- CÁC HÀM HỖ TRỢ ---

        // Lấy thông tin từ UI đóng gói thành Object
        private PhongTro GetPhongFromUI()
        {
            return new PhongTro()
            {
                TenPhong = txtTenPhong.Text,
                DienTich = (double)numDienTich.Value,
                GiaPhong = numGiaPhong.Value,
                MoTa = txtMoTa.Text,
        
                TrangThai = cbTrangThai.SelectedIndex
            };
        }

        // Kiểm tra dữ liệu nhập vào
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                MessageBox.Show("Chưa nhập tên phòng!");
                txtTenPhong.Focus();
                return false;
            }
            if (numGiaPhong.Value <= 0)
            {
                MessageBox.Show("Giá phòng phải lớn hơn 0!");
                return false;
            }
            return true;
        }

        // Xóa trắng các ô nhập
        private void ResetInput()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            numDienTich.Value = 0;
            numGiaPhong.Value = 0;
            txtMoTa.Clear();
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!CheckInput()) return;

           
            PhongTro p = GetPhongFromUI();

            
            if (_service.InsertPhong(p))
            {
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); 
                ResetInput(); 
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckInput()) return;

            // Lấy thông tin mới
            PhongTro p = GetPhongFromUI();
            p.MaPhong = int.Parse(txtMaPhong.Text); // QUAN TRỌNG: Phải gán Mã Phòng để biết sửa dòng nào

            if (_service.UpdatePhong(p))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                LoadData();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Cảnh báo");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                try
                {
                    int maPhong = int.Parse(txtMaPhong.Text);
                    if (_service.DeletePhong(maPhong))
                    {
                        MessageBox.Show("Đã xóa phòng!");
                        LoadData();
                        ResetInput();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại (Có thể ID không tồn tại)!");
                    }
                }
                catch (Exception ex)
                {
                   // lỗi này kiểu cái dòng muốn xóa nó đang dính với cái bảng khác nên hông xóa được
                    MessageBox.Show("Không thể xóa phòng này vì đang có Hợp Đồng hoặc dữ liệu liên quan!\n\nChi tiết: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
       
    }
}
