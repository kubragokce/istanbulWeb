using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class OgrenciSayilaris
    {
        public string egitim_donemi { get; set; }
        public int ilkogretimKadin { get; set; }
        public int ilkogretimErkek { get; set; }
        public int ilkokulKadin { get; set; }
        public int ilkokulErkek { get; set; }
        public int ortaokulKadin { get; set; }
        public int ortaokulErkek { get; set; }
        [Key]
        public int egitim_id { get; set; }
    }
}