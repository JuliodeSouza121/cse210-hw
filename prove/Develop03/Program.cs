// Stretch challenge: randomly select from only those words that are not already hidden.
// class scripture I created a List called "available" is filled with the indices of the 
// words that are not hidden.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scrip1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Reference ref2 = new Reference("3 Nephi", 11, 7);
        Scripture scrip2 = new Scripture(ref2, "Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him.");
        Reference ref3 = new Reference("1 Nephi", 3, 7);
        Scripture scrip3 = new Scripture(ref3, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        List<Scripture> scripList = new List<Scripture>();

        scripList.Add(scrip1);
        scripList.Add(scrip2);
        scripList.Add(scrip3);

        Random sort = new Random();
        int num = sort.Next(0, scripList.Count());

        Scripture scripchosen = scripList[num];

        bool hidden = scripchosen.IsCompletelyHidden();

        string line = "";

        while (line != "quit")
        {
            Console.Clear();
            string reference = scripchosen.GetReference().GetDisplayText();
            string text = scripchosen.GetDisplayText();

            Console.WriteLine($"{reference} - {text}");

            Console.WriteLine("Please enter to continue or quit to exit: ");
            line = Console.ReadLine();

            if (line == "quit" || hidden)
            {
                Console.WriteLine("Game Over!");
                line = "quit";
            }
            else
            {
                scripchosen.HideRandomWords(1); // Esconder apenas uma palavra aleatória
                hidden = scripchosen.IsCompletelyHidden();
            }
        }
    }
}