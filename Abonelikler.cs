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
    public partial class Abonelikler : Form
    {
        public Abonelikler()
        {
            InitializeComponent();
        }

        private void Abonelikler_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAbolikListele_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // Müşteri numarasını al
                    string musteriNo = txtAbolikID.Text.Trim();

                    // Müşteri numarası boş mu kontrol et
                    if (string.IsNullOrEmpty(musteriNo))
                    {
                        MessageBox.Show("Lütfen bir müşteri numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                // Veritabanı bağlantısını oluştur
                SqlConnection connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");
                { 
                        connection.Open();

                        // Müşteri numarasına göre sorgu
                        string query = "SELECT * FROM Abonelik WHERE AboneID = @AboneID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@AboneID", musteriNo);

                        // Verileri doldur
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        //this.abonelikTableAdapter.Fill(this.bayiiDataSet5.Abonelik);
                    // Eğer eşleşme yoksa hata mesajı göster
                    if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Bu müşteri numarasına ait bir kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // DataGridView'e sonuçları yükle
                            dgwAbolik.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

       
    }
    }

