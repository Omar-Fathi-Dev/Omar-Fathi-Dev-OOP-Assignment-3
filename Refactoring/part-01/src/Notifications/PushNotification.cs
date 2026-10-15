namespace RefactoringLab;


public class PushNotification : INotification
{
    public string Channel => "push";
    public void Send(string to, string message , DateTime? sendAt = null) =>
        Console.WriteLine($"{NotificationFormat.Tag(Channel , sendAt)} {to}: {message}");
}
