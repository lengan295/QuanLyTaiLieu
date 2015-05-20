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

            myCommand.CommandText = "SELECT * FROM CayDanhMuc";
            try
            {
                SqlDataReader myReader = null;

                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int MaDMCha = int.Parse(myReader["MaDMCha"].ToString());
                    int MaDMCon = int.Parse(myReader["MaDMCon"].ToString());
                    foreach (DanhMuc dmcha in list)
                    {
                        if (dmcha.MaDM == MaDMCha)
                        {
                            foreach (DanhMuc dmcon in list)
                            {
                                if (dmcon.MaDM == MaDMCon)
                                {
                                    dmcon.DMCha = dmcha;
                                    dmcha.DSDanhMucCon.Add(dmcon);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                this.error = e.ToString();
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].DMCha != null)
                    list.Remove(list[i]);
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

        public void addTaiLieu(TaiLieu tl)
        {
            myCommand.CommandText = "Insert into TaiLieu(LoaiTaiLieu, TacGia, TieuDe, Nam, TomTat, [File], URL, DOI)"+
                                    "values('@LoaiTaiLieu', '@TacGia', '@TieuDe', '@Nam', '@TomTat', '@File', '@URL', '@DOI');SELECT CAST(scope_identity() AS int);";
            myCommand.Parameters.Add(new SqlParameter("LoaiTaiLieu",tl.LoaiTaiLieu));
            myCommand.Parameters.Add(new SqlParameter("TacGia", tl.TacGia));
            myCommand.Parameters.Add(new SqlParameter("TieuDe", tl.TieuDe));
            myCommand.Parameters.Add(new SqlParameter("Nam", tl.Nam));
            myCommand.Parameters.Add(new SqlParameter("TomTat", tl.TomTat));
            myCommand.Parameters.Add(new SqlParameter("File", tl.File));
            myCommand.Parameters.Add(new SqlParameter("URL", tl.URL));
            myCommand.Parameters.Add(new SqlParameter("DOI", tl.DOI));

            tl.MaTL = (int) myCommand.ExecuteScalar();


        }

        public void addBaiBao(BaiBao bb)
        {
            addTaiLieu(bb);
            myCommand.CommandText = "Insert into BaiBao(MaTL, TapChi, Trang, Volume, Issue)" +
                                    "values('@MaTL','@TapChi', '@Trang', '@Volume', '@Issue')";
            myCommand.Parameters.Add(new SqlParameter("MaTL", bb.MaTL));
            myCommand.Parameters.Add(new SqlParameter("TapChi", bb.TapChi));
            myCommand.Parameters.Add(new SqlParameter("Trang", bb.Trang));
            myCommand.Parameters.Add(new SqlParameter("Volume", bb.Volume));
            myCommand.Parameters.Add(new SqlParameter("Issue", bb.Issue));

            myCommand.ExecuteNonQuery();
        }

        public void addTrangWeb(TrangWeb web)
        {
            addTaiLieu(web);
            myCommand.CommandText = "Insert into TrangWeb(MaTL, ToChuc, Ngay, Thang, NgayTruyCap)" +
                                    "values('@MaTL','@ToChuc', '@Ngay', '@Thang', '@NgayTruyCap')";
            myCommand.Parameters.Add(new SqlParameter("MaTL", web.MaTL));
            myCommand.Parameters.Add(new SqlParameter("ToChuc", web.ToChuc));
            myCommand.Parameters.Add(new SqlParameter("Ngay", web.Ngay));
            myCommand.Parameters.Add(new SqlParameter("Thang", web.Thang));
            myCommand.Parameters.Add(new SqlParameter("NgayTruyCap", web.NgayTruyCap));

            myCommand.ExecuteNonQuery();
        }

        public void addSach(Sach sh)
        {
            addTaiLieu(sh);
            myCommand.CommandText = "Insert into Sach(MaTL, NhaXB, TaiBan, ThanhPho)" +
                                    "values('@MaTL', '@NhaXB', '@TaiBan', '@ThanhPho')";
            myCommand.Parameters.Add(new SqlParameter("MaTL", sh.MaTL));
            myCommand.Parameters.Add(new SqlParameter("NhaXB", sh.NhaXB));
            myCommand.Parameters.Add(new SqlParameter("TaiBan", sh.TaiBan));
            myCommand.Parameters.Add(new SqlParameter("ThanhPho", sh.ThanhPho));

            myCommand.ExecuteNonQuery();
        }

        public void addProceeding(Proceedings pr)
        {
            addTaiLieu(pr);
            myCommand.CommandText = "Insert into Sach(MaTL, TenHoiNghi, ThanhPho)" +
                                    "values('@MaTL', '@TenHoiNghi', '@ThanhPho')";
            myCommand.Parameters.Add(new SqlParameter("MaTL", pr.MaTL));
            myCommand.Parameters.Add(new SqlParameter("TenHoiNghi", pr.TenHoiNghi));
            myCommand.Parameters.Add(new SqlParameter("ThanhPho", pr.ThanhPho));

            myCommand.ExecuteNonQuery();
        }

        public void updateTaiLieu(TaiLieu tl)
        {
            myCommand.CommandText = "Update TaiLieu set LoaiTaiLieu='@LoaiTaiLieu', TacGia='@TacGia', TieuDe='@TieuDe', Nam='@Nam', TomTat='@TomTat', [File]='@File', URL='@URL', DOI='@DOI' where MaTL='@MaTL'";
            myCommand.Parameters.Add(new SqlParameter("LoaiTaiLieu", tl.LoaiTaiLieu));
            myCommand.Parameters.Add(new SqlParameter("TacGia", tl.TacGia));
            myCommand.Parameters.Add(new SqlParameter("TieuDe", tl.TieuDe));
            myCommand.Parameters.Add(new SqlParameter("Nam", tl.Nam));
            myCommand.Parameters.Add(new SqlParameter("TomTat", tl.TomTat));
            myCommand.Parameters.Add(new SqlParameter("File", tl.File));
            myCommand.Parameters.Add(new SqlParameter("URL", tl.URL));
            myCommand.Parameters.Add(new SqlParameter("DOI", tl.DOI));
            myCommand.Parameters.Add(new SqlParameter("MaTL", tl.MaTL));

            myCommand.ExecuteNonQuery();
        }

        public void UpdateBaiBao(BaiBao bb)
        {
            updateTaiLieu(bb);
            myCommand.CommandText = "Update BaiBao set TapChi='@TapChi', Trang='@Trang', Volume='@Volume', Issue='@Issue' where MaTL='@MaTL'";
            myCommand.Parameters.Add(new SqlParameter("TapChi", bb.TapChi));
            myCommand.Parameters.Add(new SqlParameter("Trang", bb.Trang));
            myCommand.Parameters.Add(new SqlParameter("Volume", bb.Volume));
            myCommand.Parameters.Add(new SqlParameter("Issue", bb.Issue));
            myCommand.Parameters.Add(new SqlParameter("MaTL", bb.MaTL));

            myCommand.ExecuteNonQuery();
        }

        public void UpdateSach(Sach sh)
        {
            updateTaiLieu(sh);
            myCommand.CommandText = "Update Sach set NhaXB='@NhaXB', TaiBan='@TaiBan', ThanhPho='@ThanhPho' where MaTL='@MaTL'";
            myCommand.Parameters.Add(new SqlParameter("NhaXB", sh.NhaXB));
            myCommand.Parameters.Add(new SqlParameter("TaiBan", sh.TaiBan));
            myCommand.Parameters.Add(new SqlParameter("ThanhPho", sh.ThanhPho));
            myCommand.Parameters.Add(new SqlParameter("MaTL", sh.MaTL));

            myCommand.ExecuteNonQuery();
        }

        public void UpdateTrangWeb(TrangWeb web)
        {
            updateTaiLieu(web);
            myCommand.CommandText = "Update Sach set ToChuc='@ToChuc', Ngay='@Ngay', Thang='@Thang', NgayTruyCap='@NgayTruyCap' where MaTL='@MaTL'";
            myCommand.Parameters.Add(new SqlParameter("MaTL", web.MaTL));
            myCommand.Parameters.Add(new SqlParameter("ToChuc", web.ToChuc));
            myCommand.Parameters.Add(new SqlParameter("Ngay", web.Ngay));
            myCommand.Parameters.Add(new SqlParameter("Thang", web.Thang));
            myCommand.Parameters.Add(new SqlParameter("NgayTruyCap", web.NgayTruyCap));

            myCommand.ExecuteNonQuery();
        }

        public void UpdateProceeding(Proceedings pr)
        {
            updateTaiLieu(pr);
            myCommand.CommandText = "Update Sach set TenHoiNghi='@TenHoiNghi', ThanhPho='@ThanhPho' where MaTL='@MaTL'";
            myCommand.Parameters.Add(new SqlParameter("MaTL", pr.MaTL));
            myCommand.Parameters.Add(new SqlParameter("TenHoiNghi", pr.TenHoiNghi));
            myCommand.Parameters.Add(new SqlParameter("ThanhPho", pr.ThanhPho));

            myCommand.ExecuteNonQuery();
        }

        public void addDanhMuc(DanhMuc dm)
        {
            myCommand.CommandText = "Insert into DanhMuc(TenDanhMuc)" +
                                    "values('@TenDanhMuc')";
            myCommand.Parameters.Add(new SqlParameter("TenDanhMuc", dm.TenDanhMuc));

            myCommand.ExecuteNonQuery();
        }

        public void UdateDanhMuc(DanhMuc dm)
        {
            myCommand.CommandText = "Update DanhMuc set TenDanhMuc='@TenDanhMuc' where MaDM='@MaDM'";
            myCommand.Parameters.Add(new SqlParameter("TenDanhMuc", dm.TenDanhMuc));
            myCommand.Parameters.Add(new SqlParameter("MaDM", dm.MaDM));

            myCommand.ExecuteNonQuery();
        }

        public void deleteTaiLieu(TaiLieu tl)
        {
            myCommand.CommandText = "Delete from TaiLieu where MaTL='@MaTL';"
                                    + "Delete from BaiBao where MaTL='@MaTL';"
                                    + "Delete from Sach where MaTL='@MaTL';"
                                    + "Delete from TrangWeb where MaTL='@MaTL';"
                                    + "Delete from Proceeding where MaTL='@MaTL';";
            myCommand.Parameters.Add(new SqlParameter("MaTL", tl.MaTL));

            myCommand.ExecuteNonQuery();
        }

        public void deleteDanhMuc(DanhMuc dm)
        {
            myCommand.CommandText = "Delete from DanhMuc where MaDm='@MaDM'";
            myCommand.Parameters.Add(new SqlParameter("MaDM", dm.MaDM));

            myCommand.ExecuteNonQuery();
        }
    }
}
