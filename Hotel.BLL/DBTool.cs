using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Hotel.BLL
{
   public class DBTool
    {
     
        private static YılmazHotelEntities _dbInstance;
        public static YılmazHotelEntities DBInstance
        {
            get
            {
                if (_dbInstance == null)
                    _dbInstance = new YılmazHotelEntities();
                return _dbInstance;

            }
        }


    }
}
