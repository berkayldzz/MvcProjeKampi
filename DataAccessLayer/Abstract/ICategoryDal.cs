using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
      
        
        // IRepository sayesinde bunları kullanmama gerek kalmayacak.Yukarıda miras alarak.
        
        /*
        
        // CRUD işlemleri yapılacak

        List<Category> List();
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);

        // Bunları oluşturduktan sonra yeni bir tane sınıf oluşturmam gerekiyor.Bu sınıfta da burda
        // tanımlamış olduğum metotların görevini yazmam gerekiyor.Yani burda oluşturduğum bu metotlara
        // görev tanımlaması yapıcaz.
      */
    }

}
