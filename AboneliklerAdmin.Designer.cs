namespace bayii
{
    partial class AboneliklerAdmin
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
            this.txtAbolikIDAdmin = new System.Windows.Forms.TextBox();
            this.btnAbolikListeleAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwAbolikAdmin = new System.Windows.Forms.DataGridView();
            this.abonelikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonelikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayiiDataSet6 = new bayii.bayiiDataSet6();
            this.btnAbolikExAdmin = new System.Windows.Forms.Button();
            this.abonelikTableAdapter = new bayii.bayiiDataSet6TableAdapters.AbonelikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbolikAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAbolikIDAdmin
            // 
            this.txtAbolikIDAdmin.Location = new System.Drawing.Point(289, 294);
            this.txtAbolikIDAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbolikIDAdmin.Name = "txtAbolikIDAdmin";
            this.txtAbolikIDAdmin.Size = new System.Drawing.Size(124, 27);
            this.txtAbolikIDAdmin.TabIndex = 15;
            // 
            // btnAbolikListeleAdmin
            // 
            this.btnAbolikListeleAdmin.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbolikListeleAdmin.Location = new System.Drawing.Point(370, 355);
            this.btnAbolikListeleAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbolikListeleAdmin.Name = "btnAbolikListeleAdmin";
            this.btnAbolikListeleAdmin.Size = new System.Drawing.Size(109, 42);
            this.btnAbolikListeleAdmin.TabIndex = 14;
            this.btnAbolikListeleAdmin.Text = "LİSTELE";
            this.btnAbolikListeleAdmin.UseVisualStyleBackColor = true;
            this.btnAbolikListeleAdmin.Click += new System.EventHandler(this.btnAbolikListeleAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Müşteri Numarası:";
            // 
            // dgwAbolikAdmin
            // 
            this.dgwAbolikAdmin.AutoGenerateColumns = false;
            this.dgwAbolikAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwAbolikAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAbolikAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abonelikIDDataGridViewTextBoxColumn,
            this.aboneIDDataGridViewTextBoxColumn,
            this.yayinIDDataGridViewTextBoxColumn,
            this.baslangicTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dgwAbolikAdmin.DataSource = this.abonelikBindingSource;
            this.dgwAbolikAdmin.Location = new System.Drawing.Point(1, 1);
            this.dgwAbolikAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.dgwAbolikAdmin.Name = "dgwAbolikAdmin";
            this.dgwAbolikAdmin.RowHeadersWidth = 51;
            this.dgwAbolikAdmin.RowTemplate.Height = 24;
            this.dgwAbolikAdmin.Size = new System.Drawing.Size(808, 181);
            this.dgwAbolikAdmin.TabIndex = 11;
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
            this.abonelikBindingSource.DataSource = this.bayiiDataSet6;
            // 
            // bayiiDataSet6
            // 
            this.bayiiDataSet6.DataSetName = "bayiiDataSet6";
            this.bayiiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAbolikExAdmin
            // 
            this.btnAbolikExAdmin.BackgroundImage = global::bayii.Properties.Resources._5452459_arrow_direction_door_emergency_exit_icon1;
            this.btnAbolikExAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbolikExAdmin.Location = new System.Drawing.Point(706, 314);
            this.btnAbolikExAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbolikExAdmin.Name = "btnAbolikExAdmin";
            this.btnAbolikExAdmin.Size = new System.Drawing.Size(91, 76);
            this.btnAbolikExAdmin.TabIndex = 13;
            this.btnAbolikExAdmin.UseVisualStyleBackColor = true;
            this.btnAbolikExAdmin.Click += new System.EventHandler(this.btnAbolikExAdmin_Click);
            // 
            // abonelikTableAdapter
            // 
            this.abonelikTableAdapter.ClearBeforeFill = true;
            // 
            // AboneliklerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(810, 403);
            this.Controls.Add(this.txtAbolikIDAdmin);
            this.Controls.Add(this.btnAbolikListeleAdmin);
            this.Controls.Add(this.btnAbolikExAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAbolikAdmin);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboneliklerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonelikler";
            this.Load += new System.EventHandler(this.AboneliklerAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbolikAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayiiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbolikIDAdmin;
        private System.Windows.Forms.Button btnAbolikListeleAdmin;
        private System.Windows.Forms.Button btnAbolikExAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwAbolikAdmin;
        private bayiiDataSet6 bayiiDataSet6;
        private System.Windows.Forms.BindingSource abonelikBindingSource;
        private bayiiDataSet6TableAdapters.AbonelikTableAdapter abonelikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonelikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
    }
}