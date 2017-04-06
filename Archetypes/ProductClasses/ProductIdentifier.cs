using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductIdentifier: UniqueEntity
    {
        private string productId;

        public string ProductId
        {
            get { return SetDefault(ref productId); }
            set { SetValue(ref productId, value); }
        }
    }
}
