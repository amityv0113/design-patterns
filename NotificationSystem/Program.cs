using System;

namespace notificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // create users
            var user1= new User{ Name="name1",Email="name1@gmail.com",Phone="123456789"};
            var user2= new User{ Name="name2",Email="name2@gmail.com",Phone="987654321"};
            
            // create notificationPublisher object and add Subscribes
            // and set SetNotificationStrategy as EmailNotificationStrategy
            var notificationPublisher=new NotificationPublisher(); 
            notificationPublisher.Subscribe(user1);
            notificationPublisher.Subscribe(user2);
            notificationPublisher.SetNotificationStrategy(new EmailNotificationStrategy());

            var notificationFacade = new NotificationFacade();
            var subject= "New update";
            var msg= "new updated version is released";

            // Use the NotificationFacade to send notifications
            notificationFacade.SendNotification(notificationPublisher,subject,msg);

            // update NotificationStrategy for SMS notification 
            notificationPublisher.SetNotificationStrategy(new SmsNotificationStrategy());

            // Use the NotificationFacade to send notifications
            notificationFacade.SendNotification(notificationPublisher,subject,msg);

        }
    }
}
