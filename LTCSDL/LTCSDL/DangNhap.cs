using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCSDL
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDN_Click(object sender, EventArgs e)
        {
            QuanLyQuanCafe  f = new QuanLyQuanCafe ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
            {
                e.Cancel = true;  
            }

        }
    }
}
