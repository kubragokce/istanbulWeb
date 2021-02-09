using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class istasyonlars
    {
        public string istasyonAdi { get; set; }
        public string Bulunduguilce { get; set; }
        public string Koordinat { get; set; }
        [Key]
        public int ID { get; set; }
    }
}