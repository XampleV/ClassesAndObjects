using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[] { "hobby1", "hobby2"});
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
