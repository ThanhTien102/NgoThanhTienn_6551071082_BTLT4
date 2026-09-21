namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;  // Thời gian tooltip hiển thị trước khi tự ẩn (5000ms = 5 giây)
            toolTip1.InitialDelay = 500;   // Thời gian chờ di chuột vào trước khi hiện (500ms = 0.5 giây)
            toolTip1.ReshowDelay = 100;    // Thời gian chờ hiện khi di chuyển chuột giữa các ô (100ms)
            toolTip1.ShowAlways = true;    // Luôn hiển thị tooltip ngay cả khi Form không Active
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nếu txtHoTen hoặc txtSDT bị rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Dừng chương trình, không chạy tiếp xuống dưới
            }

            // 2. Ngược lại (khi đã nhập đầy đủ), lấy dữ liệu từ các control
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Lấy gói tập từ ComboBox (nếu người dùng chưa chọn thì lấy text mặc định)
            string goiTap = cboGoiTap.SelectedItem != null ? cboGoiTap.SelectedItem.ToString() : cboGoiTap.Text;

            // Lấy số buổi/tuần từ NumericUpDown
            int soBuoi = (int)numSoBuoiTuan.Value;

            // 3. Tổng hợp thông tin vừa nhập thành chuỗi
            string thongTin = $"ĐĂNG KÝ HỘI VIÊN THÀNH CÔNG!\n\n" +
                              $"- Họ và tên: {hoTen}\n" +
                              $"- Số điện thoại: {sdt}\n" +
                              $"- Gói tập: {goiTap}\n" +
                              $"- Số buổi/tuần: {soBuoi} buổi";

            // 4. Hiển thị MessageBox tổng hợp thông tin
            MessageBox.Show(
                thongTin,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
