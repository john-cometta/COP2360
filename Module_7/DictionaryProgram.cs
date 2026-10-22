using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // This dictionary will store Minecraft items and what each item is used for
        Dictionary<string, string> minecraftItems = new Dictionary<string, string>();

        // Keep the program running so the user can choose more than one option
        while (true)
        {
            // Show the user the available options
            Console.WriteLine("\nMinecraft Dictionary");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.Write("Choose an option (1-3): ");

            // Save the option selected by the user
            string choice = Console.ReadLine().Trim();

            // Use the user's choice to decide which part of the program to run
            switch (choice)
            {
                case "1":
                    // Make sure the same items are not added more than once
                    if (minecraftItems.Count > 0)
                    {
                        Console.WriteLine("Dictionary is already populated.");
                        break;
                    }

                    // Add the Minecraft items and their uses to the dictionary
                    minecraftItems.Add("Diamond Pickaxe", "Mines stone and ores");
                    minecraftItems.Add("Crafting Table", "Crafts items");
                    minecraftItems.Add("Furnace", "Smelts items");
                    minecraftItems.Add("Shield", "Blocks attacks");
                    minecraftItems.Add("Bed", "Sets spawn point");

                    Console.WriteLine("Dictionary populated.");
                    break;

                case "2":
                    // Check that the dictionary has items before displaying them
                    if (minecraftItems.Count == 0)
                    {
                        Console.WriteLine("Dictionary is empty. Populate it first.");
                    }
                    else
                    {
                        // Go through the dictionary and display each item with its use
                        foreach (var item in minecraftItems)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                    }
                    break;

                case "3":
                    // Make sure there are items available before trying to remove one
                    if (minecraftItems.Count == 0)
                    {
                        Console.WriteLine("Dictionary is empty. Populate it first.");
                        break;
                    }

                    // Ask the user which Minecraft item they want to remove
                    Console.Write("Enter a key to remove: ");
                    string inputKey = Console.ReadLine().Trim();

                    bool removed = false;

                    // Search for the key without requiring the exact capitalization
                    foreach (var key in new List<string>(minecraftItems.Keys))
                    {
                        if (key.Equals(inputKey, StringComparison.OrdinalIgnoreCase))
                        {
                            minecraftItems.Remove(key);
                            removed = true;
                            break;
                        }
                    }

                    // Let the user know whether the item was found and removed
                    if (removed)
                    {
                        Console.WriteLine(inputKey + " was removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine(inputKey + " was not found.");
                    }
                    break;

                default:
                    // Let the user know if they entered an option that is not available
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}