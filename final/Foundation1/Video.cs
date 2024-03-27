public class Video
{
    private string title;
    private string author;
    private int length;

    List<Comment> comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = comments;
    }

    public int CountComments()
    {
        int count = 0;
        foreach(Comment comment in comments)
        {
            count++;
        }
        return count;
    }

    public void DisplayVideo(int count)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($@"Title: {title}
Author: {author}
Length: {length} seconds
Number of comments: {count}");

        System.Console.WriteLine("\nComments:");

        foreach(Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }
}