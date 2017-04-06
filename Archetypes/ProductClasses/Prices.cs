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
    }
}
