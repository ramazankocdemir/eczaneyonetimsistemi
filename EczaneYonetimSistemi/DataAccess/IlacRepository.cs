using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EczaneYonetimSistemi.Entities;

namespace EczaneYonetimSistemi.DataAccess
{
    public class IlacRepository
    {
        // TÜM İLAÇLARI LİSTELE
        public List<IlacListeDto> GetAll()
        {
            List<IlacListeDto> liste = new List<IlacListeDto>();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT 
    i.Id,
    i.BarkodNo,
    i.IlacAdi,
    i.StokAdedi,
    i.BirimFiyat,
    i.SonKullanmaTarihi,
    i.ReceteZorunlulugu,
    k.Id AS KategoriId,
    k.KategoriAdi,
    k.KdvOrani
FROM Ilaclar i
INNER JOIN Kategoriler k ON k.Id = i.KategoriId
ORDER BY i.IlacAdi;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        IlacListeDto item = new IlacListeDto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            BarkodNo = dr["BarkodNo"].ToString(),
                            IlacAdi = dr["IlacAdi"].ToString(),
                            StokAdedi = Convert.ToInt32(dr["StokAdedi"]),
                            BirimFiyat = Convert.ToDecimal(dr["BirimFiyat"]),
                            SonKullanmaTarihi = Convert.ToDateTime(dr["SonKullanmaTarihi"]),
                            ReceteZorunlulugu = Convert.ToBoolean(dr["ReceteZorunlulugu"]),
                            KategoriId = Convert.ToInt32(dr["KategoriId"]),
                            KategoriAdi = dr["KategoriAdi"].ToString(),
                            KdvOrani = Convert.ToDecimal(dr["KdvOrani"])
                        };

                        liste.Add(item);
                    }
                }
            }

            return liste;
        }

        // BARKOD İLE İLAÇ GETİR (SATIŞ İÇİN)
        public IlacSatisDto GetByBarkod(string barkodNo)
        {
            if (string.IsNullOrWhiteSpace(barkodNo))
                return null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT TOP 1
    i.Id,
    i.BarkodNo,
    i.IlacAdi,
    i.StokAdedi,
    i.BirimFiyat,
    i.SonKullanmaTarihi,
    i.ReceteZorunlulugu,
    k.KdvOrani
FROM Ilaclar i
INNER JOIN Kategoriler k ON k.Id = i.KategoriId
WHERE i.BarkodNo = @BarkodNo;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@BarkodNo", SqlDbType.NVarChar, 50).Value = barkodNo.Trim();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return null;

                        return new IlacSatisDto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            BarkodNo = dr["BarkodNo"].ToString(),
                            IlacAdi = dr["IlacAdi"].ToString(),
                            StokAdedi = Convert.ToInt32(dr["StokAdedi"]),
                            BirimFiyat = Convert.ToDecimal(dr["BirimFiyat"]),
                            SonKullanmaTarihi = Convert.ToDateTime(dr["SonKullanmaTarihi"]),
                            ReceteZorunlulugu = Convert.ToBoolean(dr["ReceteZorunlulugu"]),
                            KdvOrani = Convert.ToDecimal(dr["KdvOrani"])
                        };
                    }
                }
            }
        }

        // İLAÇ EKLE
        public int Insert(string barkodNo, string ilacAdi, int stokAdedi, decimal birimFiyat, DateTime skt, bool receteZorunlu, int kategoriId)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
INSERT INTO Ilaclar (BarkodNo, IlacAdi, StokAdedi, BirimFiyat, SonKullanmaTarihi, ReceteZorunlulugu, KategoriId)
VALUES (@BarkodNo, @IlacAdi, @StokAdedi, @BirimFiyat, @SKT, @Recete, @KategoriId);
SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@BarkodNo", SqlDbType.NVarChar, 50).Value = barkodNo.Trim();
                    cmd.Parameters.Add("@IlacAdi", SqlDbType.NVarChar, 200).Value = ilacAdi.Trim();
                    cmd.Parameters.Add("@StokAdedi", SqlDbType.Int).Value = stokAdedi;

                    var pFiyat = cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal);
                    pFiyat.Precision = 18;
                    pFiyat.Scale = 2;
                    pFiyat.Value = birimFiyat;

                    cmd.Parameters.Add("@SKT", SqlDbType.Date).Value = skt.Date;
                    cmd.Parameters.Add("@Recete", SqlDbType.Bit).Value = receteZorunlu;
                    cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = kategoriId;

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        // İLAÇ SİL (İMHA)
        public void DeleteById(int id)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Ilaclar WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // STOK DÜŞ (SATIŞ)
        public bool StokDus(int ilacId, int adet)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
UPDATE Ilaclar
SET StokAdedi = StokAdedi - @Adet
WHERE Id = @Id AND StokAdedi >= @Adet;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ilacId;
                    cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;

                    int etkilenen = cmd.ExecuteNonQuery();
                    return etkilenen > 0;
                }
            }
        }

        // ===========================
        // İLAÇ KABUL İÇİN: BARKODDAN GETİR (DTO)
        // ===========================
        // ===========================
        // İLAÇ KABUL İÇİN: BARKODDAN GETİR
        // ===========================
        public IlacKabulDto GetByBarkodForKabul(string barkodNo)
        {
            if (string.IsNullOrWhiteSpace(barkodNo))
                return null;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT TOP 1
    Id, BarkodNo, IlacAdi, StokAdedi, BirimFiyat, SonKullanmaTarihi, ReceteZorunlulugu, KategoriId
FROM Ilaclar
WHERE BarkodNo = @BarkodNo;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@BarkodNo", SqlDbType.NVarChar, 50).Value = barkodNo.Trim();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return null;

                        return new IlacKabulDto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            BarkodNo = dr["BarkodNo"].ToString(),
                            IlacAdi = dr["IlacAdi"].ToString(),
                            StokAdedi = Convert.ToInt32(dr["StokAdedi"]),
                            BirimFiyat = Convert.ToDecimal(dr["BirimFiyat"]),
                            SonKullanmaTarihi = Convert.ToDateTime(dr["SonKullanmaTarihi"]),
                            ReceteZorunlulugu = Convert.ToBoolean(dr["ReceteZorunlulugu"]),
                            KategoriId = Convert.ToInt32(dr["KategoriId"])
                        };
                    }
                }
            }
        }

        // BARKOD VAR MI?
        public bool BarkodVarMi(string barkodNo)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Ilaclar WHERE BarkodNo = @BarkodNo";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@BarkodNo", SqlDbType.NVarChar, 50).Value = barkodNo.Trim();

                    int sayi = (int)cmd.ExecuteScalar();
                    return sayi > 0;
                }
            }
        }

        // ===========================
        // İLAÇ KABUL İÇİN: BARKODDAN GÜNCELLE
        // ===========================
        public bool UpdateByBarkod(string barkodNo, string ilacAdi, int stokAdedi, decimal birimFiyat, DateTime skt, bool receteZorunlu, int kategoriId)
        {
            if (string.IsNullOrWhiteSpace(barkodNo))
                return false;

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();

                string sql = @"
UPDATE Ilaclar
SET
    IlacAdi = @IlacAdi,
    StokAdedi = @StokAdedi,
    BirimFiyat = @BirimFiyat,
    SonKullanmaTarihi = @SKT,
    ReceteZorunlulugu = @Recete,
    KategoriId = @KategoriId
WHERE BarkodNo = @BarkodNo;";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@BarkodNo", SqlDbType.NVarChar, 50).Value = barkodNo.Trim();
                    cmd.Parameters.Add("@IlacAdi", SqlDbType.NVarChar, 200).Value = ilacAdi.Trim();
                    cmd.Parameters.Add("@StokAdedi", SqlDbType.Int).Value = stokAdedi;

                    var pFiyat = cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal);
                    pFiyat.Precision = 18;
                    pFiyat.Scale = 2;
                    pFiyat.Value = birimFiyat;

                    cmd.Parameters.Add("@SKT", SqlDbType.Date).Value = skt.Date;
                    cmd.Parameters.Add("@Recete", SqlDbType.Bit).Value = receteZorunlu;
                    cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = kategoriId;

                    int etkilenen = cmd.ExecuteNonQuery();
                    return etkilenen > 0;
                }
            }
        }
    }
}
