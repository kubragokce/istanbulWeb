using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class YangininKaynaginiGoreDagilims
    {
        public int OlayTarihiYil { get; set; }
        public string YanginKaynagi { get; set; }
        public int YanginSayisi { get; set; }
        [Key]
        public int ID { get; set; }
    }
}