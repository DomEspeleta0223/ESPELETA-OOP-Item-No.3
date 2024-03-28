using System;

internal class Espeleta_Assignment_Item_Number_3
{
    static void Main (string[] args)
    {
        Console.WriteLine("Hello I am Dominic! Welcome to my Time Converter!");
        Console.WriteLine("\nNOTE:");
        Console.WriteLine("\nPlease Enter A Below for Converting Seconds to Minutes");
        Console.WriteLine("Please Enter B Below for Converting Minutes to Hours");
        Console.WriteLine("Please Enter C Below for Converting Hours to Days");
        Console.WriteLine("Please Enter D Below for Converting Days to Months");

        Console.Write("\nWhat Do You Want to Convert? ( A, B, C, or D):\t");
        string selection; //declaration
        selection = Console.ReadLine();

        if (selection == "A")
        {
            Console.Write("Enter How Many Seconds:\t");
            double Seconds = Convert.ToDouble(Console.ReadLine());
            double Minutes;
            Minutes = Seconds/60;
            Console.WriteLine("\nThere are " + Minutes + " Minute(s) in " + Seconds + " Second(s)");
        }
        else if (selection == "B")
        {
            Console.Write("Enter How Many Minutes:\t");
            double Minutes = Convert.ToDouble(Console.ReadLine());
            double Hours;
            Hours = Minutes/60;
            Console.WriteLine("\nThere are " + Hours + " Hour(s) in " + Minutes + " Minute(s)");
        }
        else if (selection == "C")
        {
            Console.Write("Enter How Many Hours:\t");
            double Hours = Convert.ToDouble(Console.ReadLine());
            double Days;
            Days = Hours/24;
            Console.WriteLine("\nThere are " + Days + " Day(s) in " + Hours + " Hour(s)");
        }
        else if (selection == "D")
        {
            Console.Write("Enter How Many Days:\t");
            double Days = Convert.ToDouble(Console.ReadLine());
            double Months;
            Months = Days/30;
            Console.WriteLine("\nThere are " + Months + " Month(s) in " + Days + " Day(s)");
        }
        else if (selection == "")
        {
            Console.WriteLine("\nYou Did Not Enter Anything. Please Try Again");
        }
        else
        {
            Console.WriteLine("\nCharacter You've Entered Was Not Recognized");
            Console.WriteLine("You Can Only Choose Between ( A, B, C, or D). Please Try Again");
        }
    }
}
