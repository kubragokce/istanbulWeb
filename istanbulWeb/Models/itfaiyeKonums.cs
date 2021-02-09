using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class itfaiyeKonums
    {
        public string istasyon_adi { get; set; }
        public string ilce { get; set; }
        public string konum { get; set; }
        [Key]
        public int ID { get; set; }
    }
}