using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    public class StokTakipRepository : Irepository<stokDurumu>
    {
        YılmazHotelEntities yılmazServer = new YılmazHotelEntities();
        public void Delete(int itemId)
        {
            yılmazServer.stokDurumu.Remove(yılmazServer.stokDurumu.Find(itemId));
            yılmazServer.SaveChanges();
        }

        public void Insert(stokDurumu item)
        {
            yılmazServer.stokDurumu.Add(item);
            yılmazServer.SaveChanges();
        }

        public List<stokDurumu> SelectAll()
        {
            return yılmazServer.stokDurumu.ToList();
        }

        public stokDurumu SelectById(int itemID)
        {
            return yılmazServer.stokDurumu.Find(itemID);
        }

        public void Update(stokDurumu item)
        {
            stokDurumu updated = yılmazServer.stokDurumu.Find(item.urunID);
            yılmazServer.Entry(updated).CurrentValues.SetValues(item);
            yılmazServer.SaveChanges();
           
        }
    }
}
