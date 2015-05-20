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
        private TaiLieu tl;
        private DBController dbcon = new DBController();

        public frmXemThongTinTaiLieu()
        {
            InitializeComponent();    
        }

        public frmXemThongTinTaiLieu(TaiLieu tl)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            
        }

        public frmXemThongTinTaiLieu(TaiLieu tl)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.tl = tl;
            txt_Xemthongtin.ReadOnly = true;
            txt_Xemthongtin.Enabled = true;
            String loaitailieu = tl.LoaiTaiLieu;
            String thongtin = "Tác giả: " + tl.TacGia + "\nTiêu đề: " + tl.TieuDe + "\nNăm: " + tl.Nam;
            switch (loaitailieu)
            {
                case "article":
                    {
                        BaiBao bb = dbcon.getBaiBao(tl);
                        thongtin = thongtin + "\nLoại tài liệu: Bài báo \nTạp chí: " + bb.TapChi + "Trang: " + bb.Trang + "\nVolume: " + bb.Volume + "\nIssue: " + bb.Issue;
                    }
                    break;
                case "book":
                    {
                        Sach bb = dbcon.getSach(tl);
                        thongtin = thongtin + "\nLoại tài liệu: Sách \nNhà xuất bản: " + bb.NhaXB + "\nTái bản: " + bb.TaiBan + "\nThành phố: " + bb.ThanhPho;
                    }
                    break;
                case "inproceedings":
                    {
                        Proceedings bb = dbcon.getProceeding(tl);
                        thongtin = thongtin + "\nLoại tài liệu: Proceeding \nHội nghị: " + bb.TenHoiNghi + "\nThành phố: " + bb.ThanhPho;
                    }
                    break;
                case "misc":
                    {
                        TrangWeb bb = dbcon.getTrangWeb(tl);
                        thongtin = thongtin + "\nLoại tài liệu: Web \nTổ chức: " + bb.ToChuc + "\nNgày: " + bb.Ngay + "\\" + bb.Thang + "\nNgày truy cập: " + bb.NgayTruyCap;
                    }
                    break;
            }
            txt_Xemthongtin.Text = thongtin;
            if (tl.GhiChu != null)
                txt_Ghichu.Text = tl.GhiChu;
            if (tl.TomTat != null)
                txt_Xemtruoc.Text = tl.TomTat;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_Ghichu.Text.Length >= 1000)
                MessageBox.Show("Textbox Note ghi chú có giá trị maxlengt là [1000] xin hãy input lại");
            else
            {

            }
        }

        private void btn_Mo_Click(object sender, EventArgs e)
        {
            String path;
            if (tl.LoaiTaiLieu == "misc")
                path = tl.URL;
            else
                path = tl.File;
            try
            {
                System.Diagnostics.Process myProc = new System.Diagnostics.Process();
                myProc.EnableRaisingEvents = false;
                myProc.StartInfo = new System.Diagnostics.ProcessStartInfo(path);
                myProc.Start();
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
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

        private void txt_Xemtruoc_TextChanged(object sender, EventArgs e)
        {
            if (txt_Xemtruoc.Text.Length >= 5000)
                MessageBox.Show("Textbox Xem Trước có giá trị maxlengt là [5000] xin hãy cập nhật lại");
        }

        private void txt_Xemthongtin_TextChanged(object sender, EventArgs e)
        {
            if (txt_Xemthongtin.Text.Length >= 200)
                MessageBox.Show("Textbox \"Thông Tin Tài Liệu\" có giá trị maxlengt là [200] xin hãy cập nhật lại dữ liệu");
        }
    }
}
