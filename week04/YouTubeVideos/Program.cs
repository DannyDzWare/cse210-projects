using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment("Alice", "Great introduction!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Clear explanations.");
        videos.Add(video1);

        Video video2 = new Video("OOP in C#", "Jane Smith", 900);
        video2.AddComment("David", "This made OOP easier to understand.");
        video2.AddComment("Emma", "Awesome tutorial!");
        video2.AddComment("John", "What are the background noises?");
        video2.AddComment("Frank", "Can you make a video on interfaces?");
        videos.Add(video2);

        Video video3 = new Video("LINQ Tutorial", "Mike Johnson", 750);
        video3.AddComment("George", "LINQ is so powerful!");
        video3.AddComment("Hannah", "Thanks for simplifying this.");
        video3.AddComment("Ian", "More examples would be great.");
        video3.AddComment("Chuck", "Finally I understand it. Thank you!");
        videos.Add(video3);

        Video video4 = new Video("ASP.NET Core Overview", "Sarah Lee", 1200);
        video4.AddComment("Jack", "Perfect for beginners!");
        video4.AddComment("Karen", "How do I deploy an ASP.NET app?");
        video4.AddComment("Leo", "Loved the clarity in explanation.");
        videos.Add(video4);

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}