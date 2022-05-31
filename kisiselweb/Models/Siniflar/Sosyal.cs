using System.ComponentModel.DataAnnotations;

namespace kisiselweb.Models.Siniflar
{
    public class Sosyal
    {
        [Key]
        public int id { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string linkedin { get; set; }
    }
}