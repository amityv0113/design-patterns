namespace notificationSystem
{
    public interface INotification
    {
        void SendNotification(string email, string subject, string message);
    }
}