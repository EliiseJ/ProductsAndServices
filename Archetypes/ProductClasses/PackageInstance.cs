using System.Linq;

namespace Open.Archetypes.ProductClasses
{
    public class PackageInstance : ProductInstance
    {
        public ProductInstance[] getContents() => ProductInstances.Instance.ToArray();
    }
}
