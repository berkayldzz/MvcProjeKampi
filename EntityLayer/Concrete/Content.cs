using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }


        // Heading - Content  (1 Başlığın birden fazla içeriği olabilir.)

        public int HeadingID { get; set; } // Öncelikle ilişki kurduğum sınıfın anahtar değerinin ismiyle bir prop oluşturuyorum.
        public virtual Heading Heading { get; set; } // Başlıkla içerik ilişkili hale getirdik

     
        // Yazar - İçerik İlişkisi (1 yazar birden fazla içeriğe sahip olabilir)
        public int? WriterID { get; set; }
        public virtual Writer Writer  { get; set; }
    }
}
