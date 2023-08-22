namespace notificationSystem
{
    // factory desin pattern is used here 
    // NotificationFactory encapsulates the creation 
    // logic and allows for easy extension under if condition 
    public class NotificationFactory
    {
        public INotification CreateNotification(string type)
        {
            // diffrent type of notification can be add 
            if (type=="Email")
            {
                return new EmailNotification();
            }
            else if(type=="SMS")
            {
                return new SmsNotification();
            }

            return null;
        }
    }
}