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
    public partial class LienHe : Form
    {
        public LienHe()
        {
            InitializeComponent();
        }

        private void lbLinkGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/phihuynh100203/N14_QuanLyQuanCafe");
        }
    }
}
