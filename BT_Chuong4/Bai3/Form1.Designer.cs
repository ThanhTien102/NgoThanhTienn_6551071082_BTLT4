namespace Bai3
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
            label1 = new Label();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            đánhDấuHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            xóaCôngViệcNàyToolStripMenuItem = new ToolStripMenuItem();
            xóaTấtCảToolStripMenuItem = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 104);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Công Việc";
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(230, 101);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(291, 27);
            txtCongViecMoi.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(309, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 48);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = DockStyle.Bottom;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(0, 146);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(728, 304);
            lstCongViec.TabIndex = 3;
            lstCongViec.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { đánhDấuHoànThànhToolStripMenuItem, xóaCôngViệcNàyToolStripMenuItem, xóaTấtCảToolStripMenuItem });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            // 
            // đánhDấuHoànThànhToolStripMenuItem
            // 
            đánhDấuHoànThànhToolStripMenuItem.Name = "đánhDấuHoànThànhToolStripMenuItem";
            đánhDấuHoànThànhToolStripMenuItem.Size = new Size(220, 24);
            đánhDấuHoànThànhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            đánhDấuHoànThànhToolStripMenuItem.Click += đánhDấuHoànThànhToolStripMenuItem_Click;
            // 
            // xóaCôngViệcNàyToolStripMenuItem
            // 
            xóaCôngViệcNàyToolStripMenuItem.Name = "xóaCôngViệcNàyToolStripMenuItem";
            xóaCôngViệcNàyToolStripMenuItem.Size = new Size(220, 24);
            xóaCôngViệcNàyToolStripMenuItem.Text = "Xóa công việc này";
            xóaCôngViệcNàyToolStripMenuItem.Click += xóaCôngViệcNàyToolStripMenuItem_Click;
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            xóaTấtCảToolStripMenuItem.Size = new Size(220, 24);
            xóaTấtCảToolStripMenuItem.Text = "Xóa tất cả";
            xóaTấtCảToolStripMenuItem.Click += xóaTấtCảToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem đánhDấuHoànThànhToolStripMenuItem;
        private ToolStripMenuItem xóaCôngViệcNàyToolStripMenuItem;
        private ToolStripMenuItem xóaTấtCảToolStripMenuItem;
    }
}
