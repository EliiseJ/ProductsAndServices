using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class PriceTests: CommonTests<Price>
    {
        protected override Price GetRandomObj()
        {
            return Price.Random();
        }
    }
}
