using Open.Archetypes.BaseClasses;
using Open.Archetypes.RoleClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstances : Archetypes<ProductInstance>
    {
        public static ProductInstances Instance { get; } = new ProductInstances();
        public static ProductInstances GetPerformerAA(string uniqueId)
        {
            var r = new ProductInstances();
            var l = Instance.FindAll(x => x.ProductId == uniqueId);
            r.AddRange(l);
            return r;
        }
    }
}
