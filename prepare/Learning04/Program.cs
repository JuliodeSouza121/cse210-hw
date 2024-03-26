using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass1 = new Assignment("Samuel Bennett", "Multiplication");
        string summ1 = ass1.GetSummary();
        Console.WriteLine(summ1);

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez","Fractions", "Section 7.3", "Problems 8-19");
        string mathSummary = math1.GetSummary();
        string homeList = math1.GetHomeworkList();

        Console.WriteLine(mathSummary);
        Console.WriteLine(homeList);

        WritingAssignment wrt1 = new WritingAssignment("Mary Waters","European History", "The Causes of World War II");
        string wrtSummary = wrt1.GetSummary();
        string wrtInfo = wrt1.GetWritingInformation();

        Console.WriteLine(wrtSummary);
        Console.WriteLine(wrtInfo);


        
    
    }
}