using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WedBajet.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Nama Bridal")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}