using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class Services: Archetypes<IService>
    {
        public static Services Instance { get; } = new Services();
        public static Services GetInstances(string uniqueId)
        {
            var r = new Services();
            var l = Instance.FindAll(x => x.TypeId == uniqueId);
            r.AddRange(l);
            return r;
        }

        public static Services GetContent(string packageId)
        {
            var r = new Services();
            var l = Instance.FindAll(x => x.PackageId == packageId);
            r.AddRange(l);
            return r;
        }

        internal static IService Find(string serviceId)
        {
            return Instance.Find(x => x.UniqueId == serviceId);
        }
    }
}
