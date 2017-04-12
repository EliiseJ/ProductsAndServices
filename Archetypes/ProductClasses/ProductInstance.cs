using Open.Aids;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstance : Product<ProductType>
    {
        private string name;
        //private string serialNumber;
        private decimal price;
        //public string SerialNumber
        //{
        //    get { return SetDefault(ref serialNumber); }
        //    set { SetValue(ref serialNumber, value); }
        //}
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

        public override ProductType Type => ProductTypes.Find(TypeId);
        //public ProductFeatures Features => ProductFeatures.FindFeatures(UniqueId);

        public new static ProductInstance Random()
        {
            var e = new ProductInstance();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
            //serialNumber = GetRandom.String();
            price = GetRandom.Decimal();
        }
    }
}