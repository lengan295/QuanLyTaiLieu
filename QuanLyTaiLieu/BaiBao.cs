using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTaiLieu
{
    public class BaiBao : TaiLieu
    {
        public BaiBao(TaiLieu tl)
        {
            this.MaTL = tl.MaTL;
            this.LoaiTaiLieu = tl.LoaiTaiLieu;
            this.TacGia = tl.TacGia;
            this.TieuDe = tl.TieuDe;
            this.TomTat = tl.TomTat;
            this.Nam = tl.Nam;
            this.GhiChu = tl.GhiChu;
            this.File = tl.File;
            this.URL = tl.URL;
            this.DOI = tl.DOI;
        }
        public string TapChi
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Trang
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Volume
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Issue
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
