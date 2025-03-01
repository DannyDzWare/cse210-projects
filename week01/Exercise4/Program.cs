using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string input = "";
        while(input != "0")
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.WriteLine("Enter number:");
            input = Console.ReadLine();
            Int32.TryParse(input, out int iInput);
            if(iInput != 0)
            {
                numbers.Add(iInput);
            }
        }

        Int32 sum = 0;
        Int32 highestNumber = 0;
        Int32 smallestPositiveNumber = 9999999;
        
        foreach(int value in numbers)
        {
            sum += value;
            if(value > highestNumber)
            {
                highestNumber = value;
            }
            if(value >= 0 && value < smallestPositiveNumber)
            {
                smallestPositiveNumber = value;
            }
        }
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach(int value in numbers)
        {
            Console.WriteLine(value.ToString());
        }
        


    }
}