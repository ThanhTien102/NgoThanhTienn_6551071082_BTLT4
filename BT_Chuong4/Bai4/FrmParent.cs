namespace Bai4
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenhNhan f = new frmBenhNhan();
            f.MdiParent = this; // Gán MdiParent là FrmParent hiện tại[cite: 2]
            f.Show();
        }

        private void đặtLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen f = new frmLichHen();
            f.MdiParent = this; // Gán MdiParent là FrmParent hiện tại[cite: 2]
            f.Show();
        }
    }
}
