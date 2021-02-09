using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class RayliSistemlerİnternetSiteleris
    {
        public string Bolge { get; set; }
        public string MetroHatti { get; set; }
        public string internetSitesi { get; set; }

        [Key]
        public int ID { get; set; }
    }
}