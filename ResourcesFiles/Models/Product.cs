using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ResourcesFiles.App_GlobalResources;

namespace ResourcesFiles.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public decimal  Price { get; set; }
        [Display(ResourceType = typeof(ErrorMessageResources), 
            Name = "ReleaseDateDisplay")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(ErrorMessageResources), ErrorMessageResourceName = "ReleaseDateRequiredErrorMessage")]
        public DateTime ReleaseDate { get; set; }
    }
}