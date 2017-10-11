
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.ViewModels
{
    public class AllCurrrencyTypesViewModel
    {
        public string Currency { get; set; }

        [Display(Name = "Currencies")]
        public List<string> CurrencyTypes { get; set; }
    }
}
