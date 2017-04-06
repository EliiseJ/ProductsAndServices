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
    }
}
