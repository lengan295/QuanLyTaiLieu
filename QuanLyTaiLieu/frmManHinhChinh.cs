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

            
        }
    }
}
