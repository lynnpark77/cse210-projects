using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        int commentCount = _comments.Count;
        return commentCount;
    }
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }
    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title:{_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Run Time: {_lengthSeconds/60}min {_lengthSeconds %60}sec");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentInfo();
        }
        Console.WriteLine();
    }
}