using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class MonHocDAO
    {
        //doc tat ca mon hoc
        public List<MonHoc> getAll()
        {
            List<MonHoc> ds = new List<MonHoc>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr1"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from monhoc", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ds.Add(new MonHoc
                {
                    MaMH = dr["mamh"].ToString(),
                    TenMH = dr["tenmh"].ToString(),
                    SoTiet = int.Parse(dr["sotiet"].ToString())});
            }
            return ds;
        }
    }
}