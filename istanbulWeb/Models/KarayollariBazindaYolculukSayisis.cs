using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class KarayollariBazindaYolculukSayisis
    {
        public int Yil { get; set; }
        public int YolculukSayisi { get; set; }
        public int ozelHalkotobusuYolculukSayisi { get; set; }
        public int OtobusYolculukSayisi { get; set; }
        public int MinibusYolculukSayisi { get; set; }
        public int TaksiTaksiDolmusYolculukSayisi { get; set; }
        public int ServisYolculukSayisi { get; set; }
        public int ToplamYolculuk { get; set; }
        [Key]
        public int yolculuk_id { get; set; }
     
    }
}