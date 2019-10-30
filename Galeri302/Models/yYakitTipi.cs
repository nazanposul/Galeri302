using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class yYakitTipi
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string  Ytipi { get; set; }

        public virtual ICollection<Araclar>Araclars { get; set; }
    }
}