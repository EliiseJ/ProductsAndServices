using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogEntries : Archetypes<CatalogEntry>
    {
        public static CatalogEntries Instance { get; } = new CatalogEntries();
    }
}
