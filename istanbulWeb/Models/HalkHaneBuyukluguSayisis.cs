using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class HalkHaneBuyukluguSayisis
    {
        public string ilceAdi { get; set; }
        public int HanehalkiBuyuklugu { get; set; }
        [Key]
        public int ID { get; set; }
    }
}