using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductType : BaseType<ProductType>
    {
        private string catalogId;
        public string CatalogId
        {
            get { return SetDefault(ref catalogId); }
            set { SetValue(ref catalogId, value); }
        }

        private string productInstanceId;
        public string ProductInstanceId
        {
            get { return SetDefault(ref productInstanceId); }
            set { SetValue(ref productInstanceId, value); }
        }

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

        public override ProductType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public  ProductInstances GetProductInstances()
        {
            return ProductInstances.GetPerformerAA(productId);
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


        



        //tegemata: getPrices(context: RuleContext):Price[]


    }
}
