using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine(new string('-', 40)); 

        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("C# Basics for Beginners", "Tech Academy", 600);
        Video video2 = new Video("Understanding OOP in C#", "CodeWithMe", 720);
        Video video3 = new Video("How to Use LINQ in C#", "DotNet Guru", 540);

        
        video1.AddComment("Alice", "Great tutorial! Helped a lot.");
        video1.AddComment("Bob", "Very clear and concise.");
        video1.AddComment("Charlie", "Can you make one on advanced topics?");

        
        video2.AddComment("David", "OOP is so useful. Thanks!");
        video2.AddComment("Eve", "I finally understand classes and objects.");
        video2.AddComment("Frank", "This was very well explained.");

        
        video3.AddComment("Grace", "LINQ makes querying so much easier.");
        video3.AddComment("Hank", "This is a game changer!");
        video3.AddComment("Ivy", "Do you have more examples?");

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
