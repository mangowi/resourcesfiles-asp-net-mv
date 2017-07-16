using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResourcesFiles.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public decimal  Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}