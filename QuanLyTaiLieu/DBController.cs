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

        public List<DanhMuc> getAllCatalogues()
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
            }
            catch (Exception e)
            {
                this.error = e.ToString();
            }

            return list;
        }   
    }
}
