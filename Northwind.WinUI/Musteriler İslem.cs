using Hotel.BLL;
using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI
{
  
    public partial class YılmazVerilerForm : Form
    {
        OdalarRepository odalarRep = new OdalarRepository();
        MusterilerRepository musrep = new MusterilerRepository();
        Odalar updated;
      
        public YılmazVerilerForm()
        {
            InitializeComponent();
            
        }
        public void ClickedButton(object sender,EventArgs e)
        {
      
        }
        private void YılmazVeriler_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void verilerigetir()
        {
            dataGridView1.DataSource = musrep.SelectAll();
            dataGridView1.Columns[8].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          

        }

       
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
 

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            verilerigetir();
 
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Satır seçiniz");
                return;

            }
            try
            {
                int MusteriNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int OdaNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                if (MusteriNo > 0 && OdaNo > 0)
                {
                    Odalar Oupdated = odalarRep.SelectById(OdaNo);
                    Oupdated.OdaDolulukDurumu = Convert.ToBoolean(0); //boolean değere çevirdim.
                    odalarRep.Update(Oupdated);
                    musrep.Delete(MusteriNo);
                    MessageBox.Show("Silme işlemi Başarılı..");
                    verilerigetir();
                    Application.Restart();



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
 
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Özellik devredışı/Daha sonra Bu özellik eklenicek.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
