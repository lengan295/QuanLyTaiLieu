using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiLieu
{
    public partial class frmThemTaiLieu : Form
    {
        int index = 0;
        DBController dbcon = new DBController();
        public frmThemTaiLieu()
        {
            InitializeComponent();
            
            List<DanhMuc> list = dbcon.getAllDanhMuc();
            foreach (DanhMuc dm in list)
            {
                ListBoxItem item = new ListBoxItem();
                item.Tag = dm;
                item.Text = dm.TenDanhMuc;
                checklistbox.Items.Add(item);
            }
            cbbLoaiTL.SelectedIndex = 0;
            checklistbox.CheckOnClick = true;
        }

        private void btbOk_Click(object sender, EventArgs e)
        {
            int n;
            if (index < 0) MessageBox.Show("Chưa chọn loại tài liệu.");
            else if (txtTacgia.Text == "") MessageBox.Show("Chưa nhập tên tác giả.");
            else if (txtTieude.Text == "") MessageBox.Show("Chưa nhập tiêu đề.");
            else if (txtNam.Text == "") MessageBox.Show("Chưa nhập năm.");
            //else if (txtDOI.Text == "") MessageBox.Show("Chưa nhập chỉ số DOI.");
            //else if (txtTomtat.Text == "") MessageBox.Show("Chưa nhập tóm tắt tài liệu.");
            else if (txtTacgia.Text.Length > 500) MessageBox.Show("Textbox Tác giả có giá trị maxlengt là [500] xin hãy input lại.");
            else if (txtTieude.Text.Length > 250) MessageBox.Show("Textbox Tiêu đề có giá trị maxlengt là [250] xin hãy input lại.");
            else if (txtDOI.Text.Length > 50) MessageBox.Show("Textbox DOI có giá trị maxlengt là [50] xin hãy input lại.");
            //else if (txtTomtat.Text.Length > 200) MessageBox.Show("Textbox Tóm tắt có giá trị maxlengt là [200] xin hãy input lại.");
            else if (Int32.TryParse(txtNam.Text, out n) == false) MessageBox.Show("Năm phải là số.");
            else if (n < 0 || n > 2015) MessageBox.Show("Năm nằm ngoài phạm vi cho phép (0000-2015).");
            //else if (radiobtn1.Checked == true && txtTep.Text == "") MessageBox.Show("Chưa nhập đường dẫn của tệp tài liệu.");
            //else if (radiobtn2.Checked == true && txtLink.Text == "") MessageBox.Show("Chưa nhập Link web chứa tài liệu.");
            else if (checklistbox.CheckedItems.Count == 0) MessageBox.Show("Chưa chọn các Danh mục chứa tài liệu.");
            else
            {
                TaiLieu tl = new TaiLieu();
                tl.TacGia = txtTacgia.Text;
                tl.TieuDe = txtTieude.Text;
                tl.Nam = int.Parse(txtNam.Text);
                tl.DOI = txtDOI.Text;
                tl.TomTat = txtTomtat.Text;
                tl.File = txtTep.Text;
                tl.URL = txtLink.Text;
                List<DanhMuc> listDM = new List<DanhMuc>();
                foreach (ListBoxItem item in checklistbox.CheckedItems)
                {
                    listDM.Add((DanhMuc)item.Tag);
                }
                switch (index)
                {
                    case 0:
                        tl.LoaiTaiLieu = "article";
                        BaiBao bb = new BaiBao(tl);
                        bb.TapChi = txtTapchi.Text;
                        bb.Trang = txtTrang.Text;
                        bb.Volume = int.Parse(txtVolume.Text);
                        bb.Issue = int.Parse(txtIssue.Text);
                        dbcon.addBaiBao(bb, listDM);
                        break;
                    case 1:
                        tl.LoaiTaiLieu = "inproceedings";
                        Proceedings pr = new Proceedings(tl);
                        pr.TenHoiNghi = txtTenhoinghi.Text;
                        pr.ThanhPho = txtThanhpho.Text;
                        dbcon.addProceeding(pr, listDM);
                        break;
                    case 2:
                        tl.LoaiTaiLieu = "book";
                        Sach sh = new Sach(tl);
                        sh.NhaXB = txtNXB.Text;
                        sh.TaiBan = txtTaiban.Text;
                        sh.ThanhPho = txtThanhpho.Text;
                        dbcon.addSach(sh, listDM);
                        break;
                    case 3:
                        tl.LoaiTaiLieu = "misc";
                        TrangWeb web = new TrangWeb(tl);
                        web.ToChuc = txttochuc.Text;
                        web.Ngay = int.Parse(txtngay.Text);
                        web.Thang = int.Parse(txtthang.Text);
                        web.NgayTruyCap = DateTime.Parse(txtngaytruycap.Text);
                        dbcon.addTrangWeb(web, listDM);
                        break;
                    default:
                        break;
                }
                this.Dispose();
            }
            
        }

        private void cbbLoaiTL_SelectedIndexChanged(object sender, EventArgs e)
        {   
            index = cbbLoaiTL.SelectedIndex;
            if (index == 0)
            {
                lbtapchi.Visible = true;
                lbtrang.Visible = true;
                lbvolume.Visible = true;
                lbissue.Visible = true;
                txtTapchi.Visible = true;
                txtTrang.Visible = true;
                txtVolume.Visible = true;
                txtIssue.Visible = true;

                lbtochuc.Visible = false;
                lbngay.Visible = false;
                lbthang.Visible = false;
                lbngaytruycap.Visible = false;
                txttochuc.Visible = false;
                txtngay.Visible = false;
                txtthang.Visible = false;
                txtngaytruycap.Visible = false;

                lbtenhoinghi.Visible = false;
                lbthanhpho.Visible = false;
                txtTenhoinghi.Visible = false;
                txtThanhpho.Visible = false;

                lbnxb.Visible = false;
                lbtaiban.Visible = false;
                txtNXB.Visible = false;
                txtTaiban.Visible = false;
            }
            if (index == 1)
            {
                lbtapchi.Visible = false;
                lbtrang.Visible = false;
                lbvolume.Visible = false;
                lbissue.Visible = false;
                txtTapchi.Visible = false;
                txtTrang.Visible = false;
                txtVolume.Visible = false;
                txtIssue.Visible = false;

                lbtochuc.Visible = false;
                lbngay.Visible = false;
                lbthang.Visible = false;
                lbngaytruycap.Visible = false;
                txttochuc.Visible = false;
                txtngay.Visible = false;
                txtthang.Visible = false;
                txtngaytruycap.Visible = false;

                lbtenhoinghi.Visible = true;
                lbthanhpho.Visible = true;
                txtTenhoinghi.Visible = true;
                txtThanhpho.Visible = true;

                lbnxb.Visible = false;
                lbtaiban.Visible = false;
                txtNXB.Visible = false;
                txtTaiban.Visible = false;
            }
            if (index == 2)
            {
                lbtapchi.Visible = false;
                lbtrang.Visible = false;
                lbvolume.Visible = false;
                lbissue.Visible = false;
                txtTapchi.Visible = false;
                txtTrang.Visible = false;
                txtVolume.Visible = false;
                txtIssue.Visible = false;

                lbtochuc.Visible = false;
                lbngay.Visible = false;
                lbthang.Visible = false;
                lbngaytruycap.Visible = false;
                txttochuc.Visible = false;
                txtngay.Visible = false;
                txtthang.Visible = false;
                txtngaytruycap.Visible = false;

                lbtenhoinghi.Visible = false;
                lbthanhpho.Visible = true;
                txtTenhoinghi.Visible = false;
                txtThanhpho.Visible = true;

                lbnxb.Visible = true;
                lbtaiban.Visible = true;
                txtNXB.Visible = true;
                txtTaiban.Visible = true;
            }
            if (index == 3)
            {
                lbtapchi.Visible = false;
                lbtrang.Visible = false;
                lbvolume.Visible = false;
                lbissue.Visible = false;
                txtTapchi.Visible = false;
                txtTrang.Visible = false;
                txtVolume.Visible = false;
                txtIssue.Visible = false;

                lbtochuc.Visible = true;
                lbngay.Visible = true;
                lbthang.Visible = true;
                lbngaytruycap.Visible = true;
                txttochuc.Visible = true;
                txtngay.Visible = true;
                txtthang.Visible = true;
                txtngaytruycap.Visible = true;

                lbtenhoinghi.Visible = false;
                lbthanhpho.Visible = false;
                txtTenhoinghi.Visible = false;
                txtThanhpho.Visible = false;

                lbnxb.Visible = false;
                lbtaiban.Visible = false;
                txtNXB.Visible = false;
                txtTaiban.Visible = false;
            }
        }

        private void frmThemTaiLieu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            txtTep.Text = openFileDialog1.FileName;
        }

        /*private void cbNhomTG_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNhomTG.Checked == true)
            {
                txtTacgia.Enabled = false;
                txtNhomTG.Enabled = true;
            }
            else
            {
                txtNhomTG.Enabled = false;
                txtTacgia.Enabled = true;
            }
        }*/

        private void radiobtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn1.Checked == true)
            {
                txtTep.Enabled = true;
                btnBrowser.Enabled = true;
                txtLink.Enabled = false;
            }
            else 
            {
                txtTep.Enabled = false;
                btnBrowser.Enabled = false;
                txtLink.Enabled = true;
            }

        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTomtat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Auto_Click(object sender, EventArgs e)
        {
            bool success = true;
            string loaitailieu = "";
            
            if (txtURL_Auto.Text == "")
                MessageBox.Show("Chưa nhập vào URL");
            else
            {
                string recordIds = "";
                Match match = Regex.Match(txtURL_Auto.Text, @"arnumber=([\d]+)", RegexOptions.IgnoreCase);
                if (match.Success)
                    recordIds = match.Groups[1].Value;
                else
                {
                    MessageBox.Show("Chương trỉnh không hỗ trợ URL này.");
                    return;
                }
                WebClient client = new WebClient();                
               

                string bibTex = client.DownloadString("http://ieeexplore.ieee.org/xpl/downloadCitations?recordIds="+recordIds+"&citations-format=citation-abstract&download-format=download-bibtex");
                
                //loai tai lieu
                match = Regex.Match(bibTex, "@([\\w]+){", RegexOptions.IgnoreCase);
                if (match.Success)
                    loaitailieu = match.Groups[1].Value;

                //tieu de
                match = Regex.Match(bibTex, "\\stitle={(.*)}", RegexOptions.IgnoreCase);
                if (match.Success)
                    txtTieude.Text = match.Groups[1].Value;
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình trích xuất thông tin.");
                    return;
                }

                //tac gia
                match = Regex.Match(bibTex, "author={(.*)}", RegexOptions.IgnoreCase);
                if (match.Success)
                    txtTacgia.Text = match.Groups[1].Value;

                //nam
                match = Regex.Match(bibTex, "year={(.*)}", RegexOptions.IgnoreCase);
                if (match.Success)
                    txtNam.Text = match.Groups[1].Value;

                //tom tat
                match = Regex.Match(bibTex, "abstract={(.*)}", RegexOptions.IgnoreCase);
                if (match.Success)
                    txtTomtat.Text = match.Groups[1].Value;

                //doi
                match = Regex.Match(bibTex, "doi={(.*)}", RegexOptions.IgnoreCase);
                if (match.Success)
                    txtDOI.Text = match.Groups[1].Value;

                switch (loaitailieu)
                {
                    case "ARTICLE":
                        cbbLoaiTL.SelectedIndex = 0;

                        //tap chi
                        match = Regex.Match(bibTex, "journal={(.*)}", RegexOptions.IgnoreCase);
                        if (match.Success)
                            txtTapchi.Text = match.Groups[1].Value;

                        //Volume
                        match = Regex.Match(bibTex, "volume={(.*)}", RegexOptions.IgnoreCase);
                        if (match.Success)
                            txtVolume.Text = match.Groups[1].Value;

                        //Issue
                        match = Regex.Match(bibTex, "number={(.*)}", RegexOptions.IgnoreCase);
                        if (match.Success)
                            txtIssue.Text = match.Groups[1].Value;

                        //Trang
                        match = Regex.Match(bibTex, "pages={(.*)}", RegexOptions.IgnoreCase);
                        if (match.Success)
                            txtTrang.Text = match.Groups[1].Value;
                        break;
                    case "INPROCEEDINGS":
                        cbbLoaiTL.SelectedIndex = 1;

                        //ten hoi nghi
                        match = Regex.Match(bibTex, "booktitle={(.*)}", RegexOptions.IgnoreCase);
                        if (match.Success)
                            txtTenhoinghi.Text = match.Groups[1].Value;
                        
                        break;
                    default:
                        cbbLoaiTL.SelectedIndex = 0;
                        break;
                }

                /*string html_content = client.DownloadString(txtURL_Auto.Text);
                
               //rtb_Content.Text = html_content;
               // tomtat
               Match match = Regex.Match(html_content, "<div class=\"article\">([\\s]*)<p>(.*)</p>([\\s]*)</div>", RegexOptions.IgnoreCase);
               if (match.Success)
                   txtTomtat.Text = match.Groups[2].Value;

               //tieude
               match = Regex.Match(html_content, "<h1>([\\s]*)(.*)([\\s]*)</h1>", RegexOptions.IgnoreCase);
               if (match.Success)
                  txtTieude.Text = match.Groups[2].Value;

               //match = Regex.Match(html_content, "<dt>DOI:</dt>([\\s]*)(.*)([\\s]*)</h1>", RegexOptions.IgnoreCase);
               */
                tabPage1.Show();
            }
        }

       
    }
}
