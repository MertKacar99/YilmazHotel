namespace Northwind.WinUI
{
    partial class PersonelEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkranı));
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtizin = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBolum
            // 
            this.txtBolum.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Location = new System.Drawing.Point(175, 248);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(201, 21);
            this.txtBolum.TabIndex = 38;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(182, 84);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(194, 21);
            this.txtsoyad.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Kullandıgı izin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "PersonelMail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Personel Tel No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Personel Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Personel Soyadı: ";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(182, 22);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 21);
            this.txtad.TabIndex = 29;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextTel.Location = new System.Drawing.Point(179, 144);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.Size = new System.Drawing.Size(197, 21);
            this.maskedTextTel.TabIndex = 39;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(179, 196);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(197, 20);
            this.txtmail.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Personel Bolum:";
            // 
            // txtizin
            // 
            this.txtizin.Location = new System.Drawing.Point(175, 299);
            this.txtizin.Name = "txtizin";
            this.txtizin.Size = new System.Drawing.Size(201, 20);
            this.txtizin.TabIndex = 48;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.Khaki;
            this.btnlistele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistele.Image = global::Northwind.WinUI.Properties.Resources.Icons8_Windows_8_Files_Add_List;
            this.btnlistele.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlistele.Location = new System.Drawing.Point(1135, 20);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(89, 544);
            this.btnlistele.TabIndex = 46;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Indigo;
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnguncelle.Image = global::Northwind.WinUI.Properties.Resources.Pixelkit_Gentle_Edges_Edit;
            this.btnguncelle.Location = new System.Drawing.Point(33, 459);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(350, 53);
            this.btnguncelle.TabIndex = 43;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Crimson;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Image = global::Northwind.WinUI.Properties.Resources.Roundicons_100_Free_Solid_Cancel;
            this.btnsil.Location = new System.Drawing.Point(33, 518);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(350, 48);
            this.btnsil.TabIndex = 43;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnkaydet.BackgroundImage = global::Northwind.WinUI.Properties.Resources.Custom_Icon_Design_Mono_General_1_Save1;
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkaydet.CausesValidation = false;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(33, 408);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(350, 45);
            this.btnkaydet.TabIndex = 44;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(406, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 544);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Personel Maaş";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(175, 346);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(201, 20);
            this.txtmaas.TabIndex = 55;
            // 
            // PersonelEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1224, 620);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtizin);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkranı";
            this.Text = "PersonelEkranı";
            this.Load += new System.EventHandler(this.PersonelEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnlistele;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtizin;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaas;
    }
}