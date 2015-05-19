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
        private DBController dbcon = new DBController();
        List<DanhMuc> listDM;
        List<TaiLieu> listTL;

        public frmManHinhChinh()
        {
            InitializeComponent();

            InitializeButtons();
            toolStripStatusLabel1.Text = "";
            
            if (dbcon.error != "")
                toolStripStatusLabel1.Text = dbcon.error;
            else
            {

                listDM = dbcon.getAllDanhMuc();
                listTL = dbcon.getAllTaiLieu();

                UpdateCatalogueTree();
                UpdateListTaiLieu();
            }

            #region Lam tum bay

            //buttons
            /*
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_citation.Enabled = false;
            btn_Edit.Enabled = false;
            btn_OpenDoc.Enabled = false;
            
            
           

            
            //button1.Enabled = false;
            
            string[] arr = new string[4];
            ListViewItem itm;
            //add items to ListView
            arr[0] = "Wayne F. Robinson";
            arr[1] = "Clinicopathologic Principles For Veterinary Medicine";
            arr[2] = "1988";
            itm = new ListViewItem(arr);
            list_Docs.Items.Add(itm);

            arr[0] = "Nguyễn Văn Triều Dâng";
            arr[1] = "Ứng dụng web ngữ vào phân tích trực tuyến";
            arr[2] = "2006";
            itm = new ListViewItem(arr);
            list_Docs.Items.Add(itm);

            arr[0] = "Martin Abadi";
            arr[1] = "Explicit Communication Revisited: Two New Attacks on Authentication Protocols";
            arr[2] = "1997";
            itm = new ListViewItem(arr);
            list_Docs.Items.Add(itm);

            arr[0] = "Phan Ngọc Quốc";
            arr[1] = "Tư duy thiên tài";
            arr[2] = "2014";
            itm = new ListViewItem(arr);
            list_Docs.Items.Add(itm);

            //tom tat
            
            rich_Sumary.Text = "SSH and AKA are recent, practical protocols for secure connections over an otherwise unprotected network. This paper shows that, despite the use of public-key cryptography, SSH and AKA do not provide authentication as intended. The flaws of SSH and AKA can be viewed as the result of their disregarding a basic principle for the design of sound authentication protocols: the principle that messages should be explicit. 1 Introduction SSH and AKA are two recent, practical protocols for secure connections over an otherwise unprotected network";

            //add items to treeView
            /*
            TreeNode[] subNodes = new TreeNode[3];
            subNodes[0] = new TreeNode("Danh mục 1 (4)");
            subNodes[1] = new TreeNode("Danh mục 2 (2)");
            subNodes[2] = new TreeNode("Danh mục 3 (0)");
            TreeNode node = new TreeNode("Chủ đề 1", subNodes);
            tree_catalogue.Nodes.Add(node);

            node = new TreeNode("Danh mục 4 (0)");
            tree_catalogue.Nodes.Add(node);*/
            #endregion

            tree_catalogue.ExpandAll();
            list_Docs.FullRowSelect = true;       
        }

        private void UpdateListTaiLieu()
        {
            list_Docs.Columns.Add("Tác giả", 150);
            list_Docs.Columns.Add("Tiêu đề", 300);
            list_Docs.Columns.Add("Năm", 50);

            string[] arr = new string[4];
            ListViewItem itm;

            //add items to ListView
            foreach(TaiLieu tl in listTL)
            {
                arr[0] = tl.TacGia;
                arr[1] = tl.TieuDe;
                arr[2] = tl.Nam.ToString();
                itm = new ListViewItem(arr);
                list_Docs.Items.Add(itm);
            }
            //toolStripStatusLabel1.Text = dbcon.error;
        }

        private void UpdateCatalogueTree()
        {
            foreach (DanhMuc dm in listDM)
            {
                TreeNode node = new TreeNode(dm.TenDanhMuc);
                
                tree_catalogue.Nodes.Add(node);
                //tree_catalogue.
            }
        }

        private void InitializeButtons()
        {
            btn_Add.Image = global::QuanLyTaiLieu.Properties.Resources.add;
            btn_Add.ImageAlign = ContentAlignment.TopCenter;
            btn_Add.TextAlign = ContentAlignment.BottomCenter;

            btn_Delete.Image = global::QuanLyTaiLieu.Properties.Resources.delete;
            btn_Delete.ImageAlign = ContentAlignment.TopCenter;
            btn_Delete.TextAlign = ContentAlignment.BottomCenter;

            btn_Edit.Image = global::QuanLyTaiLieu.Properties.Resources.edi;
            btn_Edit.ImageAlign = ContentAlignment.TopCenter;
            btn_Edit.TextAlign = ContentAlignment.BottomCenter;

            btn_citation.Image = global::QuanLyTaiLieu.Properties.Resources.citation1;
            btn_citation.ImageAlign = ContentAlignment.TopCenter;
            btn_citation.TextAlign = ContentAlignment.BottomCenter;

            btn_OpenDoc.Image = global::QuanLyTaiLieu.Properties.Resources.Open;
            btn_OpenDoc.ImageAlign = ContentAlignment.TopCenter;
            btn_OpenDoc.TextAlign = ContentAlignment.BottomCenter;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmXemThongTinTaiLieu frm = new frmXemThongTinTaiLieu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemTaiLieu frm = new frmThemTaiLieu();
            frm.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn xóa (những) tài liệu này không?","Xác nhận", MessageBoxButtons.YesNo);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frmCapNhat frm = new frmCapNhat();
            frm.ShowDialog();
        }

        private void btn_citation_Click(object sender, EventArgs e)
        {
            frmTrichDanNhieu frm = new frmTrichDanNhieu();
            frm.ShowDialog();
        }

        private void btn_OpenDoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không tìm thấy tệp tin");
        }
    }
}
