using System;

namespace bayii
{
    partial class KullanıcıGirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblhata = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btngir = new System.Windows.Forms.Button();
            this.txtKulsif = new System.Windows.Forms.TextBox();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKulAd = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.lblhata);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btngir);
            this.groupBox2.Controls.Add(this.txtKulsif);
            this.groupBox2.Controls.Add(this.txtKulAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblKulAd);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(41, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 336);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Giriş Ekranı";
            // 
            // lblhata
            // 
            this.lblhata.AutoSize = true;
            this.lblhata.Location = new System.Drawing.Point(24, 291);
            this.lblhata.Name = "lblhata";
            this.lblhata.Size = new System.Drawing.Size(0, 21);
            this.lblhata.TabIndex = 5;
            this.lblhata.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "yeni kayıt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btngir
            // 
            this.btngir.Location = new System.Drawing.Point(129, 198);
            this.btngir.Name = "btngir";
            this.btngir.Size = new System.Drawing.Size(75, 34);
            this.btngir.TabIndex = 1;
            this.btngir.Text = "giriş";
            this.btngir.UseVisualStyleBackColor = true;
            this.btngir.Click += new System.EventHandler(this.btngir_Click);
            // 
            // txtKulsif
            // 
            this.txtKulsif.Location = new System.Drawing.Point(164, 135);
            this.txtKulsif.Name = "txtKulsif";
            this.txtKulsif.PasswordChar = '*';
            this.txtKulsif.Size = new System.Drawing.Size(115, 28);
            this.txtKulsif.TabIndex = 4;
            // 
            // txtKulAd
            // 
            this.txtKulAd.Location = new System.Drawing.Point(164, 54);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(115, 28);
            this.txtKulAd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre:";
            // 
            // lblKulAd
            // 
            this.lblKulAd.AutoSize = true;
            this.lblKulAd.Location = new System.Drawing.Point(39, 61);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Size = new System.Drawing.Size(119, 21);
            this.lblKulAd.TabIndex = 1;
            this.lblKulAd.Text = "Kullanıcı Adı:";
            // 
            // KullanıcıGirisEkrani
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(432, 488);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KullanıcıGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.Load += new System.EventHandler(this.KullanıcıGirisEkrani_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btngir;
        private System.Windows.Forms.TextBox txtKulsif;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKulAd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblhata;

        public EventHandler button3_Click { get; private set; }
        public EventHandler KullanıcıGirisEkrani_Load { get; private set; }
        public EventHandler txtKulAd_TextChanged { get; private set; }
    }
}