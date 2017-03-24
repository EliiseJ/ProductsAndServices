using Open.Archetypes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Archetypes.ProductClasses
{
    public class ProductIdentifiers : Archetypes<ProductIdentifier>
    {
        public static ProductIdentifiers Instance { get; } = new ProductIdentifiers();
    }
}
