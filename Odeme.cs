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

namespace bayii
{
    public partial class Odeme : Form
    {
       
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");
        private decimal _toplamFiyat;

        public Odeme(decimal toplamFiyat)
        {
            InitializeComponent();
            _toplamFiyat = toplamFiyat;
            lblToplamFiyat.Text = $"Toplam Fiyat: {_toplamFiyat:C}"; // Fiyatı TL formatında göster

        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            cmbYontem.Items.Add("Kapıda Ödeme");
            cmbYontem.Items.Add("Kredi Kartı");
        }

        private void cmbYontem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYontem.SelectedItem.ToString() == "Kredi Kartı")
            {
                // Kredi kartı seçildiğinde, kart bilgilerini göster.
                lblkart.Visible = true;
                msktxtkart.Visible = true;
                lblcvv.Visible = true;
                msktxtcvv.Visible = true;
            }
            else
            {
                // Diğer seçenek seçildiğinde, kart bilgilerini gizle.
                lblkart.Visible = false;
                msktxtkart.Visible = false;
                lblcvv.Visible = false;
                msktxtcvv.Visible = false;
            }
        }
        private bool AbonelikIDKontrol(int abonelikID)
        {
            bool gecerliMi = false;

            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                // SQL sorgusu: Abonelik ID'sinin olup olmadığını kontrol et
                string query = "SELECT COUNT(*) FROM Abonelik WHERE AbonelikID = @AbonelikID";
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@AbonelikID", abonelikID);

                int sonuc = (int)command.ExecuteScalar(); // Sonucu al

                gecerliMi = sonuc > 0; // Eğer sonuç 0'dan büyükse ID geçerli
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return gecerliMi;
        }



        private void btnodon_Click(object sender, EventArgs e)
        {


            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                // AbonelikID'nin doğruluğunu kontrol et
                string kontrolQuery = "SELECT COUNT(*) FROM Abonelik WHERE AbonelikID = @AbonelikID";
                SqlCommand kontrolCommand = new SqlCommand(kontrolQuery, _connection);
                kontrolCommand.Parameters.AddWithValue("@AbonelikID", int.Parse(txtODaboID.Text));

                int count = (int)kontrolCommand.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Girilen AbonelikID mevcut değil. Lütfen geçerli bir AbonelikID girin.");
                    return;
                }

                // Eğer AbonelikID geçerliyse ödeme ekleme işlemini gerçekleştir
                string query = "INSERT INTO Odeme (AbonelikID, OdemeTarihi, Tutar, Durum) VALUES (@AbonelikID, @OdemeTarihi, @Tutar, @Durum)";
                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@AbonelikID", int.Parse(txtODaboID.Text));
                command.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);  // Varsayılan: Bugünün tarihi
                                                                                // Toplam fiyat metninden sadece sayıyı al
                string toplamFiyatText = lblToplamFiyat.Text.Replace("Toplam Fiyat:", "").Replace("₺", "").Trim();
                decimal toplamFiyat = decimal.Parse(toplamFiyatText);
                command.Parameters.AddWithValue("@Tutar", toplamFiyat);

                //command.Parameters.AddWithValue("@Tutar", decimal.Parse(lblToplamFiyat.Text));


                int durum;
                if (cmbYontem.SelectedIndex == 0) // ComboBox'taki ilk öğe seçiliyse
                    durum = 0;
                else
                    durum = 1;

                // Durum parametresini ekle
                command.Parameters.AddWithValue("@Durum", durum);

                // Sorguyu çalıştır
                command.ExecuteNonQuery();
                MessageBox.Show("Ödeme işlemi başarılı.");           
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
}
    

