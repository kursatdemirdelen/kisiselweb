using System.ComponentModel.DataAnnotations;

namespace kisiselweb.Models.Siniflar
{
    public class Istatistik
    {
        [Key]
        public int id { get; set; }
        public string musteri { get; set; }
        public string proje { get; set; }
        public string feedback { get; set; }
    }
}