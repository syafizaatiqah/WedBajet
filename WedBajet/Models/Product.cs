using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WedBajet.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        [Display(Name = "Nama Pakej")]
        [Required(ErrorMessage = "Ruangan mesti diisi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ruangan mesti diisi")]
        [Display(Name = "Keterangan")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ruangan mesti diisi")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?", ErrorMessage = "Harga mesti dalam nombor atau dua titik perpuluhan")]
        [Display(Name = "Harga")]
        public decimal Price { get; set; }

        [Display(Name = "BridalID")]
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}