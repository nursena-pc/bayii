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
    public partial class Yayinlar : Form
    {
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");

        public Yayinlar()
        {
            InitializeComponent();
        }
        private void YayinListele()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "SELECT * FROM Yayin";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgwyay.DataSource = dataTable; // yayınları DataGridView'e bağlar
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
        private void Yayinlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bayiiDataSet2.Yayin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yayinTableAdapter.Fill(this.bayiiDataSet2.Yayin);

            cmbyaysıklık.Items.Add("Günlük");
            cmbyaysıklık.Items.Add("Haftalık");
            cmbyaysıklık.Items.Add("Aylık");
            cmbyaysıklık.Items.Add("Yıllık");
            cmbYaytur.Items.Add("Dergi");
            cmbYaytur.Items.Add("Gazete");
        }

        private void dgwyay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYayad.Text = dgwyay.CurrentRow.Cells[1].Value.ToString();
            cmbYaytur.Text = dgwyay.CurrentRow.Cells[2].Value.ToString();
            msktxtYayFiy.Text = dgwyay.CurrentRow.Cells[3].Value.ToString();
            cmbyaysıklık.Text = dgwyay.CurrentRow.Cells[4].Value.ToString();
            txtYayyayın.Text = dgwyay.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnYayKay_Click(object sender, EventArgs e)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                string query = "INSERT INTO Yayin (Baslik, Tur, Fiyat, YayinSikligi, Yayinevi) VALUES (@Baslik, @Tur, @Fiyat, @YayinSikligi, @Yayinevi)";
                SqlCommand command = new SqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Baslik", txtYayad.Text);
                command.Parameters.AddWithValue("@Tur", cmbYaytur.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Fiyat", msktxtYayFiy.Text);
                command.Parameters.AddWithValue("@YayinSikligi", cmbyaysıklık.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Yayinevi", txtYayyayın.Text);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Yayın başarıyla eklendi!");
                    YayinListele();
                }
                else
                {
                    MessageBox.Show("Yayın eklenirken bir hata oluştu.");
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

        private void btnYaySil_Click(object sender, EventArgs e)
        {
            if (dgwyay.SelectedRows.Count > 0)
            {
                int yayinID = Convert.ToInt32(dgwyay.CurrentRow.Cells[0].Value);

                try
                {
                    if (_connection.State == ConnectionState.Closed)
                        _connection.Open();

                    string query = "DELETE FROM Yayin WHERE YayinID = @YayinID";
                    SqlCommand command = new SqlCommand(query, _connection);

                    command.Parameters.AddWithValue("@YayinID", yayinID);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Yayın başarıyla silindi!");
                        command.ExecuteNonQuery();
                        YayinListele();
                    }
                    else
                    {
                        MessageBox.Show("Yayın silinirken bir hata oluştu.");
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
                MessageBox.Show("Lütfen silmek istediğiniz Yayını seçin.");
            }
        }

        private void btnYayEx_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.ShowDialog();
        }

        private void btnYayGün_Click(object sender, EventArgs e)
        {
           
                if (dgwyay.SelectedRows.Count > 0)
                {
                    // Seçili yayının ID'sini al
                    int yayinID = Convert.ToInt32(dgwyay.CurrentRow.Cells[0].Value);

                    try
                    {
                        if (_connection.State == ConnectionState.Closed)
                            _connection.Open();

                        // Güncelleme sorgusu
                        string query = "UPDATE Yayin SET Baslik = @Baslik, Tur = @Tur, Fiyat = @Fiyat, YayinSikligi = @YayinSikligi, Yayinevi = @Yayinevi WHERE YayinID = @YayinID";
                        SqlCommand command = new SqlCommand(query, _connection);

                        // Parametreleri atama
                        command.Parameters.AddWithValue("@Baslik", txtYayad.Text);
                    command.Parameters.AddWithValue("@Tur", cmbYaytur.SelectedItem?.ToString() ?? string.Empty);

                    //command.Parameters.AddWithValue("@Tur", cmbYaytur.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Fiyat", msktxtYayFiy.Text);
                        command.Parameters.AddWithValue("@YayinSikligi", cmbyaysıklık.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Yayinevi", txtYayyayın.Text);
                        command.Parameters.AddWithValue("@YayinID", yayinID);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Yayın başarıyla güncellendi!");
                            YayinListele(); // Güncellenmiş verileri tekrar yükle
                        }
                        else
                        {
                            MessageBox.Show("Yayın güncellenirken bir hata oluştu.");
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
                    MessageBox.Show("Lütfen güncellemek istediğiniz yayını seçin.");
                }
            }

        
        
    

        private void btnYayYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Yedekleme dosyasının kaydedileceği yol
                string backupPath = @"C:\Reports\bayii_yedek.bak";

                // Dizini kontrol et ve oluştur
                if (!System.IO.Directory.Exists(@"C:\Reports"))
                {
                    System.IO.Directory.CreateDirectory(@"C:\Reports");
                }

                // SQL komutu
                string backupQuery = $@"BACKUP DATABASE bayii TO DISK = '{backupPath}'";

                // SQL bağlantısı ve komut çalıştırma
                using (SqlConnection connection = new SqlConnection(@"Server=-ND-\SQLEXPRESS; Database=master; Integrated Security=True;"))
                {
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Veritabanı başarıyla yedeklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekleme sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYayYedektendon_Click(object sender, EventArgs e)
        {
            string backupPath = @"C:\Reports\bayii_yedek.bak";
            string setSingleUserQuery = "ALTER DATABASE bayii SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            string restoreQuery = $@"
    RESTORE DATABASE bayii
    FROM DISK = '{backupPath}'
    WITH REPLACE";
            string setMultiUserQuery = "ALTER DATABASE bayii SET MULTI_USER;";

            using (SqlConnection connection = new SqlConnection(@"Server=-ND-\SQLEXPRESS; Database=master; Integrated Security=True;"))
            {
                connection.Open();

                // Veritabanını SINGLE_USER moduna al
                SqlCommand singleUserCommand = new SqlCommand(setSingleUserQuery, connection);
                singleUserCommand.ExecuteNonQuery();

                // Veritabanını geri yükle
                SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection);
                restoreCommand.ExecuteNonQuery();

                // Veritabanını MULTI_USER moduna al
                SqlCommand multiUserCommand = new SqlCommand(setMultiUserQuery, connection);
                multiUserCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Veritabanı başarıyla geri yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YayinListele();

        }
    }
}
    
   
    

