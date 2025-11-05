using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<EntityLayer.Concrete.Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)// category ekle BL'a  BL: business layer
        {
           if(p.CategoryName=="" ||  p.CategoryName.Length<=3 ||
                p.CategoryDescription =="" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }

    }

  }
