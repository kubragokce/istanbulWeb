using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class TiyatroOyunSayilaris
    {
        public string kategori { get; set; }
        public int YabanciOyunSayisi { get; set; }
        public int YerliOyunSayisi { get; set; }
        public string Tarih { get; set; }
        [Key]
        public int tiyatro_id { get; set; }
    }
}