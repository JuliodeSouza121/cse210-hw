using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        while (choice < 6)
        {
            Console.WriteLine("Welcome to the Jornal Program!");
            Console.WriteLine("Please select one of the following choises:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    string today = DateTime.Today.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry();
                    newEntry._promptText = prompt.GetRandomPrompt();
                    newEntry._date = today;

                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("What is the filename?");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 4:
                    Console.WriteLine("What is the filename?");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;

                case 5:
                    Console.WriteLine("Please, Enter the text to search in journal entries.");
                    Console.Write("> ");
                    string search = Console.ReadLine();
                    journal.SearchAndDisplay(search);
                    break;

            }
        }

    }
}