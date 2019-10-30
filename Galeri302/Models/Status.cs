using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public enum Status
    {
        Sıfır=0,
        [Display(Name ="İkinci El")]
        IkinciEl=1
    }
}