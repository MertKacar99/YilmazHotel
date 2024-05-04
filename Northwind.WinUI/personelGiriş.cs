using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI
{
    public partial class personelGiriş : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        YılmazHotelEntities baglantı1 = new YılmazHotelEntities();
        public personelGiriş()
        {
            InitializeComponent();
        }
        //Yetkili Kadi=YilmazGoz
        //Yetkili Sifre=yilmaz2018101
        private void personelGiriş_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {

            string kadi = textKadi.Text;
            string ksifre = textSifre.Text;
            con = new SqlConnection("server=DESKTOP-145QGQ7\\SQLEXPRESS; Database=YılmazHotel;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Yekili_Kisiler where YetkiliKadi='" + textKadi.Text + "' AND YetkiliSifre='" + textSifre.Text + "'";
            dr = cmd.ExecuteReader();


            if (string.IsNullOrEmpty(textKadi.Text) || string.IsNullOrEmpty(textSifre.Text)) //Textlere değer girilmediyse aşağıda ki kod çalışacak. 
            {
                MessageBox.Show("Giriş yapmak için Yönetici Bilgilerinizi Eksiksiz Giriniz ! ");
                return;
            }
            else if (dr.Read())
            {
                MessageBox.Show("Bilgiler doğru Yönetim kısmına Aktarılıyorsunuz");
                PersonelEkranı personelEkranı = new PersonelEkranı();
                personelEkranı.Show(); //personel ekranı göster dedim.
                this.Hide();//   personel ekranı gizle dedim.
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış !!!!!!");
            }
            con.Close();
        }
    }
}
