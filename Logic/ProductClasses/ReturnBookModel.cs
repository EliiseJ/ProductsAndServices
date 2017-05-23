using Open.Data;
using System.Collections.Generic;
using System.Web.Mvc;
using Open.Archetypes.ContactClasses;

namespace Open.Logic.ProductClasses
{
    public class ReturnBookModel
    {
        public ReturnBookModel()
        {
        }

        public string SelectedCustomerId { get; set; }
        public IEnumerable<SelectListItem> Contacts { get; set; }
    }
}
