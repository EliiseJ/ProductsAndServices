using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class Prices : Archetypes<Price>
    {
        public static Prices Instance { get; } = new Prices();
    }
}
