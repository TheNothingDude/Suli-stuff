namespace Event;

public class SubscriptionEvenArgs : EventArgs
{
    public string Message { get; set; }
    public SubscriptionEvenArgs(string m) : base()
    {
        Message = m;
    }
}
