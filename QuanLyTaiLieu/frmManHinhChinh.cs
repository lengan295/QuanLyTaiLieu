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
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
            listView1.Columns.Add("Tiêu đề");
            listView1.Columns.Add("Tác giả");
            listView1.Columns.Add("Năm");

            ListViewItem tdtt = new ListViewItem("Tư Duy Thiên Tài");
            ListViewItem.ListViewSubItem tg = new ListViewItem.ListViewSubItem(tdtt, "Phan Ngọc Quốc");
            ListViewItem.ListViewSubItem na = new ListViewItem.ListViewSubItem(tdtt, "2014");
            tdtt.SubItems.Add(tg);
            tdtt.SubItems.Add(na);
            listView1.Items.Add(tdtt);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmXemThongTinTaiLieu frm = new frmXemThongTinTaiLieu();
            frm.Show();
        }
    }
}
