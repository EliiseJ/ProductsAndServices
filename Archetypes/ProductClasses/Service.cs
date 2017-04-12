using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public abstract class Service<T>: BaseEntity<T>, IService
    {
        private string packageId;

        public string PackageId
        {
            get { return SetDefault(ref packageId); }
            set { SetValue(ref packageId, value); }
        }
        
        //public override ServiceType Type { get; }
    }
}
