using System;
using System.ComponentModel;

public class Book
{
    // This class models certain attributes of a book.

    public string Title;
    public int Page;
    public bool Complete;

    public Book(string title, int page, bool complete)
    {
        Title = title;
        Page = page;
        Complete = complete;
    }

    // This method displays the specific value of each attribute.
    public void DisplayValues()
    {
        Console.WriteLine($"Title: {Title}, Page Count: {Page}, Completed: {Complete}");
    }

    // This method toggles a book as complete/incomplete. 
    public void UpdateValue()
    {
        Complete = !Complete;
    }
}
