namespace Open.Archetypes.ProductClasses
{
    public class ScheduledService : ServiceInstance
    {
        public bool Reschedule() { return false; }
        public bool Execute() { return false; }
        public bool Cancel() { return false; }
    }
}
