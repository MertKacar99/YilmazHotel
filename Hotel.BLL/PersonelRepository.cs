using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    public class PersonelRepository:Irepository<Personeller>
    {
        YılmazHotelEntities YılmazServer = DBTool.DBInstance;

        public void Delete(int itemId)
        {
            YılmazServer.Personeller.Remove(YılmazServer.Personeller.Find(itemId));
            YılmazServer.SaveChanges();
        }

        public void Insert(Personeller item)
        {
            YılmazServer.Personeller.Add(item);
            YılmazServer.SaveChanges();
        }

        public List<Personeller> SelectAll()
        {
            return YılmazServer.Personeller.ToList();
        }

        public Personeller SelectById(int itemID)
        {
            return YılmazServer.Personeller.Find(itemID);
        }

        public void Update(Personeller item)
        {
            Personeller updated = YılmazServer.Personeller.Find
                 (item.PersonelNo);
            YılmazServer.Entry(updated).CurrentValues.SetValues(item);
            YılmazServer.SaveChanges();

        }
    }
}
