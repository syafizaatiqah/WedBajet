using WedBajet.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WedBajet.ViewModels
{
    public class BasketViewModel
    {
        public List<BasketLine> BasketLines { get; set; }
        [Display(Name = "Jumlah Bakul:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}