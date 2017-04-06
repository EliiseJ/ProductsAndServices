namespace Open.Archetypes.ProductClasses
{
    public class PackageInstance : ProductInstance
    {
        public Products Contents() => Products.GetContent(UniqueId);
    }
}
