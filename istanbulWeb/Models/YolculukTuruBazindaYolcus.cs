using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class YolculukTuruBazindaYolcus
    {
        public int Yil { get; set; }
        public int YolcuSayisi { get; set; }
        public string YolculukTuru { get; set; }
        [Key]
        public int ID { get; set; }
    }
}