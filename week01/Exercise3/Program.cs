using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int guessNumber = -1;


        while (guessNumber != magicNumber)
        {
            Console.Write("Enter your guess number");
            guessNumber = int.Parse(Console.ReadLine()) ;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Your quess is correct, cangraulations!");
            }


            
        }
        
    }
}