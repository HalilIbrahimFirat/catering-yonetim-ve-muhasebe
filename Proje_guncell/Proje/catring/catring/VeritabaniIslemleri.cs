using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace catring
{
    public class VeritabaniIslemleri
    {
        private string _connectionString;

        public VeritabaniIslemleri(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void PersonelEkle(Personel personel)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Calisanlar WHERE TcNo = @TcNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TcNo", personel.tcNo);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Bu TC kimlik numarasına sahip bir personel zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aynı TC kimlik numarasına sahip personel yoksa, yeni personeli ekle
                query = "INSERT INTO Calisanlar (Ad, Soyad, Adres, DogumTarihi, TcNo, CalismaSaati, SaatBasiMaas, TelNo, ToplamMaas) VALUES (@Ad, @Soyad, @Adres, @DogumTarihi, @TcNo, @CalismaSaati, @SaatBasiMaas, @TelNo, @ToplamMaas)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ad", personel.ad);
                command.Parameters.AddWithValue("@Soyad", personel.soyad);
                command.Parameters.AddWithValue("@Adres", personel.adres);
                command.Parameters.AddWithValue("@DogumTarihi", personel.dogumTarihi);
                command.Parameters.AddWithValue("@TcNo", personel.tcNo);
                command.Parameters.AddWithValue("@CalismaSaati", personel.calismaSaati);
                command.Parameters.AddWithValue("@SaatBasiMaas", personel.SaatBaşıMaaş);
                command.Parameters.AddWithValue("@TelNo", personel.telNo);

                // Toplam maaşı hesapla ve parametreye ekle
                decimal toplamMaas = 30 * (personel.SaatBaşıMaaş * personel.calismaSaati);
                command.Parameters.AddWithValue("@ToplamMaas", toplamMaas);

                command.ExecuteNonQuery();
            }
        }






        public void MalzemeEkle(string malzemeAdi, float malzemeAdedi, float minimumStok, float birimFiyat)
        {
            // Malzeme tablosuna ekle
            string queryMalzeme = "INSERT INTO Malzemeler (MalzemeAdi, Adet, MinimumStok, BirimFiyat) VALUES (@MalzemeAdi, @Adet, @MinimumStok, @BirimFiyat)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryMalzeme, connection))
                {
                    command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                    command.Parameters.AddWithValue("@Adet", malzemeAdedi);
                    command.Parameters.AddWithValue("@MinimumStok", minimumStok);
                    command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Malzeme veritabanına eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }

            // GelirGider tablosuna ekleyelim
            string queryGelirGider = "INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryGelirGider, connection))
                {
                    command.Parameters.AddWithValue("@IslemTipi", "Gider"); // Gider olarak ekleyelim
                    command.Parameters.AddWithValue("@Tarih", DateTime.Now); // Örnek olarak şu anki tarihi ekleyelim, gerektiğinde değiştirilebilir
                    command.Parameters.AddWithValue("@GelirGiderTipi", "Malzeme Alımı"); // Malzeme adını GelirGiderTipi olarak ekleyelim
                    command.Parameters.AddWithValue("@Tutar", malzemeAdedi * birimFiyat); // Adet * birim fiyatını toplam tutar olarak ekleyelim
                    command.Parameters.AddWithValue("@Aciklama", malzemeAdi); // Örnek bir açıklama ekleyelim

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Gelir/Gider veritabanına eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }


        public float MevcutStok(string malzemeAdi)
        {
            float mevcutStok = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Adet FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        mevcutStok = Convert.ToSingle(result);
                    }
                }
            }
            return mevcutStok;
        }

        public float MinimumStok(string malzemeAdi)
        {
            float minimumStok = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT MinimumStok FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        minimumStok = Convert.ToSingle(result);
                    }
                }
            }
            return minimumStok;
        }

        public void StokEkle(string malzemeAdi, float stokEkleAdet)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Malzemenin birim fiyatını alın
                    string fiyatQuery = "SELECT BirimFiyat FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                    float birimFiyat;
                    using (SqlCommand fiyatCommand = new SqlCommand(fiyatQuery, connection, transaction))
                    {
                        fiyatCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        birimFiyat = Convert.ToSingle(fiyatCommand.ExecuteScalar());
                    }

                    // Stok ekleme işlemini yap
                    string stokQuery = "UPDATE Malzemeler SET Adet = Adet + @StokEkleAdet WHERE MalzemeAdi = @MalzemeAdi";
                    using (SqlCommand stokCommand = new SqlCommand(stokQuery, connection, transaction))
                    {
                        stokCommand.Parameters.AddWithValue("@StokEkleAdet", stokEkleAdet);
                        stokCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        stokCommand.ExecuteNonQuery();
                    }

                    // Maliyeti hesaplayıp GelirGider tablosuna ekleyin
                    float maliyet = birimFiyat * stokEkleAdet;
                    string giderQuery = "INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";
                    using (SqlCommand giderCommand = new SqlCommand(giderQuery, connection, transaction))
                    {
                        giderCommand.Parameters.AddWithValue("@IslemTipi", "Gider");
                        giderCommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                        giderCommand.Parameters.AddWithValue("@GelirGiderTipi", "Stok Ekleme");
                        giderCommand.Parameters.AddWithValue("@Tutar", maliyet);
                        giderCommand.Parameters.AddWithValue("@Aciklama", malzemeAdi + " stoğu eklendi.");
                        giderCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Malzeme stok ekleme işlemi tamamlandı ve gider kaydedildi!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }


        public void StokCikar(string malzemeAdi, float stokCikarAdet)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Malzemenin birim fiyatını alın
                    string fiyatQuery = "SELECT BirimFiyat FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                    float birimFiyat;
                    using (SqlCommand fiyatCommand = new SqlCommand(fiyatQuery, connection, transaction))
                    {
                        fiyatCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        birimFiyat = Convert.ToSingle(fiyatCommand.ExecuteScalar());
                    }

                    float mevcutStok = MevcutStok(malzemeAdi);
                    float minimumStok = MinimumStok(malzemeAdi);

                    if (mevcutStok - stokCikarAdet <= minimumStok)
                    {
                        MessageBox.Show("Malzeme stok seviyesi minimum stok seviyesine ulaştı veya altına düştü! Çıkarma işlemi devam edecek.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Stok çıkarma işlemini yap
                    string stokQuery = "UPDATE Malzemeler SET Adet = Adet - @StokCikarAdet WHERE MalzemeAdi = @MalzemeAdi";
                    using (SqlCommand stokCommand = new SqlCommand(stokQuery, connection, transaction))
                    {
                        stokCommand.Parameters.AddWithValue("@StokCikarAdet", stokCikarAdet);
                        stokCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        stokCommand.ExecuteNonQuery();
                    }

                    // Maliyeti hesaplayıp GelirGider tablosuna ekleyin
                    float maliyet = birimFiyat * stokCikarAdet;
                    string giderQuery = "INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";
                    using (SqlCommand giderCommand = new SqlCommand(giderQuery, connection, transaction))
                    {
                        giderCommand.Parameters.AddWithValue("@IslemTipi", "Gider");
                        giderCommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                        giderCommand.Parameters.AddWithValue("@GelirGiderTipi", "Stok Çıkarma");
                        giderCommand.Parameters.AddWithValue("@Tutar", maliyet);
                        giderCommand.Parameters.AddWithValue("@Aciklama", malzemeAdi + " stoğu çıkarıldı.");
                        giderCommand.ExecuteNonQuery();
                    }

                    string kontrolQuery = "SELECT Adet FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                    using (SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, connection, transaction))
                    {
                        kontrolCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                        float yeniStok = Convert.ToSingle(kontrolCommand.ExecuteScalar());

                        if (yeniStok <= 0)
                        {
                            MessageBox.Show("Malzeme stok seviyesi 0'a ulaştı malzeme siliniyor...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            string silQuery = "DELETE FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                            using (SqlCommand silCommand = new SqlCommand(silQuery, connection, transaction))
                            {
                                silCommand.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                                silCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Malzeme stok çıkarma işlemi tamamlandı ve gider kaydedildi!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }



        public void KaydetGelirGider(GelirGiderClass gelirGider, decimal birimFiyat)
        {
            string query = "INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IslemTipi", gelirGider.IslemTipi);
                    command.Parameters.AddWithValue("@Tarih", gelirGider.Tarih);
                    command.Parameters.AddWithValue("@GelirGiderTipi", gelirGider.GelirGiderTipi);
                    command.Parameters.AddWithValue("@Tutar", gelirGider.Tutar + birimFiyat);
                    command.Parameters.AddWithValue("@Aciklama", gelirGider.Aciklama);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }


        public decimal ToplamGelir()
        {
            decimal toplamGelir = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Tutar) FROM GelirGider WHERE IslemTipi = 'Gelir'";
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    toplamGelir = Convert.ToDecimal(result);
                }
            }

            return toplamGelir;
        }

        public decimal ToplamGider()
        {
            decimal toplamGider = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Tutar) FROM GelirGider WHERE IslemTipi = 'Gider'";
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    toplamGider = Convert.ToDecimal(result);
                }
            }

            return toplamGider;
        }
        


    }
}
