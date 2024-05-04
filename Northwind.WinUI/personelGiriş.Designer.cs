namespace Northwind.WinUI
{
    partial class personelGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelGiriş));
            this.label1 = new System.Windows.Forms.Label();
            this.textKadi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textSifre = new DevExpress.XtraEditors.TextEdit();
            this.ButtonLog = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textKadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // textKadi
            // 
            this.textKadi.EditValue = "Kullanıcı Adınızı Giriniz.";
            this.textKadi.Location = new System.Drawing.Point(175, 32);
            this.textKadi.Name = "textKadi";
            this.textKadi.Size = new System.Drawing.Size(201, 20);
            this.textKadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // textSifre
            // 
            this.textSifre.EditValue = "Şifrenizi Giriniz.";
            this.textSifre.Location = new System.Drawing.Point(175, 115);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(201, 20);
            this.textSifre.TabIndex = 3;
            // 
            // ButtonLog
            // 
            this.ButtonLog.Appearance.Font = new System.Drawing.Font("Unispace", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLog.Appearance.Options.UseFont = true;
            this.ButtonLog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.ButtonLog.Location = new System.Drawing.Point(175, 156);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(201, 36);
            this.ButtonLog.TabIndex = 4;
            this.ButtonLog.Text = "Sistem Giriş";
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // personelGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(392, 222);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKadi);
            this.Controls.Add(this.label1);
            this.Name = "personelGiriş";
            this.Text = "personelGiriş";
            this.Load += new System.EventHandler(this.personelGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textKadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textKadi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textSifre;
        private DevExpress.XtraEditors.SimpleButton ButtonLog;
    }
}