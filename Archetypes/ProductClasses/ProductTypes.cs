using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.ProductClasses
{
    public class ProductTypes : Archetypes<ProductType>
    {
        public static ProductTypes Instance { get; } = new ProductTypes();

        public static ProductType Find(string id)
        {
            return Instance.Find(x => x.ProductInstanceId == id);
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
