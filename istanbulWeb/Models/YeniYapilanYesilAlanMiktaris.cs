using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace istanbulWeb.Models
{
    public class YeniYapilanYesilAlanMiktaris
    {
        public string FAALIYETKONUSU { get; set; }
        public int y2004 { get; set; }
        public int y2005 { get; set; }
        public int y2006 { get; set; }
        public int y2007 { get; set; }
        public int y2008 { get; set; }
        public int y2009 { get; set; }
        public int y2010 { get; set; }
        public int y2011 { get; set; }
        public int y2012 { get; set; }
        public int y2013 { get; set; }
        public int y2014 { get; set; }
        public int y2015 { get; set; }
        public int y2016 { get; set; }
        public int y2017 { get; set; }
        public int y2018 { get; set; }
        public int y2019 { get; set; }
        public int TOPLAM { get; set; }
        [Key]
        public int ID { get; set; }
    }
}