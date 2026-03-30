using System;
using System.Collections.Generic;
using System.IO;
public class Video
{
    //Attributes
   public string _title;
   public string _author;
   public double _length;

   public List<Comment>_comment = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComments(Comment newComment)
    {
        _comment.Add(newComment);
    }


   public int NumOfCom()
    {
        return _comment.Count;
    }

   public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {_comment.Count}");

        foreach (Comment com in _comment)
        {
            Console.WriteLine($"{com._commenter}: {com._commentText}");
        }
    }
}
    