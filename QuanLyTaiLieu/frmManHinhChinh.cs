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
            listView1.Columns.Add("Tác giả",150);
            listView1.Columns.Add("Tiêu đề",300);            
            listView1.Columns.Add("Năm",50);


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
