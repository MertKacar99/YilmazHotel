using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    public class MusterilerRepository : Irepository<Musteriler>
    {
        YılmazHotelEntities YılmazServer = new YılmazHotelEntities();
        public void Delete(int itemId)
        {
            YılmazServer.Musteriler.Remove(YılmazServer.Musteriler.Find(itemId));
            YılmazServer.SaveChanges();
        }

        public void Insert(Musteriler item)
        {
            YılmazServer.Musteriler.Add(item);
            YılmazServer.SaveChanges();
        }

        public List<Musteriler> SelectAll()
        {
            return YılmazServer.Musteriler.ToList();
           
        }

        public Musteriler SelectById(int itemID)
        {
            return YılmazServer.Musteriler.Find(itemID);
            
        }

        public void Update(Musteriler item)
        {
            Musteriler updated = YılmazServer.Musteriler.Find
                 (item.MusteriID);
            YılmazServer.Entry(updated).CurrentValues.SetValues(item);
            YılmazServer.SaveChanges();
        }
    }
}
