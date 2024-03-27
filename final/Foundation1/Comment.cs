public class Comment
{
    private string name;
    private string text;

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public void DisplayComment()
    {
        System.Console.WriteLine($@"Name: {name}
Comment: {text}");
    }
}