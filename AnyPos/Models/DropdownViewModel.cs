using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnyPos.Models
{
    public class DropdownViewModel
    {
        //[Required]
        [Display(Name = "Choose product")]
        public string SelectedProductId { get; set; }
    }
}
