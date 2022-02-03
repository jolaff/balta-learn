using JLFOOP.SharedContext;

namespace JLFOOP.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public User? User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}