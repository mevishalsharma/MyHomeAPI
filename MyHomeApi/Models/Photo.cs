using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyHomeApi
{
    public class Photo
    {
        [Key]
        public Int32 PhotoId { get; set; }
        public string DataPhoto { get; set; }
    }
}