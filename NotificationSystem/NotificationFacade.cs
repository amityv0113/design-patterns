namespace notificationSystem
{
    // The NotificationFacade class simplified interface for sending notifications
    // Encapsulates process of setting the NotificationPublisher and notifying subscribers
    public class NotificationFacade
    {
        public void SendNotification(NotificationPublisher publisher, string subject, string msg)
        {
            publisher.NotifySubscribers(subject, msg);
        }
    }
}