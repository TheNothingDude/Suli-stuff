namespace Event;

public class Follower
{
    public string Username { get; set; }
    public Follower(string username)
    {
        Username = username;
    }

    public void FollowerEventHandler(object sender, SubscriptionEvenArgs e)
    {
        System.Console.WriteLine($"{Username} felhaszno {e.Message}.");
    }
}
