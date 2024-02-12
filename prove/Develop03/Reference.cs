using System;

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        this.book = book;            // assign parameters of the constructor to the attributes of the class Reference to assign values to the attributes
        this.chapter = chapter;
        this.startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;            // assign parameters of the constructor to the attributes of the class Reference to assign values to the attributes
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }
}