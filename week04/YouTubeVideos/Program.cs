using System;
// creativity I have added beeping sound as program ends execution 
class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("C# Basic", "John", 300);
        Comment co = new Comment();
        co._commenter = "Alice";
        co._commentText = "Great lesson!";
        video.AddComments(co);
        video.DisplayVideoDetails();
        Console.Beep();
        Console.WriteLine();

        Video video1 = new Video("Javascript Basic", "Maxwell", 200);
        Comment co1 = new Comment();
        co1._commenter = "Maurice";
        co1._commentText = "Great lesson!";
        video1.AddComments(co1);
        video1.DisplayVideoDetails();
        Console.Beep();
        Console.WriteLine();

        Video video2 = new Video("Python", "Ely", 100);

        Comment comment = new Comment();
        Comment co3 = new Comment();
        co3._commenter = "Max";
        co3._commentText = "Great lesson!";
        video2.AddComments(co3);
        video2.DisplayVideoDetails();
        Console.WriteLine();
        Console.Beep();

        // video2.DisplayVideoDetails();
    }

 
}