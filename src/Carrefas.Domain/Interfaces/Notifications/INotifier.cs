using Carrefas.Domain.Notifications;

namespace Carrefas.Domain.Interfaces.Notifications
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
