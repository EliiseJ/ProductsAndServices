using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductType : BaseType<ProductType>
    {
        private string name;
        private string description;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public override ProductType Type => ProductTypes.Find(TypeId);

        public Products Instances()
        {
            return Products.GetInstances(UniqueId);
        }

        public static ProductType Random()
        {
            var e = new ProductType();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
            description = GetRandom.String();
        }
    }
}
