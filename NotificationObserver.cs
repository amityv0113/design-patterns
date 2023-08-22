using System.Collections.Generic;


namespace notificationSystem
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    // NotificationPublisher class maintains a list of 
    // subscribers and notifies them using a chosen strategy
    public class NotificationPublisher
    {
        private INotificationStrategy _notificationStrategy;
        private List<User> _subscribers = new List<User>();

        public void Subscribe(User user)
        {
            _subscribers.Add(user);
        }

        public void SetNotificationStrategy(INotificationStrategy strategy)
        {
            _notificationStrategy = strategy;
        }

        public void NotifySubscribers(string body,string msg)
        {
            foreach (var subscriber in _subscribers)
        {
            _notificationStrategy.SendNotification(subscriber, body, msg);
        }
        }

    }
}