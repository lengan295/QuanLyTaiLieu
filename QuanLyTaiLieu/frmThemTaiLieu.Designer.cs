namespace QuanLyTaiLieu
{
    partial class frmThemTaiLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btbCancel = new System.Windows.Forms.Button();
            this.btbOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checklistbox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.radiobtn2 = new System.Windows.Forms.RadioButton();
            this.txtTep = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.radiobtn1 = new System.Windows.Forms.RadioButton();
            this.txtTomtat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTapchi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTieude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNhomTG = new System.Windows.Forms.CheckBox();
            this.txtNhomTG = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoaiTL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btbCancel);
            this.tabPage1.Controls.Add(this.btbOk);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cbbLoaiTL);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm thủ công";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btbCancel
            // 
            this.btbCancel.Location = new System.Drawing.Point(297, 446);
            this.btbCancel.Name = "btbCancel";
            this.btbCancel.Size = new System.Drawing.Size(75, 23);
            this.btbCancel.TabIndex = 9;
            this.btbCancel.Text = "Cancel";
            this.btbCancel.UseVisualStyleBackColor = true;
            // 
            // btbOk
            // 
            this.btbOk.Location = new System.Drawing.Point(216, 446);
            this.btbOk.Name = "btbOk";
            this.btbOk.Size = new System.Drawing.Size(75, 23);
            this.btbOk.TabIndex = 8;
            this.btbOk.Text = "Ok";
            this.btbOk.UseVisualStyleBackColor = true;
            this.btbOk.Click += new System.EventHandler(this.btbOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.checklistbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.radiobtn2);
            this.groupBox1.Controls.Add(this.txtTep);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.radiobtn1);
            this.groupBox1.Controls.Add(this.txtTomtat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTrang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTapchi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTieude);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNhomTG);
            this.groupBox1.Controls.Add(this.txtNhomTG);
            this.groupBox1.Controls.Add(this.txtTacgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 398);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // checklistbox
            // 
            this.checklistbox.FormattingEnabled = true;
            this.checklistbox.Items.AddRange(new object[] {
            "Danh mục 1",
            "Danh mục 2",
            "Danh mục 3",
            "Danh mục 4"});
            this.checklistbox.Location = new System.Drawing.Point(87, 322);
            this.checklistbox.Name = "checklistbox";
            this.checklistbox.Size = new System.Drawing.Size(174, 64);
            this.checklistbox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Danh mục*";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(87, 290);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(174, 20);
            this.txtLink.TabIndex = 21;
            // 
            // radiobtn2
            // 
            this.radiobtn2.AutoSize = true;
            this.radiobtn2.Location = new System.Drawing.Point(9, 290);
            this.radiobtn2.Name = "radiobtn2";
            this.radiobtn2.Size = new System.Drawing.Size(45, 17);
            this.radiobtn2.TabIndex = 20;
            this.radiobtn2.TabStop = true;
            this.radiobtn2.Text = "Link";
            this.radiobtn2.UseVisualStyleBackColor = true;
            // 
            // txtTep
            // 
            this.txtTep.Location = new System.Drawing.Point(87, 264);
            this.txtTep.Name = "txtTep";
            this.txtTep.Size = new System.Drawing.Size(174, 20);
            this.txtTep.TabIndex = 19;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(267, 264);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 18;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // radiobtn1
            // 
            this.radiobtn1.AutoSize = true;
            this.radiobtn1.Location = new System.Drawing.Point(9, 264);
            this.radiobtn1.Name = "radiobtn1";
            this.radiobtn1.Size = new System.Drawing.Size(44, 17);
            this.radiobtn1.TabIndex = 17;
            this.radiobtn1.TabStop = true;
            this.radiobtn1.Text = "Tệp";
            this.radiobtn1.UseVisualStyleBackColor = true;
            // 
            // txtTomtat
            // 
            this.txtTomtat.Location = new System.Drawing.Point(87, 203);
            this.txtTomtat.Multiline = true;
            this.txtTomtat.Name = "txtTomtat";
            this.txtTomtat.Size = new System.Drawing.Size(256, 55);
            this.txtTomtat.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tóm tắt*";
            // 
            // txtTrang
            // 
            this.txtTrang.Location = new System.Drawing.Point(87, 177);
            this.txtTrang.Name = "txtTrang";
            this.txtTrang.Size = new System.Drawing.Size(256, 20);
            this.txtTrang.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trang*";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(87, 151);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(256, 20);
            this.txtSo.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số*";
            // 
            // txtTapchi
            // 
            this.txtTapchi.Location = new System.Drawing.Point(87, 126);
            this.txtTapchi.Name = "txtTapchi";
            this.txtTapchi.Size = new System.Drawing.Size(256, 20);
            this.txtTapchi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tạp chí*";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(87, 100);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(256, 20);
            this.txtNam.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm*";
            // 
            // txtTieude
            // 
            this.txtTieude.Location = new System.Drawing.Point(87, 74);
            this.txtTieude.Name = "txtTieude";
            this.txtTieude.Size = new System.Drawing.Size(256, 20);
            this.txtTieude.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiêu đề*";
            // 
            // cbNhomTG
            // 
            this.cbNhomTG.AutoSize = true;
            this.cbNhomTG.Location = new System.Drawing.Point(27, 50);
            this.cbNhomTG.Name = "cbNhomTG";
            this.cbNhomTG.Size = new System.Drawing.Size(89, 17);
            this.cbNhomTG.TabIndex = 4;
            this.cbNhomTG.Text = "Nhóm tác giả";
            this.cbNhomTG.UseVisualStyleBackColor = true;
            // 
            // txtNhomTG
            // 
            this.txtNhomTG.Location = new System.Drawing.Point(118, 48);
            this.txtNhomTG.Name = "txtNhomTG";
            this.txtNhomTG.Size = new System.Drawing.Size(225, 20);
            this.txtNhomTG.TabIndex = 3;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(87, 22);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(256, 20);
            this.txtTacgia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tác giả*";
            // 
            // cbbLoaiTL
            // 
            this.cbbLoaiTL.DisplayMember = "1";
            this.cbbLoaiTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTL.FormattingEnabled = true;
            this.cbbLoaiTL.Items.AddRange(new object[] {
            "Bài báo",
            "Sách",
            "Tạp chí"});
            this.cbbLoaiTL.Location = new System.Drawing.Point(130, 5);
            this.cbbLoaiTL.Name = "cbbLoaiTL";
            this.cbbLoaiTL.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiTL.Sorted = true;
            this.cbbLoaiTL.TabIndex = 6;
            this.cbbLoaiTL.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại tài liệu*";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm tự động";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmThemTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 509);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThemTaiLieu";
            this.Text = "Thêm thủ công";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btbCancel;
        private System.Windows.Forms.Button btbOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checklistbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton radiobtn2;
        private System.Windows.Forms.TextBox txtTep;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.RadioButton radiobtn1;
        private System.Windows.Forms.TextBox txtTomtat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTapchi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTieude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbNhomTG;
        private System.Windows.Forms.TextBox txtNhomTG;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoaiTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}