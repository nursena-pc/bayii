using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace bayii
{
    internal class DataExport
    {
       
        private string _connection = "Server=-ND-\\SQLEXPRESS;Database=bayii;Integrated Security=True;";

       

        // Veritabanından veri alıp CSV dosyasına dışa aktarma
        public void ExportDataToCsv(string filePath)
        {
            try
            {
                string query = "SELECT AboneID, Isim, Soyisim, Telefon, Email, Adres, KullaniciAdi, Rol, Aktiflik FROM Abone";
                using (SqlConnection conn = new SqlConnection(_connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // CSV dosyasını yaz
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        // Başlık satırını yaz
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sw.Write(dt.Columns[i].ColumnName);
                            if (i < dt.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        // Verileri yaz
                        foreach (DataRow row in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                sw.Write(row[i].ToString());
                                if (i < dt.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Veri başarıyla dışa aktarıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
