using DevExpress.ClipboardSource.SpreadsheetML;
using Hotel.BLL;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI
{
    public partial class FormUrunList : Form
    {
        public FormUrunList()
        {
            InitializeComponent();
        }
        StokTakipRepository stoktakRep = new StokTakipRepository();
        YılmazHotelEntities YılmazSever = DBTool.DBInstance;
        private void FormUrunList_Load(object sender, EventArgs e)
        {
            textUrunNo.Visible=false;
            Verilerigetir();
               
        }
        public   void UrunEkle() //her yerden erişim için public yaptım.
        {
          
                if (string.IsNullOrEmpty(textUrunAdet.Text) || string.IsNullOrEmpty(textGrupNo.Text) || string.IsNullOrEmpty(textUrunFiyat.Text) || string.IsNullOrEmpty(textUrunBirim.Text) || string.IsNullOrEmpty(textUrunFiyat.Text)       )
                {
                    MessageBox.Show("Lütfen Tüm alanları eksiksiz doldurunuz..");
                    return;
                }
            try
            {
                stokDurumu stokT = new stokDurumu {  
                    urunGno = int.Parse(textGrupNo.Text),
                    urunAdi = textUrunAdı.Text, 
                    //urunVarmiYokmu =Convert.ToBoolean(textUrundurum.Text),
                    urunAdet = int.Parse(textUrunAdet.Text), 
                    urunBirimi = textUrunBirim.Text, 
                    //urunDurumMesaj = textdurum.Text, 
                    urunFiyat = Convert.ToDecimal(textUrunFiyat.Text) };
                    stoktakRep.Insert(stokT);
                    MessageBox.Show("kaydetme başarılı");
            }
            catch (ArgumentOutOfRangeException exRange)
            {

                MessageBox.Show("Lütfen İşlemleri Sırasıyla yapın.." +
                    " Örneğin;" +
                       "" +
                       "" +
                       "" +
                    "ilk Listeleme işlemini yapın,sonrasında silme/günelleme/ekleme işlemlerini" +
                    "yapabilirsiniz..");
            }

        }
        public void UrunSil()
        {
            try
            {
                int UrunNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                stoktakRep.Delete(UrunNo);
                MessageBox.Show("Silme işlemi başarılı");
                Verilerigetir();
    
            }
        
            catch (ArgumentOutOfRangeException exRange)
            {

                MessageBox.Show("Lütfen İşlemleri Sırasıyla yapın.." +
                    " Örneğin;" +
                       "" +
                       "" +
                       "" +
                    "ilk Listeleme işlemini yapın,sonrasında silme/günelleme/ekleme işlemlerini" +
                    "yapabilirsiniz.." );
            }


        }
        
        public void Verilerigetir() //her yerden erişilsin diye public yaptım.
        {
          dataGridView1.DataSource = stoktakRep.SelectAll();
          dataGridView1.Columns[8].Visible = false; //entity yüzünden çekilen bağlantılı kolonunu gizledim..
          dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int urunNo =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); //.value koymassak değer atanamıyor.
            stokDurumu StokdurumID = stoktakRep.SelectById(urunNo);
            textUrunNo.Text = Convert.ToString(StokdurumID.urunID);
            textGrupNo.Text = Convert.ToString(StokdurumID.urunGno);
            textUrunAdı.Text = StokdurumID.urunAdi;
            textUrunBirim.Text = StokdurumID.urunBirimi;
            textUrunAdet.Text = Convert.ToString(StokdurumID.urunAdet);
            textUrunFiyat.Text = Convert.ToString(StokdurumID.urunFiyat);
            textUrundurum.Text = StokdurumID.urunVarmiYokmu.ToString();
            textdurum.Text = StokdurumID.urunDurumMesaj;
            if (textUrundurum.Text=="True")
            {
              
                textUrundurum.Text = "Urun Stokarımızda Mevcuttur.";

            }
            else
            {
                textUrundurum.Text = "Urun stoklarımızda Tükenmiştir.";
            }
            if ( StokdurumID.urunAdet<20)
            {
               
                textdurum.Text = "Ürün Alımı  yapmamız lazım.";
                stokDurumu stoklar = new stokDurumu { urunDurumMesaj = textdurum.Text };
                stoktakRep.Insert(stoklar);
            }

            else if (StokdurumID.urunAdet<30)
            {
              
                textdurum.Text = "Ürün stok miktarı Sınır  düzeyde";
                stokDurumu stoklar = new stokDurumu { urunDurumMesaj = textdurum.Text };
                stoktakRep.Insert(stoklar);
            }
            else if (StokdurumID.urunAdet>30)
            {
                 
              
                textdurum.Text = "Ürün  stok miktarı fazlasıyla yeterli.";
                stokDurumu stoklar = new stokDurumu { urunDurumMesaj = textdurum.Text };
                stoktakRep.Insert(stoklar);
            }
            
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
