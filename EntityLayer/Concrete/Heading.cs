using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        public bool HeadingStatus{ get; set; }
        public DateTime HeadingDate { get; set; }

        // İlişki Kurma İşlemleri (1 kategorinin birden fazla başlığı olabilir)

        // Heading - Category
        // Burada oluşturacağım propertynin ismini ilişkili tablomun(category) anahtar sütunuyla(CategoryID) aynı isim olarak vermem gerekiyor.

        public int CategoryID { get; set; } // Heading tablomun içerisinde categoryıd isminde bir sütunum olucak.

        // Ben bu sütunumun ilişki içinde olup olmadığını nasıl belirleyeceğim ?
        // Virtual anahtar kelimesini kullanıp category sınıfından değer alıp bir prop oluşturucaz.

        public virtual Category Category { get; set; }


        // Heading - Content (1 başlık birden fazla içeriğe sahip olabilir.)

        public ICollection<Content> Contents { get; set; }

        // Heading-Writer (1 Yazar birden fazla başlığa sahip olabilir)

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


    }
}
