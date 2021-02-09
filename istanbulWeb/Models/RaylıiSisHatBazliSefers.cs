using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class RaylıiSisHatBazliSefers
    {
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
        public int M4 { get; set; }
        public int M6 { get; set; }
        public int T1 { get; set; }
        public int T3 { get; set; }
        public int T4 { get; set; }
        public int F1 { get; set; }

        public int TF1 { get; set; }
        public int TF2 { get; set; }

        [Key]
        public int ID { get; set; }
    }
}