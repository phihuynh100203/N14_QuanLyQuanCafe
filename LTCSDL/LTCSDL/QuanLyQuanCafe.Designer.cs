
namespace LTCSDL
{
    partial class QuanLyQuanCafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstHoaDon = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmSLNuoc = new System.Windows.Forms.NumericUpDown();
            this.btnThemNuoc = new System.Windows.Forms.Button();
            this.cbNuoc = new System.Windows.Forms.ComboBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.flbBan = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSLNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiToolStripMenuItem
            // 
            this.thôngTinTàiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiToolStripMenuItem.Name = "thôngTinTàiToolStripMenuItem";
            this.thôngTinTàiToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngTinTàiToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstHoaDon);
            this.panel2.Location = new System.Drawing.Point(599, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 310);
            this.panel2.TabIndex = 2;
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.HideSelection = false;
            this.lstHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(453, 304);
            this.lstHoaDon.TabIndex = 0;
            this.lstHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.nmGiamGia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(599, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 129);
            this.panel3.TabIndex = 3;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(4, 76);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(133, 33);
            this.cbChuyenBan.TabIndex = 4;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(4, 16);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(133, 54);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Location = new System.Drawing.Point(159, 76);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(133, 26);
            this.nmGiamGia.TabIndex = 4;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(159, 16);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(133, 54);
            this.btnGiamGia.TabIndex = 5;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(312, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(133, 86);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmSLNuoc);
            this.panel4.Controls.Add(this.btnThemNuoc);
            this.panel4.Controls.Add(this.cbNuoc);
            this.panel4.Controls.Add(this.cbDanhMuc);
            this.panel4.Location = new System.Drawing.Point(599, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 100);
            this.panel4.TabIndex = 4;
            // 
            // nmSLNuoc
            // 
            this.nmSLNuoc.Location = new System.Drawing.Point(390, 28);
            this.nmSLNuoc.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSLNuoc.Name = "nmSLNuoc";
            this.nmSLNuoc.Size = new System.Drawing.Size(66, 26);
            this.nmSLNuoc.TabIndex = 3;
            this.nmSLNuoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemNuoc
            // 
            this.btnThemNuoc.Location = new System.Drawing.Point(263, 4);
            this.btnThemNuoc.Name = "btnThemNuoc";
            this.btnThemNuoc.Size = new System.Drawing.Size(120, 72);
            this.btnThemNuoc.TabIndex = 2;
            this.btnThemNuoc.Text = "Thêm nước";
            this.btnThemNuoc.UseVisualStyleBackColor = true;
            // 
            // cbNuoc
            // 
            this.cbNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNuoc.FormattingEnabled = true;
            this.cbNuoc.Location = new System.Drawing.Point(4, 43);
            this.cbNuoc.Name = "cbNuoc";
            this.cbNuoc.Size = new System.Drawing.Size(253, 33);
            this.cbNuoc.TabIndex = 1;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(4, 4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(253, 33);
            this.cbDanhMuc.TabIndex = 0;
            // 
            // flbBan
            // 
            this.flbBan.Location = new System.Drawing.Point(12, 50);
            this.flbBan.Name = "flbBan";
            this.flbBan.Size = new System.Drawing.Size(581, 548);
            this.flbBan.TabIndex = 5;
            // 
            // QuanLyQuanCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 622);
            this.Controls.Add(this.flbBan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyQuanCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmSLNuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbNuoc;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Button btnThemNuoc;
        private System.Windows.Forms.NumericUpDown nmSLNuoc;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flbBan;
    }
}