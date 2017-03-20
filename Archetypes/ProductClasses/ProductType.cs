using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductType : BaseType<ProductType>
    {
        private string name;
        private string description;
        private string productId;

        public string ProductId
        {
            get { return SetDefault(ref productId); }
            set { SetValue(ref productId, value); }
        }
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

        public static ProductType Random()
        {
            var e = new ProductType();
            e.SetRandomValues();
            return e;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            ProductId = GetRandom.String();
        }
        public override ProductType Type => ProductTypes.Find(TypeId);



        //tegemata: getPrices(context: RuleContext):Price[]


    }
}
