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
    public partial class KullanıcıGirisEkrani : Form
    {
        public static bool kapa=false;
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");

        public KullanıcıGirisEkrani() 
        {
            InitializeComponent();
        }

        private void btngir_Click(object sender, EventArgs e)
        {

            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT Rol FROM Abone WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre ";
                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@KullaniciAdi", txtKulAd.Text);
                command.Parameters.AddWithValue("@Sifre", txtKulsif.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string rol = reader["Rol"].ToString();
                    reader.Close();

                    MessageBox.Show("Giriş başarılı! Rol: " + rol);


                    if (rol == "admin")
                    {
                        
                            // Admin paneline yönlendirme
                            Form1 adminForm = new Form1();
                            adminForm.Show();
                            this.Hide();
                        

                    }
                    else
                    {
                        // Normal kullanıcı paneline yönlendirme
                        kullanıcıPaneli kullaniciForm = new kullanıcıPaneli();
                        kullaniciForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblhata.Text = "Kullanıcı adı veya şifre hatalı!";
                    lblhata.Visible = true;
                }
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
            
        private void button3_Click_1(object sender, EventArgs e)
        {
            YeniKayit kayit = new YeniKayit();
            kayit.ShowDialog();


        }

       
    }
}
