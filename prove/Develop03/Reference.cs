using System;
class Reference
{
    // declare attributes
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    // create constructors with different parameters to handle the case of references having one or several verses
    public Reference(string book, int chapter, int startVerse) // case where reference only has one verse
    {
        this.book = book;            // assign parameters of the constructor to the attributes of the class to assign values to them
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = -1; // assign a -1 value to endVerse attribute since this case does not have more than one verse
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) // case where reference has several verses
    {
        this.book = book;            // assign parameters of the constructor to the attributes of the class to assign values to them
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse; // this time, assign endVerse parameter value to endVerse attribute
    }

    public void DisplayReference()
    {
        if (endVerse == -1) // check if endVerse equals -1, handle the case where the reference only has one verse and display it
        {
            System.Console.WriteLine($"{book} {chapter}:{startVerse}");
        }
        else // handle the case where the reference has several verses and display it
        {
            System.Console.WriteLine($"{book} {chapter}:{startVerse}-{endVerse}");
        }
    }
}