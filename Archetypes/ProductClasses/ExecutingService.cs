namespace Open.Archetypes.ProductClasses
{
    public class ExecutingService : ServiceInstance
    {
        public bool Complete() { return false; }
        public bool Cancel() { return false; }
    }
}
