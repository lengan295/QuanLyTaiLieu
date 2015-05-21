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

                list_Docs.Columns.Add("Tác giả", 150);
                list_Docs.Columns.Add("Tiêu đề", 300);
                list_Docs.Columns.Add("Năm", 50);

                listDM = dbcon.getCayDanhMuc();
                listTL = dbcon.getAllTaiLieu();

                UpdateCatalogueTree();
                UpdateListTaiLieu();

                tree_catalogue.NodeMouseClick += tree_catalogue_NodeMouseClick;
                list_Docs.MouseDoubleClick += list_Docs_MouseDoubleClick;
                list_Docs.SelectedIndexChanged += list_Docs_SelectedIndexChanged;
            }

            #region Lam tum bay

            //buttons
            /*
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_citation.Enabled = false;
            btn_Edit.Enabled = false;
            btn_OpenDoc.Enabled = false;
            
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

        void list_Docs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Docs.SelectedItems.Count > 0)
            {
                TaiLieu tl = (TaiLieu)list_Docs.SelectedItems[0].Tag;
                rich_Sumary.Text = tl.TomTat; 
            }
        }

        private void tree_catalogue_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DanhMuc dm = (DanhMuc) e.Node.Tag;
            listTL = dbcon.getTaiLieuByDanhMuc(dm);
            UpdateListTaiLieu();
        }

        void list_Docs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaiLieu tl = (TaiLieu) list_Docs.SelectedItems[0].Tag;
            frmXemThongTinTaiLieu frm = new frmXemThongTinTaiLieu(tl);
            frm.Show();
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
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa (những) tài liệu này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ListViewItem item in list_Docs.SelectedItems)
                {
                    TaiLieu tl = (TaiLieu)item.Tag;
                    dbcon.deleteTaiLieu(tl);
                    listTL.Remove(tl);
                    UpdateListTaiLieu();
                }
            }
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
    }
}
