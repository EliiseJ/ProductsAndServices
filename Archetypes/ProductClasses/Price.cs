using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class Price: UniqueEntity
    {
        private string productId;
        private string description;
        private decimal amount;

        public string ProductId
        {
            get { return SetDefault(ref productId); }
            set { SetValue(ref productId, value);}
        }
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
        public decimal Amount
        {
            get { return SetDefault(ref amount); }
            set { SetValue(ref amount, value); }
        }
    }
}
