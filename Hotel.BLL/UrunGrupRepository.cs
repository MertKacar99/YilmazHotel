using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    public class UrunGrupRepository : Irepository<urunGrup>
    {
        YılmazHotelEntities YılmazServer = new YılmazHotelEntities();
        public void Delete(int itemId)
        {
            YılmazServer.urunGrup.Remove(YılmazServer.urunGrup.Find(itemId));
            YılmazServer.SaveChanges();

        }

        public void Insert(urunGrup item)
        {
            YılmazServer.urunGrup.Add(item);

        }

        public List<urunGrup> SelectAll()
        {
            return YılmazServer.urunGrup.ToList(); 
        }

        public urunGrup SelectById(int itemID)
        {
            return YılmazServer.urunGrup.Find(itemID);
        }

        public void Update(urunGrup item)
        {
            urunGrup updated = YılmazServer.urunGrup.Find(item.urunGno);
            YılmazServer.Entry(updated).CurrentValues.SetValues(item);
            YılmazServer.SaveChanges();
        
        }
    }
}
