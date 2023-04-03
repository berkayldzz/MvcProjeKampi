using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);

        // Sildirceğimiz değeri buldurmamız gerekiyor
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p);
        void Update(T p);

        // Şartlı listeleme için kullanacağım metot
        // Mesela yazar adı ali olanları getir dersek bu metot sayesinde getiricez.

        List<T> List(Expression<Func<T, bool>> filter);

    }
}
