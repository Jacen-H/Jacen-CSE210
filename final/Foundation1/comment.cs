class Comment{
    public string _name="";
    public string _text="";

    public void DisplayComment(){
        Console.WriteLine($"\t{_name}: {_text}");
    }
}