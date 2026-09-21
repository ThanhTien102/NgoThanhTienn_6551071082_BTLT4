namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                // Add nội dung vào lstCongViec.Items[cite: 1]
                lstCongViec.Items.Add(txtCongViecMoi.Text.Trim());

                // Clear ô nhập[cite: 1]
                txtCongViecMoi.Clear();

                // Đưa con trỏ chuột quay lại ô nhập để tiếp tục nhập việc mới
                txtCongViecMoi.Focus();
            }
        }

        private void đánhDấuHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                int selectedIndex = lstCongViec.SelectedIndex;
                string currentText = lstCongViec.SelectedItem.ToString();
                string prefix = "[Hoàn thành] ";

                // Kiểm tra nếu chưa có tiền tố "[Hoàn thành] "
                if (!currentText.StartsWith(prefix))
                {
                    // Cập nhật lại item bằng cách chèn thêm tiền tố vào đầu chuỗi
                    lstCongViec.Items[selectedIndex] = prefix + currentText;
                }
            }
        }

        private void xóaCôngViệcNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                // Nếu chưa chọn item nào thì hiển thị MessageBox nhắc chọn trước khi xóa
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xóaTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
        "Bạn có chắc chắn muốn xóa toàn bộ công việc không?",
        "Xác nhận xóa tất cả",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            // Nếu Yes thì gọi lstCongViec.Items.Clear()[cite: 1]
            if (dialog == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
