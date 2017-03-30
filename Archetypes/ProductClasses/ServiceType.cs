using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ServiceType: BaseType<ServiceType>
    {
        public override ServiceType Type { get; }
    }
}
