namespace YılmazHotel.WinUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kadi = new System.Windows.Forms.Label();
            this.textKadi = new System.Windows.Forms.TextBox();
            this.Ksifre = new System.Windows.Forms.Label();
            this.textKsifre = new System.Windows.Forms.TextBox();
            this.ButonSistem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kadi
            // 
            this.Kadi.AutoSize = true;
            this.Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kadi.Location = new System.Drawing.Point(416, 245);
            this.Kadi.Name = "Kadi";
            this.Kadi.Size = new System.Drawing.Size(164, 18);
            this.Kadi.TabIndex = 0;
            this.Kadi.Text = "Yönetici Kullanıcı Adı";
            this.Kadi.UseWaitCursor = true;
            // 
            // textKadi
            // 
            this.textKadi.Location = new System.Drawing.Point(590, 245);
            this.textKadi.Name = "textKadi";
            this.textKadi.Size = new System.Drawing.Size(170, 20);
            this.textKadi.TabIndex = 1;
            // 
            // Ksifre
            // 
            this.Ksifre.AutoSize = true;
            this.Ksifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ksifre.Location = new System.Drawing.Point(416, 349);
            this.Ksifre.Name = "Ksifre";
            this.Ksifre.Size = new System.Drawing.Size(108, 18);
            this.Ksifre.TabIndex = 2;
            this.Ksifre.Text = "Yönetici Sifre";
            this.Ksifre.UseWaitCursor = true;
            // 
            // textKsifre
            // 
            this.textKsifre.Location = new System.Drawing.Point(590, 347);
            this.textKsifre.Name = "textKsifre";
            this.textKsifre.Size = new System.Drawing.Size(170, 20);
            this.textKsifre.TabIndex = 3;
            this.textKsifre.TextChanged += new System.EventHandler(this.textKsifre_TextChanged);
            // 
            // ButonSistem
            // 
            this.ButonSistem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButonSistem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButonSistem.BackgroundImage")));
            this.ButonSistem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButonSistem.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonSistem.Image = ((System.Drawing.Image)(resources.GetObject("ButonSistem.Image")));
            this.ButonSistem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButonSistem.Location = new System.Drawing.Point(806, 282);
            this.ButonSistem.Name = "ButonSistem";
            this.ButonSistem.Size = new System.Drawing.Size(208, 61);
            this.ButonSistem.TabIndex = 4;
            this.ButonSistem.Text = "Sistem Giriş";
            this.ButonSistem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButonSistem.UseVisualStyleBackColor = false;
            this.ButonSistem.Click += new System.EventHandler(this.ButonSistem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(419, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Yılmaz Hotel Yönetim Giriş";
            this.textBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 559);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButonSistem);
            this.Controls.Add(this.textKsifre);
            this.Controls.Add(this.Ksifre);
            this.Controls.Add(this.textKadi);
            this.Controls.Add(this.Kadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kadi;
        private System.Windows.Forms.TextBox textKadi;
        private System.Windows.Forms.Label Ksifre;
        private System.Windows.Forms.TextBox textKsifre;
        private System.Windows.Forms.Button ButonSistem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

