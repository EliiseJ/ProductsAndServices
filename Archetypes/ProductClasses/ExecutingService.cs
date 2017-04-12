using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ExecutingService: Archetypes<IService>
    {
        public bool Complete() { return false; }
        public bool Cancel() { return false; }
    }
}
