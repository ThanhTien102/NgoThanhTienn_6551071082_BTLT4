namespace Bai1
{
    public partial class CafeStatusDemo : Form
    {
        public CafeStatusDemo()
        {
            InitializeComponent();
            timer1_Tick(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. Lấy giờ hiện tại gán vào nhãn
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            // 2. Lấy giờ hiện tại (gioHienTai) ép sang kiểu thời gian để so sánh
            TimeSpan gioHienTai = TimeSpan.Parse(lblGioHienTai.Text);

            // 3. Khai báo các mốc giờ mở cửa và đóng cửa
            TimeSpan gioMoCua = TimeSpan.Parse("06:00:00");
            TimeSpan gioDongCua = TimeSpan.Parse("22:00:00");

            // 4. So sánh trực tiếp giờ hiện tại với các mốc giờ
            if (gioHienTai >= gioMoCua && gioHienTai < gioDongCua)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đang đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Gán màu đã chọn cho nền của Form
                this.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
