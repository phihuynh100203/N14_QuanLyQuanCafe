
namespace LTCSDL
{
    partial class DangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btDN);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Controls.Add(this.lbMK);
            this.panel1.Controls.Add(this.lbTenDN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 485);
            this.panel1.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(159)))));
            this.btThoat.Location = new System.Drawing.Point(681, 331);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(211, 73);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDN
            // 
            this.btDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(159)))));
            this.btDN.Location = new System.Drawing.Point(419, 331);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(211, 73);
            this.btDN.TabIndex = 5;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = false;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(657, 229);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(285, 39);
            this.txtMK.TabIndex = 4;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(657, 145);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(285, 39);
            this.txtTenDN.TabIndex = 3;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(136)))), ((int)(((byte)(175)))));
            this.lbMK.Location = new System.Drawing.Point(412, 231);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(167, 37);
            this.lbMK.TabIndex = 2;
            this.lbMK.Text = "Mật khẩu:";
            // 
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(136)))), ((int)(((byte)(175)))));
            this.lbTenDN.Location = new System.Drawing.Point(394, 145);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(258, 37);
            this.lbTenDN.TabIndex = 1;
            this.lbTenDN.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.lbDangNhap);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 93);
            this.panel2.TabIndex = 0;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.DeepPink;
            this.lbDangNhap.Location = new System.Drawing.Point(349, 20);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(293, 52);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(952, 486);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btThoat;
    }
}

