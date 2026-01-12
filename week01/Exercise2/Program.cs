using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is grade percentage?");
        string studentGrade = Console.ReadLine();
        int grade = int.Parse(studentGrade);

        string letter = "";

        if (grade >=90)
        {
            letter = "A";
        } 
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "D";
        }
        
        Console.WriteLine($"Your grade percent {letter} ");

        if (grade >= 70)
        {
          Console.WriteLine("You passed, Congratulations");  
        }
        else
        {
            Console.WriteLine("You try another time");
        }
    }
}