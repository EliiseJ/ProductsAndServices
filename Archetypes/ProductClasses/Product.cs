using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.ProductClasses
{
    public abstract class Product<T>: BaseEntity<T>, IProduct
    {
        private string packageId;

        public string PackageId
        {
            get { return SetDefault(ref packageId); }
            set { SetValue(ref packageId, value);}
        }
    }
}
