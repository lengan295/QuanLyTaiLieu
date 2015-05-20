using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiLieu
{
    public partial class frmThemTaiLieu : Form
    {
        public frmThemTaiLieu()
        {
            InitializeComponent();
        }

        private void btbOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa chọn danh mục tài liệu thuộc vê.");
        }

        private void cbbLoaiTL_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int index = cbbLoaiTL.SelectedIndex;
            frmThemTaiLieu_Load(sender, e);
            if (index == 1)
            {
                label2.Visible = false;
                txtTacgia.Visible = false;
            }
            if (index == 2)
            {
                frmThemTaiLieu_Load(sender, e);
            }
        }

        private void frmThemTaiLieu_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

       
    }
}
