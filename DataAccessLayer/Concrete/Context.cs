using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        // Context sınıfımın içeriğinde tanımlayacağım propertyler birer tablo ismi olarak sqlde karşılık bulucak.

        // Eğer bir başka katmanın sınıflarını,metotlarını,propertylerini bir başka katmanda kullanmak istiyosan o katmandan referans almak gerekir.

        public DbSet<About> Abouts { get; set; } // About projemin içinde yer alan sınıfımın ismi , Abouts ise sqlde veri tabanımıza yansıyıcak olan tablomuzun ismi.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
