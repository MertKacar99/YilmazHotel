using DevExpress.XtraGrid.Views.Grid;
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
    public partial class StokYonetim : Form
    {
 
        public StokYonetim()
        {
            InitializeComponent();
        }
         
        private void StokYonetim_Load(object sender, EventArgs e)
        {

        }
        StokTakipRepository stoktakRep = new StokTakipRepository();
        FormUrunList frmUrunList;
        private void Butonozel()
        {
            if (frmUrunList == null)
            {
                frmUrunList = new FormUrunList();
                frmUrunList.MdiParent = this;
                frmUrunList.Verilerigetir();
                frmUrunList.Hide();
              
            }
                
        }
        private void BtnListele_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunList==null)
            {
                frmUrunList = new FormUrunList();
                frmUrunList.MdiParent = this;
                frmUrunList.Show();
                
            }
             
        }

        private void btnsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Butonozel();
            frmUrunList.UrunSil();
            
        }

        private void btnekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Butonozel();
             frmUrunList.UrunEkle();
             frmUrunList.Verilerigetir();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(

                "www.yilmazotel.com.tr" +
                "",
                "yilmazdestek@gmail.com") ;
 
               
        }
    }
}
