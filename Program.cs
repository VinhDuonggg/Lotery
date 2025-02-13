// C# program to check Lucky Number
using System;

class Lotery
{

    public static int counter = 2;


    // Returns 1 if n is a lucky no.
    // otherwise returns 0
    static bool isLucky(int n)
    {
        if (counter > n)
            return true;
        if (n % counter == 0)
            return false;

        /*calculate next position of input no.
         Variable "next_position" is just for
         readability of the program we can
         remove it and update in "n" only */
        int next_position = n - (n / counter);

        counter++;

        return isLucky(next_position);
    }

    // Driver code
    public static void Main()
    {
        Console.WriteLine("---WELCOME TO VIETLOT---");
        Console.WriteLine("Have a nice day !");
        Console.WriteLine("Enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        // Function call
        if (isLucky(x))
            Console.Write(x + " is a "
                          + "lucky number.");
        else
            Console.Write(x + " is not"
                          + " a lucky number.");
        Console.WriteLine();
    }
}

// This code is contributed by
// nitin mittal.