namespace bayii
{
    partial class Yayinlar
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
            this.dgwyay = new System.Windows.Forms.DataGridView();
            this.yayinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinSikligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSet2 = new bayii.bayiiDataSet2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbYaytur = new System.Windows.Forms.ComboBox();
            this.cmbyaysıklık = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYayGün = new System.Windows.Forms.Button();
            this.btnYaySil = new System.Windows.Forms.Button();
            this.btnYayKay = new System.Windows.Forms.Button();
            this.msktxtYayFiy = new System.Windows.Forms.MaskedTextBox();
            this.txtYayyayın = new System.Windows.Forms.TextBox();
            this.txtYayad = new System.Windows.Forms.TextBox();
            this.lblAboepo = new System.Windows.Forms.Label();
            this.lblAboTel = new System.Windows.Forms.Label();
            this.lblAbosoy = new System.Windows.Forms.Label();
            this.lblAboAd = new System.Windows.Forms.Label();
            this.bayiiDataSet = new bayii.bayiiDataSet();
            this.bayiiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yayinTableAdapter = new bayii.bayiiDataSet2TableAdapters.YayinTableAdapter();
            this.btnYayEx = new System.Windows.Forms.Button();
            this.btnYayYedekle = new System.Windows.Forms.Button();
            this.btnYayYedektendon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwyay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwyay
            // 
            this.dgwyay.AutoGenerateColumns = false;
            this.dgwyay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwyay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwyay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yayinIDDataGridViewTextBoxColumn,
            this.baslikDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.yayinSikligiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn});
            this.dgwyay.DataSource = this.yayinBindingSource;
            this.dgwyay.Location = new System.Drawing.Point(1, 2);
            this.dgwyay.Name = "dgwyay";
            this.dgwyay.RowHeadersWidth = 51;
            this.dgwyay.RowTemplate.Height = 24;
            this.dgwyay.Size = new System.Drawing.Size(1087, 256);
            this.dgwyay.TabIndex = 0;
            this.dgwyay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwyay_CellContentClick);
            // 
            // yayinIDDataGridViewTextBoxColumn
            // 
            this.yayinIDDataGridViewTextBoxColumn.DataPropertyName = "YayinID";
            this.yayinIDDataGridViewTextBoxColumn.HeaderText = "YayinID";
            this.yayinIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinIDDataGridViewTextBoxColumn.Name = "yayinIDDataGridViewTextBoxColumn";
            this.yayinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yayinIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // baslikDataGridViewTextBoxColumn
            // 
            this.baslikDataGridViewTextBoxColumn.DataPropertyName = "Baslik";
            this.baslikDataGridViewTextBoxColumn.HeaderText = "Baslik";
            this.baslikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslikDataGridViewTextBoxColumn.Name = "baslikDataGridViewTextBoxColumn";
            this.baslikDataGridViewTextBoxColumn.Width = 125;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinSikligiDataGridViewTextBoxColumn
            // 
            this.yayinSikligiDataGridViewTextBoxColumn.DataPropertyName = "YayinSikligi";
            this.yayinSikligiDataGridViewTextBoxColumn.HeaderText = "YayinSikligi";
            this.yayinSikligiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinSikligiDataGridViewTextBoxColumn.Name = "yayinSikligiDataGridViewTextBoxColumn";
            this.yayinSikligiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "Yayinevi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinBindingSource
            // 
            this.yayinBindingSource.DataMember = "Yayin";
            this.yayinBindingSource.DataSource = this.bayiiDataSet2;
            // 
            // bayiiDataSet2
            // 
            this.bayiiDataSet2.DataSetName = "bayiiDataSet2";
            this.bayiiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbYaytur);
            this.groupBox4.Controls.Add(this.cmbyaysıklık);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnYayGün);
            this.groupBox4.Controls.Add(this.btnYaySil);
            this.groupBox4.Controls.Add(this.btnYayKay);
            this.groupBox4.Controls.Add(this.msktxtYayFiy);
            this.groupBox4.Controls.Add(this.txtYayyayın);
            this.groupBox4.Controls.Add(this.txtYayad);
            this.groupBox4.Controls.Add(this.lblAboepo);
            this.groupBox4.Controls.Add(this.lblAboTel);
            this.groupBox4.Controls.Add(this.lblAbosoy);
            this.groupBox4.Controls.Add(this.lblAboAd);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(929, 226);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EKLEME-GÜNCELLEME-SİLME";
            // 
            // cmbYaytur
            // 
            this.cmbYaytur.FormattingEnabled = true;
            this.cmbYaytur.Location = new System.Drawing.Point(112, 106);
            this.cmbYaytur.Name = "cmbYaytur";
            this.cmbYaytur.Size = new System.Drawing.Size(187, 32);
            this.cmbYaytur.TabIndex = 12;
            // 
            // cmbyaysıklık
            // 
            this.cmbyaysıklık.FormattingEnabled = true;
            this.cmbyaysıklık.Location = new System.Drawing.Point(505, 153);
            this.cmbyaysıklık.Name = "cmbyaysıklık";
            this.cmbyaysıklık.Size = new System.Drawing.Size(187, 32);
            this.cmbyaysıklık.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(373, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yayın Sıklığı:";
            // 
            // btnYayGün
            // 
            this.btnYayGün.BackgroundImage = global::bayii.Properties.Resources._6586126_refresh_reload_update_icon;
            this.btnYayGün.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYayGün.Location = new System.Drawing.Point(870, 81);
            this.btnYayGün.Name = "btnYayGün";
            this.btnYayGün.Size = new System.Drawing.Size(53, 47);
            this.btnYayGün.TabIndex = 6;
            this.btnYayGün.UseVisualStyleBackColor = true;
            this.btnYayGün.Click += new System.EventHandler(this.btnYayGün_Click);
            // 
            // btnYaySil
            // 
            this.btnYaySil.BackgroundImage = global::bayii.Properties.Resources._9004743_trash_delete_bin_remove_icon;
            this.btnYaySil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYaySil.Location = new System.Drawing.Point(870, 156);
            this.btnYaySil.Name = "btnYaySil";
            this.btnYaySil.Size = new System.Drawing.Size(57, 50);
            this.btnYaySil.TabIndex = 6;
            this.btnYaySil.UseVisualStyleBackColor = true;
            this.btnYaySil.Click += new System.EventHandler(this.btnYaySil_Click);
            // 
            // btnYayKay
            // 
            this.btnYayKay.BackgroundImage = global::bayii.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnYayKay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYayKay.Location = new System.Drawing.Point(870, 15);
            this.btnYayKay.Name = "btnYayKay";
            this.btnYayKay.Size = new System.Drawing.Size(53, 50);
            this.btnYayKay.TabIndex = 6;
            this.btnYayKay.UseVisualStyleBackColor = true;
            this.btnYayKay.Click += new System.EventHandler(this.btnYayKay_Click);
            // 
            // msktxtYayFiy
            // 
            this.msktxtYayFiy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msktxtYayFiy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtYayFiy.Location = new System.Drawing.Point(112, 169);
            this.msktxtYayFiy.Mask = "00";
            this.msktxtYayFiy.Name = "msktxtYayFiy";
            this.msktxtYayFiy.Size = new System.Drawing.Size(187, 30);
            this.msktxtYayFiy.TabIndex = 6;
            // 
            // txtYayyayın
            // 
            this.txtYayyayın.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtYayyayın.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayyayın.Location = new System.Drawing.Point(505, 62);
            this.txtYayyayın.Name = "txtYayyayın";
            this.txtYayyayın.Size = new System.Drawing.Size(187, 30);
            this.txtYayyayın.TabIndex = 8;
            // 
            // txtYayad
            // 
            this.txtYayad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtYayad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayad.Location = new System.Drawing.Point(112, 35);
            this.txtYayad.Name = "txtYayad";
            this.txtYayad.Size = new System.Drawing.Size(187, 30);
            this.txtYayad.TabIndex = 5;
            // 
            // lblAboepo
            // 
            this.lblAboepo.AutoSize = true;
            this.lblAboepo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboepo.Location = new System.Drawing.Point(33, 178);
            this.lblAboepo.Name = "lblAboepo";
            this.lblAboepo.Size = new System.Drawing.Size(56, 21);
            this.lblAboepo.TabIndex = 3;
            this.lblAboepo.Text = "Fiyat:";
            // 
            // lblAboTel
            // 
            this.lblAboTel.AutoSize = true;
            this.lblAboTel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboTel.Location = new System.Drawing.Point(373, 62);
            this.lblAboTel.Name = "lblAboTel";
            this.lblAboTel.Size = new System.Drawing.Size(84, 21);
            this.lblAboTel.TabIndex = 2;
            this.lblAboTel.Text = "Yayınevi:";
            // 
            // lblAbosoy
            // 
            this.lblAbosoy.AutoSize = true;
            this.lblAbosoy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbosoy.Location = new System.Drawing.Point(33, 106);
            this.lblAbosoy.Name = "lblAbosoy";
            this.lblAbosoy.Size = new System.Drawing.Size(45, 21);
            this.lblAbosoy.TabIndex = 1;
            this.lblAbosoy.Text = "Tür:";
            // 
            // lblAboAd
            // 
            this.lblAboAd.AutoSize = true;
            this.lblAboAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAboAd.Location = new System.Drawing.Point(23, 40);
            this.lblAboAd.Name = "lblAboAd";
            this.lblAboAd.Size = new System.Drawing.Size(92, 21);
            this.lblAboAd.TabIndex = 0;
            this.lblAboAd.Text = "Yayın Adı:";
            // 
            // bayiiDataSet
            // 
            this.bayiiDataSet.DataSetName = "bayiiDataSet";
            this.bayiiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bayiiDataSetBindingSource
            // 
            this.bayiiDataSetBindingSource.DataSource = this.bayiiDataSet;
            this.bayiiDataSetBindingSource.Position = 0;
            // 
            // yayinTableAdapter
            // 
            this.yayinTableAdapter.ClearBeforeFill = true;
            // 
            // btnYayEx
            // 
            this.btnYayEx.BackgroundImage = global::bayii.Properties.Resources._5452459_arrow_direction_door_emergency_exit_icon1;
            this.btnYayEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYayEx.Location = new System.Drawing.Point(1005, 433);
            this.btnYayEx.Name = "btnYayEx";
            this.btnYayEx.Size = new System.Drawing.Size(60, 52);
            this.btnYayEx.TabIndex = 9;
            this.btnYayEx.UseVisualStyleBackColor = true;
            this.btnYayEx.Click += new System.EventHandler(this.btnYayEx_Click);
            // 
            // btnYayYedekle
            // 
            this.btnYayYedekle.Location = new System.Drawing.Point(964, 304);
            this.btnYayYedekle.Name = "btnYayYedekle";
            this.btnYayYedekle.Size = new System.Drawing.Size(101, 30);
            this.btnYayYedekle.TabIndex = 11;
            this.btnYayYedekle.Text = "YEDEKLE";
            this.btnYayYedekle.UseVisualStyleBackColor = true;
            this.btnYayYedekle.Click += new System.EventHandler(this.btnYayYedekle_Click);
            // 
            // btnYayYedektendon
            // 
            this.btnYayYedektendon.Location = new System.Drawing.Point(964, 350);
            this.btnYayYedektendon.Name = "btnYayYedektendon";
            this.btnYayYedektendon.Size = new System.Drawing.Size(101, 42);
            this.btnYayYedektendon.TabIndex = 12;
            this.btnYayYedektendon.Text = "YEDEKTEN DÖN";
            this.btnYayYedektendon.UseVisualStyleBackColor = true;
            this.btnYayYedektendon.Click += new System.EventHandler(this.btnYayYedektendon_Click);
            // 
            // Yayinlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1089, 509);
            this.Controls.Add(this.btnYayYedektendon);
            this.Controls.Add(this.btnYayYedekle);
            this.Controls.Add(this.btnYayEx);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgwyay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Yayinlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayinlar";
            this.Load += new System.EventHandler(this.Yayinlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwyay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwyay;
        private System.Windows.Forms.Button btnYayEx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYayGün;
        private System.Windows.Forms.Button btnYaySil;
        private System.Windows.Forms.Button btnYayKay;
        private System.Windows.Forms.MaskedTextBox msktxtYayFiy;
        private System.Windows.Forms.TextBox txtYayyayın;
        private System.Windows.Forms.TextBox txtYayad;
        private System.Windows.Forms.Label lblAboepo;
        private System.Windows.Forms.Label lblAboTel;
        private System.Windows.Forms.Label lblAbosoy;
        private System.Windows.Forms.Label lblAboAd;
        private System.Windows.Forms.ComboBox cmbyaysıklık;
        private System.Windows.Forms.BindingSource bayiiDataSetBindingSource;
        private bayiiDataSet bayiiDataSet;
        private bayiiDataSet2 bayiiDataSet2;
        private System.Windows.Forms.BindingSource yayinBindingSource;
        private bayiiDataSet2TableAdapters.YayinTableAdapter yayinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinSikligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbYaytur;
        private System.Windows.Forms.Button btnYayYedekle;
        private System.Windows.Forms.Button btnYayYedektendon;
    }
}