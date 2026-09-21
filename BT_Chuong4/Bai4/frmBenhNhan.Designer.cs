namespace Bai4
{
    partial class frmBenhNhan
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
            txtHoTen = new TextBox();
            label1 = new Label();
            nudTuoi = new NumericUpDown();
            label2 = new Label();
            txtTrieuChung = new TextBox();
            label3 = new Label();
            button1 = new Button();
            lstBenhNhan = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudTuoi).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(204, 81);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(316, 27);
            txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 81);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ Tên: ";
            // 
            // nudTuoi
            // 
            nudTuoi.Location = new Point(204, 142);
            nudTuoi.Name = "nudTuoi";
            nudTuoi.Size = new Size(316, 27);
            nudTuoi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 144);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Tuổi: ";
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(204, 199);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(316, 27);
            txtTrieuChung.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 202);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Triệu chứng:";
            // 
            // button1
            // 
            button1.Location = new Point(269, 315);
            button1.Name = "button1";
            button1.Size = new Size(141, 39);
            button1.TabIndex = 6;
            button1.Text = "Lưu Tạm";
            button1.UseVisualStyleBackColor = true;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(454, 254);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(319, 184);
            lstBenhNhan.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBenhNhan);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtTrieuChung);
            Controls.Add(label2);
            Controls.Add(nudTuoi);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            ((System.ComponentModel.ISupportInitialize)nudTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private NumericUpDown nudTuoi;
        private Label label2;
        private TextBox txtTrieuChung;
        private Label label3;
        private Button button1;
        private ListBox lstBenhNhan;
    }
}