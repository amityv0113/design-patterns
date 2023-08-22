namespace notificationSystem
{
    // Singleton design pattern is used here 
    // NotificationManager class ensures that 
    // only one instance of itself is created
    public class NotificationManager
    {
        private static NotificationManager _instance;
        private NotificationFactory notificationFactory;
        private NotificationManager()
        {
            notificationFactory=new NotificationFactory();
        }

        //getNotificationManager method provides global access to that instance
        public static NotificationManager getNotificationManager()
        {
            if (_instance==null)
            {
                _instance = new NotificationManager();
            }
            return _instance;
            
        }
        public void SendNotification(string userInfo ,string type,string body,string msg)
        {
            var notifaction= notificationFactory.CreateNotification(type);
            notifaction.SendNotification(userInfo, body, msg);
        }
    }
}