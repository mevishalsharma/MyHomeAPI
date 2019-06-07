using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyHomeApi
{
    public class Property
    {
        [Key]
        public Int32 PropertyId { get; set; }
        public string GroupLogoUrl { get; set; }
        public string BedsString { get; set; }
        public double Price { get; set; }
        public double SizeStringMeters { get; set; }
        public string DisplayAddress { get; set; }
        public string PropertyType { get; set; }
        public string BathString { get; set; }
        public string BerRating { get; set; }
        public string MainPhoto { get; set; }
        [ForeignKey("Photo")]
        public Int32 PhotoID { get; set; }

        public virtual Photo Photo { get; set; }
    }

    public class PropertyViewModel
    {
         
        public Int32 PropertyId { get; set; }
        public string GroupLogoUrl { get; set; }
        public string BedsString { get; set; }
        public double Price { get; set; }
        public double SizeStringMeters { get; set; }
        public string DisplayAddress { get; set; }
        public string PropertyType { get; set; }
        public string BathString { get; set; }
        public string BerRating { get; set; }
        public string MainPhoto { get; set; }
        public  string Photos { get; set; }
    }
}