using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{  //buranın içinde ne varsa hepsi generic olacak onlara da geçecek herşey burdan dönecek gibi
    public interface IRepository<T> //dışarıdan T türünde bir parametre alacak sql deki tabloyu temsil edecek
    {
        List<T> List(); //T türünde liste döndürecek
        void Insert(T p); //T'den parametre alır
        void Delete(T p); //T'den parametre alır
        void Update(T p); //T'den parametre alır

        List<T> List(Expression<Func<T, bool>> filter); //filtreleme yapabilmek için


    }
}
