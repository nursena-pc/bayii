using System.Windows.Forms;

namespace bayii
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYayin = new System.Windows.Forms.Button();
            this.btnAbonelik = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnYayin);
            this.panel1.Controls.Add(this.btnAbonelik);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAbone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 509);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::bayii.Properties.Resources.yayinlar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(0, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 100);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnYayin
            // 
            this.btnYayin.BackgroundImage = global::bayii.Properties.Resources._6334482_draw_edit_heart_line_pencil_icon1;
            this.btnYayin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYayin.Location = new System.Drawing.Point(0, 194);
            this.btnYayin.Name = "btnYayin";
            this.btnYayin.Size = new System.Drawing.Size(146, 100);
            this.btnYayin.TabIndex = 4;
            this.btnYayin.UseVisualStyleBackColor = true;
            this.btnYayin.Click += new System.EventHandler(this.btnYayin_Click);
            // 
            // btnAbonelik
            // 
            this.btnAbonelik.BackgroundImage = global::bayii.Properties.Resources.abonelik;
            this.btnAbonelik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbonelik.Location = new System.Drawing.Point(0, 97);
            this.btnAbonelik.Name = "btnAbonelik";
            this.btnAbonelik.Size = new System.Drawing.Size(146, 100);
            this.btnAbonelik.TabIndex = 2;
            this.btnAbonelik.UseVisualStyleBackColor = true;
            this.btnAbonelik.Click += new System.EventHandler(this.btnAbonelik_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::bayii.Properties.Resources._5452459_arrow_direction_door_emergency_exit_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(0, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 100);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAbone
            // 
            this.btnAbone.BackgroundImage = global::bayii.Properties.Resources._2431357_follower_group_men_people_subscriber_icon;
            this.btnAbone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbone.Location = new System.Drawing.Point(0, 0);
            this.btnAbone.Name = "btnAbone";
            this.btnAbone.Size = new System.Drawing.Size(146, 100);
            this.btnAbone.TabIndex = 0;
            this.btnAbone.UseVisualStyleBackColor = true;
            this.btnAbone.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "DERGİ VE GAZETE SATIŞ NOKTASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1438, 521);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN PANELİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbone;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbonelik;
        private System.Windows.Forms.Button btnYayin;
        private System.Windows.Forms.Label label1;
        private Button button1;

        public PaintEventHandler panel1_Paint { get; private set; }
    }
}

