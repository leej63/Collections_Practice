using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Create an array to hold integer values 0-9
            int[] numArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] namesArr = {"Tim", "Martin", "Nikki", "Sara"};

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booleanArr = {true, false, true, false, true, false, true, false, true, false};

            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Chocolate"); 
            iceCreamFlavors.Add("Vanilla"); 
            iceCreamFlavors.Add("Strawberry"); 
            iceCreamFlavors.Add("Rocky Road"); 
            iceCreamFlavors.Add("Salted Caramel"); 

            // Output the length of this list after building it
            Console.WriteLine(iceCreamFlavors.Count);

            // Output the third flavor in the list, then remove this value
            Console.WriteLine(iceCreamFlavors[2]);
            iceCreamFlavors.RemoveAt(3);

            // Output the new length of the list (it should jsut be one fewer!)
            Console.WriteLine(iceCreamFlavors.Count);

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> users = new Dictionary<string, string>();

            // Add key/value pairs to this dictionary where:
                // each key is a name from your names array
                // each value is a randomly selected flavor from your flavors list
            Random rand = new Random();
            users.Add("Tim", iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            users.Add("Martin", iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            users.Add("Nikki", iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            users.Add("Sara", iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);
            
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var entry in users)
            {
                Console.WriteLine(entry.Key + "'s favorite ice cream flavor is " + entry.Value + ".");
            }
        }
    }
}
