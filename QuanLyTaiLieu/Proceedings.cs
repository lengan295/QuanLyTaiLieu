using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTaiLieu
{
    public class Proceedings : TaiLieu
    {
        public Proceedings(TaiLieu tl)
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
        public string TenHoiNghi
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string ThanhPho
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
