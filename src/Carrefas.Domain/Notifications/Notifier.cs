using Carrefas.Domain.Interfaces.Notifications;

namespace Carrefas.Domain.Notifications
{
    public class Notifier : INotifier
    {
        private List<Notification> _notifications; // criei a lista notifications

        public Notifier() // inicializando a lista pelo construtor
        {
            _notifications = new List<Notification>();
        }

        public List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotification()
        {
            return _notifications.Any();
        }
    }
}
