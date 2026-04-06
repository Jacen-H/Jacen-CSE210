class Video{
    public string _title="";
    public string _author="";
    public int _length=0;
    public List <Comment> _comments=new();

    public int NumComments(){
        return _comments.Count;
    }

    public void DisplayVideo(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comments: {NumComments()}");
        foreach(Comment comment in _comments){
            comment.DisplayComment();
        }
    }
}