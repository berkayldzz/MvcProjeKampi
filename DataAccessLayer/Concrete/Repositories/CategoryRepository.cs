using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{

    public class CategoryRepository : ICategoryDal
    {
       
        
        // Bu ifade örnek olması amacıyla silmedik fakat bu şekilde bir kullanım olmaz.


        // ICategoryDal da tanımladığımız metotların içini doldurmak için burda o interfacei miras aldık.
        // Ama kullanabilmek için implement işlemi gerekli.

        // Çağırmam gereken 2 tane ifade var

        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            // Direkt değişiklikleri kaydet

            c.SaveChanges();
        }
    }
}
