using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("XxveryCoolxX", 20, "assassin creed valhalla");
            sam.SetHobbies(new string[] { "every", "single", "assasin", "creed", "game"});
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
