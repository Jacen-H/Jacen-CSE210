using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Video temp=new();
        // int tempNum=temp.NumComments();
        // Console.WriteLine($"Number of comments:{tempNum}");

        Video firstVid=new();
        firstVid._author="Smarter Every Day";
        firstVid._title="How To Get Smarter";
        firstVid._length=1200;
        Comment firstVidComment1=new();
        firstVidComment1._name="Shayman";
        firstVidComment1._text="I'm so much smarter now";
        firstVid._comments.Add(firstVidComment1);
        Comment firstVidComment2=new();
        firstVidComment2._name="JohnCena";
        firstVidComment2._text="You can't see me";
        firstVid._comments.Add(firstVidComment2);
        firstVid.DisplayVideo();
    }
}