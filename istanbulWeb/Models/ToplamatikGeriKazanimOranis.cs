using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class ToplamatikGeriKazanimOranis
    {
        public int Yil { get; set; }
        public string ToplamAtikGeriKazanim { get; set; }      
        [Key]
        public int ID { get; set; }
    }
}