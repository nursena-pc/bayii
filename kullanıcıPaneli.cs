using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayii
{
    public partial class kullanıcıPaneli : Form
    {
        public kullanıcıPaneli()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbonelik_Click(object sender, EventArgs e)
        {
            Abonelikler abonelik = new Abonelikler();
            abonelik.ShowDialog();
        }

        private void btnYayin_Click(object sender, EventArgs e)
        {
            YayinlariArama arama = new YayinlariArama();
            arama.ShowDialog();
        }
    }
}
