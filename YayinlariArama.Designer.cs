using System;

namespace bayii
{
    partial class YayinlariArama
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
            this.dgwara = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSetYayin = new bayii.bayiiDataSetYayin();
            this.txtarara = new System.Windows.Forms.TextBox();
            this.cmbarafilt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnyaypdf = new System.Windows.Forms.Button();
            this.btnyaysep = new System.Windows.Forms.Button();
            this.btnyaycuz = new System.Windows.Forms.Button();
            this.btnarara = new System.Windows.Forms.Button();
            this.yayinTableAdapter1 = new bayii.bayiiDataSetYayinTableAdapters.YayinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSetYayin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwara
            // 
            this.dgwara.AutoGenerateColumns = false;
            this.dgwara.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgwara.DataSource = this.yayinBindingSource2;
            this.dgwara.Location = new System.Drawing.Point(3, 3);
            this.dgwara.Name = "dgwara";
            this.dgwara.RowHeadersWidth = 51;
            this.dgwara.RowTemplate.Height = 24;
            this.dgwara.Size = new System.Drawing.Size(795, 201);
            this.dgwara.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YayinID";
            this.dataGridViewTextBoxColumn1.HeaderText = "YayinID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Baslik";
            this.dataGridViewTextBoxColumn2.HeaderText = "Baslik";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tur";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fiyat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YayinSikligi";
            this.dataGridViewTextBoxColumn5.HeaderText = "YayinSikligi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Yayinevi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Yayinevi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // yayinBindingSource2
            // 
            this.yayinBindingSource2.DataMember = "Yayin";
            this.yayinBindingSource2.DataSource = this.bayiiDataSetYayin;
            // 
            // bayiiDataSetYayin
            // 
            this.bayiiDataSetYayin.DataSetName = "bayiiDataSetYayin";
            this.bayiiDataSetYayin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtarara
            // 
            this.txtarara.Location = new System.Drawing.Point(245, 350);
            this.txtarara.Name = "txtarara";
            this.txtarara.Size = new System.Drawing.Size(200, 22);
            this.txtarara.TabIndex = 1;
            // 
            // cmbarafilt
            // 
            this.cmbarafilt.FormattingEnabled = true;
            this.cmbarafilt.Location = new System.Drawing.Point(245, 289);
            this.cmbarafilt.Name = "cmbarafilt";
            this.cmbarafilt.Size = new System.Drawing.Size(200, 24);
            this.cmbarafilt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtreleme Seçeneği:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arama:";
            // 
            // btnyaypdf
            // 
            this.btnyaypdf.BackgroundImage = global::bayii.Properties.Resources._774684_pdf_document_extension_file_format_icon;
            this.btnyaypdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnyaypdf.Location = new System.Drawing.Point(3, 403);
            this.btnyaypdf.Name = "btnyaypdf";
            this.btnyaypdf.Size = new System.Drawing.Size(58, 45);
            this.btnyaypdf.TabIndex = 11;
            this.btnyaypdf.UseVisualStyleBackColor = true;
            this.btnyaypdf.Click += new System.EventHandler(this.btnyaypdf_Click_1);
            // 
            // btnyaysep
            // 
            this.btnyaysep.BackgroundImage = global::bayii.Properties.Resources._9070917_shopping_icon;
            this.btnyaysep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnyaysep.Location = new System.Drawing.Point(609, 372);
            this.btnyaysep.Name = "btnyaysep";
            this.btnyaysep.Size = new System.Drawing.Size(80, 66);
            this.btnyaysep.TabIndex = 10;
            this.btnyaysep.UseVisualStyleBackColor = true;
            this.btnyaysep.Click += new System.EventHandler(this.btnyaysep_Click);
            // 
            // btnyaycuz
            // 
            this.btnyaycuz.BackgroundImage = global::bayii.Properties.Resources.odeme;
            this.btnyaycuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnyaycuz.Location = new System.Drawing.Point(695, 372);
            this.btnyaycuz.Name = "btnyaycuz";
            this.btnyaycuz.Size = new System.Drawing.Size(93, 66);
            this.btnyaycuz.TabIndex = 9;
            this.btnyaycuz.UseVisualStyleBackColor = true;
            this.btnyaycuz.Click += new System.EventHandler(this.btnyaycuz_Click_1);
            // 
            // btnarara
            // 
            this.btnarara.BackgroundImage = global::bayii.Properties.Resources._9004811_search_find_magnifier_zoom_icon;
            this.btnarara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnarara.Location = new System.Drawing.Point(722, 210);
            this.btnarara.Name = "btnarara";
            this.btnarara.Size = new System.Drawing.Size(66, 57);
            this.btnarara.TabIndex = 5;
            this.btnarara.UseVisualStyleBackColor = true;
            this.btnarara.Click += new System.EventHandler(this.btnarara_Click);
            // 
            // yayinTableAdapter1
            // 
            this.yayinTableAdapter1.ClearBeforeFill = true;
            // 
            // YayinlariArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnyaypdf);
            this.Controls.Add(this.btnyaysep);
            this.Controls.Add(this.btnyaycuz);
            this.Controls.Add(this.btnarara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbarafilt);
            this.Controls.Add(this.txtarara);
            this.Controls.Add(this.dgwara);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YayinlariArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YayinlariArama";
            this.Load += new System.EventHandler(this.YayinlariArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSetYayin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dgwara;
        private System.Windows.Forms.TextBox txtarara;
        private System.Windows.Forms.ComboBox cmbarafilt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnarara;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinSikligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnyaycuz;
        private System.Windows.Forms.Button btnyaysep;
        private System.Windows.Forms.Button btnyaypdf;
        private bayiiDataSetYayin bayiiDataSetYayin;
        private System.Windows.Forms.BindingSource yayinBindingSource2;
        private bayiiDataSetYayinTableAdapters.YayinTableAdapter yayinTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}