using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmBenhNhan : Form
    {
        private List<string> dsBenhNhan = new List<string>();

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra họ tên không được để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // 2. Định dạng thông tin bệnh nhân thành chuỗi
            string thongTinBN = $"{txtHoTen.Text.Trim()} - {nudTuoi.Value} tuổi - Triệu chứng: {txtTrieuChung.Text.Trim()}";

            // 3. Lưu vào biến thành viên List<string>
            dsBenhNhan.Add(thongTinBN);

            // 4. Cập nhật hiển thị lên ListBox
            lstBenhNhan.Items.Add(thongTinBN);

            // 5. Xóa/Reset ô nhập để tiếp tục nhập bệnh nhân tiếp theo
            txtHoTen.Clear();
            nudTuoi.Value = 0;
            txtTrieuChung.Clear();
            txtHoTen.Focus();
        }
    }
}
