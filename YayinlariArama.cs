using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Reporting;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.ReportAppServer.ReportDefModel;
using ReportDocument = CrystalDecisions.CrystalReports.Engine.ReportDocument;


namespace bayii
{
    public partial class YayinlariArama : Form
    {
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");
        DataSet _dataSet;
        public YayinlariArama()
        {
            InitializeComponent();
        }
        private void YayinlariListele()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT * FROM Yayin";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgwara.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void YayinlariArama_Load(object sender, EventArgs e)
        {
            this.yayinTableAdapter1.Fill(this.bayiiDataSetYayin.Yayin);

            YayinlariListele();
            cmbarafilt.Items.Add("Yayın Adı");
            cmbarafilt.Items.Add("Fiyat");
            cmbarafilt.SelectedIndex = 0; // Varsayılan olarak 'yyaın adı' seçili
        }

        private void btnarara_Click(object sender, EventArgs e)
        {
            {
                string kriter = cmbarafilt.SelectedItem.ToString(); // Seçilen kriter (Ad veya Fiyat)
                string aramaTerimi = txtarara.Text.Trim(); // Kullanıcının yazdığı arama terimi

                if (string.IsNullOrEmpty(aramaTerimi))
                {
                    MessageBox.Show("Lütfen bir arama terimi girin.");
                    return;
                }

                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    // SQL sorgusu kriterine göre ayarlanır
                    string query;
                    if (kriter == "Yayın Adı")
                    {
                        query = "SELECT * FROM Yayin WHERE Baslik  LIKE @AramaTerimi"; // Ad'a göre arama
                    }
                    else if (kriter == "Fiyat")
                    {
                        query = "SELECT * FROM Yayin WHERE Fiyat = @AramaTerimi"; // Fiyata göre arama
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kriter seçildi.");
                        return;
                    }

                    // SQL komutu oluşturulur
                    SqlCommand command = new SqlCommand(query, _connection);

                    // Arama terimi için parametre eklenir
                    if (kriter == "Yayın Adı")
                    {
                        command.Parameters.AddWithValue("@AramaTerimi", "%" + aramaTerimi + "%"); // LIKE ifadesi
                    }
                    else if (kriter == "Fiyat")
                    {
                        if (decimal.TryParse(aramaTerimi, out decimal fiyat)) // Fiyatı decimal'e dönüştür
                        {
                            command.Parameters.AddWithValue("@AramaTerimi", fiyat);
                        }
                        else
                        {
                            MessageBox.Show("Geçerli bir fiyat girin.");
                            return;
                        }
                    }

                    // Veriler okunur ve DataGridView'e aktarılır
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgwara.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        




        decimal toplamFiyat = 0;

        private void btnyaysep_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'de seçili bir satır var mı kontrolü
                if (dgwara.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir yayın seçin.");
                    return;
                }

                // Seçili satırdan verileri al
                string yayinAdi = dgwara.CurrentRow.Cells[1].Value?.ToString() ?? "Bilinmeyen Yayın"; // Yayın adı
                string fiyatStr = dgwara.CurrentRow.Cells[3].Value?.ToString(); // Yayın fiyatı

                if (decimal.TryParse(fiyatStr, out decimal fiyat)) // Fiyatı decimal'e dönüştür
                {
                    // Toplam fiyatı güncelle
                    toplamFiyat += fiyat;

                    // Kullanıcıya bilgi mesajı göster
                    MessageBox.Show($"{yayinAdi} sepete eklendi! \nToplam Fiyat: {toplamFiyat:C}", "Sepet Güncellemesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seçili yayının fiyat bilgisi geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnyaypdf_Click_1(object sender, EventArgs e)
        {



            _dataSet = bayiiDataSetYayin;

            YayinRaporu raporu = new YayinRaporu();
            raporu.dataset = _dataSet;
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "PDF Files|*.pdf";
            //saveFileDialog.Title = "Save Report As PDF";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        string pdfPath = saveFileDialog.FileName; // Kullanıcının seçtiği dosya yolu
            //        ReportDocument reportDocument = new ReportDocument();
            //        reportDocument.SetDataSource(_dataSet);

            //        // PDF olarak dışa aktarreportDocument.SetDataSource(_dataSet);
            //        reportDocument.Load(@"C:\Users\nursena\Desktop\bayiiC#\bayii\YayinRaporum.rpt");
        
            //        reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, pdfPath);

            //        MessageBox.Show($"Rapor başarıyla kaydedildi: {pdfPath}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Rapor kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //try
            //{
            //    // Crystal Report dosyasını yükle
            //    ReportDocument reportDocument = new ReportDocument();
            //    reportDocument.SetDataSource(_dataSet);

            //    reportDocument.Load(@"C:\Users\nursena\Desktop\bayiiC#\bayii\YayinRaporum.rpt"); // Rapor dosyasının tam yolu

            //    // PDF'in kaydedileceği dosya yolu
            //    string pdfPath = @"C:\Reports\YayinRaporum.pdf";

            //    // Raporu PDF formatında dışa aktar
            //    reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, pdfPath);

            //    // Başarı mesajı
            //    MessageBox.Show($"Rapor başarıyla PDF olarak kaydedildi:\n{pdfPath}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    // Hata mesajı
            //    MessageBox.Show("Rapor kaydedilirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            raporu.ShowDialog();
        }

            //decimal toplamFiyat=0;

            private void btnyaycuz_Click_1(object sender, EventArgs e)
        {

            if (toplamFiyat <= 0)
            {
                MessageBox.Show("Sepetiniz boş! Lütfen önce bir ürün ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Odeme odemeForm = new Odeme(toplamFiyat);
            odemeForm.ShowDialog();
        }

    }
}
    



    


    

