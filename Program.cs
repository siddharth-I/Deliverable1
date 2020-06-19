using System;

class Deliverable1
{
    public static void Main (string[] args)
    {
        Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
        string vacationType = Console.ReadLine();

        Console.Write("How many are in your group? ");
        int groupSize = int.Parse(Console.ReadLine());

        if (vacationType == "musical" && groupSize >= 1 && groupSize <= 2)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class to New Orleans.");

        }

        if (vacationType == "musical" && groupSize >= 3 && groupSize <= 5)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to New Orleans.");

        }

        if (vacationType == "musical" && groupSize >= 6)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to New Orleans.");

        }

        if (vacationType == "tropical" && groupSize >= 1 && groupSize <= 2)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class to a beach vacation in Mexico.");

        }

        if (vacationType == "tropical" && groupSize >= 3 && groupSize <= 5)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to a beach vacation in Mexico.");

        }

        if (vacationType == "tropical" && groupSize >= 6)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to a beach vacation in Mexico.");

        }

        if (vacationType == "adventurous" && groupSize >= 1 && groupSize <= 2)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class to whitewater raft the Grand Canyon.");

        }

        if (vacationType == "adventurous" && groupSize >= 3 && groupSize <= 5)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to whitewater raft the Grand Canyon.");

        }

        if (vacationType == "adventurous" && groupSize >= 6)
        {
            Console.WriteLine("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to whitewater raft the Grand Canyon.");

        }


    }
}
