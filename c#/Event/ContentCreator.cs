namespace Event;

public class ContentCreator
{
    public delegate void ContentEvent(object sender, SubscriptionEvenArgs e);
    public event ContentEvent Subcribe;
    public string Name { get; set; }
    public ContentCreator(string name)
    {
        Name = name;
    }

    public void Follow(Follower f)
    {
        Subcribe += f.FollowerEventHandler;
        //OnSubcribe($"feliratkozott a {Name} csatornara");
    }

    public void Unfollow(Follower f)
    {
        Subcribe -= f.FollowerEventHandler;
        //OnSubcribe($"lefeliratkozott a {Name} csatornarol");
    }

    public void NewVideo(string title)
    {
        OnSubcribe($"NEW VIDEO!!! {title} from {Name}");
    }

    protected void OnSubcribe(string m)
    {
        if (Subcribe != null)
            Subcribe(this, new SubscriptionEvenArgs(m));
    }

}
