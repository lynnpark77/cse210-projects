using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Epic Space Journey in 4K", "GalaxyExplorer", 735);
        video1._comments.Add(new Comment("StellarFan99", "This is the most beautiful space video I've ever seen!"));
        video1._comments.Add(new Comment("AstroGeek", "The visuals are out of the world! Love the commentary too."));
        video1._comments.Add(new Comment("CosmicWanderer", "I can't believe how detailed the nebula shots are. Subscribed"));
        video1._comments.Add(new Comment("StarLight", "Amazing video! Epic shots!!"));

        Video video2 = new Video("Top 10 Life Hacks You Should Know", "LifeProTips", 482);
        video2._comments.Add(new Comment("HackMaster", "Number 3 changed my life!"));
        video2._comments.Add(new Comment("QucikFixer","Why didn't I know these sooner?"));
        video2._comments.Add(new Comment("DIYFanatic", "Great video. Subscribed for more!"));

        Video video3 = new Video("Relaxing Nature Sounds - 10 Hours", "TranquilVibes", 36000);
        video3._comments.Add(new Comment("PeaceLover", "Perfect for studying or sleeping. Thank you!"));
        video3._comments.Add(new Comment("ZenMaster", "I feel so calm listening to this."));
        video3._comments.Add(new Comment("NatureAddict", "I could listen to this all day. Amazing!"));
        video3._comments.Add(new Comment("Mindfullness", "It makes me calm down in any circumstances."));
        video3._comments.Add(new Comment("FindPeace", "Soothing sound perfect for sleeping."));

        Video video4 = new Video("Beginner's Guide to Coding in C#", "CodeAcademy101", 1123);
        video4._comments.Add(new Comment("CodeNewbie", "Super helpful for beginners. Thanks a ton!"));
        video4._comments.Add(new Comment("CsharpFan","Explained so clearly. Great tutorial!"));
        video4._comments.Add(new Comment("FutureDev", "This gave me confidence to start coding!"));

        List<Video> videos = new List<Video>()
        {
            video1,video2,video3,video4
        };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
       





    }
}