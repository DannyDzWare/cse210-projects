using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade:");
        string grade = Console.ReadLine();
        Int32.TryParse(grade, out int iGrade);
        string letter = "F";
        if(iGrade >= 90)
        {
            letter = "A";
        }
        else if(iGrade >= 80)
        {
            letter = "B";
        }
        else if(iGrade >= 70)
        {
            letter = "C";
        }
        else if(iGrade >= 60)
        {
            letter = "D";
        }

         // Determine the sign
        int lastDigit = iGrade % 10;
        string sign = "";
        
        if ((letter != "A" && iGrade >=7) && letter != "F") // Avoid A+ and F+/F-
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");
        if(iGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Work hard and you will pass the next time.");
        }
    }
}