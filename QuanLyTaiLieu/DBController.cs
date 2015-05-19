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
    }
}
