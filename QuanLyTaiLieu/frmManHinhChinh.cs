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

            button1.Image = global::QuanLyTaiLieu.Properties.Resources.add;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.TextAlign = ContentAlignment.BottomCenter;

            button2.Image = global::QuanLyTaiLieu.Properties.Resources.delete;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.TextAlign = ContentAlignment.BottomCenter;

            button3.Image = global::QuanLyTaiLieu.Properties.Resources.edi;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.TextAlign = ContentAlignment.BottomCenter;

            button4.Image = global::QuanLyTaiLieu.Properties.Resources.citation1;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.TextAlign = ContentAlignment.BottomCenter;

            button5.Image = global::QuanLyTaiLieu.Properties.Resources.Open;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.TextAlign = ContentAlignment.BottomCenter;

            listView1.Columns.Add("Tác giả",150);
            listView1.Columns.Add("Tiêu đề",300);            
            listView1.Columns.Add("Năm",50);

            //button1.Enabled = false;

            string[] arr = new string[4];
            ListViewItem itm;
            //add items to ListView
            arr[0] = "Phan Ngọc Quốc";
            arr[1] = "Tư duy thiên tài";
            arr[2] = "2014";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmXemThongTinTaiLieu frm = new frmXemThongTinTaiLieu();
            frm.Show();
        }
    }
}
