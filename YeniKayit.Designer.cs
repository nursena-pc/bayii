using System;

namespace bayii
{
    partial class YeniKayit
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
            this.rchyenadres = new System.Windows.Forms.RichTextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.msktxtyentel = new System.Windows.Forms.MaskedTextBox();
            this.txtYenpos = new System.Windows.Forms.TextBox();
            this.txtYenSoy = new System.Windows.Forms.TextBox();
            this.txtYenAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbyenrol = new System.Windows.Forms.ComboBox();
            this.btnYenikay = new System.Windows.Forms.Button();
            this.txtYensif = new System.Windows.Forms.TextBox();
            this.txtYeniadkul = new System.Windows.Forms.TextBox();
            this.lblyensif = new System.Windows.Forms.Label();
            this.lblyenKulAd = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.rchyenadres);
            this.groupBox2.Controls.Add(this.chkAktif);
            this.groupBox2.Controls.Add(this.msktxtyentel);
            this.groupBox2.Controls.Add(this.txtYenpos);
            this.groupBox2.Controls.Add(this.txtYenSoy);
            this.groupBox2.Controls.Add(this.txtYenAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbyenrol);
            this.groupBox2.Controls.Add(this.btnYenikay);
            this.groupBox2.Controls.Add(this.txtYensif);
            this.groupBox2.Controls.Add(this.txtYeniadkul);
            this.groupBox2.Controls.Add(this.lblyensif);
            this.groupBox2.Controls.Add(this.lblyenKulAd);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // rchyenadres
            // 
            this.rchyenadres.Location = new System.Drawing.Point(132, 294);
            this.rchyenadres.Name = "rchyenadres";
            this.rchyenadres.Size = new System.Drawing.Size(253, 116);
            this.rchyenadres.TabIndex = 19;
            this.rchyenadres.Text = "";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(392, 61);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(104, 25);
            this.chkAktif.TabIndex = 18;
            this.chkAktif.Text = "Aktif üye";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // msktxtyentel
            // 
            this.msktxtyentel.Location = new System.Drawing.Point(132, 168);
            this.msktxtyentel.Mask = "(999) 000-0000";
            this.msktxtyentel.Name = "msktxtyentel";
            this.msktxtyentel.Size = new System.Drawing.Size(163, 28);
            this.msktxtyentel.TabIndex = 16;
            // 
            // txtYenpos
            // 
            this.txtYenpos.Location = new System.Drawing.Point(132, 247);
            this.txtYenpos.Name = "txtYenpos";
            this.txtYenpos.Size = new System.Drawing.Size(163, 28);
            this.txtYenpos.TabIndex = 14;
            // 
            // txtYenSoy
            // 
            this.txtYenSoy.Location = new System.Drawing.Point(132, 110);
            this.txtYenSoy.Name = "txtYenSoy";
            this.txtYenSoy.Size = new System.Drawing.Size(163, 28);
            this.txtYenSoy.TabIndex = 13;
            // 
            // txtYenAd
            // 
            this.txtYenAd.Location = new System.Drawing.Point(132, 58);
            this.txtYenAd.Name = "txtYenAd";
            this.txtYenAd.Size = new System.Drawing.Size(163, 28);
            this.txtYenAd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rol:";
            // 
            // cmbyenrol
            // 
            this.cmbyenrol.FormattingEnabled = true;
            this.cmbyenrol.Location = new System.Drawing.Point(516, 221);
            this.cmbyenrol.Name = "cmbyenrol";
            this.cmbyenrol.Size = new System.Drawing.Size(149, 29);
            this.cmbyenrol.TabIndex = 5;
            this.cmbyenrol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnYenikay
            // 
            this.btnYenikay.Location = new System.Drawing.Point(495, 376);
            this.btnYenikay.Name = "btnYenikay";
            this.btnYenikay.Size = new System.Drawing.Size(111, 34);
            this.btnYenikay.TabIndex = 1;
            this.btnYenikay.Text = "kaydet";
            this.btnYenikay.UseVisualStyleBackColor = true;
            this.btnYenikay.Click += new System.EventHandler(this.btnYenikay_Click);
            // 
            // txtYensif
            // 
            this.txtYensif.Location = new System.Drawing.Point(516, 168);
            this.txtYensif.Name = "txtYensif";
            this.txtYensif.Size = new System.Drawing.Size(149, 28);
            this.txtYensif.TabIndex = 4;
            // 
            // txtYeniadkul
            // 
            this.txtYeniadkul.Location = new System.Drawing.Point(522, 110);
            this.txtYeniadkul.Name = "txtYeniadkul";
            this.txtYeniadkul.Size = new System.Drawing.Size(143, 28);
            this.txtYeniadkul.TabIndex = 3;
            // 
            // lblyensif
            // 
            this.lblyensif.AutoSize = true;
            this.lblyensif.Location = new System.Drawing.Point(412, 171);
            this.lblyensif.Name = "lblyensif";
            this.lblyensif.Size = new System.Drawing.Size(53, 21);
            this.lblyensif.TabIndex = 2;
            this.lblyensif.Text = "Şifre:";
            // 
            // lblyenKulAd
            // 
            this.lblyenKulAd.AutoSize = true;
            this.lblyenKulAd.Location = new System.Drawing.Point(388, 110);
            this.lblyenKulAd.Name = "lblyenKulAd";
            this.lblyenKulAd.Size = new System.Drawing.Size(119, 21);
            this.lblyenKulAd.TabIndex = 1;
            this.lblyenKulAd.Text = "Kullanıcı Adı:";
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(681, 454);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniKayit";
            this.Load += new System.EventHandler(this.YeniKayit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYenikay;
        private System.Windows.Forms.TextBox txtYensif;
        private System.Windows.Forms.TextBox txtYeniadkul;
        private System.Windows.Forms.Label lblyensif;
        private System.Windows.Forms.Label lblyenKulAd;
        private System.Windows.Forms.ComboBox cmbyenrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYenAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYenpos;
        private System.Windows.Forms.TextBox txtYenSoy;
        private System.Windows.Forms.MaskedTextBox msktxtyentel;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.RichTextBox rchyenadres;

        public EventHandler label2_Click { get; private set; }
        public EventHandler groupBox2_Enter { get; private set; }
    }
}