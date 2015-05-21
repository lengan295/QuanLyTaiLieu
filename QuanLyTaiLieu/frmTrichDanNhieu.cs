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
    public partial class frmTrichDanNhieu : Form

       


    {
        private DBController dbcon = new DBController();
        List<DanhMuc> listDM;
        List<TaiLieu> listTL;

        public frmTrichDanNhieu()
        {
            InitializeComponent();

            list_Docs.Columns.Add("Tác giả", 150);
            list_Docs.Columns.Add("Tiêu đề", 300);
            list_Docs.Columns.Add("Năm", 50);

            listDM = dbcon.getCayDanhMuc();
            listTL = dbcon.getAllTaiLieu();

            UpdateCatalogueTree();
            UpdateListTaiLieu();

            tree_catalogue.NodeMouseClick += tree_catalogue_NodeMouseClick;
            list_Docs.MouseDoubleClick += list_Docs_MouseDoubleClick;
           // list_Docs.SelectedIndexChanged += list_Docs_SelectedIndexChanged;

            tree_catalogue.ExpandAll();
            list_Docs.FullRowSelect = true;
        }

        /*void list_Docs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Docs.SelectedItems.Count > 0)
            {
                TaiLieu tl = (TaiLieu)list_Docs.SelectedItems[0].Tag;
                rich_Sumary.Text = tl.TomTat; 
            }
        }*/

        private void tree_catalogue_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DanhMuc dm = (DanhMuc) e.Node.Tag;
            listTL = dbcon.getTaiLieuByDanhMuc(dm);
            UpdateListTaiLieu();
        }

        void list_Docs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaiLieu tl = (TaiLieu) list_Docs.SelectedItems[0].Tag;
            String td;
            if (comboBox1.SelectedIndex == 0)
            {
                td = TrichDanHarvard(tl);
                richTextBox1.Text += td + "\n";
            }
        }

        

       /* private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmXemThongTinTaiLieu frm = new frmXemThongTinTaiLieu();
            frm.Show();
        }*/

      

     

        

        private void UpdateListTaiLieu()
        {
            string[] arr = new string[4];
            ListViewItem itm;
            list_Docs.Items.Clear();
            //add items to ListView
            foreach (TaiLieu tl in listTL)
            {
                arr[0] = tl.TacGia;
                arr[1] = tl.TieuDe;
                arr[2] = tl.Nam.ToString();
                itm = new ListViewItem(arr);
                itm.Tag = tl;
                list_Docs.Items.Add(itm);
            }
            //toolStripStatusLabel1.Text = dbcon.error;
        }

        private void UpdateCatalogueTree()
        {
            foreach (DanhMuc dm in listDM)
            {
                TreeNode node = new TreeNode(dm.TenDanhMuc);
                node.Tag = dm;
                tree_catalogue.Nodes.Add(node);
                if (dm.DSDanhMucCon.Count>0)
                {
                    foreach (DanhMuc dmcon in dm.DSDanhMucCon)
                    {
                        TreeNode childnode = new TreeNode(dmcon.TenDanhMuc);
                        childnode.Tag = dmcon;
                        node.Nodes.Add(childnode);
                    }
                }
            }
        }

        private String TrichDanHarvard(TaiLieu tl)
        {
            String s;
            if(tl.LoaiTaiLieu.Trim()=="book")
            {
                Sach book = new Sach(tl);
                s = book.TacGia+". "+book.TieuDe;
                if(book.Nam!=0)
                    s+=", "+book.Nam;
                if(book.NhaXB!="")
                    s+=" , NXB "+book.NhaXB;
                if(book.ThanhPho!="")
                    s+=", "+book.ThanhPho;
                               
                s+=".";
            }
            else if(tl.LoaiTaiLieu.Trim()=="article")
            {
                BaiBao article = new BaiBao(tl);
                s = article.TacGia+", "+article.TieuDe;
                if(article.TapChi!="")
                    s +=", "+ article.TapChi;
                if(article.Nam!=0)
                    s+=", "+article.Nam;
                if(article.Volume!=0)
                    s+=", volume "+article.Volume;
                if(article.Issue!=0)
                    s+=", issue "+article.Issue;
                if(article.Trang!=0)
                    s+="trang "+ article.Trang;
                s+=".";
            }
            else if(tl.LoaiTaiLieu.Trim()=="misc")
            {
                TrangWeb misc = new TrangWeb(tl);
                s = misc.TacGia+", "+misc.TieuDe;
                if(misc.Ngay!=0)
                    s +=", "+ misc.Ngay;
                if(misc.Thang!=0)
                    s+="."+misc.Thang;
                if(misc.Nam!=0)
                    s+="."+ misc.Nam;
                
                if(misc.NgayTruyCap!=0)
                    s+=".Truy cập ngày "+misc.NgayTruyCap+")";
                if(misc.URL!="")
                    s+= " từ "+misc.URL;
                s+=".";

            }
            else if (tl.LoaiTaiLieu.Trim() == "inproceedings")
            {
                Proceedings inproceedings = new Proceedings(tl);
                s = inproceedings.TacGia+", "+inproceedings.TieuDe;
                if(inproceedings.TenHoiNghi!="")
                    s +=", "+ inproceedings.TenHoiNghi;
                if(inproceedings.ThanhPho)
                    s+= ", " + inproceedings.ThanhPho;
                if(inproceedings.Nam!=0)
                    s+=", "+inproceedings.Nam;
                s+=".";

            }
            return s;
           
                        
        }

        private TrichDanChicago(TaiLieu tl)
        {
            String s;
            if(tl.LoaiTaiLieu.Trim()=="book")
            {
                Sach book = new Sach(tl);
                s = book.TacGia+". "+book.TieuDe;
                if(book.ThanhPho!="")
                    s+=". "+book.ThanhPho;
                if(book.NhaXB!="")
                    s+=" : NXB "+book.NhaXB;
                if(book.Nam!=0)
                    s+=", "+book.Nam;
                s+=".";
            }
            else if(tl.LoaiTaiLieu.Trim()=="article")
            {
                BaiBao article = new BaiBao(tl);
                s = article.TacGia+". "+article.TieuDe;
                if(article.TapChi!="")
                    s +=", "+ article.TapChi;
                if(article.Nam!=0)
                    s+=", "+article.Nam;
                if(article.Trang!=0)
                    s+=":"+ article.Trang;
                s+=".";
            }
            else if(tl.LoaiTaiLieu.Trim()=="misc")
            {
                TrangWeb misc = new TrangWeb(tl);
                s = misc.TacGia+". "+misc.TieuDe;
                if(misc.Ngay!=0)
                    s +=". "+ misc.Ngay;
                if(misc.Thang!=0)
                    s+="."+misc.Thang;
                if(misc.Nam!=0)
                    s+="."+ misc.Nam;
                if(misc.URL!="")
                    s+= ". "+misc.URL;
                if(misc.NgayTruyCap!=0)
                    s+=". (truy cập ngày "+misc.NgayTruyCap+")";
                s+=".";

            }
            else if (tl.LoaiTaiLieu.Trim() == "inproceedings")
            {
                Proceedings inproceedings = new Proceedings(tl);
                s = inproceedings.TacGia+". "+inproceedings.TieuDe;
                if(inproceedings.TenHoiNghi!="")
                    s +=". "+ inproceedings.TenHoiNghi;
                if(inproceedings.ThanhPho)
                    s+= ". " + inproceedings.ThanhPho;
                if(inproceedings.Nam!=0)
                    s+=", "+inproceedings.Nam;
                s+=".";

            }
            return s;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            MessageBox.Show("Đã copy phần trích dẫn");
        }
    }
}
