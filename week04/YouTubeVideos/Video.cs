using System.Collections.Generic;

public class Video
{
    // Properties for the Video class
    //
    // this works as a model for the video
    // it has title, author, length in seconds and a list of comments
    public string title { get; set; }
    public string author { get; set; }
    public int lengthInseconds { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // i added this method to get the comments 
    // so it return a copy of the comments list
    // to prevent external modification
    public IReadOnlyList<Comment> GetComments()
    {
        return _comments.AsReadOnly();
    }
}