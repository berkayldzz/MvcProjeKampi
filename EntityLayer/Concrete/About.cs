using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        // Attributeler köşeli parantez içinne yazılır.Hangi propertynin üst satırında tanımlarsanız sadece onun için geçerli olur.

        [Key] // AboutID birincil anahtar olması için bunu kullandık.
        public int AboutID { get; set; }

        [StringLength(1000)] // Max 1000 karakter olsun.
        public string AboutDetail1 { get; set; }

        [StringLength(1000)]
        public string AboutDetail2 { get; set; }

        [StringLength(100)]
        public string AboutImage1 { get; set; }

        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
