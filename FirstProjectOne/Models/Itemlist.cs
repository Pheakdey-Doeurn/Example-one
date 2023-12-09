using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FirstProjectOne.Models
{
    public class Itemlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string category { get; set; }
    }
}