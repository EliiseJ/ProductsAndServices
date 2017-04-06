using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ServiceTypes : Archetypes<ServiceType>
    {
        public static ServiceTypes Instance { get; } = new ServiceTypes();

        public static ServiceType Find(string id)
        {
            return Instance.Find(x => x.UniqueId == id);
        }

        public static ProductTypes Random()
        {
            var r = new ProductTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductType.Random());
            return r;
        }
    }
}
