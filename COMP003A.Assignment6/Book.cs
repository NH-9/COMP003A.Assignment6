using System;
using System.ComponentModel;

public class Book
{
    public string Title;
    public int Page;
    public bool Complete;

    public Book(string title, int page, bool complete)
    {
        Title = title;
        Page = page;
        Complete = complete;
    }

    public void DisplayValues()
    {
        Console.WriteLine($"Title: {Title}, Page Count: {Page}, Completed: {Complete}");
    }

    public void UpdateValue()
    {
        Complete = !Complete;
    }
}
