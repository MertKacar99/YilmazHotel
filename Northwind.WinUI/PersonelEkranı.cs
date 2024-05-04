using DevExpress.ClipboardSource.SpreadsheetML;
using Hotel.BLL;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI
{
    public partial class PersonelEkranı : Form
    {
        YılmazHotelEntities YılmazServer = DBTool.DBInstance;
        PersonelRepository Per_rep = new PersonelRepository();
        Personeller updated;
        Personeller pupdated;
        public PersonelEkranı()
        {
            InitializeComponent();
        }

        private void PersonelEkranı_Load(object sender, EventArgs e)
        {
 
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count>0)
            {
                try
                {
                    int PerNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);//DatagridView'da listelenen "0.index" PersonelID olduğundan,Onu bir değişkene atadım.
                    Personeller updated = Per_rep.SelectById(PerNo);//atadığım değişkeni Personel Rep. içindeki SelectByID ye atayarak id ye göre işlem yapcağım alt satırlarda.
                    txtad.Text = updated.PersonelAdi; //Personel adını,personel id'ye göre getir  ve Text'e ata,komutu.
                    txtsoyad.Text = updated.PersonelSoyadi;  //Personel Soyadını,personel id'ye göre getir  ve Text'e ata,komutu.
                    maskedTextTel.Text = updated.PersonelTelefon;//Personel Telefonunu,personel id'ye göre getir  ve Text'e ata,komutu.
                    txtmail.Text = updated.PersonelMail;//Personel Mailini,personel id'ye göre getir  ve Text'e ata,komutu.
                    txtBolum.Text = updated.PersonelBolum;//Personel Bölümü,personel id'ye göre getir  ve Text'e ata,komutu.
                    txtizin.Text = (updated.P_KulanndıgıIzın).ToString();//Personel Kullandığı izini,personel id'ye göre getir ve Text'e ata,komutu.
                    txtmaas.Text = updated.PersonelMaas.ToString();//Personel Kullandığı izini,personel id'ye göre getir ve Text'e ata,komutu.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Personellerin_Listesini_Getir();
        }
        private void Personellerin_Listesini_Getir()
        {
            dataGridView1.DataSource = Per_rep.SelectAll();

        


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {  //Kayıt Kısmı
            if (string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoyad.Text) || string.IsNullOrEmpty(maskedTextTel.Text) || string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(txtmaas.Text) || string.IsNullOrEmpty(txtizin.Text) || string.IsNullOrEmpty(txtBolum.Text))
            {
                MessageBox.Show("Tüm Alanları Eksik Doldurunuz..");
                return;
            }
          
                Personeller Personel = new Personeller { PersonelAdi = txtad.Text, PersonelSoyadi = txtsoyad.Text, PersonelTelefon = maskedTextTel.Text, PersonelBolum = txtBolum.Text, PersonelMaas = decimal.Parse(txtmaas.Text), PersonelMail = txtmaas.Text, P_KulanndıgıIzın = Convert.ToInt32(txtizin.Text) };
                Per_rep.Insert(Personel);
                MessageBox.Show("Kaydetme İşlemi Başarılı..");
                Personellerin_Listesini_Getir(); //Select All işleminin Fonksiyonunu buraya çağırıyorum.
            }
            catch (Exception ex)
            {
                 
                
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoyad.Text) || string.IsNullOrEmpty(maskedTextTel.Text) || string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(txtmaas.Text) || string.IsNullOrEmpty(txtizin.Text) || string.IsNullOrEmpty(txtBolum.Text))
            {
                MessageBox.Show("Tüm Alanları Eksik Doldurunuz..");
                return;
            }
            int PerNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Personeller updated = Per_rep.SelectById(PerNo);
            updated.PersonelAdi = txtad.Text;
            updated.PersonelSoyadi = txtsoyad.Text;
            updated.PersonelTelefon = maskedTextTel.Text;
            updated.P_KulanndıgıIzın = Convert.ToInt32(txtizin.Text);
            updated.PersonelBolum = txtBolum.Text;
            updated.PersonelMaas = Convert.ToDecimal(txtmaas.Text);
            updated.PersonelMail = txtmail.Text; 
            Personellerin_Listesini_Getir();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Satır Seçiniz..");
                return;
            }
            int PersonellNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Per_rep.Delete(PersonellNo);
            MessageBox.Show("Silme işlemi Başarılı..");
            Personellerin_Listesini_Getir();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 