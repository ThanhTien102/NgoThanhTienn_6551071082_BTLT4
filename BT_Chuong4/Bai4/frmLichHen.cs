using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmLichHen : Form
    {
        private List<string> dsLichHen = new List<string>();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return;
            }

            // Tạo chuỗi thông tin lịch hẹn
            string thongTin = $"{txtTenBenhNhan.Text.Trim()} - Lịch hẹn: {dtpNgayGio.Value:dd/MM/yyyy HH:mm}";

            // Lưu vào biến List<string> và đưa lên ListBox
            dsLichHen.Add(thongTin);
            lstLichHen.Items.Add(thongTin);

            // Reset ô nhập
            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
