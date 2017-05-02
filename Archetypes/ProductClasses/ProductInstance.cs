using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstance : BaseEntity<ProductType>
    {
        private string name;
        private string serialNumber;
        private decimal price;
        private Products product;
        public Products Product
        {
            get { return SetDefault(ref product); }
            set { SetValue(ref product, value); }
        }


        public string SerialNumber
        {
            get { return SetDefault(ref serialNumber); }
            set { SetValue(ref serialNumber, value); }
        }
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public decimal Price
        {
            get { return SetDefault(ref price); }
            set { SetValue(ref price, value); }
        }
        private string packageId;

        public string PackageId
        {
            get { return SetDefault(ref packageId); }
            set { SetValue(ref packageId, value); }
        }

        public override ProductType Type => ProductTypes.Find(TypeId);
        public ProductFeature Feature => ProductFeatures.Find(UniqueId);

        public static ProductInstance GetRandomDerived()
        {
            var i = GetRandom.Int32() % 3;
            if (i == 1) return ServiceInstance.Random();
            if (i == 2) return PackageInstance.Random();
            return ProductInstance.Random();
        }
        public static ProductInstance Random()
        {
            var e = new ProductInstance();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
            serialNumber = GetRandom.String();
            price = GetRandom.Decimal();
        }
    }
}