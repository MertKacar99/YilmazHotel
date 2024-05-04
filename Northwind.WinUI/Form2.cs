using Hotel.DAL;
using Northwind.WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YılmazHotel.WinUI
{
   
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriKayitForm musteriForm = new MusteriKayitForm();
            musteriForm.Show();            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YılmazVerilerForm YlmazForm = new YılmazVerilerForm();
            YlmazForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdalarForm OdaForm = new OdalarForm();
            OdaForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelGiriş personelGiriş = new personelGiriş();
            personelGiriş.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StokYonetim StokForm = new StokYonetim();
            StokForm.Show();
        }
    }
}
