namespace RefactoringLab;

public interface INotification
{
    string Channel { get; }
    public void Send(string to, string message , DateTime? sendAt = null);
    
}

