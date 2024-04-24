using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LTCSDL.Properties.Resources;

namespace LTCSDL
{
    public partial class ThongTinQuan : Form
    {
        public ThongTinQuan()
        {
            InitializeComponent();
        }

        //private void ThongTinQuan_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string message = ThongTin();
        //        if (message.Length > 0)
        //        {
        //            MessageBox.Show(message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        //            goto TheEnd;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        goto TheEnd;
        //    }

        //TheEnd:
        //    return;
        //}
        //private string ThongTin()
        //{
        //    string message = "";
        //    try
        //    {
        //        DataTable dt = DbThongTin.GetInfoStore();
        //        if (dt == null)
        //        {
        //            message = DbThongTin.Message;
        //            goto TheEnd;
        //        }

        //        DataRow dr = dt.Rows[0];
        //        lbTenQuan.Tag = (long)dr["maThongTin"];
        //        txtTenQuan.Text = (string)dr["maThongTin"];
        //        txtDiaChi.Text = (string)dr["diaChiQuan"];
        //        txtSĐT.Text = (string)dr["soDTQuan"];
        //        txtMaThue.Text = (string)dr["maThue"];
        //    }
        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //        goto TheEnd;
        //    }
        //TheEnd:
        //    return message;
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnXacNhan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtTenQuan.Text == "")
        //        {
                   
        //            MessageBox.Show("Tên cửa hàng không được để trống", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            goto TheEnd;
        //        }

        //        DbStoreOut dbStoreOut = new DbStoreOut();
        //        dbStoreOut.Id = long.Parse(lbTenQuan.Tag.ToString());
        //        dbStoreOut.NameStore = txtTenQuan.Text;
        //        dbStoreOut.AddressStore = txtDiaChi.Text;
        //        dbStoreOut.PhoneStore = txtSĐT.Text;
        //        dbStoreOut.TaxCode = txtMaThue.Text;

        //        int Update = DbStore.UpdateStore(dbStoreOut);
        //        if (Update < 1)
        //        {
        //            MessageBox.Show(DbStore.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            goto TheEnd;
        //        }

        //        MessageBox.Show(DbStore.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        DialogResult = DialogResult.OK;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        goto TheEnd;
        //    }

        //TheEnd:
        //    return;
        
        // }
    }
}
