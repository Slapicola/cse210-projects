public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public string GetAmountOfComments()
    {
        return $"{_comments.Count()} comments";
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string DisplayVideo()
    {
        string aVideo = $"{_title}\n{_author} || length: {_length} seconds";
        return aVideo;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.CommentDisplay());
        }
    }
}