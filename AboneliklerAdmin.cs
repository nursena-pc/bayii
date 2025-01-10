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
    public partial class AboneliklerAdmin : Form
    {
        public AboneliklerAdmin()
        {
            InitializeComponent();
        }

        private void btnAbolikExAdmin_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.ShowDialog();
        }

        private void btnAbolikListeleAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                // Müşteri numarasını al
                string musteriNo = txtAbolikIDAdmin.Text.Trim();

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
                        dgwAbolikAdmin.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboneliklerAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bayiiDataSet6.Abonelik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.abonelikTableAdapter.Fill(this.bayiiDataSet6.Abonelik);

        }
    }
}
