using System;

class Program
{
    static void Main(string[] args)
    {

        string keepPlaying = "yes";
        while (keepPlaying.ToLower() == "yes")
        {
            // Console.Write("What is the magic number? ");
            // string magicNumber = Console.ReadLine();
            // int magic = int.Parse(magicNumber);

            Random randomGenaretor = new Random();
            int magic = randomGenaretor.Next(0, 100);


            string result = "";
            int track = 0;

            while (result != "You guessed it!")
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                int guess = int.Parse(guessNumber);

                if (magic > guess)
                {
                    result = "Higher";
                }
                else if (magic < guess)
                {
                    result = "Lower";
                }
                else if (magic == guess)
                {
                    result = "You guessed it!";
                }
                else
                {
                    result = "error";
                }
                
                track ++;
                Console.WriteLine(result);
            }
                Console.WriteLine($"You tried {track} times!");
                Console.Write("Do you want to play again? ");
                keepPlaying = Console.ReadLine();
        }
    }
}