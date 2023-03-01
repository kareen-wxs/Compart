using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebApplication2.ViewModel
{
    public class ViewModelProduct
    {
        [DisplayName("BP")]
        public string Id { get; set; }

        public List<SelectListItem>ListofProduct { get; set; }
    }
}
