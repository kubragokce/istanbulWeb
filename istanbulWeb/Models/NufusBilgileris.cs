using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class NufusBilgileris
    {
        public string belediye_ismi { get; set; }
        public int nufus { get; set; }

        [Key]
        public int ID { get; set; }
    }
}