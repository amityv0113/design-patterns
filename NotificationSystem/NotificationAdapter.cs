namespace notificationSystem
{
    // The NotificationAdapter class adapts the complex 
    // notificationManager to a simplified interface for sending notifications
    public class NotificationAdapter
    {
        private NotificationManager _notificationManager;

        public NotificationAdapter()
        {
            _notificationManager= NotificationManager.getNotificationManager();
        }
        public void SendNotification(string userInfo, string type, string subject, string msg)
        {
            _notificationManager.SendNotification(userInfo, type, subject, msg);
        }
    }
}