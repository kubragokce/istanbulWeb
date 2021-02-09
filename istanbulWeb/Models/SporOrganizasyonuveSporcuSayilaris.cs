using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class SporOrganizasyonuveSporcuSayilaris
    {
        public int Yil { get; set; }
        public int UlusalSporOrganizasyonuSayisi { get; set; }
        public int UluslararasiSporOrganizasyonuSayisi { get; set; }
        public int SporcuSayisi { get; set; }
        [Key]
        public int ID { get; set; }
    }
}