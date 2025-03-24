using System;
using System.Reflection;
public class Video
{
    private string _title {get; set;} = string.Empty;
    private string _author {get; set;} = string.Empty;
    private double _length {get; set;} = 0;

    private List<Comment> _comments {get; set;} = new List<Comment>();

    /// <summary>
    /// Constructor for a new Video.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <param name="length">Length of the video in seconds.</param>
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    /// <summary>
    /// Method for adding a comment to the Video.
    /// </summary>
    /// <param name="name">commenter's name</param>
    /// <param name="comment">command itself</param>
    public void AddComment(string name, string comment)
    {
        _comments.Add(new Comment(name, comment));
    }

    /// <summary>
    /// Displays the information for the video and also all the assigned comments.
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"{Environment.NewLine}Title: {_title}, Author: {_author}, Length {_length}s, {GetNumberOfComments()} Comments:");
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }

    /// <summary>
    /// Returns the number of Comments.
    /// </summary>
    /// <returns></returns>
    public double GetNumberOfComments()
    {
        return _comments.Count();
    }
}