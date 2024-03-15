using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a Number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Count;
        int largest = int.MinValue;
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {(smallestPositive != int.MaxValue ? smallestPositive.ToString() : "N/A")}");
        Console.Write("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num} ");
        }
        Console.WriteLine();
    }       
}