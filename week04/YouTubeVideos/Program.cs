using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // checking video 1
        Video video1 = new Video
        {
            title = "How to Learn C#",
            author = "Bro Coder",
            lengthInseconds = 600
        };

        // In this section we are adding comments to video1
        // This is just an example, you can add more comments as needed
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2 ", "Very Helpful tutorial!"));
        video1.AddComment(new Comment("User3 ", "I learn a Lot!."));

        //checking video 2
        Video video2 = new Video
        {
            title = "How to Make Cookies",
            author = "CookingWithLanea",
            lengthInseconds = 300
        };
        // In this section we are adding comments to video2
        // This is the same with the previous video
        video2.AddComment(new Comment("User4", "Yummy! I love cookies!"));
        video2.AddComment(new Comment("User5", "Can't wait to try this recipe!"));

        videos.Add(video1);
        videos.Add(video2);

        // Displaying video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.lengthInseconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.commenterName}: {comment.commentText}");
            }
            Console.WriteLine();
        }


    }
}