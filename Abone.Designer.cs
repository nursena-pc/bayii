using System;
using System.Windows.Forms;

namespace bayii
{
    partial class Abone
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
            this.components = new System.ComponentModel.Container();
            this.dgwAbo = new System.Windows.Forms.DataGridView();
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktiflikDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aboneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSet1 = new bayii.bayiiDataSet1();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSet = new bayii.bayiiDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.cmbAborol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbosif = new System.Windows.Forms.TextBox();
            this.txtAbokulad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAboGün = new System.Windows.Forms.Button();
            this.btnAboSil = new System.Windows.Forms.Button();
            this.btnAboKay = new System.Windows.Forms.Button();
            this.rchtxtAboAdres = new System.Windows.Forms.RichTextBox();
            this.msktxtAboTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAbopos = new System.Windows.Forms.TextBox();
            this.txtAboSoy = new System.Windows.Forms.TextBox();
            this.txtAboad = new System.Windows.Forms.TextBox();
            this.lblAboAdres = new System.Windows.Forms.Label();
            this.lblAboepo = new System.Windows.Forms.Label();
            this.lblAboTel = new System.Windows.Forms.Label();
            this.lblAbosoy = new System.Windows.Forms.Label();
            this.lblAboAd = new System.Windows.Forms.Label();
            this.btnAboEx = new System.Windows.Forms.Button();
            this.aboneTableAdapter = new bayii.bayiiDataSetTableAdapters.AboneTableAdapter();
            this.aboneTableAdapter1 = new bayii.bayiiDataSet1TableAdapters.AboneTableAdapter();
            this.btnAbver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAbo
            // 
            this.dgwAbo.AutoGenerateColumns = false;
            this.dgwAbo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aboneIDDataGridViewTextBoxColumn,
            this.ısimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.aktiflikDataGridViewCheckBoxColumn});
            this.dgwAbo.DataSource = this.aboneBindingSource1;
            this.dgwAbo.Location = new System.Drawing.Point(-7, 2);
            this.dgwAbo.Name = "dgwAbo";
            this.dgwAbo.RowHeadersWidth = 51;
            this.dgwAbo.RowTemplate.Height = 24;
            this.dgwAbo.Size = new System.Drawing.Size(1037, 217);
            this.dgwAbo.TabIndex = 0;
            this.dgwAbo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwAbo_CellClick);
            // 
            // aboneIDDataGridViewTextBoxColumn
            // 
            this.aboneIDDataGridViewTextBoxColumn.DataPropertyName = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.HeaderText = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aboneIDDataGridViewTextBoxColumn.Name = "aboneIDDataGridViewTextBoxColumn";
            this.aboneIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aboneIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            this.ısimDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.Width = 125;
            // 
            // aktiflikDataGridViewCheckBoxColumn
            // 
            this.aktiflikDataGridViewCheckBoxColumn.DataPropertyName = "Aktiflik";
            this.aktiflikDataGridViewCheckBoxColumn.HeaderText = "Aktiflik";
            this.aktiflikDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.aktiflikDataGridViewCheckBoxColumn.Name = "aktiflikDataGridViewCheckBoxColumn";
            this.aktiflikDataGridViewCheckBoxColumn.Width = 125;
            // 
            // aboneBindingSource1
            // 
            this.aboneBindingSource1.DataMember = "Abone";
            this.aboneBindingSource1.DataSource = this.bayiiDataSet1;
            // 
            // bayiiDataSet1
            // 
            this.bayiiDataSet1.DataSetName = "bayiiDataSet1";
            this.bayiiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataMember = "Abone";
            this.aboneBindingSource.DataSource = this.bayiiDataSet;
            // 
            // bayiiDataSet
            // 
            this.bayiiDataSet.DataSetName = "bayiiDataSet";
            this.bayiiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAktif);
            this.groupBox4.Controls.Add(this.cmbAborol);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtAbosif);
            this.groupBox4.Controls.Add(this.txtAbokulad);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnAboGün);
            this.groupBox4.Controls.Add(this.btnAboSil);
            this.groupBox4.Controls.Add(this.btnAboKay);
            this.groupBox4.Controls.Add(this.rchtxtAboAdres);
            this.groupBox4.Controls.Add(this.msktxtAboTel);
            this.groupBox4.Controls.Add(this.txtAbopos);
            this.groupBox4.Controls.Add(this.txtAboSoy);
            this.groupBox4.Controls.Add(this.txtAboad);
            this.groupBox4.Controls.Add(this.lblAboAdres);
            this.groupBox4.Controls.Add(this.lblAboepo);
            this.groupBox4.Controls.Add(this.lblAboTel);
            this.groupBox4.Controls.Add(this.lblAbosoy);
            this.groupBox4.Controls.Add(this.lblAboAd);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(2, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(929, 238);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EKLEME-GÜNCELLEME-SİLME";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(689, 191);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(91, 25);
            this.chkAktif.TabIndex = 19;
            this.chkAktif.Text = "Aktiflik";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // cmbAborol
            // 
            this.cmbAborol.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAborol.FormattingEnabled = true;
            this.cmbAborol.Location = new System.Drawing.Point(728, 107);
            this.cmbAborol.Name = "cmbAborol";
            this.cmbAborol.Size = new System.Drawing.Size(121, 32);
            this.cmbAborol.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(651, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rol";
            // 
            // txtAbosif
            // 
            this.txtAbosif.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAbosif.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAbosif.Location = new System.Drawing.Point(392, 186);
            this.txtAbosif.Name = "txtAbosif";
            this.txtAbosif.Size = new System.Drawing.Size(202, 30);
            this.txtAbosif.TabIndex = 12;
            // 
            // txtAbokulad
            // 
            this.txtAbokulad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAbokulad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAbokulad.Location = new System.Drawing.Point(728, 23);
            this.txtAbokulad.Name = "txtAbokulad";
            this.txtAbokulad.Size = new System.Drawing.Size(121, 30);
            this.txtAbokulad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(330, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(613, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnAboGün
            // 
            this.btnAboGün.BackgroundImage = global::bayii.Properties.Resources._6586126_refresh_reload_update_icon;
            this.btnAboGün.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboGün.Location = new System.Drawing.Point(870, 100);
            this.btnAboGün.Name = "btnAboGün";
            this.btnAboGün.Size = new System.Drawing.Size(53, 47);
            this.btnAboGün.TabIndex = 6;
            this.btnAboGün.UseVisualStyleBackColor = true;
            this.btnAboGün.Click += new System.EventHandler(this.btnAboGün_Click);
            // 
            // btnAboSil
            // 
            this.btnAboSil.BackgroundImage = global::bayii.Properties.Resources._9004743_trash_delete_bin_remove_icon;
            this.btnAboSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboSil.Location = new System.Drawing.Point(866, 178);
            this.btnAboSil.Name = "btnAboSil";
            this.btnAboSil.Size = new System.Drawing.Size(57, 50);
            this.btnAboSil.TabIndex = 6;
            this.btnAboSil.UseVisualStyleBackColor = true;
            this.btnAboSil.Click += new System.EventHandler(this.btnAboSil_Click);
            // 
            // btnAboKay
            // 
            this.btnAboKay.BackgroundImage = global::bayii.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnAboKay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboKay.Location = new System.Drawing.Point(870, 15);
            this.btnAboKay.Name = "btnAboKay";
            this.btnAboKay.Size = new System.Drawing.Size(53, 50);
            this.btnAboKay.TabIndex = 6;
            this.btnAboKay.UseVisualStyleBackColor = true;
            this.btnAboKay.Click += new System.EventHandler(this.btnAboKay_Click);
            // 
            // rchtxtAboAdres
            // 
            this.rchtxtAboAdres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rchtxtAboAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxtAboAdres.Location = new System.Drawing.Point(392, 21);
            this.rchtxtAboAdres.Name = "rchtxtAboAdres";
            this.rchtxtAboAdres.Size = new System.Drawing.Size(202, 126);
            this.rchtxtAboAdres.TabIndex = 6;
            this.rchtxtAboAdres.Text = "";
            // 
            // msktxtAboTel
            // 
            this.msktxtAboTel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msktxtAboTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtAboTel.Location = new System.Drawing.Point(112, 140);
            this.msktxtAboTel.Mask = "(999) 000-0000";
            this.msktxtAboTel.Name = "msktxtAboTel";
            this.msktxtAboTel.Size = new System.Drawing.Size(187, 30);
            this.msktxtAboTel.TabIndex = 6;
            // 
            // txtAbopos
            // 
            this.txtAbopos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAbopos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAbopos.Location = new System.Drawing.Point(112, 186);
            this.txtAbopos.Name = "txtAbopos";
            this.txtAbopos.Size = new System.Drawing.Size(187, 30);
            this.txtAbopos.TabIndex = 8;
            // 
            // txtAboSoy
            // 
            this.txtAboSoy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAboSoy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAboSoy.Location = new System.Drawing.Point(112, 83);
            this.txtAboSoy.Name = "txtAboSoy";
            this.txtAboSoy.Size = new System.Drawing.Size(187, 30);
            this.txtAboSoy.TabIndex = 6;
            // 
            // txtAboad
            // 
            this.txtAboad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAboad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAboad.Location = new System.Drawing.Point(112, 29);
            this.txtAboad.Name = "txtAboad";
            this.txtAboad.Size = new System.Drawing.Size(187, 30);
            this.txtAboad.TabIndex = 5;
            // 
            // lblAboAdres
            // 
            this.lblAboAdres.AutoSize = true;
            this.lblAboAdres.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboAdres.Location = new System.Drawing.Point(330, 32);
            this.lblAboAdres.Name = "lblAboAdres";
            this.lblAboAdres.Size = new System.Drawing.Size(56, 21);
            this.lblAboAdres.TabIndex = 4;
            this.lblAboAdres.Text = "Adres";
            // 
            // lblAboepo
            // 
            this.lblAboepo.AutoSize = true;
            this.lblAboepo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboepo.Location = new System.Drawing.Point(33, 191);
            this.lblAboepo.Name = "lblAboepo";
            this.lblAboepo.Size = new System.Drawing.Size(72, 21);
            this.lblAboepo.TabIndex = 3;
            this.lblAboepo.Text = "E-posta";
            // 
            // lblAboTel
            // 
            this.lblAboTel.AutoSize = true;
            this.lblAboTel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboTel.Location = new System.Drawing.Point(33, 140);
            this.lblAboTel.Name = "lblAboTel";
            this.lblAboTel.Size = new System.Drawing.Size(71, 21);
            this.lblAboTel.TabIndex = 2;
            this.lblAboTel.Text = "Telefon";
            // 
            // lblAbosoy
            // 
            this.lblAbosoy.AutoSize = true;
            this.lblAbosoy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbosoy.Location = new System.Drawing.Point(33, 83);
            this.lblAbosoy.Name = "lblAbosoy";
            this.lblAbosoy.Size = new System.Drawing.Size(58, 21);
            this.lblAbosoy.TabIndex = 1;
            this.lblAbosoy.Text = "Soyad";
            // 
            // lblAboAd
            // 
            this.lblAboAd.AutoSize = true;
            this.lblAboAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboAd.Location = new System.Drawing.Point(33, 32);
            this.lblAboAd.Name = "lblAboAd";
            this.lblAboAd.Size = new System.Drawing.Size(32, 21);
            this.lblAboAd.TabIndex = 0;
            this.lblAboAd.Text = "Ad";
            // 
            // btnAboEx
            // 
            this.btnAboEx.BackgroundImage = global::bayii.Properties.Resources._5452459_arrow_direction_door_emergency_exit_icon1;
            this.btnAboEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboEx.Location = new System.Drawing.Point(960, 344);
            this.btnAboEx.Name = "btnAboEx";
            this.btnAboEx.Size = new System.Drawing.Size(60, 52);
            this.btnAboEx.TabIndex = 7;
            this.btnAboEx.UseVisualStyleBackColor = true;
            this.btnAboEx.Click += new System.EventHandler(this.btnAboEx_Click);
            // 
            // aboneTableAdapter
            // 
            this.aboneTableAdapter.ClearBeforeFill = true;
            // 
            // aboneTableAdapter1
            // 
            this.aboneTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAbver
            // 
            this.btnAbver.Location = new System.Drawing.Point(865, 223);
            this.btnAbver.Name = "btnAbver";
            this.btnAbver.Size = new System.Drawing.Size(155, 38);
            this.btnAbver.TabIndex = 8;
            this.btnAbver.Text = "veriyi dışarı aktar";
            this.btnAbver.UseVisualStyleBackColor = true;
            this.btnAbver.Click += new System.EventHandler(this.btnAbver_Click);
            // 
            // Abone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 533);
            this.ControlBox = false;
            this.Controls.Add(this.btnAbver);
            this.Controls.Add(this.btnAboEx);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgwAbo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Abone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abone";
            this.Load += new System.EventHandler(this.Abone_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAbo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAbopos;
        private System.Windows.Forms.TextBox txtAboSoy;
        private System.Windows.Forms.TextBox txtAboad;
        private System.Windows.Forms.Label lblAboAdres;
        private System.Windows.Forms.Label lblAboepo;
        private System.Windows.Forms.Label lblAboTel;
        private System.Windows.Forms.Label lblAbosoy;
        private System.Windows.Forms.Label lblAboAd;
        private System.Windows.Forms.MaskedTextBox msktxtAboTel;
        private System.Windows.Forms.RichTextBox rchtxtAboAdres;
        private System.Windows.Forms.Button btnAboGün;
        private System.Windows.Forms.Button btnAboSil;
        private System.Windows.Forms.Button btnAboKay;
        private System.Windows.Forms.Button btnAboEx;
        private EventHandler Abone_Load;
        private readonly EventHandler textBox7_TextChanged;
        private Label label2;
        private Label label1;
        private TextBox txtAbosif;
        private TextBox txtAbokulad;
        private ComboBox cmbAborol;
        private Label label3;
        private CheckBox chkAktif;
        private bayiiDataSet bayiiDataSet;
        private BindingSource aboneBindingSource;
        private bayiiDataSetTableAdapters.AboneTableAdapter aboneTableAdapter;
        private DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aktiflikDataGridViewCheckBoxColumn;
        private bayiiDataSet1 bayiiDataSet1;
        private BindingSource aboneBindingSource1;
        private bayiiDataSet1TableAdapters.AboneTableAdapter aboneTableAdapter1;
        private Button btnAbver;

        public DataGridViewCellEventHandler dataGridView1_CellContentClick { get; private set; }
        public EventHandler groupBox4_Enter { get; private set; }
        public EventHandler textBox9_TextChanged { get; private set; }
        public EventHandler textBox10_TextChanged { get; private set; }
        public MaskInputRejectedEventHandler maskedTextBox1_MaskInputRejected { get; private set; }
        public EventHandler rchtxtAboAdres_TextChanged { get; private set; }
        public EventHandler txtAboAd_Click { get; private set; }
        public EventHandler txtAbosoy_Click { get; private set; }
        public DataGridViewCellEventHandler dgwAbo_CellContentClick { get; private set; }
        public DataGridViewCellEventHandler DgwAbo_CellContentClick { get; private set; }
    }
}