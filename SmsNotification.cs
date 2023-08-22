using System;

namespace notificationSystem
{
    // SmsNotification implement SendNotification method 
    // containing actual SMS sending logic 
    public class SmsNotification : INotification
    {
        public void SendNotification(string PhoneNo, string subject, string message)
        {
            // Actual SMS sending logic 
            Console.WriteLine($"SMS notification send to {PhoneNo}");
        }
    }
}