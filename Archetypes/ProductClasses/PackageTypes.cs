using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
   public class PackageTypes : Archetypes<PackageType>
    {
        public static PackageTypes Instances { get; } = new PackageTypes();
    }
}
