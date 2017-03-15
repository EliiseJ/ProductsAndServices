namespace Logic
{
    public class PackageType //: ProductType
    {
        public PricingStrategy PricingStrategy { get; set; }

        public PackageType() { }

        public PackageType(PricingStrategy pricingStrategy)
        {
            this.PricingStrategy = pricingStrategy;
        }
    }
}

