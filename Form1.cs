using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Options();
            
        }

        private void Options()
        {
            if (!Directory.Exists("D:\\bayii"))
                Directory.CreateDirectory("D:\\bayii");

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Abone abone = new Abone();
            abone.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // db.kapa = true;
            Application.Exit();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnAbonelik_Click(object sender, EventArgs e)
        {
            AboneliklerAdmin abonelik = new AboneliklerAdmin();
            abonelik.ShowDialog();
        }

        

        private void btnYayin_Click(object sender, EventArgs e)
        {
            Yayinlar yayin = new Yayinlar();
            yayin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YayinlariArama arama = new YayinlariArama();
            arama.ShowDialog();
        }
    }

}
