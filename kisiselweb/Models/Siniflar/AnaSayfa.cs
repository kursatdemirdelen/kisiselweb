using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kisiselweb.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
       
    }
}