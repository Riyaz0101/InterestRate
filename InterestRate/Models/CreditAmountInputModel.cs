using System;
using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class CreditAmountInputModel
    {
        [Required(ErrorMessage = "The Amount is required")]
        [Range(0, Int64.MaxValue, ErrorMessage = "The Amount should not contain characters")]
        public string creditAmount { get; set; }
    }
}
