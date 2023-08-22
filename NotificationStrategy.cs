using System;

namespace notificationSystem
{
    // Strategy Pattern is used 
    public interface INotificationStrategy
    {
        void SendNotification(User user, string subject, string msg);
    }

    
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(User user, string subject, string msg)
        {
            NotificationAdapter notificationAdapter = new NotificationAdapter();
            Console.WriteLine($"Sending email notification to {user.Name}, sub: {subject}, msg: {msg}");
            notificationAdapter.SendNotification(user.Email ,"Email", subject, msg);
        }
    }

    public class SmsNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(User user, string subject, string msg)
        {
            NotificationAdapter notificationAdapter = new NotificationAdapter();
            Console.WriteLine($"Sending SMS notification to {user.Name},sub: {subject}, msg: {msg}");
            notificationAdapter.SendNotification(user.Phone, "SMS", subject, msg);
            
        }
    }

}