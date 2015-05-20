﻿using System;
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
    public partial class frmThemTaiLieu : Form
    {
        int index = -1;
        public frmThemTaiLieu()
        {
            InitializeComponent();
        }

        private void btbOk_Click(object sender, EventArgs e)
        {
            int n;
            if (index < 0) MessageBox.Show("Chưa chọn loại tài liệu.");
            else
                if (txtTacgia.Text == "") MessageBox.Show("Chưa nhập tên tác giả.");
            else
                if (txtTieude.Text == "") MessageBox.Show("Chưa nhập tiêu đề.");
            else
                if (txtNam.Text == "") MessageBox.Show("Chưa nhập năm.");
            else
                if (txtDOI.Text == "") MessageBox.Show("Chưa nhập chỉ số DOI.");
            else
                if (txtTomtat.Text == "") MessageBox.Show("Chưa nhập tóm tắt tài liệu.");
            else
                if (txtTacgia.Text.Length > 50) MessageBox.Show("Textbox Tác giả có giá trị maxlengt là [50] xin hãy input lại.");
            else
                if (txtTieude.Text.Length > 200) MessageBox.Show("Textbox Tiêu đề có giá trị maxlengt là [200] xin hãy input lại.");
            else
                if (txtDOI.Text.Length > 50) MessageBox.Show("Textbox DOI có giá trị maxlengt là [50] xin hãy input lại.");
            else
                if (txtTomtat.Text.Length > 200) MessageBox.Show("Textbox Tóm tắt có giá trị maxlengt là [200] xin hãy input lại.");
            else
                if (Int32.TryParse(txtNam.Text, out n) == false) MessageBox.Show("Năm phải là số.");
            else
                if (n < 0 || n > 2015) MessageBox.Show("Năm nằm ngoài phạm vi cho phép (0000-2015).");
            else
                if (radiobtn1.Checked == true && txtTep.Text == "") MessageBox.Show("Chưa nhập đường dẫn thư mục nơi sẽ lưu tài liệu.");
            else
                if (radiobtn2.Checked == true && txtLink.Text == "") MessageBox.Show("Chưa nhập Link web chứa tài liệu.");
            
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

        private void cbNhomTG_CheckedChanged(object sender, EventArgs e)
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
        }

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

       
    }
}
