using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problem;
    }
    public string GetHomeworkList()
    {
        string homeworkList = $"Section: {_textbookSection} - Problems : {_problems}";
        
        return homeworkList;
    }
}