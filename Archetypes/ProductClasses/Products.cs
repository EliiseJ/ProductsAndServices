using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class Products : Archetypes<IProduct>
    {
        public static Products Instance { get; } = new Products();
        public static Products GetInstances(string uniqueId)
        {
            var r = new Products();
            var l = Instance.FindAll(x => x.TypeId == uniqueId);
            r.AddRange(l);
            return r;
        }

        public static Products GetContent(string packageId)
        {
            var r = new Products();
            var l = Instance.FindAll(x => x.PackageId == packageId);
            r.AddRange(l);
            return r;
        }

        internal static IProduct Find(string productId)
        {
            throw new NotImplementedException();
        }
    }
}
