using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ScheduledService : Archetypes<IService>
    {
        public bool Reschedule() { return false; }
        public bool Execute() { return false; }
        public bool Cancel() { return false; }
    }
}
