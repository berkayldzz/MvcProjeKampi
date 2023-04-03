using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;  // _categorydal a değer ataması yapabilmek için constructor kullanıyoruz.

        public CategoryManager(ICategoryDal categorydal)
        {
            _categoryDal = categorydal;
        }



        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


        // Bu sınıfın interfaceinde tanımlanan metotları kalıtım ile üzerine aldırıyoruz.



        // Üzerinde çalışacağım sınıfı çağırmam gerekiyor.
        // GenericRepository<Category> repo = new GenericRepository<Category>();

        // Bu işlemleri kaldırıyoruz çünkü bunlar artık ICategoryService e bağlı olarak çalışan constructor üzerinden çağırıcam.

        /*
        
        // Her bir crud işlemi için metotlar tanımlayacağız ve isteğe bağlı şart ekleyeceğiz

        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                // hata mesajları
            }
            else
            {
                repo.Insert(p);
            }
                 
        }

        */

    }
}
