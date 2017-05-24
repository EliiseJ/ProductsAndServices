using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Open.Logic.ProductClasses
{
    public class LendBookModel
    {
        public string SelectedCustomerId { get; set; }
        public string SelectedProductId { get; set; }
        [Display(Name = "Customer")]
        public IEnumerable<SelectListItem> Contacts { get; set; }
        [Display(Name = "Book")]
        public IEnumerable<SelectListItem> Products { get; set; }
    }
}
