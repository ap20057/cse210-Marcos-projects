
/* Separate files for each individual class
This is my main class, Program
Author: Marcos Alas
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating four videos for this exammple
        Video video1 = new Video("Product Review: SmartPhone X", "MarcosTech", 600);
        Video video2 = new Video("Top 5 Headphones 2026", "AudioWorld", 480);
        Video video3 = new Video("Unboxing New Laptop", "ElSalvadorZone", 720);
        Video video4 = new Video("Best Budget Cameras", "PhotoPro", 540);

        // Adding comments to each video
        video1.AddComment(new Comment("Marcos", "Great review!"));
        video1.AddComment(new Comment("Derick", "Very helpful!"));
        video1.AddComment(new Comment("Esteban", "I am buying this now!"));

       
        video2.AddComment(new Comment("Dave", "Awesome list."));
        video2.AddComment(new Comment("Eve", "You missed one brand."));


        video3.AddComment(new Comment("Grace", "That laptop looks amazing."));
        video3.AddComment(new Comment("Hank", "Can you test gaming?"));
        video3.AddComment(new Comment("Ivy", "Waiting for price drop."));

        
        video4.AddComment(new Comment("Jack", "Great budget options."));
        video4.AddComment(new Comment("Maria", "Very informative."));

      
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

      
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthSeconds);
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}