using System;
using System.Data;
using System.Data.SqlClient;

namespace EczaneYonetimSistemi.DataAccess
{
    public class PersonelDto
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdSoyad { get; set; }
        public string Rol { get; set; }
    }

    public class PersonelRepository
    {
        public PersonelDto Login(string kullaniciAdi, string sifreHash)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT TOP 1 Id, KullaniciAdi, AdSoyad, Rol
FROM Personeller
WHERE Aktif = 1
  AND KullaniciAdi = @KullaniciAdi
  AND SifreHash = @SifreHash;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar, 50).Value = kullaniciAdi;
                    cmd.Parameters.Add("@SifreHash", SqlDbType.NVarChar, 64).Value = sifreHash;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read()) return null;

                        return new PersonelDto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            KullaniciAdi = dr["KullaniciAdi"].ToString(),
                            AdSoyad = dr["AdSoyad"].ToString(),
                            Rol = dr["Rol"].ToString()
                        };
                    }
                }
            }
        }
    }
}
