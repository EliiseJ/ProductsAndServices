using Open.Aids;
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
        public static CatalogEntries Random()
        {
            var r = new CatalogEntries();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(CatalogEntry.Random());
            return r;
        }
    }
}
