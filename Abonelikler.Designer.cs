namespace bayii
{
    partial class Abonelikler
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
            this.dgwAbolik = new System.Windows.Forms.DataGridView();
            this.abonelikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonelikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSet5 = new bayii.bayiiDataSet5();
            this.abonelikTableAdapter = new bayii.bayiiDataSet5TableAdapters.AbonelikTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbolikListele = new System.Windows.Forms.Button();
            this.txtAbolikID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbolik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAbolik
            // 
            this.dgwAbolik.AutoGenerateColumns = false;
            this.dgwAbolik.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwAbolik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAbolik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abonelikIDDataGridViewTextBoxColumn,
            this.aboneIDDataGridViewTextBoxColumn,
            this.yayinIDDataGridViewTextBoxColumn,
            this.baslangicTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dgwAbolik.DataSource = this.abonelikBindingSource;
            this.dgwAbolik.Location = new System.Drawing.Point(12, 12);
            this.dgwAbolik.Name = "dgwAbolik";
            this.dgwAbolik.RowHeadersWidth = 51;
            this.dgwAbolik.RowTemplate.Height = 24;
            this.dgwAbolik.Size = new System.Drawing.Size(776, 99);
            this.dgwAbolik.TabIndex = 0;
            // 
            // abonelikIDDataGridViewTextBoxColumn
            // 
            this.abonelikIDDataGridViewTextBoxColumn.DataPropertyName = "AbonelikID";
            this.abonelikIDDataGridViewTextBoxColumn.HeaderText = "AbonelikID";
            this.abonelikIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.abonelikIDDataGridViewTextBoxColumn.Name = "abonelikIDDataGridViewTextBoxColumn";
            this.abonelikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.abonelikIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aboneIDDataGridViewTextBoxColumn
            // 
            this.aboneIDDataGridViewTextBoxColumn.DataPropertyName = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.HeaderText = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aboneIDDataGridViewTextBoxColumn.Name = "aboneIDDataGridViewTextBoxColumn";
            this.aboneIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinIDDataGridViewTextBoxColumn
            // 
            this.yayinIDDataGridViewTextBoxColumn.DataPropertyName = "YayinID";
            this.yayinIDDataGridViewTextBoxColumn.HeaderText = "YayinID";
            this.yayinIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinIDDataGridViewTextBoxColumn.Name = "yayinIDDataGridViewTextBoxColumn";
            this.yayinIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // baslangicTarihiDataGridViewTextBoxColumn
            // 
            this.baslangicTarihiDataGridViewTextBoxColumn.DataPropertyName = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.HeaderText = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslangicTarihiDataGridViewTextBoxColumn.Name = "baslangicTarihiDataGridViewTextBoxColumn";
            this.baslangicTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bitisTarihiDataGridViewTextBoxColumn
            // 
            this.bitisTarihiDataGridViewTextBoxColumn.DataPropertyName = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.HeaderText = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitisTarihiDataGridViewTextBoxColumn.Name = "bitisTarihiDataGridViewTextBoxColumn";
            this.bitisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // abonelikBindingSource
            // 
            this.abonelikBindingSource.DataMember = "Abonelik";
            this.abonelikBindingSource.DataSource = this.bayiiDataSet5;
            // 
            // bayiiDataSet5
            // 
            this.bayiiDataSet5.DataSetName = "bayiiDataSet5";
            this.bayiiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonelikTableAdapter
            // 
            this.abonelikTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası:";
            // 
            // btnAbolikListele
            // 
            this.btnAbolikListele.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbolikListele.Location = new System.Drawing.Point(336, 225);
            this.btnAbolikListele.Name = "btnAbolikListele";
            this.btnAbolikListele.Size = new System.Drawing.Size(110, 34);
            this.btnAbolikListele.TabIndex = 9;
            this.btnAbolikListele.Text = "LİSTELE";
            this.btnAbolikListele.UseVisualStyleBackColor = true;
            this.btnAbolikListele.Click += new System.EventHandler(this.btnAbolikListele_Click);
            // 
            // txtAbolikID
            // 
            this.txtAbolikID.Location = new System.Drawing.Point(231, 164);
            this.txtAbolikID.Name = "txtAbolikID";
            this.txtAbolikID.Size = new System.Drawing.Size(100, 22);
            this.txtAbolikID.TabIndex = 10;
            // 
            // Abonelikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.txtAbolikID);
            this.Controls.Add(this.btnAbolikListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAbolik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Abonelikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonelikler";
            this.Load += new System.EventHandler(this.Abonelikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbolik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAbolik;
        private bayiiDataSet5 bayiiDataSet5;
        private System.Windows.Forms.BindingSource abonelikBindingSource;
        private bayiiDataSet5TableAdapters.AbonelikTableAdapter abonelikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonelikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbolikListele;
        private System.Windows.Forms.TextBox txtAbolikID;
    }
}