using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ServiceType: BaseType<ServiceType>
    {
        private string name;
        private string description;

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

        public override ServiceType Type => ServiceTypes.Find(TypeId);

        public Products Instances()
        {
            return Products.GetInstances(UniqueId);
        }

        public static ServiceType Random()
        {
            var e = new ServiceType();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
            description = GetRandom.String();
        }
    }
}
