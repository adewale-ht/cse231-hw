using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos and comments
        Video video1 = new Video("How to Cook Rice", "Chef John", 300);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Easy to follow."));
        video1.AddComment(new Comment("Charlie", "Tried it, loved it!"));

        Video video2 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video2.AddComment(new Comment("Dave", "Very helpful."));
        video2.AddComment(new Comment("Eve", "Clear explanations."));
        video2.AddComment(new Comment("Frank", "Thanks for the tips!"));

        Video video3 = new Video("Travel Vlog: Paris", "Wanderlust", 900);
        video3.AddComment(new Comment("Grace", "Beautiful shots!"));
        video3.AddComment(new Comment("Heidi", "Paris is on my bucket list."));
        video3.AddComment(new Comment("Ivan", "Loved the editing."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}