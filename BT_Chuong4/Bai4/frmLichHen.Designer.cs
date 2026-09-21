namespace Bai4
{
    partial class frmLichHen
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
            dtpNgayGio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtTenBenhNhan = new TextBox();
            button1 = new Button();
            lstLichHen = new ListBox();
            SuspendLayout();
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(216, 52);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(408, 27);
            dtpNgayGio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 57);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Giờ hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 129);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên bệnh nhân:";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(216, 126);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(408, 27);
            txtTenBenhNhan.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(324, 199);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Đặt lịch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(216, 249);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(380, 164);
            lstLichHen.TabIndex = 5;
            lstLichHen.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLichHen);
            Controls.Add(button1);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgayGio);
            Name = "frmLichHen";
            Text = "frmLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGio;
        private Label label1;
        private Label label2;
        private TextBox txtTenBenhNhan;
        private Button button1;
        private ListBox lstLichHen;
    }
}