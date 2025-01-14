﻿namespace BandGroupGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("------------------------\n");
        Console.WriteLine("Welcome to Rock band group name generator in C#\r");
        Console.WriteLine("------------------------\n");

        Console.WriteLine("Do you want to create your band group name by yourself?");
        Console.WriteLine("\ty - Yes, I want to create a band name by myself");
        Console.WriteLine("\tn - No, I want the name to be generated by the application");
        Console.Write("Your option? ");
        switch (Console.ReadLine())
        {
            case "y":
            Console.Write("Name would be created from two words. Please enter an adjective: "); 
            string adjective = Console.ReadLine();
            Console.Write("Enter an noun: ");
            string noun = Console.ReadLine();
            Console.WriteLine("Your rock band name is " + adjective + " " + noun + "!");
                    Console.WriteLine("If you are happy about created band group name and want to end the work?");
                    Console.WriteLine("\ty - Yes, I`m happy");
                    Console.WriteLine("\tn - No, I want the name to be generated by the application");
                    Console.Write("Your option? ");          
 		            switch (Console.ReadLine())
                        {
                        case "y":
                        Console.Write("Press any key to close the Calculator console app...");
                        Console.ReadKey();
                        break;
                        case "n":
                        Console.WriteLine("Great! We will help you. Please turn off app ant turn on again");
                        break;
                        }
            break;
            case "n":
            Console.WriteLine("Great! We will help you");
            string[] suggestedAdjective = {"Stunning", "Delightful", "Wild", "Useless", "Great", "Drunken", "Crazy", "Quiet", "Bright", "Scrumptious"};
            string[] suggestedNoun = {"Compass", "Banana", "Geek", "Sausage", "Fairy", "Melons", "Buffalo", "Programmers", "Mustangs", "Joysticks"};
            Random rand = new Random();  
            int index1 = rand.Next(suggestedAdjective.Length);
            int index2 = rand.Next(suggestedNoun.Length);
            Console.WriteLine($"Your rock band name suggestion {suggestedAdjective[index1]} {suggestedNoun[index2]}.");
            
            String[] names1 = {"Bodrum Salvador", "Hilary Ouse", "Indigo Violet", "Hans Down", "Shequondolisa Bivouac", "Ingredia Nutrisha", "Fig Nelson", "Benjamin Evalent", "Gustav Purpleson", "Elon Gated"};
            int index3 = rand.Next(names1.Length);
            Console.WriteLine($"We also made suggestion of your rock band team mates: {names1[index3]} would be vocalist.");
            int index4 = rand.Next(names1.Length);
            Console.WriteLine($"{names1[index3]} would be drummer.");
            int index5 = rand.Next(names1.Length);
            Console.WriteLine($"{names1[index5]} would be guitarist.");
            int index6 = rand.Next(names1.Length);
            Console.WriteLine($"{names1[index5]} would be playing electric guitar.");
            break;
        }
        Console.WriteLine("Press any key to close the Rock group name generator console app...");
        Console.ReadKey();
        }
    }
}