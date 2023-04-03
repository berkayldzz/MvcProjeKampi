using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
       
        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } // Category tablosu ilişkili bir tablo olduğundan silme işlemi yerine aktif/pasif yap kullanıcaz.Yoksa ilişkili olan tüm değerler silinir.

        // İlişki Kurma İşlemleri

        // Heading - Category

        // Ben bu sınıfa bağlı bir koleksiyon oluşturmak istiyorum anlamına geliyor.
        // <> işaretleri arasına ilişki içerisine almak istediğimiz sınıfı yazıyoruz.

        public ICollection<Heading> Headings { get; set; }   // Daha sonra heading tarafına geçiyoruz.



    }
}
