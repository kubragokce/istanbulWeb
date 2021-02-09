using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class SehirTiyatrolarindaSergilenenOyunlars
    {
        public string repertuvar { get; set; }
        public string kategori { get; set; }
        public string oyun_adi { get; set; }
        public int toplam_adet { get; set; }
        public int seans_sayisi { get; set; }
        public int doluluk_orani { get; set; }
        [Key]
        public int ID { get; set; }
        public int tiyatro_id { get; set; }
    }
}