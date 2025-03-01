using System;

class Program
{
    static void Main(string[] args)
    {
        int amountGueses = 0;
        int iGuess = 0;
        string response = "yes";

        while(response.ToLower() == "yes")
        {
            int magicNumber = new Random().Next(1,100);
            do
            {
                Console.WriteLine($"The magic number is {magicNumber}");
                Console.WriteLine("What is your guess?");
                string strGuess = Console.ReadLine();
                Int32.TryParse(strGuess, out iGuess);
                GetHint(iGuess, magicNumber);
                amountGueses++;
            }
            while(iGuess != magicNumber);

            Console.WriteLine($"It took you {amountGueses} guess/guesses to find the magic number.");
            Console.WriteLine("Do you want to play again, then type yes:");
            response = Console.ReadLine();
            amountGueses = 0;
        }
        
    }

    static void GetHint(int guess, int magicnumber)
    {
        if(guess > magicnumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicnumber)
        {
            Console.WriteLine("Higher");
        }
    }
}