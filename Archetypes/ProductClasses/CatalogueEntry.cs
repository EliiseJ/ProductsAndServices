namespace Open.Archetypes.ProductClasses
{
    public class CatalogueEntry
    {
        private string Identifier { get; set; }
        private string Description { get; set; }

        public CatalogueEntry GetCategories(string identifier)
        {
            this.Identifier = identifier;
            return null;
        }

        //public ProductTypes GetProductTypes(string ID)
        //{
        //    return ProductTypes.Instances.GetProductTypesByID(ID);
        //}
    }
}
