using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class ToplananKatiAtikMiktarlaris
    {
        public int Yil { get; set; }
        public int DenizYuzundenToplananKatiAtik { get; set; }
        public int KiyivePlajlardanToplananKatiAtik { get; set; }
        [Key]
        public int ID { get; set; }
    }
}