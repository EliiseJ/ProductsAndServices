﻿using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class CatalogEntry : BaseEntity<ProductType>
    {
        private string catalogId;
        private string description;

        public string CatalogId
        {
            get { return SetDefault(ref catalogId); }
            set { SetValue(ref catalogId, value); }
        }

        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public CatalogEntry GetCategories(string catalogId)
        {
            this.CatalogId = catalogId;
            return null;
        }

        private string productId;

        public string ProductId
        {
            get { return SetDefault(ref productId); }
            set { SetValue(ref productId, value); }
        }

        private string productInstanceId;

        public string ProductInstanceId
        {
            get { return SetDefault(ref productInstanceId); }
            set { SetValue(ref productInstanceId, value); }
        }

        public ProductType ProductType => ProductTypes.Find(ProductInstanceId);

        public override ProductType Type => ProductTypes.Find(TypeId);
    }
}
