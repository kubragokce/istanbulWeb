using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class Tables
    {
        public string TableName { get; set; }
        public List<string> Sutunlar = new List<string>();
        public List<List<string>> Satirlar = new List<List<string>>();

        
    }
}