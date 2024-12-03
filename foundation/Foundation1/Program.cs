using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }  // in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("How to Code in C#", "John Doe", 300);
        video1.Comments.Add(new Comment("Alice", "Great tutorial!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1.Comments.Add(new Comment("Joe", "Knock Knock, Whose there, joe, joe who, joe mama."));

        Video video2 = new Video("C# Advanced Techniques", "Jane Smith", 450);
        video2.Comments.Add(new Comment("Charlie", "I learned so much!"));
        video2.Comments.Add(new Comment("David", "Great explanations!"));
        video2.Comments.Add(new Comment("Trevin", "Great video!"));

        
        List<Video> videos = new List<Video> { video1, video2 };

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
