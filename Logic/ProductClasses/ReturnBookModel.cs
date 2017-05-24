using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Open.Logic.ProductClasses
{
    public class ReturnBookModel
    {
        public ReturnBookModel()
        {
        }

        public string SelectedCustomerId { get; set; }

        [Display(Name = "Customers")]
        public IEnumerable<SelectListItem> Contacts { get; set; }
    }
}
