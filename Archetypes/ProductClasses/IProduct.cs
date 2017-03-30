namespace Open.Archetypes.ProductClasses
{
    public interface IProduct
    {
        string UniqueId { get; }
        string TypeId { get; }
        string PackageId { get; }
    }
}
