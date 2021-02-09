using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class GeriKazanilanatikMiktars
    {
        public int Yil { get; set; }
        public int GeriKazanilanMiktar { get; set; }

        [Key]
        public int ID { get; set; }
    }
}