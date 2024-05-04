using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Hotel.BLL
{
    public class OdalarRepository : Irepository<Odalar>
    {
        YılmazHotelEntities YılmazServer = new YılmazHotelEntities();

        public void Delete(int itemId)
        {
            YılmazServer.Odalar.Remove(YılmazServer.Odalar.Find(itemId));
            YılmazServer.SaveChanges();
        }

        public void Insert(Odalar item)
        {
            YılmazServer.Odalar.Add(item);
            YılmazServer.SaveChanges();
        }

        public List<Odalar> SelectAll()
        {
            return YılmazServer.Odalar.ToList();
        }

        public Odalar SelectById(int itemID)
        {
            return YılmazServer.Odalar.Find(itemID);
          
        }

        public void Update(Odalar item)
        {
            Odalar updated = YılmazServer.Odalar.Find
                      (item.OdaNo);
            YılmazServer.Entry(updated).CurrentValues.SetValues(item);
            YılmazServer.SaveChanges();
        }
    }
}
