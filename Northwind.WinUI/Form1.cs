using Hotel.BLL;
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
using System.Data.SqlClient;
using System.Net.Http.Headers;
//Mert Kaçar-20181011126-YılmazHotel Proje

namespace YılmazHotel.WinUI
{
    public partial class Form1 : Form
    {
       
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        YılmazHotelEntities baglantı1 = new YılmazHotelEntities();
        public Form1()
        {

            InitializeComponent();
        }

        private void ButonSistem_Click(object sender, EventArgs e)
        {
            //Kadi=admin
            //Şifre=Admin1


            //////sürekli uzun sifre  ve kullanıcı adı yazmamak için proje basında bunu aktif hale getirdim.
            //string kadi = "a";
            //string sifre = "a";
            //if (textKadi.Text == kadi && textKsifre.Text == sifre)
            //{
            //    Form2 form2 = new Form2();
            //    form2.Show(); //form2 göster dedim.
            //    this.Hide();//   form1 gizle dedim.
            //}


            string kadi = textKadi.Text;
            string ksifre = textKsifre.Text;
            con = new SqlConnection("server=DESKTOP-145QGQ7\\SQLEXPRESS; Database=YılmazHotel;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Yonetim_kisiler where yoneticiKadi='" + textKadi.Text + "' AND YoneticiSifre='" + textKsifre.Text + "'";
            dr = cmd.ExecuteReader();


            if (string.IsNullOrEmpty(textKadi.Text) || string.IsNullOrEmpty(textKsifre.Text)) //Textlere değer girilmediyse aşağıda ki kod çalışacak. 
            {
                MessageBox.Show("Giriş yapmak için Yönetici Bilgilerinizi Eksiksiz Giriniz ! ");
                return;
            }
            else if (dr.Read())
            {
                MessageBox.Show("Bilgiler doğru Yönetim kısmına Aktarılıyorsunuz");
                Form2 form2 = new Form2();
                form2.Show(); //form2 göster dedim.
                this.Hide();//   form1 gizle dedim.
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlış !!!!!!");
            }
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textKsifre_TextChanged(object sender, EventArgs e)
        {
            textKsifre.PasswordChar = '*'; //Texbox'a yazılan değer '*' ile gizlensin diye bu kodu kullandım.
        }
    }
}
