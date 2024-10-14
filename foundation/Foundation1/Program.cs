using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Switching Every 5 Minutes Art Challenge!", "Doodles-a-Day", 812);
        Video video2 = new Video("Using New Markers", "Doodles-a-Day", 1250);
        Video video3 = new Video("Playing Minecraft Hardcore", "GamerKat", 3577);

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);


        Comment comment1 = new Comment("@Mocha_Stars", "Good job on the challenge!");
        Comment comment2 = new Comment("@Jasmine Key", "Both of you guys' art is amazing!!");
        Comment comment3 = new Comment("@I_love_hats", "I love it!!!");

        video1.addComment(comment1);
        video1.addComment(comment2);
        video1.addComment(comment3);


        Comment comment4 = new Comment("@Brooke124", "How much were ur markers?");
        Comment comment5 = new Comment("@Choc0late_Muffin", "That's a lot of markers!");
        Comment comment6 = new Comment("@Quackers", "I like the shading u did");
        Comment comment7 = new Comment("@Cherry_Blossom17", "Very pretty colors!");

        video2.addComment(comment4);
        video2.addComment(comment5);
        video2.addComment(comment6);
        video2.addComment(comment7);


        Comment comment8 = new Comment("@Ether_dragon", "I love Minecraft!");
        Comment comment9 = new Comment("@Juice_and_Tea", "The parrots were so cute");
        Comment comment10 = new Comment("@21_froggers", "Was this Singleplayer?");

        video3.addComment(comment8);
        video3.addComment(comment9);
        video3.addComment(comment10);


        foreach (Video video in _videos)
        {
            Console.WriteLine(video.DisplayVideo());
            Console.WriteLine(video.GetAmountOfComments());
            Console.WriteLine("");
        }
    }
}