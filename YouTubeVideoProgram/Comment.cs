using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    public class Video
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; private set; }

        public Video(string title, string description)
        {
            Title = title;
            Description = description;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void DisplayComments()
        {
            Console.WriteLine($"Comments for '{Title}':");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
        }
    }

    public class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}