namespace Open.Archetypes.ProductClasses
{
    public interface IService
    {
        string UniqueId { get; }
        string TypeId { get; }
        string PackageId { get; }
    }
}
