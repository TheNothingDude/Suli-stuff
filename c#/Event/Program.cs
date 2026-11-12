using System;
using System.Runtime.InteropServices.JavaScript;

namespace Event
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ContentCreator JG = new ContentCreator("Janosik Gergo");
            Follower f1 = new Follower("Kis Kazmer");
            Follower f2 = new Follower("vad virag");
            JG.Follow(f1);
            JG.Follow(f2);
            //JG.NewVideo("Uj ital");

            ContentCreator cc2 = new ContentCreator("Supa Mario");
            Follower f3 = new Follower("Luigi");

            cc2.Follow(f1);
            cc2.Follow(f2);
            cc2.Follow(f3);

            cc2.Unfollow(f2);
            cc2.NewVideo("GOOMBAS BADDD");
        }
    }
}