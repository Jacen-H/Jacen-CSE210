using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video();
        vid1._title = "How To Get Smarter";
        vid1._author = "Smarter Every Day";
        vid1._length = 1200;

        vid1._comments.Add(new Comment { _name = "Shayman", _text = "I'm so much smarter now!" });
        vid1._comments.Add(new Comment { _name = "JohnCena", _text = "You can't see me" });
        vid1._comments.Add(new Comment { _name = "Alice", _text = "Great explanation!" });

        videos.Add(vid1);

        Video vid2 = new Video();
        vid2._title = "Learn C# in 10 Minutes";
        vid2._author = "Code Academy";
        vid2._length = 600;

        vid2._comments.Add(new Comment { _name = "Bob", _text = "Super helpful!" });
        vid2._comments.Add(new Comment { _name = "Charlie", _text = "Too fast for beginners." });
        vid2._comments.Add(new Comment { _name = "Dana", _text = "Loved it!" });

        videos.Add(vid2);

        Video vid3 = new Video();
        vid3._title = "Top 10 Space Facts";
        vid3._author = "Science Hub";
        vid3._length = 900;

        vid3._comments.Add(new Comment { _name = "Eve", _text = "Space is amazing!" });
        vid3._comments.Add(new Comment { _name = "Frank", _text = "Mind blown" });
        vid3._comments.Add(new Comment { _name = "Grace", _text = "More videos like this!" });

        videos.Add(vid3);

        Video vid4 = new Video();
        vid4._title = "Beginner Workout Routine";
        vid4._author = "Fitness Pro";
        vid4._length = 1500;

        vid4._comments.Add(new Comment { _name = "Henry", _text = "This helped me start!" });
        vid4._comments.Add(new Comment { _name = "Ivy", _text = "Great routine!" });
        vid4._comments.Add(new Comment { _name = "Jake", _text = "Challenging but fun." });

        videos.Add(vid4);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}