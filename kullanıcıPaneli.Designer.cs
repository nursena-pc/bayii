namespace bayii
{
    partial class kullanıcıPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYayin = new System.Windows.Forms.Button();
            this.btnAbonelik = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnYayin);
            this.panel1.Controls.Add(this.btnAbonelik);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 467);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnYayin
            // 
            this.btnYayin.BackgroundImage = global::bayii.Properties.Resources.yayinlar;
            this.btnYayin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYayin.Location = new System.Drawing.Point(9, 3);
            this.btnYayin.Name = "btnYayin";
            this.btnYayin.Size = new System.Drawing.Size(138, 117);
            this.btnYayin.TabIndex = 4;
            this.btnYayin.UseVisualStyleBackColor = true;
            this.btnYayin.Click += new System.EventHandler(this.btnYayin_Click);
            // 
            // btnAbonelik
            // 
            this.btnAbonelik.BackgroundImage = global::bayii.Properties.Resources.abonelik;
            this.btnAbonelik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbonelik.Location = new System.Drawing.Point(9, 170);
            this.btnAbonelik.Name = "btnAbonelik";
            this.btnAbonelik.Size = new System.Drawing.Size(146, 117);
            this.btnAbonelik.TabIndex = 2;
            this.btnAbonelik.UseVisualStyleBackColor = true;
            this.btnAbonelik.Click += new System.EventHandler(this.btnAbonelik_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::bayii.Properties.Resources._5452459_arrow_direction_door_emergency_exit_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(9, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 117);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "DERGİ VE GAZETE SATIŞ NOKTASI";
            // 
            // kullanıcıPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1107, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kullanıcıPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYayin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbonelik;
    }
}