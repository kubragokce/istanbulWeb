using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class KarayollariBazindaAracVeHatSayisis
    {
        public int yil { get; set; }
        public int iettotobusAracSayisi { get; set; }
        public int iettmetrobusAracSayisi { get; set; }
        public int ozelHalkOtobusSayisi { get; set; }
        public int otobusSayisi { get; set; }
        public int ToplamAracSayisi { get; set; }

        public int ToplamHatSayisi { get; set; }

        [Key]
        public int ID { get; set; }
    }
}