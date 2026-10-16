namespace RefactoringLab;

public class EmailNotification : INotification
{
    public string Channel => "email";
    public void Send(string to, string message , DateTime? sendAt = null ) =>
        Console.WriteLine($"{NotificationFormat.Tag(Channel , sendAt)} {to}: {message}");
}

public class SmsNotification : INotification
{
    public string Channel => "sms";
    public void Send(string to, string message , DateTime? sendAt = null) =>
        Console.WriteLine($"{NotificationFormat.Tag(Channel , sendAt)} {to}: {message}");
}

// New Channel 


public class UrgentNotification : INotification
{
    private readonly INotification notification;
    public string Channel => notification.Channel;
    public UrgentNotification(INotification notification)
    {
        ArgumentNullException.ThrowIfNull(notification);
        this.notification = notification;
    }
    
    public void Send(string to, string message , DateTime? sendAt = null) =>
        notification.Send(to, $"[URGENT] {message}" , sendAt);
}

public class ScheduledNotification : INotification
{
    private readonly INotification notification;
    public string Channel => notification.Channel;
    public DateTime SendAt { get; }

    public ScheduledNotification(INotification notification, DateTime sendAt)
    {
        ArgumentNullException.ThrowIfNull(notification);

        this.notification = notification;
        SendAt = sendAt;
    }

    public void Send(string to, string message , DateTime? sendAt = null) =>
        notification.Send(to, message, SendAt );

}