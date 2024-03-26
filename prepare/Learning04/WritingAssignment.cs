using System;

public class WritingAssignment : Assignment 
{
    private string _title;


    public WritingAssignment(string name, string section, string title) : base(name, section)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string  authorName = GetName();
        return $" Title: {_title} by {authorName}";
    }
}