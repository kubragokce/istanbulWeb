using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class RayliTamamlanmisSantiyes
    {
        public string HatAdi { get; set; }
        public string SantiyeBilgileri { get; set; }   
        public DateTime  BitisTarihi { get; set; }

        [Key]
        public int ID { get; set; }
    }
}