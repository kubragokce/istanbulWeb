using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class SonBirYildaDepremEtkenligis
    {
        public string tarih { get; set; }
        public string magType { get; set; }
        public string olay_yeri_adi { get; set; }
        public int enlem { get; set; }
        public int boylam { get; set; }
        public int derinlik { get; set; }
        [Key]
        public int ID { get; set; }
        public int olay_id { get; set; }
    }
}