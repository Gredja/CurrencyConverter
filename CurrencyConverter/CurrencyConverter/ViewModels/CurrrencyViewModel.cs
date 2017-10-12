using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.ViewModels
{
    public class CurrrencyViewModel
    {
        [Required]
        public string CurrencyFrom { get; set; }

        [Required]
        public string CurrencyTo { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Amount { get; set; }

        [Display(Name = "Currencies")]
        public List<string> CurrencyTypes { get; set; }
    }
}
