using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    interface Irepository<T>
    {

        //Ekle
        void Insert(T item);


        //sil
        void Delete(int itemId);


        //Güncelle
        void Update(T item);


        //hepsini seç
        List<T> SelectAll();
        T SelectById(int itemID);
    }
}
