using System;
using System.Collections.Generic;

class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;
}

class Program
{
    static void Main()
    {
        Bunny bunny1 = new Bunny
        {
            Name = "Roger",
            LikesCarrots = true,
            LikesHumans = true
        };

        Bunny bunny2 = new Bunny
        {
            Name = "Max",
            LikesCarrots = true,
            LikesHumans = false
        };

        List<Bunny> bunnies = new List<Bunny>();

        bunnies.Add(bunny1);
        bunnies.Add(bunny2);

        foreach (Bunny bunny in bunnies)
        {
            Console.WriteLine("Bunny Name: " + bunny.Name);
            Console.WriteLine("Likes Carrots: " + bunny.LikesCarrots);
            Console.WriteLine("Likes Humans: " + bunny.LikesHumans);
            Console.WriteLine();
        }
    }
}