using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class ilceBazliOkumaYazmaBilenBilmeyenKisiSayisis
    {
        public string ilceler { get; set; }
        public int bilinmeyen { get; set; }
        public int okuma_yazma_bilen { get; set; }
        public int okuma_yazma_bilmeyen { get; set; }
        [Key]
        public int ID { get; set; }
        public int egitim_id { get; set; }
    }
}