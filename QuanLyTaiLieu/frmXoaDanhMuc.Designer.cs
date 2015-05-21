namespace QuanLyTaiLieu
{
    partial class frmXoaDanhMuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.radio_Xoahet = new System.Windows.Forms.RadioButton();
            this.radio_Giulai = new System.Windows.Forms.RadioButton();
            this.radio_ChuyenDenDanhMuc = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn muốn ?";
            // 
            // radio_Xoahet
            // 
            this.radio_Xoahet.AutoSize = true;
            this.radio_Xoahet.Location = new System.Drawing.Point(73, 47);
            this.radio_Xoahet.Name = "radio_Xoahet";
            this.radio_Xoahet.Size = new System.Drawing.Size(62, 17);
            this.radio_Xoahet.TabIndex = 1;
            this.radio_Xoahet.TabStop = true;
            this.radio_Xoahet.Text = "Xóa hết";
            this.radio_Xoahet.UseVisualStyleBackColor = true;
            // 
            // radio_Giulai
            // 
            this.radio_Giulai.AutoSize = true;
            this.radio_Giulai.Location = new System.Drawing.Point(73, 71);
            this.radio_Giulai.Name = "radio_Giulai";
            this.radio_Giulai.Size = new System.Drawing.Size(54, 17);
            this.radio_Giulai.TabIndex = 2;
            this.radio_Giulai.TabStop = true;
            this.radio_Giulai.Text = "Giữ lại";
            this.radio_Giulai.UseVisualStyleBackColor = true;
            // 
            // radio_ChuyenDenDanhMuc
            // 
            this.radio_ChuyenDenDanhMuc.AutoSize = true;
            this.radio_ChuyenDenDanhMuc.Location = new System.Drawing.Point(73, 95);
            this.radio_ChuyenDenDanhMuc.Name = "radio_ChuyenDenDanhMuc";
            this.radio_ChuyenDenDanhMuc.Size = new System.Drawing.Size(145, 17);
            this.radio_ChuyenDenDanhMuc.TabIndex = 3;
            this.radio_ChuyenDenDanhMuc.TabStop = true;
            this.radio_ChuyenDenDanhMuc.Text = "Di chuyển đến danh mục";
            this.radio_ChuyenDenDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(73, 145);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(199, 144);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // frmXoaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 185);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radio_ChuyenDenDanhMuc);
            this.Controls.Add(this.radio_Giulai);
            this.Controls.Add(this.radio_Xoahet);
            this.Controls.Add(this.label1);
            this.Name = "frmXoaDanhMuc";
            this.Text = "frmXoaDanhMuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Xoahet;
        private System.Windows.Forms.RadioButton radio_Giulai;
        private System.Windows.Forms.RadioButton radio_ChuyenDenDanhMuc;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}