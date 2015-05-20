using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiLieu
{
    class DBController
    {
        private SqlConnection myConnection;
        SqlCommand myCommand = new SqlCommand();
        public  string error { get; set; }

        public DBController()
        {
            string ConnectionString = @"Data Source=NGANPC\SQLEXPRESS;Initial Catalog=QLTL;Integrated Security=True";
            myConnection = new SqlConnection(ConnectionString);
            try
            {
                myConnection.Open();
                this.error = "";
                this.myCommand.Connection = myConnection;
            }
            catch(Exception e)
            {
                this.error = "Không thể kết nối CSDL";
            }
        }

        public List<DanhMuc> getAllDanhMuc()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            myCommand.CommandText = "SELECT * FROM DanhMuc";
            try
            {
                SqlDataReader myReader = null;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int MaDM = int.Parse(myReader["MaDM"].ToString());
                    string TenDM = myReader["TenDanhMuc"].ToString();
                    DanhMuc dm = new DanhMuc(MaDM, TenDM);
                    list.Add(dm);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                this.error = e.ToString();
            }
            
            return list;
        }

        public List<TaiLieu> getAllTaiLieu()
        {
            List<TaiLieu> list = new List<TaiLieu>();
            myCommand.CommandText = "SELECT * FROM TaiLieu";
            try
            {
                SqlDataReader myReader = null;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TaiLieu tmp = new TaiLieu();
                    tmp.MaTL = int.Parse(myReader["MaTL"].ToString());
                    tmp.LoaiTaiLieu = myReader["LoaiTaiLieu"].ToString();
                    tmp.TacGia = myReader["TacGia"].ToString();
                    tmp.TieuDe = myReader["TieuDe"].ToString();
                    tmp.Nam = int.Parse(myReader["Nam"].ToString());
                    tmp.TomTat = myReader["TomTat"].ToString();
                    tmp.GhiChu = myReader["GhiChu"].ToString();
                    tmp.File = myReader["File"].ToString();
                    tmp.URL = myReader["URL"].ToString();
                    tmp.DOI = myReader["DOI"].ToString();
                    list.Add(tmp);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                this.error = e.ToString();
            }

            return list;
        }

        public List<TaiLieu> getTaiLieuByDanhMuc(DanhMuc dm)
        {
            List<TaiLieu> list = new List<TaiLieu>();
            myCommand.CommandText = "Select * from TaiLieu where MaTL in (SELECT MaTL FROM DMTL WHERE MaDM='"+dm.MaDM+"')";
            try
            {
                SqlDataReader myReader = null;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    TaiLieu tmp = new TaiLieu();
                    tmp.MaTL = int.Parse(myReader["MaTL"].ToString());
                    tmp.LoaiTaiLieu = myReader["LoaiTaiLieu"].ToString();
                    tmp.TacGia = myReader["TacGia"].ToString();
                    tmp.TieuDe = myReader["TieuDe"].ToString();
                    tmp.Nam = int.Parse(myReader["Nam"].ToString());
                    tmp.TomTat = myReader["TomTat"].ToString();
                    tmp.GhiChu = myReader["GhiChu"].ToString();
                    tmp.File = myReader["File"].ToString();
                    tmp.URL = myReader["URL"].ToString();
                    tmp.DOI = myReader["DOI"].ToString();
                    list.Add(tmp);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                this.error = e.ToString();
            }

            return list;
        }

        public BaiBao getBaiBao(TaiLieu tl)
        {
            if (tl.LoaiTaiLieu == "article")
            {
                BaiBao tmp = new BaiBao(tl);
                myCommand.CommandText = "Select * from BaiBao where MaTL ='" + tl.MaTL + "')";
                try
                {
                    SqlDataReader myReader = null;

                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tmp.TapChi = myReader["TapChi"].ToString();
                        tmp.Trang = myReader["Trang"].ToString();
                        tmp.Volume = int.Parse(myReader["Volume"].ToString());
                        tmp.Issue = int.Parse(myReader["Issue"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e)
                {
                    this.error = e.ToString();
                }
                return tmp;
            }
            return null;
        }

        public Sach getSach(TaiLieu tl)
        {
            if (tl.LoaiTaiLieu == "book")
            {
                Sach tmp = new Sach(tl);
                myCommand.CommandText = "Select * from Sach where MaTL ='" + tl.MaTL + "')";
                try
                {
                    SqlDataReader myReader = null;

                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tmp.NhaXB = myReader["NhaXB"].ToString();
                        tmp.TaiBan = myReader["TaiBan"].ToString();
                        tmp.ThanhPho = myReader["ThanhPho"].ToString();
                    }
                    myReader.Close();
                }
                catch (Exception e)
                {
                    this.error = e.ToString();
                }
                return tmp;
            }
            return null;
        }

        public Proceedings getProceeding(TaiLieu tl)
        {
            if (tl.LoaiTaiLieu == "inproceedings")
            {
                Proceedings tmp = new Proceedings(tl);
                myCommand.CommandText = "Select * from Proceeding where MaTL ='" + tl.MaTL + "')";
                try
                {
                    SqlDataReader myReader = null;

                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tmp.TenHoiNghi = myReader["TenHoiNghi"].ToString();
                        tmp.ThanhPho = myReader["ThanhPho"].ToString();
                    }
                    myReader.Close();
                }
                catch (Exception e)
                {
                    this.error = e.ToString();
                }
                return tmp;
            }
            return null;
        }

        public TrangWeb getTrangWeb(TaiLieu tl)
        {
            if (tl.LoaiTaiLieu == "misc")
            {
                TrangWeb tmp = new TrangWeb(tl);
                myCommand.CommandText = "Select * from TrangWeb where MaTL ='" + tl.MaTL + "')";
                try
                {
                    SqlDataReader myReader = null;

                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        tmp.ToChuc = myReader["ToChuc"].ToString();
                        tmp.Ngay = int.Parse(myReader["Ngay"].ToString());
                        tmp.Thang = int.Parse(myReader["Thang"].ToString());
                        tmp.NgayTruyCap = DateTime.Parse(myReader["NgayTruyCap"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception e)
                {
                    this.error = e.ToString();
                }
                return tmp;
            }
            return null;
        }
    }
}
