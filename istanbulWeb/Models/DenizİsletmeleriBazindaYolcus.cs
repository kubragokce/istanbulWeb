using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class DenizİsletmeleriBazindaYolcus
    {
        public int Yil { get; set; }
        public int IDOistanbulDenizOtobusleriYolculukSayisi { get; set; }
        public int SehirHatlariMaxYolculukSayisi { get; set; }
        public int OzelTekneMotorMaxYolculukSayisi { get; set; }
        public string F5 { get; set; }
        [Key]
        public int ID { get; set; }
    }
}