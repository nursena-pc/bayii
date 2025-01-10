using System;
using System.Collections;
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
    public partial class Abone : Form
    {
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");

        public Abone()
        {
            InitializeComponent();
        }



        private void KullaniciListele()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT AboneID, Isim, Soyisim, Telefon, Email, Adres, KullaniciAdi, Rol, Aktiflik FROM Abone";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgwAbo.DataSource = dataTable; // Kullanıcıları DataGridView'e bağlar
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
        private void Abone_Load_1(object sender, EventArgs e)
        {
            this.aboneTableAdapter1.Fill(this.bayiiDataSet1.Abone);
         
            cmbAborol.Items.Add("admin");
            cmbAborol.Items.Add("üye");
            cmbAborol.SelectedIndex = 1; // Varsayılan olarak 'üye' seçili
        }

        private void btnAboKay_Click(object sender, EventArgs e)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "INSERT INTO Abone (Isim, Soyisim, Telefon, Email, Adres, KullaniciAdi, Sifre, Rol, Aktiflik) VALUES (@Isim, @Soyisim, @Telefon, @Email, @Adres, @KullaniciAdi, @Sifre, @Rol, @Aktiflik)";
                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Isim", txtAboad.Text);
                command.Parameters.AddWithValue("@Soyisim", txtAboSoy.Text);
                command.Parameters.AddWithValue("@Telefon", msktxtAboTel.Text);
                command.Parameters.AddWithValue("@Email", txtAbopos.Text);
                command.Parameters.AddWithValue("@Adres", rchtxtAboAdres.Text);
                command.Parameters.AddWithValue("@KullaniciAdi", txtAbokulad.Text);
                command.Parameters.AddWithValue("@Sifre", txtAbosif.Text);
                command.Parameters.AddWithValue("@Rol", cmbAborol.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Aktiflik", chkAktif.Checked ? 1 : 0);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla eklendi!");
                    KullaniciListele();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.");
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

      

        

        private void btnAboSil_Click(object sender, EventArgs e)
        {

            if (dgwAbo.SelectedRows.Count > 0)
            {
                int aboneID = Convert.ToInt32(dgwAbo.CurrentRow.Cells[0].Value);
                // int aboneID = Convert.ToInt32(dgwAbo.SelectedRows[0].Cells["AboneID"].Value);

                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    string query = "DELETE FROM Abone WHERE AboneID = @AboneID";
                    SqlCommand command = new SqlCommand(query, _connection);

                    command.Parameters.AddWithValue("@AboneID", aboneID);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi!");
                        command.ExecuteNonQuery();
                        KullaniciListele();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.");
            }
        }

        private void btnAboEx_Click(object sender, EventArgs e)
        {

            Form1 geri = new Form1();
            geri.ShowDialog();
        }
       

       

        private void btnAboGün_Click(object sender, EventArgs e)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                // Güncelleme sorgusu
                string query = @"UPDATE Abone 
                         SET Isim = @Isim, 
                             Soyisim = @Soyisim, 
                             Telefon = @Telefon, 
                             Email = @Email, 
                             Adres = @Adres, 
                             KullaniciAdi = @KullaniciAdi,
                             Rol = @Rol, 
                             Aktiflik = @Aktiflik 
                         WHERE AboneID = @AboneID";

                SqlCommand command = new SqlCommand(query, _connection);

                // Parametreler
                command.Parameters.AddWithValue("@AboneID", dgwAbo.CurrentRow.Cells[0].Value); // Seçilen satırın AboneID'si
                command.Parameters.AddWithValue("@Isim", txtAboad.Text);
                command.Parameters.AddWithValue("@Soyisim", txtAboSoy.Text);
                command.Parameters.AddWithValue("@Telefon", msktxtAboTel.Text);
                command.Parameters.AddWithValue("@Email", txtAbopos.Text);
                command.Parameters.AddWithValue("@Adres", rchtxtAboAdres.Text);
                command.Parameters.AddWithValue("@KullaniciAdi", txtAbokulad.Text);
                command.Parameters.AddWithValue("@Rol", cmbAborol.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Aktiflik", chkAktif.Checked ? 1 : 0);

                // Sorguyu çalıştır
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla güncellendi!");
                    KullaniciListele(); // Güncel veriyi yeniden yükler
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu.");
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


            
            int secilen;
        private void DgwAbo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAboad.Text = dgwAbo.CurrentRow.Cells[1].Value.ToString();
            txtAboSoy.Text = dgwAbo.CurrentRow.Cells[2].Value.ToString();
            msktxtAboTel.Text = dgwAbo.CurrentRow.Cells[3].Value.ToString();
            txtAbopos.Text = dgwAbo.CurrentRow.Cells[4].Value.ToString();
            rchtxtAboAdres.Text = dgwAbo.CurrentRow.Cells[5].Value.ToString();
            txtAbokulad.Text = dgwAbo.CurrentRow.Cells[6].Value.ToString();
            cmbAborol.Text = dgwAbo.CurrentRow.Cells[7].Value.ToString();
            chkAktif.Text = dgwAbo.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnAbver_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV dosyaları (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.FileName = "AboneVerileri.csv"; // Varsayılan dosya adı

            // Eğer kullanıcı bir dosya seçerse
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // DataExport sınıfını çağır ve veriyi dışa aktar
                DataExport dataExport = new DataExport();
                dataExport.ExportDataToCsv(saveFileDialog.FileName); // Seçilen dosya yoluna veri aktarılır
            }
        }
    }
    }
    
    

