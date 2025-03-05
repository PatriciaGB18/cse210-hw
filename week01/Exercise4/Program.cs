using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        while (true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;
            numbers.Add(num);
        }

        int sum =0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");


        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            maxNumber = number;
        }

        Console.WriteLine($"The largest number is: {maxNumber}");


        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive == int. MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }


        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    
}