public class Comment
{
    public string commenterName { get; set; }
    public string commentText { get; set; }
    

    public Comment(string name, string text)
    {
        commenterName = name;
        commentText = text;
    }
}