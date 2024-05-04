using DevExpress.Data.Mask;
using DevExpress.Utils.Extensions;
using Hotel.BLL;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YılmazHotel.WinUI
{
    

    public partial class MusteriKayitForm : Form
    {
        YılmazHotelEntities YılmazServer = DBTool.DBInstance;
        
        OdalarRepository odalarRep = new OdalarRepository(); //odalar repositornin içeriğini kullanabilmek için,bir isim aldım.
        MusterilerRepository musrteriRep = new MusterilerRepository();
        Odalar updated; //update edebilmek için.
        Musteriler Mupdated;

        public bool Odagenel { get; private set; }

        public MusteriKayitForm()
        {
            InitializeComponent();
        }

        private void MusteriKayitForm_Load(object sender, EventArgs e)
        {
            //Yapım aşamasında Toplam oda sayısını, boş dolu oda sayısını gösterme.
            //int countB=0;
            //foreach (Control c in this.Controls)
            //{
            //    if (c is Button)
            //    {
            //        if ( c.Name != button1.Name && c.Name != btnsil.Name && 
            //            c.Name !=button4.Name && c.Name !=button3.Name && c.Name!=button2.Name && c.Name != button5.Name)
            //        {
            //          label10.Text =  " " + countB.ToString();    
                   
            //        }
            //    }
                
            //}
           
            try
            {
                List<Odalar> oda1Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 1).ToList();
                foreach (var item in oda1Durum)
                {

                    btnoda1.Text = item.OdaDolulukDurumu.ToString();
                    if (btnoda1.Text == "True")
                    {
                        btnoda1.Text = "Oda 1-Dolu";
                        btnoda1.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda1.Text = "Oda 1-Boş";
                        btnoda1.BackColor = Color.Green;

                    }
                }
                List<Odalar> oda2Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 2).ToList();
                foreach (var i in oda2Durum)
                {
                    btnoda2.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda2.Text == "True")
                    {
                        btnoda2.Text = "Oda 2-Dolu";
                        btnoda2.BackColor = Color.Red;

                    }
                    else
                    {
                        btnoda2.Text = "oda 2-Bos";
                        btnoda2.BackColor = Color.Green;

                    }
                }
                List<Odalar> Oda3Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 3).ToList();
                foreach (var i in Oda3Durum)
                {
                    btnoda3.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda3.Text == "True")
                    {
                        btnoda3.Text = "Oda 3-Dolu";
                        btnoda3.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda3.Text = "Oda 3-Bos";
                        btnoda3.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda4Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 4).ToList();
                foreach (var i in Oda4Durum)
                {
                    btnoda4.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda4.Text == "True")
                    {
                        btnoda4.Text = "Oda 4-Dolu";
                        btnoda4.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda4.Text = "Oda 4-Bos";
                        btnoda4.BackColor = Color.Green;

                    }

                }
                List<Odalar> Oda5Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 5).ToList();
                foreach (var i in Oda5Durum)
                {
                    btnoda5.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda5.Text == "True")
                    {
                        btnoda5.Text = "Oda 5-Dolu";
                        btnoda5.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda5.Text = "Oda 5-Bos";
                        btnoda5.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda6Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 6).ToList();
                foreach (var i in Oda6Durum)
                {
                    btnoda6.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda6.Text == "True")
                    {
                        btnoda6.Text = "Oda 6-Dolu";
                        btnoda6.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda6.Text = "Oda 6-Bos";
                        btnoda6.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda7Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 7).ToList();
                foreach (var i in Oda7Durum)
                {
                    btnoda7.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda7.Text == "True")
                    {
                        btnoda7.Text = "Oda 7-Dolu";
                        btnoda7.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda7.Text = "Oda 7-Bos";
                        btnoda7.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda8Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 8).ToList();
                foreach (var i in Oda8Durum)
                {
                    btnoda8.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda8.Text == "True")
                    {
                        btnoda8.Text = "Oda 8-Dolu";
                        btnoda8.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda8.Text = "Oda 8-Bos";
                        btnoda8.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda9Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 9).ToList();
                foreach (var i in Oda9Durum)
                {
                    btnoda9.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda9.Text == "True")
                    {
                        btnoda9.Text = "Oda 9-Dolu";
                        btnoda9.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda9.Text = "Oda 9-Bos";
                        btnoda9.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda10Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 10).ToList();
                foreach (var i in Oda10Durum)
                {
                    btnoda10.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda10.Text == "True")
                    {
                        btnoda10.Text = "Oda 10-Dolu";
                        btnoda10.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda10.Text = "Oda 10-Bos";
                        btnoda10.BackColor = Color.Green;
                    }
                }
                List<Odalar> Oda11Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 11).ToList();
                foreach (var i in Oda11Durum)
                {
                    btnoda11.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda11.Text == "True")
                    {
                        btnoda11.Text = "Oda 11-Dolu";
                        btnoda11.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda11.Text = "Oda 11-Bos";
                        btnoda11.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda12Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 12).ToList();
                foreach (var i in Oda12Durum)
                {
                    btnoda12.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda12.Text == "True")
                    {
                        btnoda12.Text = "Oda 12-Dolu";
                        btnoda12.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda12.Text = "Oda 12-Bos";
                        btnoda12.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda13Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 13).ToList();
                foreach (var i in Oda13Durum)
                {
                    btnoda13.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda13.Text == "True")
                    {
                        btnoda13.Text = "Oda 13-Dolu";
                        btnoda13.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda13.Text = "Oda 13-Bos";
                        btnoda13.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda14Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 14).ToList();
                foreach (var i in Oda14Durum)
                {
                    btnoda14.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda14.Text == "True")
                    {
                        btnoda14.Text = "Oda 14-Dolu";
                        btnoda14.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda14.Text = "Oda 14-Bos";
                        btnoda14.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda15Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 15).ToList();
                foreach (var i in Oda5Durum)
                {
                    btnoda15.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda15.Text == "True")
                    {
                        btnoda15.Text = "Oda 15-Dolu";
                        btnoda5.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda15.Text = "Oda 15-Bos";
                        btnoda15.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda16Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 16).ToList();
                foreach (var i in Oda16Durum)
                {
                    btnoda16.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda16.Text == "True")
                    {
                        btnoda16.Text = "Oda 16-Dolu";
                        btnoda16.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda16.Text = "Oda 16-Bos";
                        btnoda16.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda17Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 17).ToList();
                foreach (var i in Oda17Durum)
                {
                    btnoda17.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda17.Text == "True")
                    {
                        btnoda17.Text = "Oda 17-Dolu";
                        btnoda17.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda17.Text = "Oda 17-Bos";
                        btnoda17.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda18Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 18).ToList();
                foreach (var i in Oda5Durum)
                {
                    btnoda18.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda18.Text == "True")
                    {
                        btnoda18.Text = "Oda 18-Dolu";
                        btnoda18.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda18.Text = "Oda 18-Bos";
                        btnoda18.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda19Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 19).ToList();
                foreach (var i in Oda19Durum)
                {
                    btnoda19.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda19.Text == "True")
                    {
                        btnoda19.Text = "Oda 19-Dolu";
                        btnoda19.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda19.Text = "Oda 19-Bos";
                        btnoda19.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda20Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 20).ToList();
                foreach (var i in Oda20Durum)
                {
                    btnoda20.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda20.Text == "True")
                    {
                        btnoda20.Text = "Oda 20-Dolu";
                        btnoda20.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda20.Text = "Oda 20-Bos";
                        btnoda20.BackColor = Color.Green;

                    }

                }
                List<Odalar> Oda21Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 21).ToList();
                foreach (var i in Oda21Durum)
                {
                    btnoda21.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda21.Text == "True")
                    {
                        btnoda21.Text = "Oda 21-Dolu";
                        btnoda21.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda21.Text = "Oda 21-Bos";
                        btnoda21.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda22Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 22).ToList();
                foreach (var i in Oda22Durum)
                {
                    btnoda22.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda22.Text == "True")
                    {
                        btnoda22.Text = "Oda 22-Dolu";
                        btnoda22.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda22.Text = "Oda 22-Bos";
                        btnoda22.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda23Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 23).ToList();
                foreach (var i in Oda23Durum)
                {
                    btnoda23.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda23.Text == "True")
                    {
                        btnoda23.Text = "Oda 23-Dolu";
                        btnoda23.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda23.Text = "Oda 23-Bos";
                        btnoda23.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda24Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 24).ToList();
                foreach (var i in Oda24Durum)
                {
                    btnoda24.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda24.Text == "True")
                    {
                        btnoda24.Text = "Oda 24-Dolu";
                        btnoda24.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda24.Text = "Oda 24-Bos";
                        btnoda24.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda25Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 25).ToList();
                foreach (var i in Oda25Durum)
                {
                    btnoda25.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda25.Text == "True")
                    {
                        btnoda25.Text = "Oda 25-Dolu";
                        btnoda25.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda25.Text = "Oda 25-Bos";
                        btnoda25.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda26Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 26).ToList();
                foreach (var i in Oda26Durum)
                {
                    btnoda26.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda26.Text == "True")
                    {
                        btnoda26.Text = "Oda 26-Dolu";
                        btnoda26.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda26.Text = "Oda 26-Bos";
                        btnoda26.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda27Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 27).ToList();
                foreach (var i in Oda27Durum)
                {
                    btnoda27.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda27.Text == "True")
                    {
                        btnoda27.Text = "Oda 27-Dolu";
                        btnoda27.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda27.Text = "Oda 27-Bos";
                        btnoda27.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda28Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 28).ToList();
                foreach (var i in Oda28Durum)
                {
                    btnoda28.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda28.Text == "True")
                    {
                        btnoda28.Text = "Oda 28-Dolu";
                        btnoda28.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda28.Text = "Oda 28-Bos";
                        btnoda28.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda29Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 29).ToList();
                foreach (var i in Oda29Durum)
                {
                    btnoda29.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda29.Text == "True")
                    {
                        btnoda29.Text = "Oda 29-Dolu";
                        btnoda29.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda29.Text = "Oda 29-Bos";
                        btnoda29.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda67Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 67).ToList();
                foreach (var i in Oda67Durum)
                {
                    btnoda67.Text = i.OdaDolulukDurumu.ToString();
                    if (btnoda67.Text == "True")
                    {
                        btnoda67.Text = "Oda 67-Dolu";
                        btnoda67.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda67.Text = "Oda 67-Bos";
                        btnoda67.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda68Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 68).ToList();
                foreach (var i in Oda68Durum)
                {
                    btnoda68.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda68.Text == "True")
                    {
                        btnoda68.Text = "Oda 68-Dolu";
                        btnoda68.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda68.Text = "Oda 68-Bos";
                        btnoda68.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda69Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 69).ToList();
                foreach (var i in Oda69Durum)
                {
                    btnoda69.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda69.Text == "True")
                    {
                        btnoda69.Text = "Oda 69-Dolu";
                        btnoda69.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda69.Text = "Oda 69-Bos";
                        btnoda69.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda70Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 70).ToList();
                foreach (var i in Oda70Durum)
                {
                    btnoda70.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda70.Text == "True")
                    {
                        btnoda70.Text = "Oda 70-Dolu";
                        btnoda70.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda70.Text = "Oda 70-Bos";
                        btnoda70.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda71Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 71).ToList();
                foreach (var i in Oda71Durum)
                {
                    btnoda71.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda71.Text == "True")
                    {
                        btnoda71.Text = "Oda 71-Dolu";
                        btnoda71.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda71.Text = "Oda 71-Bos";
                        btnoda71.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda72Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 72).ToList();
                foreach (var i in Oda72Durum)
                {
                    btnoda72.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda72.Text == "True")
                    {
                        btnoda72.Text = "Oda 72-Dolu";
                        btnoda72.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda72.Text = "Oda 72-Bos";
                        btnoda72.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda73Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 73).ToList();
                foreach (var i in Oda73Durum)
                {
                    btnoda73.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda73.Text == "True")
                    {
                        btnoda73.Text = "Oda 73-Dolu";
                        btnoda73.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda73.Text = "Oda 73-Bos";
                        btnoda73.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda74Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 74).ToList();
                foreach (var i in Oda74Durum)
                {
                    btnoda74.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda74.Text == "True")
                    {
                        btnoda74.Text = "Oda 74-Dolu";
                        btnoda74.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda74.Text = "Oda 74-Bos";
                        btnoda74.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda75Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 75).ToList();
                foreach (var i in Oda75Durum)
                {
                    btnoda75.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda75.Text == "True")
                    {
                        btnoda75.Text = "Oda 75-Dolu";
                        btnoda75.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda75.Text = "Oda 75-Bos";
                        btnoda75.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda76Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 76).ToList();
                foreach (var i in Oda76Durum)
                {
                    btnoda76.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda76.Text == "True")
                    {
                        btnoda76.Text = "Oda 76-Dolu";
                        btnoda76.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda76.Text = "Oda 76-Bos";
                        btnoda76.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda77Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 77).ToList();
                foreach (var i in Oda77Durum)
                {
                    btnoda77.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda77.Text == "True")
                    {
                        btnoda77.Text = "Oda 77-Dolu";
                        btnoda77.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda77.Text = "Oda 77-Bos";
                        btnoda77.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda78Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 78).ToList();
                foreach (var i in Oda78Durum)
                {
                    btnoda78.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda78.Text == "True")
                    {
                        btnoda78.Text = "Oda 78-Dolu";
                        btnoda78.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda78.Text = "Oda 78-Bos";
                        btnoda78.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda79Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 79).ToList();
                foreach (var i in Oda79Durum)
                {
                    btnoda79.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda79.Text == "True")
                    {
                        btnoda79.Text = "Oda 79-Dolu";
                        btnoda79.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda79.Text = "Oda 79-Bos";
                        btnoda79.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda80Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 80).ToList();
                foreach (var i in Oda80Durum)
                {
                    btnoda80.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda80.Text == "True")
                    {
                        btnoda80.Text = "Oda 80-Dolu";
                        btnoda80.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda80.Text = "Oda 80-Bos";
                        btnoda80.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda81Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 81).ToList();
                foreach (var i in Oda81Durum)
                {
                    btnoda81.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda81.Text == "True")
                    {
                        btnoda81.Text = "Oda 81-Dolu";
                        btnoda81.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda81.Text = "Oda 81-Bos";
                        btnoda81.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda82Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 82).ToList();
                foreach (var i in Oda82Durum)
                {
                    btnoda82.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda82.Text == "True")
                    {
                        btnoda82.Text = "Oda 82-Dolu";
                        btnoda82.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda82.Text = "Oda 82-Bos";
                        btnoda82.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda83Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 83).ToList();
                foreach (var i in Oda83Durum)
                {
                    btnoda83.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda83.Text == "True")
                    {
                        btnoda83.Text = "Oda 83-Dolu";
                        btnoda83.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda83.Text = "Oda 83-Bos";
                        btnoda83.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda84Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 84).ToList();
                foreach (var i in Oda84Durum)
                {
                    btnoda84.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda84.Text == "True")
                    {
                        btnoda84.Text = "Oda 84-Dolu";
                        btnoda84.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda84.Text = "Oda 84-Bos";
                        btnoda84.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda85Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 85).ToList();
                foreach (var i in Oda85Durum)
                {
                    btnoda85.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda85.Text == "True")
                    {
                        btnoda85.Text = "Oda 85-Dolu";
                        btnoda85.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda85.Text = "Oda 85-Bos";
                        btnoda85.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda86Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 86).ToList();
                foreach (var i in Oda86Durum)
                {
                    btnoda86.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda86.Text == "True")
                    {
                        btnoda86.Text = "Oda 86-Dolu";
                        btnoda86.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda86.Text = "Oda 86-Bos";
                        btnoda86.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda87Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 87).ToList();
                foreach (var i in Oda87Durum)
                {
                    btnoda87.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda87.Text == "True")
                    {
                        btnoda87.Text = "Oda 87-Dolu";
                        btnoda87.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda87.Text = "Oda 87-Bos";
                        btnoda87.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda104Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 104).ToList();
                foreach (var i in Oda104Durum)
                {
                    btnoda104.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda104.Text == "True")
                    {
                        btnoda104.Text = "Oda 104-Dolu";
                        btnoda104.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda104.Text = "Oda 104-Bos";
                        btnoda104.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda105Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 105).ToList();
                foreach (var i in Oda105Durum)
                {
                    btnoda105.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda105.Text == "True")
                    {
                        btnoda105.Text = "Oda 105-Dolu";
                        btnoda105.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda105.Text = "Oda 105-Bos";
                        btnoda105.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda106Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 106).ToList();
                foreach (var i in Oda106Durum)
                {
                    btnoda106.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda106.Text == "True")
                    {
                        btnoda106.Text = "Oda 106-Dolu";
                        btnoda106.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda106.Text = "Oda 106-Bos";
                        btnoda106.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda107Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 107).ToList();
                foreach (var i in Oda107Durum)
                {
                    btnoda107.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda107.Text == "True")
                    {
                        btnoda107.Text = "Oda 107-Dolu";
                        btnoda107.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda107.Text = "Oda 107-Bos";
                        btnoda107.BackColor = Color.Green;
                    }

                }
                 List<Odalar> Oda108Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 108).ToList();
                foreach (var i in Oda108Durum)
                {
                    btnoda108.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda108.Text == "True")
                    {
                        btnoda108.Text = "Oda 108-Dolu";
                        btnoda27.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda108.Text = "Oda 108-Bos";
                        btnoda108.BackColor = Color.Green;
                    }

                }
                List<Odalar> Oda111Durum = YılmazServer.Odalar.Where(s => s.OdaNo == 111).ToList();
                foreach (var i in Oda111Durum)
                {
                    btnoda111.Text = i.OdaDolulukDurumu.ToString();

                    if (btnoda111.Text == "True")
                    {
                        btnoda111.Text = "Oda 111-Dolu";
                        btnoda111.BackColor = Color.Red;
                    }
                    else
                    {
                        btnoda111.Text = "Oda 111-Bos";
                        btnoda111.BackColor = Color.Green;
                    }

                }
                button3.BackColor = Color.Green;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdalarınListesiniGetir();
        }
        private void OdalarınListesiniGetir() //odaları gridbagda bir çok alanda listeleyeceğim bundan dolayı  kod kalabalığı olmasın diye bir fonksiyona yazma kararı aldım.
        {
            dataGridView1.DataSource = odalarRep.SelectAll(); //odalardaki tüm verilerin çekmesini yarayan kod satırı, "odalarRep" olarak tanımladığımız isimi OdalarRepository deki SelectAll komutunu çağırdık.
            
        
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                
                int odaNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Odalar updated = odalarRep.SelectById(odaNo);
                TextYtakSayisi.Text = updated.YatakSayisi;
                TextTutar.Text = (updated.OdaGunlukTutar).ToString();
                textBox3.Text = (updated.OdaNo).ToString();
                TextBalkonDrumu.Text = (updated.BalkonDurumu).ToString();
                
                
                try
                {
                    if (TextBalkonDrumu.Text == "True")
                    {
                        TextBalkonDrumu.Text = "Balkon mevcut ";

                    }
                    else if (TextBalkonDrumu.Text == "False")
                    {
                        TextBalkonDrumu.Text = "Balkon Mevcut değil.";

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yazılımsal bir hata var,Özür dileriz..");
                    Console.WriteLine(ex);
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
     
  
            decimal Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            textGun.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(textGun.Text) * Convert.ToDecimal(TextTutar.Text);
            textHesap.Text = Ucret.ToString();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))//Eğer bu alanlar boş olrsa if bloğu çalışıcak.
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz..");
                return;
            }


            try
            {
                //string yapmak için parse kullandım.                DateTime'a çevirmek için kullandım.                                                                        
                Musteriler Musteri = new Musteriler { Musadi = textBox1.Text, MusSoyadi = textBox2.Text, hesap = decimal.Parse(textHesap.Text), telefon = (maskedTextBox1.Text), OdaNo = int.Parse(textBox3.Text), gTarih = Convert.ToDateTime(dateTimePicker1.Text), CTarih = Convert.ToDateTime(dateTimePicker2.Text) };
                musrteriRep.Insert(Musteri);
                MessageBox.Show("Kaydetme işlemi başarılı..");
          
                Application.Restart();
              
                //yukarısı ekleme kısmı.
            }
            catch (Exception ex)
            {
                 
                MessageBox.Show(ex.Message);
            }
            
         
            //aşağısı  doluluk oranı güncelleme kısmı.

            int OdaNo = Convert.ToInt32(textBox3.Text);
            Odalar Oupdated = odalarRep.SelectById(OdaNo);
            Oupdated.OdaDolulukDurumu = Convert.ToBoolean(1); //boolean değere çevirdim==Doluluk durumu true.
            odalarRep.Update(Oupdated);

            OdalarınListesiniGetir(); //işlem bittikten sonra listeleme işlemi tekrarlanacak.
           
            
        
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();//uyuglaam yenileme.

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                  
        }
    }
}
