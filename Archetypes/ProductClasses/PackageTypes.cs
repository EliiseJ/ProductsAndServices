using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class PackageTypes : Archetypes<PackageType>
    {
        public static PackageTypes Instance { get; } = new PackageTypes();

        public static PackageType Find(string packageId)
        {
            return Instance.Find(x => x.UniqueId == packageId);
        }

        public static PackageTypes Random()
        {
            var r = new PackageTypes();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(PackageType.Random());
            return r;
        }
    }
}
