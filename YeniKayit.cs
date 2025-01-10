using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayii
{
    public partial class YeniKayit : Form
    {
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");
        public YeniKayit()
        {

            InitializeComponent();
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {
            cmbyenrol.Items.Add("üye");
            cmbyenrol.SelectedIndex = 0; // Varsayılan olarak 'üye' seçili

        }

        private void btnYenikay_Click(object sender, EventArgs e)
        {

        
            try
            {
               

                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
                string query = "INSERT INTO Abone (Isim, Soyisim, Telefon, Email, Adres, KullaniciAdi, Sifre, Rol, Aktiflik) VALUES (@Isim, @Soyisim, @Telefon, @Email, @Adres, @KullaniciAdi, @Sifre, @Rol, @Aktiflik)";

                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@Isim", txtYenAd.Text);
                command.Parameters.AddWithValue("@Soyisim", txtYenSoy.Text);
                command.Parameters.AddWithValue("@Telefon", msktxtyentel.Text);
                command.Parameters.AddWithValue("@Email", txtYenpos.Text);
                command.Parameters.AddWithValue("@Adres", rchyenadres.Text);
                command.Parameters.AddWithValue("@KullaniciAdi", txtYeniadkul.Text);
                command.Parameters.AddWithValue("@Sifre", txtYensif.Text);
                command.Parameters.AddWithValue("@Rol", cmbyenrol.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Aktiflik", chkAktif.Checked ? 1 : 0);


                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi!");

                kullanıcıPaneli kayit = new kullanıcıPaneli();
                kayit.ShowDialog();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

