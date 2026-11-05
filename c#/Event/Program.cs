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
            JG.Unfollow(f2);

            
        }
    }
}