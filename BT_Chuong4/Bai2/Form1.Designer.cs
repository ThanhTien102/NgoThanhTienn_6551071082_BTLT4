namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl5 = new Label();
            label7 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            cboGoiTap = new ComboBox();
            dtpNgaySinh = new Label();
            numSoBuoiTuan = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(197, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(276, 27);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(197, 92);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(276, 27);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(83, 53);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(56, 20);
            lbl1.TabIndex = 3;
            lbl1.Text = "Họ Tên";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(83, 95);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(102, 20);
            lbl2.TabIndex = 4;
            lbl2.Text = "Số Điện Thoại";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(83, 141);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(46, 20);
            lbl3.TabIndex = 5;
            lbl3.Text = "Email";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(83, 241);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(85, 20);
            lbl5.TabIndex = 8;
            lbl5.Text = "Combo Gói";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 288);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 9;
            label7.Text = "Số buổi tập";
            // 
            // button1
            // 
            button1.Location = new Point(243, 357);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(196, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP ", "Premium" });
            cboGoiTap.Location = new Point(196, 233);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(151, 28);
            cboGoiTap.TabIndex = 12;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.AutoSize = true;
            dtpNgaySinh.Location = new Point(83, 192);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(76, 20);
            dtpNgaySinh.TabIndex = 13;
            dtpNgaySinh.Text = "Ngày Sinh";
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(197, 286);
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(150, 27);
            numSoBuoiTuan.TabIndex = 14;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cboGoiTap);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(lbl5);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label DateTimePicker;
    
        private Label lbl5;
        private Label label7;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboGoiTap;
        private Label dtpNgaySinh;
        private NumericUpDown numSoBuoiTuan;
        private ToolTip toolTip1;
    }
}
