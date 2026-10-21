using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> minecraftItems = new Dictionary<string, string>();

        Console.WriteLine("Minecraft Dictionary");
        Console.WriteLine("1. Populate Dictionary");
        Console.WriteLine("2. Display Dictionary Contents");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                minecraftItems.Add("Diamond Pickaxe", "Mines stone and ores");
                minecraftItems.Add("Crafting Table", "Crafts items");
                minecraftItems.Add("Furnace", "Smelts items");
                minecraftItems.Add("Shield", "Blocks attacks");
                minecraftItems.Add("Bed", "Sets spawn point");

                Console.WriteLine("Dictionary populated.");
                break;

            case "2":
                foreach (KeyValuePair<string, string> item in minecraftItems)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}