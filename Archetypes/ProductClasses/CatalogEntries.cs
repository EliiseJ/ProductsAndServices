using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogEntries : Archetypes<CatalogEntry>
    {
        public static CatalogEntries Instance { get; } = new CatalogEntries();

        internal static CatalogEntry Find(string catalogId)
        {
            return Instance.Find(x => x.UniqueId == catalogId);
        }
    }
}
