using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class Prices : Archetypes<Price>
    {
        public static Prices Instance { get; } = new Prices();

        public static Price Find(string productId)
        {
            return Instance.Find(x => x.UniqueId == productId);
        }
        public static Prices Random()
        {
            var r = new Prices();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(Price.Random());
            return r;
        }
    }
}
