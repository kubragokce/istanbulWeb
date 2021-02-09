using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class GemiAtikTuruveMiktaris
    {
        public string gemilerdenToplananAtik { get; set; }
        public int y2015 { get; set; }
        public int y2016 { get; set; }
        public int y2017 { get; set; }
        public int y2018 { get; set; }
        public int y2019 { get; set; }
        [Key]
        public int ID { get; set; }
    }
}