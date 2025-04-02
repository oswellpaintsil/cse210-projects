using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> myVideos = new List<Video>();

        Video video1 = new Video("Coco","Enersto De La Cruz",3689);
        Video video2 = new Video("Next Day Air","Wood Harris",4200);
        Video video3 = new Video("Why Did I Get Married","Tyler Perry",1200);

        Comment comment1 = new Comment("Oswell","This is a nice video");
        Comment comment2 = new Comment("Emmanuel","Not really catchy");
        Comment comment3 = new Comment("Desmond","I thought it was an action movie");

        Comment comment4 = new Comment("Oswell","This is one of my favorite movies");
        Comment comment5 = new Comment("Emmanuel","Wow this is exactly how I want my movies to be");
        Comment comment6 = new Comment("Desmond","I thought it was an action movie");

        Comment comment7 = new Comment("Oswell","I like the screen resolution");
        Comment comment8 = new Comment("Emmanuel","The scene is blurry");
        Comment comment9 = new Comment("Desmond","Awesome! movie");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        myVideos.Add(video1);
        myVideos.Add(video2);
        myVideos.Add(video3);

        foreach (Video video in myVideos)
        {
            video.DisplayVideoInfo();
        }
    }
}