namespace Open.Archetypes.ProductClasses
{
    public class PackageInstance : ProductInstance
    {
        //public Products Contents() => Products.GetContent(UniqueId);

        public new static PackageInstance Random()
        {
            var e = new PackageInstance();
            e.SetRandomValues();
            return e;
        }
    }
}
