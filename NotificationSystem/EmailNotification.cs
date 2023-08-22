using System;

namespace notificationSystem
{
    // EmailNotification implement SendNotification method 
    // containing actual email sending logic 
    public class EmailNotification : INotification
    {
        public void SendNotification(string email, string subject, string message)
        {
            // Actual email sending logic 
            Console.WriteLine($"Email notification send to {email}");
            
        }
    }
}