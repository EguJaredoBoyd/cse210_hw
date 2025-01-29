using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    private List<Comment> comments; 

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    
    public void AddComment(string commenterName, string text)
    {
        comments.Add(new Comment(commenterName, text));
    }

    
    public int GetCommentCount()
    {
        return comments.Count;
    }

    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"📹 Video: {Title}");
        Console.WriteLine($"🎬 Author: {Author}");
        Console.WriteLine($"⏳ Length: {Length} seconds");
        Console.WriteLine($"💬 Comments ({GetCommentCount()}):");

        foreach (Comment comment in comments)
        {
            Console.WriteLine($"   - {comment.Commenter}: {comment.Text}");
        }

        Console.WriteLine(new string('-', 40)); 
    }
}
