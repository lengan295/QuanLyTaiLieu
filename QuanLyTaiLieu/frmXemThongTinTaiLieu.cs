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
    public partial class frmXemThongTinTaiLieu : Form
    {
        public frmXemThongTinTaiLieu()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_Ghichu.Text.Length >= 1000)
                MessageBox.Show("Textbox Note ghi chú có giá trị maxlengt là [1000] xin hãy input lại");
            else
                MessageBox.Show("Đã lưu vào database");
        }

        private void btn_Mo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Trichdan_Click(object sender, EventArgs e)
        {
            frmTrichDanNhieu frm = new frmTrichDanNhieu();
            frm.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string message = "Bạn thật sự muốn xóa?";
            string caption = "Thông báo xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Đã xóa!", "Thông báo xác nhận", MessageBoxButtons.OK);
            }
        }
    }
}
