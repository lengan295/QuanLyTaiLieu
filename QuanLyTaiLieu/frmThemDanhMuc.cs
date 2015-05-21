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
    public partial class frmThemDanhMuc : Form
    {
        public frmThemDanhMuc()
        {
            InitializeComponent();
        }

        public frmThemDanhMuc(List<DanhMuc> listdm)
        {
            InitializeComponent();

            ListBoxItem item = new ListBoxItem();
            item.Text = "<None>";
            item.Tag = null;
            cbbDMCha.Items.Add(item);
            foreach (DanhMuc dm in listdm)
            {
                item = new ListBoxItem();
                item.Text = dm.TenDanhMuc;
                item.Tag = dm;
                cbbDMCha.Items.Add(item);
            }
            cbbDMCha.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDM.Text == "")
            {
                MessageBox.Show("Chưa nhập tên Danh mục");
            }
            else
            {
                DanhMuc dm = new DanhMuc();
                dm.TenDanhMuc = txtTenDM.Text;
                if (((ListBoxItem)cbbDMCha.SelectedItem).Tag != null)
                    dm.DMCha = (DanhMuc)((ListBoxItem)cbbDMCha.SelectedItem).Tag;
                DBController dbcon = new DBController();
                dbcon.addDanhMuc(dm);
                this.Dispose();
            }
        }
    }
}
