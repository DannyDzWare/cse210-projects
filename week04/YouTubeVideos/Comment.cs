public class Comment
{
    private string _name {get; set;} = String.Empty;
    private string _comment {get; set;} = String.Empty;

    /// <summary>
    /// Constructor for a new comment.
    /// </summary>
    /// <param name="name">commenter's name</param>
    /// <param name="comment">the comment itself</param>
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    /// <summary>
    /// Displays the commenter's name and text.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"Name: {_name}: {_comment}");
    }
}