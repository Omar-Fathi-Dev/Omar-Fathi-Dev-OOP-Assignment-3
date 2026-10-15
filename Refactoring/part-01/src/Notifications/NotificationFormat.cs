namespace RefactoringLab;

public static class NotificationFormat
{
    public static string Tag(string channel, DateTime? sendAt)
        => sendAt == null
            ? $"[{channel}]"
            : $"[{channel} scheduled {sendAt:g}]";
}

