# project for the YouTube Video Program assignment, we will define two classes: `Video` and `Comment`. The `Video` class will represent a YouTube video, while the `Comment` class will represent comments made on that video. The `Program.cs` file will demonstrate the functionality of these classes.

Here’s how you can structure the project:

### Project Structure
```
YouTubeVideoProgram/
│
├── Video.cs
├── Comment.cs
└── Program.cs
```

### Video.cs
```csharp
using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Likes { get; private set; }
    public int Dislikes { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string description)
    {
        Title = title;
        Description = description;
        Likes = 0;
        Dislikes = 0;
        Comments = new List<Comment>();
    }

    public void Like()
    {
        Likes++;
    }

    public void Dislike()
    {
        Dislikes++;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Likes: {Likes}, Dislikes: {Dislikes}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.UserName}: {comment.Text}");
        }
    }
}
```

### Comment.cs
```csharp
public class Comment
{
    public string UserName { get; set; }
    public string Text { get; set; }

    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }
}
```

### Program.cs
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new video
        Video video = new Video("Learn C# in 10 Minutes", "A quick tutorial on C# programming.");

        // Like the video
        video.Like();
        video.Like();
        video.Dislike();

        // Add comments
        video.AddComment(new Comment("Alice", "Great video! Very helpful."));
        video.AddComment(new Comment("Bob", "I learned a lot, thanks!"));

        // Display video information
        video.DisplayInfo();
    }
}
```

### Instructions to Create the Project
1. **Create a New Folder**: Create a new folder named `YouTubeVideoProgram` in your desired location.
2. **Create the C# Files**: Inside the `YouTubeVideoProgram` folder, create three files: `Video.cs`, `Comment.cs`, and `Program.cs`.
3. **Copy the Code**: Copy the respective code snippets provided above into the corresponding files.
4. **Compile and Run**: Use a C# compiler or an IDE like Visual Studio or Visual Studio Code to compile and run the `Program.cs` file.

### Expected Output
When you run the `Program.cs`, you should see output similar to the following:
```
Title: Learn C# in 10 Minutes
Description: A quick tutorial on C# programming.
Likes: 2, Dislikes: 1
Comments:
- Alice: Great video! Very helpful.
- Bob: I learned a lot, thanks!
```

This structure and code will allow you to demonstrate the functionality of the `Video` and `Comment` classes effectively.