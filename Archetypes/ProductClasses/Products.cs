using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Open.Archetypes.ProductClasses
{
    [KnownType(typeof(ProductInstance))]
    [XmlInclude(typeof(ProductInstance))]
    [KnownType(typeof(ServiceInstance))]
    [XmlInclude(typeof(ServiceInstance))]
    [KnownType(typeof(PackageInstance))]
    [XmlInclude(typeof(PackageInstance))]

    public class Products : Archetypes<ProductInstance>
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

        internal static Products Random()
        {
            var p = new Products();
            for (var i = 0; i < GetRandom.Count(); i++)
                p.Add(ProductInstance.GetRandomDerived());
            return p;
        }

        internal static ProductInstance Find(string productId)
        {
            return Instance.Find(x => x.UniqueId == productId);
        }
    }
}
