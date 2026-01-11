using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EczaneYonetimSistemi.Entities;

namespace EczaneYonetimSistemi.DataAccess
{
    public class KategoriRepository
    {
        public List<KategoriDto> GetAll()
        {
            var list = new List<KategoriDto>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT Id, KategoriAdi, KdvOrani
FROM Kategoriler
ORDER BY KategoriAdi;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr["Id"] != DBNull.Value ? Convert.ToInt32(dr["Id"]) : 0;
                        string kategoriAdi = dr["KategoriAdi"] != DBNull.Value ? dr["KategoriAdi"].ToString() : "";
                        decimal kdvOrani = dr["KdvOrani"] != DBNull.Value ? Convert.ToDecimal(dr["KdvOrani"]) : 0m;

                        list.Add(new KategoriDto
                        {
                            Id = id,
                            KategoriAdi = kategoriAdi,
                            KdvOrani = kdvOrani
                        });
                    }
                }
            }

            return list;
        }
    }
}
