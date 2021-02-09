using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class GunesUretimMiktarlaris
    {
        public int DogayaSaglananAgacKatkisi { get; set; }
        public int TrafiktenCekilenAracSayisi { get; set; }
        public int Enlem { get; set; }
        public int Boylam { get; set; }
        public string Aciklama { get; set; }
        [Key]
        public int ID { get; set; }
    }
}