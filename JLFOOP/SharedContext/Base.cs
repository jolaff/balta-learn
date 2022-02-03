using JLFOOP.NotificationContext;

namespace JLFOOP.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

    }
}