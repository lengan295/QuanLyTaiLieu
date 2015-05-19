using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTaiLieu
{
    public class DanhMuc
    {
        public DanhMuc(int MaDM, string TenDM)
        {
            // TODO: Complete member initialization
            this.MaDM = MaDM;
            this.TenDanhMuc = TenDM;
        }
        public int MaDM
        {
            get;
            set;
        }

        public string TenDanhMuc
        {
            get;
            set;
        }

        public int DSTaiLieu
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int DSDanhMucCon
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void TaoDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void CapNhatDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void XoaDanhMuc()
        {
            throw new System.NotImplementedException();
        }

        public void ThongTin()
        {
            throw new System.NotImplementedException();
        }

        public void SoLuongTaiLieu()
        {
            throw new System.NotImplementedException();
        }
    }
}
