using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class PossiblePrices : Archetypes<PossiblePrice>
    {
        public static PossiblePrices Instance { get; } = new PossiblePrices();
    }
}
