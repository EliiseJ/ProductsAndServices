using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogueEntries : Archetypes<CatalogueEntry>
    {
        public static CatalogueEntries Instances { get; } = new CatalogueEntries();
    }
}
